using System.Diagnostics;

namespace ControllsDemo;

public partial class TextControlDemo : ContentPage
{
	public TextControlDemo()
	{
		InitializeComponent();
	}

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        Debug.WriteLine(txtName.Text);  
    }

    private void Entry_Completed(object sender, EventArgs e)
    {
        Debug.WriteLine(txtName.Text);
    }
}