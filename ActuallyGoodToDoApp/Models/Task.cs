namespace ActuallyGoodToDoApp.Models
{
    public class Task : Activity
    {
        public List<Task> SubTasks { get; set; }
    }
}
