﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FinTrack.Models;

public partial class TypeOfIncome
{
    public int Id { get; set; }

    public string Name { get; set; }

    public virtual ICollection<Income> Incomes { get; set; } = new List<Income>();
}