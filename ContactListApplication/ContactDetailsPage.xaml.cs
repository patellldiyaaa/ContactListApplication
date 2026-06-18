namespace ContactListApplication;

public partial class ContactDetailsPage : ContentPage
{
	public ContactDetailsPage(Contact contact)
	{
		InitializeComponent();
		BindingContext = contact;
	}

	private async void BackButton_Clicked(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
	}
}