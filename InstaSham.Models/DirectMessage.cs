using System;
using System.Collections.Generic;

namespace InstaSham.Models;

public partial class DirectMessage
{
    public int Id { get; set; }

    public int Sender { get; set; }

    public int Receiver { get; set; }

    public string? Content { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual User ReceiverNavigation { get; set; } = null!;

    public virtual User SenderNavigation { get; set; } = null!;
}
