﻿using System;
using System.Collections.Generic;

namespace OLIVIA_S_BAKERY___BACKEND.model.conectionDB;

public partial class UsuarioAdmin
{
    public string IdUsuarioAdmin { get; set; } = null!;

    public string IdUsuario { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}