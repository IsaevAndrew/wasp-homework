namespace FirstProgramm;

public partial class MainPage : ContentPage
{
    public string true_password = "1234";
	public MainPage()
	{
		InitializeComponent();
	}
    public void OnButtonClicked(object sender, EventArgs args)
    {
        Result.Text += (sender as Button).Text;
    }
    public void Check(object sender, EventArgs args)
    {
        if (Result.Text!=true_password)
            Result.Text = "";
        else
        {
            Result.Text = "Успешно!";
            foreach (View a in ((sender as Button).Parent as Grid).Children.Cast<View>())
                a.IsEnabled = false;
        }
    }
    public void Deleat(object sender, EventArgs args)
    {
        Result.Text = "";
    }
}

