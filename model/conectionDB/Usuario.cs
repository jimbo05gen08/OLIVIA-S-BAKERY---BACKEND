using System;
using System.Collections.Generic;

namespace OLIVIA_S_BAKERY___BACKEND.model.conectionDB;

public partial class Usuario
{
    public string IdUsuario { get; set; } = null!;

    public string Nombres { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public string Dni { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public string Email { get; set; } = null!;

    public virtual ICollection<DetallePedido> DetallePedidos { get; set; } = new List<DetallePedido>();

    public virtual ICollection<UsuarioAdmin> UsuarioAdmins { get; set; } = new List<UsuarioAdmin>();

    public virtual ICollection<UsuarioCliente> UsuarioClientes { get; set; } = new List<UsuarioCliente>();
}
