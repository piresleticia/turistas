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

		imgcavalo.Source = atual.Getfototamorto();

		ProgressBarFome.Progress = atual.GetFome();

		var timer=
		Application.Current.Dispatcher.CreateTimer();
		timer.Interval=
		TimeSpan.FromSeconds(1);
		timer.Tick+=(s,e)=>
		PassouTempo();
		timer.Start();
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

	 imgcavalo.Source = atual.Getfototamorto();
	   AtualizaPersonagem();
	   
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
	atual.SetCarinho(atual.GetCarinho() + 0.05);
	AtualizaPersonagem();
}


   void AtualizaPersonagem()
   {
    ProgressBarSede.Progress = atual.GetSede();
	ProgressBarFome.Progress = atual.GetFome();
	 ProgressBarCarinho.Progress = atual.GetCarinho();
	imgcavalo.Source= atual.Getfototamorto();
   }  

   void PassouTempo()
   {
	var tamorto = atual.Gettamorto();
	atual.SetFome(atual.GetFome() - 0.1);
	atual.SetSede(atual.GetSede() - 0.1);
    atual.SetCarinho(atual.GetCarinho() - 0.1);
	AtualizaPersonagem();
	if (tamorto != atual.Gettamorto())
	{
		 imgcavalo.Source = atual.Getfototamorto();
	}
   }
}

        





