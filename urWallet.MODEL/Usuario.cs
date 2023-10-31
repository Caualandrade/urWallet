using System;
using System.Collections.Generic;

namespace urWallet.MODEL;

public partial class Usuario
{
    public int Id { get; set; }

    public string user { get; set; } = null!;

    public string Senha { get; set; } = null!;

    public decimal? Saldo { get; set; }
}
