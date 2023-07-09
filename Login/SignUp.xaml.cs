namespace Login;

public partial class SignUp : ContentPage
{
	public SignUp()
	{
		InitializeComponent();
	}

    private async void TapGestureRecognizer_Tapped_For_SingIn(object sender, TappedEventArgs e)
    {
		await Shell.Current.GoToAsync("//SignIn");
    }
}