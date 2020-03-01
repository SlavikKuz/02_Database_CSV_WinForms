﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TubeStore.Models.Chat;

namespace TubeStore.Models.Notification
{
    public class NotificationUser
    {
        public string NotificationUserId {get;set;}
        public int NotificationId { get; set; }
        public Notification Notification { get; set; }
        public string ChatUserId { get; set; }
        public ChatUser ChatUser { get; set; }
        public bool IsRead { get; set; } = false;
    }
}
