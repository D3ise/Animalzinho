namespace Animalzinho;

public class Personagens
{
    protected double fome;
    protected double sede;
    protected double tristeza;
    protected string  ImagemAnimalzinho;
     
    public Personagens()
    {
        fome = 0;
        sede = 0;
        tristeza = 0;
    }

    public void SetFome(double f)
    {
        fome = f;
    }
    public double GetSede()
    {
        return sede;
    }
    

    public string GetNomeDaImagem()
    {
        return ImagemAnimalzinho;
    }
}