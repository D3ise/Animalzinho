namespace Animalzinho;

public partial class MainPage : ContentPage
{
	Personagens atual;

	GatoPreto Pretinho = new GatoPreto();
	GatoBranco Nuvenzinha = new GatoBranco();
	GatoLaranja Laranjinha = new GatoLaranja();

	public MainPage()
	{
		InitializeComponent ();

    	atual = Pretinho;
		ImagemAnimalzinho.Source = atual.GetNomeDaImagem();
	}

    void MudarPersonagem (object SENDER, EventArgs args)
	 {
		if (atual == Pretinho)
		{
			atual = Nuvenzinha;
		}
		else if (atual == Nuvenzinha)
		{
			atual = Laranjinha;
		}
		else 
		{
			atual= Pretinho;
		}

        ProgressbarHum.Progress = atual.SetFome();
		ProgressbarCopo.Progress = atual.GetSede();
    	ImagemAnimalzinho.Source = atual.GetNomeDaImagem();
	 }
	  void AumentarFome (object SENDER, EventArgs args)
	  {
		var animalzinho =GatoPreto.GetFome();
		GatoPreto.SetFome(animalzinho + 0.1);
	  }
}

