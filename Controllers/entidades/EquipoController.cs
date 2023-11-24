using Microsoft.AspNetCore.Mvc;
namespace ECOCEMProject;

[Route("api/[controller]/[action]")]
[ApiController]
public class EquipoController : Controller
{
    private readonly EquipoServicio _equipoServicio;

    public EquipoController(EquipoServicio equipoServicio)
    {
        _equipoServicio = equipoServicio;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        Equipo equipo = await _equipoServicio.Get(id);
        if (equipo == null)
        {
            return NotFound();
        }
        return Ok(equipo);
    }

    [HttpGet]
    public async Task<IEnumerable<Equipo>> GetAll() => await _equipoServicio.GetAll();

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Equipo equipo)
    {
        if (equipo == null)
        {
            return BadRequest();
        }
        Equipo equipoCreado = await _equipoServicio.Create(equipo);
        return CreatedAtRoute("Get", new { id = equipoCreado.EquipoId }, equipoCreado);
    }

    [HttpPut]
    public async Task<IActionResult> Put(int id, Equipo equipo)
    {
        if (equipo == null)
        {
            return BadRequest();
        }
        Equipo equipoModificado = await _equipoServicio.Update(id, equipo);
        if (equipoModificado == null)
        {
            return NotFound();
        }
        return Ok(equipoModificado);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(int id)
    {
        await _equipoServicio.Delete(id);
        return NoContent();
    }
}