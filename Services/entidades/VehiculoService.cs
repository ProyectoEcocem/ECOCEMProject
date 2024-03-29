using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace ECOCEMProject;
public class VehiculoService
{
    private readonly MyContext _context;

    public VehiculoService(MyContext context)
    {
        _context = context;
    }

    public async Task<Vehiculo> Get(int id)
    {
        var current_entity = await _context.Vehiculos.FindAsync(id);
        if (current_entity == null)
        {
            return null;
        }
        return current_entity;
    }

    public async Task<IEnumerable<Vehiculo>> GetAll()
    {
        return await _context.Vehiculos.ToListAsync();
    }

    public async Task<Vehiculo> Update(int id, Vehiculo vehiculo)
    {
        var existingVehiculo = await Get(id);
        if (existingVehiculo == null)
        {
            return null;
        }
        existingVehiculo.VehiculoId = vehiculo.VehiculoId;
        await _context.SaveChangesAsync();
        return vehiculo;
    }

    public async Task<Vehiculo> Create(Vehiculo vehiculo)
    {
        _context.Vehiculos.Add(vehiculo);
        await _context.SaveChangesAsync();
        return vehiculo;
    }

    public async Task Delete(int id)
    {
        var vehiculo = await Get(id);
        if (vehiculo == null)
        {
            return;
        }
        _context.Vehiculos.Remove(vehiculo);
        await _context.SaveChangesAsync();
    }
}
