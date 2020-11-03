using FileHelpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;


namespace MarksmanshipTracker
{
  public partial class PeopleForm : Form
  {


    public PeopleForm()
    {
      InitializeComponent();


    }

    private void PeopleForm_Load(object sender, EventArgs e)
    {
      LoadData();
    }

    private void LoadData()
    {


      MainForm.trmnContext.People.Load();

      peopleBindingSource.DataSource = MainForm.trmnContext.People.Local.ToBindingList();
      branchesBindingSource.DataSource = MainForm.trmnContext.Branches.ToList();
      ranksBindingSource.DataSource = MainForm.trmnContext.Ranks.ToList();
      shipsBindingSource.DataSource = MainForm.trmnContext.Ships.ToList();

    }


    private void btnClose_Click(object sender, EventArgs e)
    {

      this.Close();
    }

    private void dgvPeople_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
    {

      DataGridViewComboBoxEditingControl cbx = e.Control as DataGridViewComboBoxEditingControl;
      if (cbx != null)
      {
        int rn = cbx.EditingControlRowIndex;
        if (cbx.DisplayMember == "RankName")
        {
          Int64 branchId = (Int64)dgvPeople[dgvPeople.Columns["cboBranchDGV"].Index, rn].Value;
          cbx.DataSource = MainForm.trmnContext.Ranks.Where(r => r.BranchId == branchId).ToList();
        }
      }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      MainForm.trmnContext.SaveChanges();
      this.Close();
    }

    private void dgvPeople_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
      //MessageBox.Show("Oops! Either you goofed or I did");
      MessageBox.Show(e.Exception.ToString());
      e.Cancel = true;

    }

    private void btnImport_Click(object sender, EventArgs e)
    {
      btnImport.Enabled = false;
      //Select CSV file
      fsImportFile.ShowDialog();
      string inputFile = fsImportFile.FileName;
      if (string.IsNullOrWhiteSpace(inputFile))
      {
        btnImport.Enabled = true;
        return;
      }
      //ReadInto Object List
      var engine = new FileHelperEngine<PersonBase>();
      List<PersonBase> inputPeople = engine.ReadFileAsList(inputFile);
      //Get Lookups
      List<Branch> branches = MainForm.trmnContext.Branches.ToList();
      List<Rank> ranks = MainForm.trmnContext.Ranks.ToList();
      List<Ship> ships = MainForm.trmnContext.Ships.ToList();
      //Iterate on List
      foreach(PersonBase pb in inputPeople)
      {
        //Check for already in
        Person p = MainForm.trmnContext.People.FirstOrDefault(ppl => ppl.RMNId == pb.RMNId);
        if (p != null) continue;

        //Create New Person
        //Map fields individually  -- Stop and Message on error
        p = new Person();
        p.FirstName = pb.FirstName;
        p.LastName = pb.LastName;
        p.RMNId = pb.RMNId;
        Branch b = branches.FirstOrDefault(br => br.BranchName == pb.BranchName);
        if(b == null)
        {
          MessageBox.Show($"Unable to find Branch {pb.BranchName} in list of Branches. Cannot load list");
          return;
        }
        p.BranchId = b.Id;
        Rank r = ranks.FirstOrDefault(ra => ra.RankName == pb.RankName && ra.BranchId == b.Id);
        if (r == null)
        {
          MessageBox.Show($"Unable to find Rank {pb.RankName} in list of Ranks for Branch. Cannot load list");
          return;
        }
        p.RankId = r.Id;
        Ship s = ships.FirstOrDefault(sh => sh.ShipName == pb.ShipName);
        if (s == null)
        {
          MessageBox.Show($"Unable to find Ship {pb.ShipName} in list of Ships. Cannot load list");
          return;
        }
        p.ShipId = s.Id;
        MainForm.trmnContext.People.Add(p);

      }
      //Commit to context
      MainForm.trmnContext.SaveChanges();
      btnImport.Enabled = true;
    }
  }
}
