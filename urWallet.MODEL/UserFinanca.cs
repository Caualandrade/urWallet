using System;
using System.Collections.Generic;

namespace urWallet.MODEL;

public partial class UserFinanca
{
    public int Id { get; set; }

    public int? IdFinanca { get; set; }

    public int? IdUser { get; set; }

    public virtual Financa? IdFinancaNavigation { get; set; }

    public virtual Usuario? IdUserNavigation { get; set; }
}
