namespace turistas;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}
	 private void ClicarInicio(object sender, EventArgs args) 
	{
	  Application.Current.MainPage = new PaginaUmPage();
	  
	}

}

