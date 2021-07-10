using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Windows.Forms;
using FileHelpers;

namespace MarksmanshipTracker
{
  public partial class SessionsForm : Form
  {

    List<TrmnPerson> players = new List<TrmnPerson>();
    List<TrmnPlayer> sessionPlayers = new List<TrmnPlayer>();
    List<TrmnPlayer> savedPlayers = new List<TrmnPlayer>();
    private Int64 _sessionId = -1;
    private bool _editMode = false;
    public SessionsForm()
    {
      InitializeComponent();
    }

    private void SessionsForm_Load(object sender, EventArgs e)
    {
      List<Person> ppl = MainForm.trmnContext.People.OrderBy(p => p.LastName).ToList();

      foreach (Person p in ppl)
      {
        players.Add(new MarksmanshipTracker.TrmnPerson
        {
          Id = p.Id,
          Name = $"{p.RMNId}: {p.LastName}, {p.FirstName}"
        });
      }
      bindingSourceTRMNPerson.DataSource = players;
      MainForm.trmnContext.Games.Load();
      gameBindingSource.DataSource = MainForm.trmnContext.Games.Local.ToBindingList();
      sessionPlayers.Clear();
      btnAddPlayer.Enabled = false;
      _editMode = false;
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      SaveSession();
      this.Close();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {

      //Remove session if created
      if (_sessionId != -1 && !_editMode)
      {
        Session thisSession = MainForm.trmnContext.Sessions.Where(s => s.Id == _sessionId).First();
        MainForm.trmnContext.Sessions.Remove(thisSession);
        MainForm.trmnContext.SaveChanges();
      }
      this.Close();
    }

    private void btnAddPlayer_Click(object sender, EventArgs e)
    {

      if (string.IsNullOrWhiteSpace(txtMinutes.Text) || Convert.ToInt32(txtMinutes.Text) < 5)
      {
        MessageBox.Show("Not enough minutes. Minimum is 15");
        return;
      }

      if (_sessionId == -1)
      {
        Session thisSession = MainForm.trmnContext.Sessions.FirstOrDefault(s => s.SessionDate.Value.CompareTo(dpSessionDate.Value.Date) == 0 && s.GameId == (Int64)cboGame.SelectedValue);
        if (thisSession == null)
        {
          {
            //Check for exising session, prompt to edit
            //Add session, get ID
            thisSession = new Session
            {
              SessionDate = DateTime.Parse(dpSessionDate.Text),
              GameId = (Int64)cboGame.SelectedValue
            };
            MainForm.trmnContext.Sessions.Add(thisSession);
            MainForm.trmnContext.SaveChanges();
            _sessionId = thisSession.Id;
          }
        }
        else
        {
          DialogResult doEdit = MessageBox.Show("A session exists in the system for that date and game combination. Do you want to edit it?", "Session Exists", MessageBoxButtons.YesNo);
          if (doEdit == DialogResult.Yes)
          {
            btnEdit_Click(new object(), new EventArgs());
          }
          return;
        }
      }

      TrmnPlayer thisPlayer = sessionPlayers.FirstOrDefault(p => p.PersonId == (Int64)cboTrmnPlayer.SelectedValue);
      if (thisPlayer == null)
      {
        thisPlayer = new MarksmanshipTracker.TrmnPlayer
        {
          Name = cboTrmnPlayer.Text,
          SessionId = _sessionId,
          PersonId = (Int64)cboTrmnPlayer.SelectedValue,
          Minutes = Convert.ToInt64(txtMinutes.Text)
        };
        sessionPlayers.Add(thisPlayer);

        trmnPlayerBindingSource.DataSource = sessionPlayers;
        trmnPlayerBindingSource.ResetBindings(false);
      }
    }

    private void btnSaveNew_Click(object sender, EventArgs e)
    {
      SaveSession();
      _sessionId = -1;
      btnAddPlayer.Enabled = false;
      //sessionPlayers.Clear();
      //trmnPlayerBindingSource.DataSource = sessionPlayers;
      //trmnPlayerBindingSource.ResetBindings(false);

    }

    private void SaveSession()
    {
      //If Edit mode, clear participants for session
      if (_editMode)
      {
        MainForm.trmnContext.SessionParticipants.RemoveRange(MainForm.trmnContext.SessionParticipants.Where(sp => sp.SessionId == _sessionId));
        MainForm.trmnContext.SaveChanges();
      }
      int totalPlayers = sessionPlayers.Count() + (int)numXtraPlayers.Value;
      if (totalPlayers < 2)
      {
        MessageBox.Show("Not enough players. Need 2 minimum.");
        return;
      }
      int multiplier = (totalPlayers > 4) ? 4 : totalPlayers - 1;
      //CalculateCredits
      foreach (TrmnPlayer p in sessionPlayers)
      {
        SessionParticipant sessionPlayer = new SessionParticipant
        {
          SessionId = _sessionId,
          PersonId = p.PersonId,
          Minutes = Convert.ToInt64(p.Minutes),
          Credits = (p.Minutes / 60m) * multiplier
        };
        MainForm.trmnContext.SessionParticipants.Add(sessionPlayer);
      }
      MainForm.trmnContext.SaveChanges();
      _editMode = false;
    }

    private void cboTrmnPlayer_SelectedValueChanged(object sender, EventArgs e)
    {
      btnAddPlayer.Enabled = true;
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {
      foreach(DataGridViewRow r in dgvPlayers.SelectedRows)
      {
        sessionPlayers.RemoveAll(s => s.PersonId == (Int64)r.Cells["PersonId"].Value);
      }
      trmnPlayerBindingSource.DataSource = sessionPlayers;
      trmnPlayerBindingSource.ResetBindings(false);
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      sessionPlayers.Clear();
      trmnPlayerBindingSource.DataSource = sessionPlayers;
      trmnPlayerBindingSource.ResetBindings(false);

    }

    private void btnImportLog_Click(object sender, EventArgs e)
    {
      btnImportLog.Enabled = false;
      fsImportFile.ShowDialog();
      string inputFile = fsImportFile.FileName;
      if (string.IsNullOrWhiteSpace(inputFile))
      {
        btnImportLog.Enabled = true;
        return;
      }
      //Preload People, Ships, Games
      List<Person> people = MainForm.trmnContext.People.ToList();
      List<Ship> ships = MainForm.trmnContext.Ships.ToList();
      List<Branch> branches = MainForm.trmnContext.Branches.ToList();
      List<Rank> ranks = MainForm.trmnContext.Ranks.ToList();
      List<Game> games = MainForm.trmnContext.Games.ToList();
      //Read File - Foreach
      var engine = new FileHelperEngine<PeopleSessionLog>();
      List<PeopleSessionLog> importsessions = engine.ReadFileAsList(inputFile);
      foreach (PeopleSessionLog logEntry in importsessions)
      {
        //Get Local Game. Add and save if new
        Game localGame = games.FirstOrDefault(g => g.GameName == logEntry.GameName);
        if(localGame == null)
        {
          localGame = new Game
          {
            GameName = logEntry.GameName,
            RMAWeapon = logEntry.RMAWeapon,
            RMNWeapon = logEntry.RMNWeapon
          };
          MainForm.trmnContext.Games.Add(localGame);
          MainForm.trmnContext.SaveChanges();
          games = MainForm.trmnContext.Games.ToList();
        }
        //Get Local Ship. Add and save if new
        Ship localShip = ships.FirstOrDefault(s => s.ShipName == logEntry.ShipName);
        if (localShip == null)
        {
           localShip = new Ship
          {
            ShipName = logEntry.ShipName
          };
          MainForm.trmnContext.Ships.Add(localShip);
          MainForm.trmnContext.SaveChanges();
          ships = MainForm.trmnContext.Ships.ToList();
        }

        //Get Local Person using RMN #
        Person localPerson = people.FirstOrDefault(p => p.RMNId == logEntry.RMNId);
        //IF NULl
        if (localPerson == null)
        {
          //Get BranchId
          Branch localBranch = MainForm.trmnContext.Branches.FirstOrDefault(b => b.BranchName == logEntry.BranchName);
          //Get RankId
          Rank localRank = MainForm.trmnContext.Ranks.FirstOrDefault(r => r.BranchId == localBranch.Id && r.RankName == logEntry.RankName);
          //Create and Save Person
          localPerson = new Person
          {
            FirstName = logEntry.FirstName,
            LastName = logEntry.LastName,
            RMNId = logEntry.RMNId,
            BranchId = localBranch.Id,
            RankId = localRank.Id,
            ShipId = localShip.Id
          };
          MainForm.trmnContext.People.Add(localPerson);
          MainForm.trmnContext.SaveChanges();
        }
        //Get Local Session by Game and Date
        Session localSession =
          MainForm.trmnContext.Sessions.FirstOrDefault(se => se.SessionDate.Value.CompareTo(logEntry.SessionDate) == 0 && se.GameId == localGame.Id);
        if(localSession != null)
        {
          SessionParticipant sp = MainForm.trmnContext.SessionParticipants.FirstOrDefault(s => s.SessionId == localSession.Id && s.PersonId == localPerson.Id);
          if (sp != null)
          {
            MessageBox.Show($"There is already a session entry for {logEntry.FirstName} {logEntry.LastName} playing {logEntry.GameName} on {logEntry.SessionDate.ToShortDateString()} in this system. Skipping entry");
            continue;
          }
        }
        else
        {
          localSession = new Session
          {
            GameId = localGame.Id,
            SessionDate = logEntry.SessionDate
          };
          MainForm.trmnContext.Sessions.Add(localSession);
          MainForm.trmnContext.SaveChanges();
        }
        //Create and save SessionParticipant
        SessionParticipant localParticipant = new SessionParticipant
        {
          PersonId = localPerson.Id,
          SessionId = localSession.Id,
          Credits = logEntry.Credits
        };
        MainForm.trmnContext.SessionParticipants.Add(localParticipant);
        MainForm.trmnContext.SaveChanges();
      }
      btnImportLog.Enabled = true;
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
      //Validate selection
      if(string.IsNullOrWhiteSpace(dpSessionDate.Text) || string.IsNullOrWhiteSpace(cboGame.Text))
      {
        MessageBox.Show("No date or game selected.  Select a data and game to edit a session.");
        return;
      }
      //Get Session. Messasge if not found
      Session savedSession = MainForm.trmnContext.Sessions.FirstOrDefault(s => s.SessionDate.Value.CompareTo(dpSessionDate.Value.Date) == 0 &&
          s.GameId == (Int64)cboGame.SelectedValue);
      if(savedSession == null)
      {
        MessageBox.Show("No session saved for that date and game");
        return;
      }
      _sessionId = savedSession.Id;
      //Get SessionParticipants
      List<SessionParticipant> savedParticpants = MainForm.trmnContext.SessionParticipants.Include("Person").Where(p => p.SessionId == _sessionId).ToList();
      //Load SavedPlayers
      sessionPlayers.Clear();
      foreach (SessionParticipant sp in savedParticpants)
      {
        sessionPlayers.Add(new MarksmanshipTracker.TrmnPlayer
        {
          Name = $"{sp.Person.RMNId}: {sp.Person.FirstName} {sp.Person.LastName}",
          SessionId = sp.SessionId,
          PersonId = sp.PersonId,
          Minutes = sp.Minutes.Value
        });
      }
      //Show SessionParticipants
      trmnPlayerBindingSource.DataSource = sessionPlayers;
      trmnPlayerBindingSource.ResetBindings(false);

      //SetEditMode
      _editMode = true;
    }
  }



  public class TrmnPerson
  {
    public Int64 Id { get; set; }
    public string Name { get; set; }
  }

  public class TrmnPlayer
  {
    public string Name { get; set; }
    public Int64 PersonId { get; set; }
    public Int64 SessionId { get; set; }
    public Int64 Minutes { get; set; }
  }
}
