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
     public double GetFome()
    {
        return fome;
    }
    public void SetSede(double s)
    {
        sede = s;
    }
    public double GetSede()
    {
        return sede;
    }
    public void SetTristeza(double t)
    {
        tristeza = t;
    }
    public double GetTristeza()
    {
        return tristeza;
    }
    

    public string GetNomeDaImagem()
    {
        return ImagemAnimalzinho;
    }
}