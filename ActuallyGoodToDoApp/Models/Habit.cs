namespace ActuallyGoodToDoApp.Models
{
    public class Habit : Activity
    {
        public DateTime TimeWindow { get; set; } // for use with windowed tasks.  tasks that you know can only be done between specific times a day
    }
}
