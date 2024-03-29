
namespace ECOCEMProject;

public class HerramientaMantNecesario
{
    public int HerramientasId {get; set;}
    public Herramienta? Herramienta {get; set;}

    //llaves de Mantenimiento necesario
    public int TipoEquipoId {get; set;}
    public int AMId {get; set;}
    public double HorasExpId {get; set; }

    public MantenimientoNecesario? MantenimientoNecesario {get; set;}

    public string UnidadMedidaR {get; set;}
    public int CantidadR {get; set;}
}