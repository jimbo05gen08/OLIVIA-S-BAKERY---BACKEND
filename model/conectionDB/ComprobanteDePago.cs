using System;
using System.Collections.Generic;

namespace OLIVIA_S_BAKERY___BACKEND.model.conectionDB;

public partial class ComprobanteDePago
{
    public string IdComprobante { get; set; } = null!;

    public string TipoComprobante { get; set; } = null!;

    public virtual ICollection<DetallePedido> DetallePedidos { get; set; } = new List<DetallePedido>();
}
