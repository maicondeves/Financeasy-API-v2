﻿namespace Financeasy.Business.Core
{
    public class Notification
    {
        public string Message { get; }

        public Notification(string message)
        {
            Message = message;
        }
    }
}