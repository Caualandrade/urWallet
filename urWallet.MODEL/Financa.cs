using System;
using System.Collections.Generic;

namespace urWallet.MODEL;

public partial class Financa
{
    public int Id { get; set; }

    public string? Tipo { get; set; }

    public DateTime? Data { get; set; }

    public decimal? Valor { get; set; }

    public string? Categoria { get; set; }

    public string? Descricao { get; set; }

    public virtual ICollection<UserFinanca> UserFinancas { get; set; } = new List<UserFinanca>();
}
