using System;
using SQLite;

namespace SQLiteDemo.MVVM.Models;

public class Car
{
    [PrimaryKey,AutoIncrement]
    public int ID {get;set;}

    [Column("Car_id")]
    public string CarId { get; set; }
    [Column("Model")]
    public string Model {get;set;}
    [Column("Color")]
    public string Color {get;set;}
}
