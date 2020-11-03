using System;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

namespace MarksmanshipTracker
{
  public partial class MainForm : Form
  {

    private static TrackingDataEntities _context = null;
    private static SqlConnectionStringBuilder _sqlConnection = null;

    public static TrackingDataEntities trmnContext { get { return _context; } }
    public static string AdoConnection { get { return _sqlConnection.ConnectionString; } }

    public MainForm()
    {
      InitializeComponent();

      string connectSource = $"{Application.StartupPath}\\TrackingData.db";

#if DEBUG
      connectSource = @"C:\Users\rick\Documents\Visual Studio 2015\Projects\MarksmanshipTracker\MarksmanshipTracker\TrackingData.db";
#endif


      _sqlConnection = new SqlConnectionStringBuilder();
      _sqlConnection.DataSource = connectSource;

      string contextConnect = CreateConnectionString(_sqlConnection);
      _context = new TrackingDataEntities(contextConnect);



    }

    private void btnExit_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void btnPeople_Click(object sender, EventArgs e)
    {
      PeopleForm frmPpl = new PeopleForm();
      frmPpl.ShowDialog();
    }

    private void btnShips_Click(object sender, EventArgs e)
    {
      ShipsForm ships = new ShipsForm();
      ships.ShowDialog();
    }

    private void btnGames_Click(object sender, EventArgs e)
    {
      GamesForm games = new GamesForm();
      games.ShowDialog();
    }

    private void btnSessions_Click(object sender, EventArgs e)
    {
      SessionsForm sessions = new SessionsForm();
      sessions.ShowDialog();
    }

    private void btnReports_Click(object sender, EventArgs e)
    {
      ReportsForm reports = new ReportsForm();
      reports.ShowDialog();
    }

    private static string CreateConnectionString(SqlConnectionStringBuilder sqlDataSource)
    {
      const string providerName = "System.Data.SQLite.EF6";
      const string metaData = "res://*/TrackingDataModel.csdl|res://*/TrackingDataModel.ssdl|res://*/TrackingDataModel.msl";


      EntityConnectionStringBuilder efBuilder = new EntityConnectionStringBuilder();
      efBuilder.Metadata = metaData;
      efBuilder.Provider = providerName;
      efBuilder.ProviderConnectionString = sqlDataSource.ConnectionString;

      return efBuilder.ConnectionString;
    }
  }
}
