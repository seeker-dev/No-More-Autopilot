using ActuallyGoodToDoApp.Models;

namespace ActuallyGoodToDoApp;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    public List<ActivityGroup> Activities { get; private set; } = new List<ActivityGroup>();

    private void ContentPage_Loaded(object sender, EventArgs e)
    {
        var allactivities = ActivityRepository.GetActivities();

        Activities.Add(new ActivityGroup("Today", allactivities.Where(x => x.Date == DateTime.Today || x.Date == DateTime.MinValue)));

        Activities.Add(new ActivityGroup("Tomorrow", allactivities.Where(x => x.Date.DayOfYear == DateTime.Today.DayOfYear + 1)));

        if (allactivities[5].Date.DayOfYear != DateTime.Today.DayOfYear + 1) { }

        Activities.Add(new ActivityGroup("Upcoming", allactivities.Where(x => x.Date > DateTime.Today.AddDays(2))));

        xcv_collection.ItemsSource = Activities;
    }

    private async void xbt_add_Clicked(object sender, EventArgs e)
    {
        //await Shell.Current.GoToAsync($"{nameof(AddActivity)}");
    }

    private async void xlv_list_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        //await Shell.Current.GoToAsync($"{nameof(ViewActivity)}?id={((Activity)xlv_list.SelectedItem).Id - 1}");
    }
}

public class ActivityGroup : List<Activity>
{
    public string Name { get; private set; }

    public ActivityGroup (string name, IEnumerable<Activity> activities) : base (activities) 
    { 
        Name = name;
    }
}

