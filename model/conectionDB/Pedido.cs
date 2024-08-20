using System;
using System.Collections.Generic;

namespace OLIVIA_S_BAKERY___BACKEND.model.conectionDB;

public partial class Pedido
{
    public string IdPedido { get; set; } = null!;

    public string Estado { get; set; } = null!;

    public DateTime? Fecha { get; set; }

    public virtual ICollection<DetallePedido> DetallePedidos { get; set; } = new List<DetallePedido>();
}
