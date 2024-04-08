namespace Animalzinho;

public class Personagens
{
    protected double fome;
    protected double sede;
    protected double tristeza;
    protected string ImagemAnimalzinhoVivo;

    protected string ImagemAnimalzinhoMorto;
    protected bool SeEstiverMorto;
     
    public Personagens()
    {
        fome = 0;
        sede = 0;
        tristeza = 0;
    }

    public void SetFome(double f)
    {
        fome = f;
        if (fome <= 0)
        {
            fome = 0;
            SeEstiverMorto = true;
        }
    }
     public double GetFome()
    {
        return fome;
    }
    public void SetSede(double s)
    {
        sede = s;
        if (sede <= 0)
        {
            sede = 0;
            SeEstiverMorto = true;
        }
    }
    public double GetSede()
    {
        return sede;
    }
    public void SetTristeza(double t)
    {
        tristeza = t;
        if (tristeza <= 0)
        {
            tristeza = 0;
            SeEstiverMorto = true;
        }
    }
    public double GetTristeza()
    {
        return tristeza;
    }
    

    public string GetNomeDaImagem()
    {
        if (SeEstiverMorto)
            return ImagemAnimalzinhoMorto;
        else
            return ImagemAnimalzinhoVivo;
    }

    public bool GetSeEstiverMorto()
    {
        return SeEstiverMorto;
    }
}