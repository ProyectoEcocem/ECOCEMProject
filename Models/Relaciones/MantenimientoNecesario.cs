
namespace ECOCEMProject;

public class MantenimientoNecesario
{
    public int TipoEquipoId {get; set;}
    public int AMId {get; set;}
    public double HorasExpId {get; set; }

    public List<HerramientaMantNecesario> HerramientaMantNecesarios {get; } = new();
}