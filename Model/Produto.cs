using System;
using System.Collections.Generic;

namespace winForms.Model;

public partial class Produto
{
    public int Id { get; set; }

    public string Name { get; set; }

    public decimal? Preco { get; set; }

    public virtual ICollection<Estoque> Estoques { get; set; } = new List<Estoque>();
}
