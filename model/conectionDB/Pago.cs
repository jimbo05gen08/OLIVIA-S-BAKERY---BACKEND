using System;
using System.Collections.Generic;

namespace OLIVIA_S_BAKERY___BACKEND.model.conectionDB;

public partial class Pago
{
    public string IdPago { get; set; } = null!;

    public decimal MontoTotal { get; set; }

    public string MetodoPago { get; set; } = null!;

    public virtual ICollection<DetallePedido> DetallePedidos { get; set; } = new List<DetallePedido>();
}
