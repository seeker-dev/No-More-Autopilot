namespace ActuallyGoodToDoApp.Models
{
    public static class ActivityRepository
    {
        public static List<Activity> activities = new()
        {
            new Task() {Id= 1, Summary = "Get podiatrist"},
            new Task() {Id= 2, Summary = "Car wash"},
            new Task() {Id= 3, Summary = "Clean apartment"},
            new Task() {Id= 4, Summary = "Look for condo"},
            new Habit() {Id= 5, Summary = "Wash comforter"},
            new Task() {Id= 6, Summary = "Get rid of excess paper"},
            new Task() {Id= 7, Summary = "Mitigate excessive mail"},
            new Task() {Id= 8, Summary = "Call Verizon concerning random AMC+"},
            new Task() {Id= 9, Summary = "Plan vacation"},
            new Task() {Id= 10, Summary = "Get rid of garbage in work room"},
            new Task() {Id= 11, Summary = "Get gym gloves"},
            new Event() {Id= 12, Summary = "Summer Game Fest"}
        };

        public static List<Activity> GetActivities() => activities;

        public static Activity GetActivity(int id) => activities[id];
    }
}
