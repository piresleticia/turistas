using Microsoft.Maui.Handlers;

namespace turistas;

public partial class PaginaUmPage : ContentPage
{

	public PaginaUmPage()
	{
		InitializeComponent();

	}

 private void Clicarvoltar(object sender, EventArgs args) 
	{
	  Application.Current.MainPage = new MainPage();
	  
	}


       {atual= fazenda;

       imgPersonagem.Source = atual.GetNomeDaImagem(); 
       progressBarFome.Progress = atual.GetFome();
	   }
void quandoclicartrocar(object sender, EventArgs args) 
{
	atual = nome da personagem;
}









}
