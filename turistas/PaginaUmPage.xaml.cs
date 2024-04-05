using Microsoft.Maui.Handlers;

namespace turistas;


public partial class PaginaUmPage : ContentPage
{
	Personagens atual;

	Cavalo cavalo = new Cavalo();

	Paicavalo paicavalo = new Paicavalo();
	Maecavalo maecavalo =new Maecavalo();


	public PaginaUmPage()
	{
		InitializeComponent();

		atual = cavalo;

		imgcavalo.Source = atual.GetNomedafoto();


	}

 private void Clicarvoltar(object sender, EventArgs args) 
	{
	  Application.Current.MainPage = new MainPage();
	  
	}

	void TrocaPersonagem(object sender, EventArgs args)
	{
	   if(atual == cavalo)
	   { 
		  atual = paicavalo;
	   }
	   else if(atual == paicavalo)
	   { 
		 atual = maecavalo;
	   }   
	 else 
	 {
		atual= cavalo;
	 }

	   imgcavalo.Source = atual.GetNomedafoto();
	   
	}
}
        





