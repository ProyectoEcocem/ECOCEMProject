namespace ECOCEMProyect;

public class AccionMantenimiento
{
    public int AMId { get; set; }
}
public class MantenimientoImprevisto : AccionMantenimiento 
{
    
}
public class MantenimientoPlanificado : AccionMantenimiento 
{
    public List<MantenimientoNecesario> MantenimientosNecesarios {get;} = new();
}