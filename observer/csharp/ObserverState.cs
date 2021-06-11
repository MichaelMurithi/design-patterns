using System;

namespace CSharp{
    public class ObserverState{
        public string Message { get; set; }
        public DateTime LastUpdated { get; set; } = DateTime.UtcNow;
    }
}