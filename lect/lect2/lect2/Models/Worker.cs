using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace lect2.Models;

public partial class Worker
{
    public int Wid { get; set; }
    [Required(ErrorMessage = "Worker name is required")]
    public string? Wname { get; set; }
    [Required(ErrorMessage = "Bid is required")]

    public int Bid { get; set; }

    public virtual Branch? BidNavigation { get; set; } = null!;
}
