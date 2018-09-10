namespace ServiceBus.Shared.Messages
{
    using System;

    public class InstanceValidatorMessage : InstanceMessage
    {
        public InstanceValidatorMessage()
        {
        }

        public InstanceValidatorMessage(string validatorMessage, Guid instanceId) : base(instanceId)
        {
            ValidatorMessage = validatorMessage;
        }

        public string ValidatorMessage { get; set; }
    }
}