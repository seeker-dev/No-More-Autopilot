using ActuallyGoodToDoApp.Models;

namespace ActuallyGoodToDoApp;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void ContentPage_Loaded(object sender, EventArgs e)
    {
        xlv_list.ItemsSource = ActivityRepository.GetActivities();
    }

    private async void xbt_add_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"{nameof(AddActivity)}");
    }

    private async void xlv_list_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        await Shell.Current.GoToAsync($"{nameof(ViewActivity)}?id={((Activity)xlv_list.SelectedItem).Id - 1}");
    }
}

