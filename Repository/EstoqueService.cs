using winForms.Model;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq.Expressions;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

public class EstoqueService
{
    CrudWinFormContext context = new CrudWinFormContext();

    public async Task<bool> AddEstoque(Estoque stoq)
    {
        
        try
        {
            context.Estoques.Add(stoq);
            await context.SaveChangesAsync();
            return true;
        }
        catch (System.Exception)
        {
            
            throw;
        }
    }

    public async Task<List<Estoque>> VerificaEstoque(Expression<Func<Estoque, bool>> exp)
    {
        var query = context.Estoques.Where(exp);
        return await query.ToListAsync();
    }
}