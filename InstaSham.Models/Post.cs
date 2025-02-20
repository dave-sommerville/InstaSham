using System;
using System.Collections.Generic;

namespace InstaSham.Models;

public partial class Post
{
    public int Id { get; set; }

    public string? Photo { get; set; }

    public string Content { get; set; } = null!;

    public int UserId { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ICollection<PostLike> PostLikes { get; set; } = new List<PostLike>();

    public virtual User User { get; set; } = null!;
}
