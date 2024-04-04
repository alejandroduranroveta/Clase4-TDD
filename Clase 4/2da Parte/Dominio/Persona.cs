namespace Clase_4;

public class Persona
{
    public string Nombre { get; set; }
    public decimal Salario { get; private set; }
    
    
    public Persona(string nombre, decimal salario)
    {
        Nombre = nombre;
        Salario = salario;
    }
    
    public void AumentarSalario(decimal porcentaje)
    {
        Salario += Salario * porcentaje / 100;
    }
}