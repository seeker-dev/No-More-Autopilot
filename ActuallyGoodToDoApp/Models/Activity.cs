﻿namespace ActuallyGoodToDoApp.Models
{
    public abstract class Activity
    {
        public int Id { get; set; }
        public string Summary { get; set; }
        public DateTime Date { get; set; }
        public string ActivityType { get => this.GetType().Name.ToString(); }
        public List<DateTime> Reminders { get; set; }
    }
}
