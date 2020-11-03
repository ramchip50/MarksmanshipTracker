namespace MarksmanshipTracker
{
  using System;
  using System.Data.Entity;
  using System.Data.Entity.Infrastructure;

  public partial class TrackingDataEntities : DbContext
  {
    public TrackingDataEntities(string connString)
        : base(connString)
    {
    }
  }
}