namespace Clase_4;

public class Empresa
{
    public List<Persona> Empleados { get; set; }
    
    public Empresa()
    {
        Empleados = new List<Persona>();
    }
    
    public void DarAumento(decimal porcentaje)
    {
        foreach (var empleado in Empleados)
        {
            empleado.AumentarSalario(porcentaje);
        }
    }
    
}