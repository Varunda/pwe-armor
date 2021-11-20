﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using watchtower.Models;
using watchtower.Models.Events;

namespace watchtower.Services {

    public class AdminMessageBroadcast : IAdminMessageBroadcast {

        private List<Message> _Messages = new List<Message>();

        public event EventHandler<Models.Events.Ps2EventArgs<string>>? OnMessageEvent;
        public delegate void MessageHandler(object? sender, string msg);

        public event EventHandler<Ps2EventArgs<int>>? OnClearEvent;
        public delegate void ClearHandler(object? sender);

        public void Log(string msg) {
            _Messages.Insert(0, new Message() {
                Timestamp = DateTime.UtcNow,
                Content = msg
            });
            OnMessageEvent?.Invoke(this, new Ps2EventArgs<string>(msg));
        }

        public void Clear() {
            _Messages.Clear();
            OnClearEvent?.Invoke(this, new Ps2EventArgs<int>(0));
        }

        public List<Message> GetMessages() => new List<Message>(_Messages);

    }
}
