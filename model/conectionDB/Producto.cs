using System;
using System.Collections.Generic;

namespace OLIVIA_S_BAKERY___BACKEND.model.conectionDB;

public partial class Producto
{
    public string IdProducto { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public decimal Precio { get; set; }

    public decimal Stock { get; set; }

    public virtual ICollection<DetallePedido> DetallePedidos { get; set; } = new List<DetallePedido>();
}
