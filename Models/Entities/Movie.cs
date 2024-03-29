﻿namespace Models.Entities;

[Table("movie")]
public class Movie : BaseEntity
{
    public string Name { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}
