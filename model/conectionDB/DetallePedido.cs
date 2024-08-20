using System;
using System.Collections.Generic;

namespace OLIVIA_S_BAKERY___BACKEND.model.conectionDB;

public partial class DetallePedido
{
    public string IdDetalle { get; set; } = null!;

    public string IdUsuario { get; set; } = null!;

    public string IdPago { get; set; } = null!;

    public string IdComprobante { get; set; } = null!;

    public string IdPedido { get; set; } = null!;

    public string IdProducto { get; set; } = null!;

    public decimal Cantidad { get; set; }

    public virtual ComprobanteDePago IdComprobanteNavigation { get; set; } = null!;

    public virtual Pago IdPagoNavigation { get; set; } = null!;

    public virtual Pedido IdPedidoNavigation { get; set; } = null!;

    public virtual Producto IdProductoNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
