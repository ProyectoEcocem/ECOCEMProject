namespace ECOCEMProject;

public class Brigada
{
    public int BrigadaId { get; set; }
    public List<OrdenTrabajo> OrdenesTrabajo {get; } = new();
}