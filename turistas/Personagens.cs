namespace turistas;


public class Personagens

{
    protected string Nomedafoto;
    protected double Fome;
    protected double Sede;
    protected double Carinho;
    protected bool tamorto;
    protected string fototamorto;

public Personagens()
{
   Fome = 0;
   Sede = 0;
   Carinho = 0;
}

    public string GetNomedafoto()
{
    return Nomedafoto;
}


 public void SetFome(double F)
 {
    Fome = F;
    if (Fome <= 0)
    {
      Fome = 0;
      tamorto = true;
    }
 }


 public double GetFome()
 {
    return Fome;
 }


public void SetSede(double S)
{
  Sede = S;
  if (Sede <= 0)
    {
      Sede = 0;
      tamorto = true;
    }
}


public double GetSede()
{
    return Sede;
}


 public void SetCarinho(double C)
 {
    Carinho = C;
    if (Carinho <= 0)
    {
      Carinho = 0;
      tamorto = true;
    }
 } 


 public double GetCarinho()
 {
    return Carinho;
 }
 
}
