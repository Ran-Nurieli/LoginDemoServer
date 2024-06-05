using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LoginDemoServer.Models;

[Keyless]
public partial class Grade
{
    [StringLength(100)]
    public string Email { get; set; } = null!;

    [StringLength(100)]
    public string Subject { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Date { get; set; }

    [Column("Grade")]
    public int Grade1 { get; set; }

    [ForeignKey("Email")]
    public virtual User EmailNavigation { get; set; } = null!;
}
