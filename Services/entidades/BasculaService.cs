
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
namespace ECOCEMProject;

public class BasculaService
{
    private readonly MyContext _context;

    public BasculaService(MyContext context)
    {
        _context = context;
    }

    public async Task<Bascula> Get(int id)
    {
        //var current_entity = await _context.FindAsync<Bascula>(id);
        var current_entity = await _context.Basculas.FindAsync(id);
        
        if(current_entity == null!){
             throw new InvalidOperationException("Entidad no encontrada");
        }
        return current_entity;
    }


    public async Task<IEnumerable<Bascula>> GetAll()
    {
        return await _context.Basculas.ToListAsync();
    }

    public async Task<Bascula> Update(int id,Bascula bascula)
    {
        var existingBascula = await Get(id);

        if (existingBascula == null)
        {
            return null;
        }
        
        //existingBascula.BasculaId = bascula.BasculaId;
        await _context.SaveChangesAsync();

        return bascula;
    }

    public async Task<Bascula> Create(Bascula bascula)
    {
        _context.Basculas.Add(bascula);
        await _context.SaveChangesAsync();

        return bascula;
    }

    public async Task Delete(int id)
    {
        var bascula = await Get(id);

        if (bascula == null)
        {
            return;
        }

        _context.Basculas.Remove(bascula);
        await _context.SaveChangesAsync();
    }
}
