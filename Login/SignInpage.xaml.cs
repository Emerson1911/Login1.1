namespace Login;

public partial class SignInpage : ContentPage
{
	public SignInpage()
	{
		InitializeComponent();
	}

    private async void TapGestureRecognizer_Tapped_For_SignUp(object sender, TappedEventArgs e)
    {
		await Shell.Current.GoToAsync("//SignUp");
    }
}