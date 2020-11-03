using FileHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarksmanshipTracker
{
  public partial class ReportsForm : Form
  {

    private List<PeopleSessionLog> periodLog;
    private List<PeopleCumulativeLog> cumulativeLog;
    private List<PersonAward> ribbonRacks;
    private SQLiteConnection _tdbConn;
    public ReportsForm()
    {
      InitializeComponent();
      _tdbConn = new SQLiteConnection(MainForm.AdoConnection);
      _tdbConn.Open();
    }

    private void btnGo_Click(object sender, EventArgs e)
    {
      if (rdoSessionLog.Checked) LoadSessionLog();
    }

    private void LoadSessionLog()
    {
      string periodStart = dpStart.Value.ToString("yyyy-MM-dd");
      string periodEnd = dpEnd.Value.AddDays(1).ToString("yyyy-MM-dd");

      string logCmd = $"Select * from PeopleSessionLog Where SessionDate >= '{periodStart}' And SessionDate <= '{periodEnd}'";
      periodLog = new List<PeopleSessionLog>();
      SQLiteCommand tdbCmd = new SQLiteCommand(logCmd, _tdbConn);

      using (SQLiteDataReader rdr = tdbCmd.ExecuteReader()) {

        while (rdr.Read())
        {
          periodLog.Add(new PeopleSessionLog
          {
            PersonId = rdr.GetInt64(rdr.GetOrdinal("PersonId")),
            LastName = rdr.GetString(rdr.GetOrdinal("LastName")),
            FirstName = rdr.GetString(rdr.GetOrdinal("FirstName")),
            RMNId = rdr.GetString(rdr.GetOrdinal("RMNId")),
            BranchName = rdr.GetString(rdr.GetOrdinal("BranchName")),
            RankName = rdr.GetString(rdr.GetOrdinal("RankName")),
            ShipName = rdr.GetString(rdr.GetOrdinal("ShipName")),
            SessionDate = rdr.GetDateTime(rdr.GetOrdinal("SessionDate")),
            GameName = rdr.GetString(rdr.GetOrdinal("GameName")),
            Credits = rdr.GetDecimal(rdr.GetOrdinal("Credits")),
            RMNWeapon = rdr.GetString(rdr.GetOrdinal("RMNWeapon")),
            RMAWeapon = rdr.GetString(rdr.GetOrdinal("RMAWeapon"))
          });
        }
      }

      peopleSessionLogBindingSource.DataSource = periodLog.OrderBy(pl => pl.SessionDate).ThenBy(pl => pl.LastName);
    }

    private void LoadCumLog(bool bindToGrid = true)
    {
      //Create PCL List
      cumulativeLog = new List<PeopleCumulativeLog>();
      string logCmd = "Select * from PeopleCumulativeLog";
      SQLiteCommand tdbCmd = new SQLiteCommand(logCmd, _tdbConn);

      using (SQLiteDataReader rdr = tdbCmd.ExecuteReader())
      {

        while (rdr.Read())
        {



          cumulativeLog.Add(new PeopleCumulativeLog
          {
            PersonId = rdr.GetInt64(rdr.GetOrdinal("PersonId")),
            LastName = rdr.GetString(rdr.GetOrdinal("LastName")),
            FirstName = rdr.GetString(rdr.GetOrdinal("FirstName")),
            RMNId = rdr.GetString(rdr.GetOrdinal("RMNId")),
            BranchName = rdr.GetString(rdr.GetOrdinal("BranchName")),
            RankName = rdr.GetString(rdr.GetOrdinal("RankName")),
            ShipName = rdr.GetString(rdr.GetOrdinal("ShipName")),
            RMNWeapon = rdr.GetString(rdr.GetOrdinal("RMNWeapon")),
            CumCredits = rdr.GetDecimal(rdr.GetOrdinal("CumCredits")),
          });
        }

      }
      //Bind to grid
      if(bindToGrid) peopleCumulativeLogBindingSource.DataSource = cumulativeLog.OrderBy(cl => cl.LastName);

    }

    private void LoadAwards() {

      if(cumulativeLog == null) LoadCumLog(false);
      List<Award> ribbons = MainForm.trmnContext.Awards.ToList();
      List<PersonAward> chests = new List<PersonAward>();
      foreach(PeopleCumulativeLog pcl in cumulativeLog)
      {
        
        //Find the Award
        Award weapon = ribbons.Where(r => r.WeaponName == pcl.RMNWeapon && r.MinCredits <= pcl.CumCredits).OrderByDescending(r => r.MinCredits).FirstOrDefault();
        //Can get award
        if (weapon != null)
        {
          //Already have?
          PeopleAward pplAward = MainForm.trmnContext.PeopleAwards.Where(p => p.PersonId == pcl.PersonId && p.AwardId == weapon.Id).FirstOrDefault();
          if(pplAward == null)
          {
            PeopleAward newAward = new PeopleAward
            {
              PersonId= pcl.PersonId,
              AwardId = weapon.Id,
              DateAwarded= DateTime.Now
            };
            MainForm.trmnContext.PeopleAwards.Add(newAward);
            MainForm.trmnContext.SaveChanges();
          }
        }
      }
      //Get PeopleAwardList
      List<PeopleAward> ribbonsOnChests = MainForm.trmnContext.PeopleAwards.Include("Award").ToList();
      ribbonRacks = new List<PersonAward>();
      //Iterate PeopleList, build PeopleAward
      foreach (PeopleCumulativeLog pcl in cumulativeLog)
      {

        PersonAward ribbonrack = ribbonRacks.FirstOrDefault(r => r.PersonId == pcl.PersonId);
        if (ribbonrack != null) continue;

        PeopleAward pistol = ribbonsOnChests.Where(r => r.PersonId == pcl.PersonId && r.Award.WeaponName == "Pistol").OrderByDescending(r => r.Award.MinCredits).FirstOrDefault();
        PeopleAward rifle = ribbonsOnChests.Where(r => r.PersonId == pcl.PersonId && r.Award.WeaponName == "Rifle").OrderByDescending(r => r.Award.MinCredits).FirstOrDefault();

        ribbonRacks.Add(new PersonAward
        {
          PersonId = pcl.PersonId,
          RMNId = pcl.RMNId,
          FirstName = pcl.FirstName,
          LastName = pcl.LastName,
          BranchName = pcl.BranchName,
          RankName = pcl.RankName,
          ShipName = pcl.ShipName,
          PistolAward = pistol != null ? pistol.Award.AwardName : null,
          RifleAward = rifle != null ? rifle.Award.AwardName : null
        });
      }
      personAwardBindingSource.DataSource = ribbonRacks;
      }

    private void btnExportLog_Click(object sender, EventArgs e)
    {
      var engine = new FileHelperEngine<PeopleSessionLog>();
      engine.HeaderText = engine.GetFileHeader();
      string thisFile = $"GameSessionLog_{dpStart.Value.ToString("yyyy-MM-dd")}_to_{dpEnd.Value.ToString("yyyy-MM-dd")}";
      savExport.FileName = thisFile;
      savExport.ShowDialog();
      engine.WriteFile(savExport.FileName, periodLog);


    }

    private void btnExportCum_Click(object sender, EventArgs e)
    {
      var engine = new FileHelperEngine<PeopleCumulativeLog>();
      engine.HeaderText = engine.GetFileHeader();
      string thisFile = $"CumulativeLog_{DateTime.Now.ToString("yyyy-MM-dd")}";
      savExport.FileName = thisFile;
      savExport.ShowDialog();
      engine.WriteFile(savExport.FileName, cumulativeLog);
    }

    private void btnExportAwards_Click(object sender, EventArgs e)
    {
      var engine = new FileHelperEngine<PersonAward>();
      engine.HeaderText = engine.GetFileHeader();
      string thisFile = $"EarnedAwards_{DateTime.Now.ToString("yyyy-MM-dd")}";
      savExport.FileName = thisFile;
      savExport.ShowDialog();
      engine.WriteFile(savExport.FileName, ribbonRacks);
    }

    private void btnExit_Click(object sender, EventArgs e)
    {

      this.Close();
    }

    private void rdoSessionLog_CheckedChanged(object sender, EventArgs e)
    {
      if (((RadioButton)sender).Checked)
      {
        pnlSessionLog.Visible = true;
        pnlCumulative.Visible = false;
        pnlAwards.Visible = false;
        LoadSessionLog();
        this.Refresh();
      }
    }

    private void rdoCumLog_CheckedChanged(object sender, EventArgs e)
    {
      if (((RadioButton)sender).Checked)
      {
        pnlSessionLog.Visible = false;
        pnlCumulative.Visible = true;
        pnlAwards.Visible = false;
        LoadCumLog();
        this.Refresh();
      }
    }

    private void rdoEarnedAwards_CheckedChanged(object sender, EventArgs e)
    {
      if (((RadioButton)sender).Checked)
      {
        pnlSessionLog.Visible = false;
        pnlCumulative.Visible = false;
        pnlAwards.Visible = true;
        LoadAwards();
        this.Refresh();
      }
    }

    private void ReportsForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      _tdbConn.Close();
    }
  }
  
}
