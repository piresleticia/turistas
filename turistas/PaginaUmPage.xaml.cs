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

		ProgressFome.Progress = atual.GetFome();


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

	void maisfome(object sender, EventArgs args) 
{
	atual.SetFome(atual.GetFome() + 0.05);
	AtualizaPersonagem();
}

	void maissede(object sender, EventArgs args) 
{
	atual.SetSede(atual.GetSede() + 0.05);
	AtualizaPersonagem();
}
	void maiscarinho(object sender, EventArgs args) 
{
	atual.SetCarinho(atual.Getcarinho() + 0.05);
	AtualizaPersonagem();
}


   void AtualizaPersonagem();
     ProgressBarSede.Progress = atual.GetSede();
	  ProgressBarFome.Progress = atual.GetFome();
	   ProgressBarCarinho.Progress = atual.GetCarinho();
	   
}
        





