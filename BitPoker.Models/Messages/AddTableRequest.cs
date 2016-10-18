﻿using System;

namespace BitPoker.Models.Messages
{
    public class AddTableRequest : BaseMessage
    {
        public Contracts.Table Table { get; set; }

        public AddTableRequest()
        {
            base.TimeStamp = DateTime.UtcNow;
            base.Id = Guid.NewGuid();
        }
    }
}
