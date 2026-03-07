using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASPCoreWebAPICRUD.Models;

public partial class Student
{
    [Key]
    public int Id { get; set; }

    public string? Studentname { get; set; }

    public int? Age { get; set; }

    public int? Standard { get; set; }

    public string? Fathername { get; set; }
}
