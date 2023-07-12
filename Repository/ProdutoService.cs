using winForms.Model;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System;
using Microsoft.EntityFrameworkCore;

public class ProductService
{
    CrudWinFormContext context = new CrudWinFormContext();
    public async Task<bool> AddProduct(Produto prod)
    {
        try
        {
            context.Produtos.Add(prod);
            await context.SaveChangesAsync();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public async Task<List<Produto>> Filter(Expression<Func<Produto, bool>> exp)
    {
        var query = context.Produtos.Where(exp);
        return await query.ToListAsync();
    }
    

}