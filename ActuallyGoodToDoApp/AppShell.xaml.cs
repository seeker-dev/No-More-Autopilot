namespace ActuallyGoodToDoApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(ViewActivity), typeof(ViewActivity));
        Routing.RegisterRoute(nameof(AddActivity), typeof(AddActivity));
    }
}
