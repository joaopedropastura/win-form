using winForms.Model;
using System.Threading.Tasks;
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

    // public async Task<int> VerificaEstoque()
    // {
        
    // }
}