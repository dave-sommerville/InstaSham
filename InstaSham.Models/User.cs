using System;
using System.Collections.Generic;

namespace InstaSham.Models;

public partial class User
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Username { get; set; } 

    public string UserPassword { get; set; } = null!;

    public string? Bio { get; set; }

    public string? Email { get; set; }

    public string? ProfilePicture { get; set; }

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ICollection<DirectMessage> DirectMessageReceiverNavigations { get; set; } = new List<DirectMessage>();

    public virtual ICollection<DirectMessage> DirectMessageSenderNavigations { get; set; } = new List<DirectMessage>();

    public virtual ICollection<PostLike> PostLikes { get; set; } = new List<PostLike>();

    public virtual ICollection<Post> Posts { get; set; } = new List<Post>();

    public virtual ICollection<Story> Stories { get; set; } = new List<Story>();

    public virtual ICollection<StoryLike> StoryLikes { get; set; } = new List<StoryLike>();

    public virtual ICollection<StoryView> StoryViews { get; set; } = new List<StoryView>();

    public virtual ICollection<User> Followers { get; set; } = new List<User>();

    public virtual ICollection<User> Followings { get; set; } = new List<User>();
}
