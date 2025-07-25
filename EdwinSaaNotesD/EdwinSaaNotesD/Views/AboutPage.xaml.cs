namespace EdwinSaaNotesD.Views;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}

    private async void Btn_MiComidafavorita_Clicked(Object sender, EventArgs e)
    {
        if (BindingContext is Models.About about)
        {
            // Navigate to the specified URL in the system browser.
            await Launcher.Default.OpenAsync(about.ComidaFavoritaInfoUrl);
        }
    }
}