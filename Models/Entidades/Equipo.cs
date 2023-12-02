using System.Text.Json.Serialization;
namespace ECOCEMProject;

public class Equipo
{
    public int EquipoId {get; set;}
    public int TipoEId { get; set; }
    [JsonIgnore]
    public virtual TipoEquipo TipoEquipo {get;set; }=null!; 
    public int SedeId {get; set;}
    [JsonIgnore]
    public Sede Sede {get; }
    
    //public List<Reporte> Reportes = null!;


    //public List<RoturaEquipo> RoturasEquipos {get; set;}
    //public List<OrdenTrabajo> OrdenesTrabajo {get; } = new();
}