﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OpenChat.Models
{
    public class Message
    {
        public Message()
        {
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            this.Timestamp = (DateTime.Today - dtDateTime).TotalSeconds;
        }

        public int ID { get; set; }
        public string Text { get; set; }
        public double Timestamp { get; set; }
        public string Author { get; set; }
        public string Room { get; set; }
    }
}