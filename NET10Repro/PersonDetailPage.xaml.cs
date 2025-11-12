namespace NET10Repro;

public partial class PersonDetailPage : ContentPage
{
	public PersonDetailPage()
	{
		InitializeComponent();
		BindingContext = new BaseViewModel();
	}
}