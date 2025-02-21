using System;
using System.Collections.Generic;

namespace InstaSham.Models;

public partial class Story
{
    public int Id { get; set; }

    public string? Photo { get; set; }

    public string Content { get; set; } = null!;

    public int UserId { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual ICollection<StoryView> StoryViews { get; set; } = new List<StoryView>();

    public virtual User User { get; set; } = null!;
}
