using System;

namespace DefineX.MessageBus;

public class BaseMessage
{
    public int Id { get; set; }
    public DateTime MessageCreated { get; set; }
}
