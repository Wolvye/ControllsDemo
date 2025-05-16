namespace ControllsDemo;

public partial class CommandsControlsDemo : ContentPage
{
	public CommandsControlsDemo()
	{
		InitializeComponent();
	}

    private void btnTest_Clicked(object sender, EventArgs e)
    {
		DisplayAlert("Test", "This is a demo","Ok");
    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {

    }

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        DisplayAlert("RadioButton", $"Changed: {e.Value}", "Ok");
    }
}