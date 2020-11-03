using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace MarksmanshipTracker
{
  public partial class GamesForm : Form
  {
    public GamesForm()
    {
      InitializeComponent();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      MainForm.trmnContext.SaveChanges();

      this.Close();

    }

    private void GamesForm_Load(object sender, EventArgs e)
    {
      MainForm.trmnContext.Games.Load();

      gamesBindingSource.DataSource = MainForm.trmnContext.Games.Local.ToBindingList();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
  }
}
