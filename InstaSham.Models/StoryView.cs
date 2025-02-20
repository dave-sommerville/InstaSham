using System;
using System.Collections.Generic;

namespace InstaSham.Models;

public partial class StoryView
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int Viewed { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual User User { get; set; } = null!;
}
