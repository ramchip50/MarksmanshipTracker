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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarksmanshipTracker
{
  [IgnoreFirst]
  [DelimitedRecord(",")]
  public class PersonBase
  {
    [FieldOrder(2)]
    public string FirstName { get; set; }
    [FieldOrder(3)]
    public string LastName { get; set; }
    [FieldOrder(4)]
    public string RMNId { get; set; }
    [FieldOrder(5)]
    public string BranchName { get; set; }
    [FieldOrder(6)]
    public string RankName { get; set; }
    [FieldOrder(7)]
    public string ShipName { get; set; }

  }

  [IgnoreFirst]
  [DelimitedRecord(",")]
  public class PeopleCumulativeLog
  {
    [FieldOrder(1)]
    [FieldConverter(ConverterKind.Int64)]
    public long PersonId { get; set; }
    [FieldOrder(2)]
    public string FirstName { get; set; }
    [FieldOrder(3)]
    public string LastName { get; set; }
    [FieldOrder(4)]
    public string RMNId { get; set; }
    [FieldOrder(5)]
    public string BranchName { get; set; }
    [FieldOrder(6)]
    public string RankName { get; set; }
    [FieldOrder(7)]
    public string ShipName { get; set; }
    [FieldOrder(8)]
    public string RMNWeapon { get; set; }
    [FieldOrder(9)]
    public decimal CumCredits { get; set; }

  }

  [IgnoreFirst]
  [DelimitedRecord(",")]
  public class PeopleSessionLog
  {
    [FieldOrder(1)]
    [FieldConverter(ConverterKind.Int64)]
    public long PersonId { get; set; }
    [FieldOrder(2)]
    public string FirstName { get; set; }
    [FieldOrder(3)]
    public string LastName { get; set; }
    [FieldOrder(4)]
    public string RMNId { get; set; }
    [FieldOrder(5)]
    public string BranchName { get; set; }
    [FieldOrder(6)]
    public string RankName { get; set; }
    [FieldOrder(7)]
    public string ShipName { get; set; }
    [FieldConverter(ConverterKind.Date, "yyyy-MM-dd")]
    [FieldOrder(8)]
    public DateTime SessionDate { get; set; }
    [FieldOrder(9)]
    public string GameName { get; set; }
    [FieldOrder(10)]
    public Decimal Credits { get; set; }
    [FieldOrder(11)]
    public string RMNWeapon { get; set; }
    [FieldOrder(12)]
    public string RMAWeapon { get; set; }
  }

  [IgnoreFirst]
  [DelimitedRecord(",")]
  public class PersonAward
  {
    [FieldOrder(1)]
    public long PersonId { get; set; }
    [FieldOrder(2)]
    public string FirstName { get; set; }
    [FieldOrder(3)]
    public string LastName { get; set; }
    [FieldOrder(4)]
    public string RMNId { get; set; }
    [FieldOrder(5)]
    public string BranchName { get; set; }
    [FieldOrder(6)]
    public string RankName { get; set; }
    [FieldOrder(7)]
    public string ShipName { get; set; }
    [FieldOrder(8)]
    public string PistolAward { get; set; }
    [FieldOrder(9)]
    public string RifleAward { get; set; }

  }

}