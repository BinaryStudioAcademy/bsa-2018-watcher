namespace Watcher.Common.Errors
{
    using System;

    [Serializable]
    public class ErrorResponse
    {
        public ErrorResponse() { }

        public ErrorResponse(string message)
        {
            ErrorMessage = message;
        }

        public string ErrorMessage { get; set; } = string.Empty;
    }
}
