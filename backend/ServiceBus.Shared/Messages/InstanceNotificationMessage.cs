namespace ServiceBus.Shared.Messages
{
    using System;

    using ServiceBus.Shared.Enums;

    public class InstanceNotificationMessage : InstanceMessage
    {
        public InstanceNotificationMessage()
        {
        }

        public InstanceNotificationMessage(string text, InstanceNotifyType type, DateTime createdAt, Guid instanceId) : base(instanceId)
        {
            Text = text;
            Type = type;
            CreatedAt = createdAt;
        }

        public string Text { get; set; }

        public InstanceNotifyType Type { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}