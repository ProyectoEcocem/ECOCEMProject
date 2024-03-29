using Microsoft.EntityFrameworkCore;

namespace ECOCEMProject;

public class MedidorService
{
     private readonly MyContext _context;

    public MedidorService(MyContext context)
    {
        _context = context;
    }

    public async Task<Medidor> Get(int id)
    {
        var current_entity = await _context.Medidores.FindAsync(id);
        
        if(current_entity == null!){
             throw new InvalidOperationException("Entidad no encontrada");
        }
        return current_entity;
    }


    public async Task<IEnumerable<Medidor>> GetAll()
    {
        return await _context.Medidores.ToListAsync();
    }

    public async Task<Medidor> Update(int id,Medidor medidor)
    {
        var existingMedidor = await Get(id);

        if (existingMedidor == null)
        {
            return null;
        }
        
        //existingBascula.BasculaId = bascula.BasculaId;
        await _context.SaveChangesAsync();

        return medidor;
    }

    public async Task<Medidor> Create(Medidor medidor)
    {
        _context.Medidores.Add(medidor);
        await _context.SaveChangesAsync();

        return medidor;
    }

    public async Task Delete(int id)
    {
        var medidor = await Get(id);

        if (medidor == null)
        {
            return;
        }

        _context.Medidores.Remove(medidor);
        await _context.SaveChangesAsync();
    }
}
