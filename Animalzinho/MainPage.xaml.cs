namespace Animalzinho;

public partial class MainPage : ContentPage
{
	Personagens atual;

	
	GatoPreto pretinho;
	GatoLaranja laranjinha;
	GatoBranco nuvenzinha;

	public MainPage()
	{
		InitializeComponent ();

        pretinho = new GatoPreto();
		laranjinha = new GatoLaranja();
		nuvenzinha = new GatoBranco();
    	atual = pretinho;

		var Pretinho = new Personagens();
		Pretinho.SetFome(0.1);
		ProgressbarHum.Progress = Pretinho.GetFome();
	}

    void MudarPersonagem (object SENDER, EventArgs args)
	 {
		if (atual == pretinho)
		{
			atual = nuvenzinha;
		}
		else if (atual == nuvenzinha)
		{
			atual = laranjinha;
		}
		else 
		{
			atual= pretinho;
		}

		ImagemAnimalzinho.Source = atual.GetNomeDaImagem();
		AtualizaPersonagem();
       
	 }
	  void AumentarFome (object SENDER, EventArgs args)
	  {
		atual.SetFome(atual.GetFome() + 0.1);
		AtualizaPersonagem();
	  }
	  void AumentarSede (object SENDER, EventArgs args)
	  {
		atual.SetSede(atual.GetSede() + 0.1);
		AtualizaPersonagem();
	  }
	  void AumentarFelicidade (object SENDER, EventArgs args)
	  {
		atual.SetTristeza(atual.GetTristeza() + 0.1);
		AtualizaPersonagem();
	  }
	  void AtualizaPersonagem()
	  { 
		ProgressbarHum.Progress = atual.GetFome();
		ProgressbarCopo.Progress = atual.GetSede();
		ProgressbarRosto.Progress = atual.GetTristeza();
    	ImagemAnimalzinho.Source = atual.GetNomeDaImagem();
	  }
}

