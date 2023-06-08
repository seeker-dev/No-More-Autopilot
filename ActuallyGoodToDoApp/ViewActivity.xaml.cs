using ActuallyGoodToDoApp.Models;

namespace ActuallyGoodToDoApp;

[QueryProperty(nameof(ActivityId), "id")]
public partial class ViewActivity : ContentPage
{
	protected Activity _activity;

	public ViewActivity()
	{
		InitializeComponent();
	}

	public int ActivityId { get; set; }

    private void ContentPage_BindingContextChanged(object sender, EventArgs e)
    {
        _activity = ActivityRepository.GetActivity(ActivityId);
        BindingContext = _activity;
    }
}