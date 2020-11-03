using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace MarksmanshipTracker
{
  public partial class ShipsForm : Form
  {
    public ShipsForm()
    {
      InitializeComponent();
    }

    private void LoadData()
    {
      MainForm.trmnContext.Ships.Load();
      shipsBindingSource.DataSource = MainForm.trmnContext.Ships.Local.ToBindingList();
    }



    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void ShipsForm_Load(object sender, EventArgs e)
    {
      LoadData();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      MainForm.trmnContext.SaveChanges();
      this.Close();
    }
  }
}
