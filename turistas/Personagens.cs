namespace turistas;


public class Personagens

{
    public string Nomedafoto;
    protected double Fome;
    protected double Sede;
    protected double Carinho;

    public string GetNomedafoto()
{
    return Nomedafoto;
}
 public void SetFome(double F)
 {
    Fome = F;
 }
 public double GetFome()
 {
    return Fome;
 }

public void SetSede(double S)
{
  Sede = S;
}
public double GetSede()
{
    return Sede;
}

 public void SetCarinho(double C)
 {
    Carinho = C;
 } 
 public double Getcarinho()
 {
    return Carinho;
 }
 
}
