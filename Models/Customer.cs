using System;
using System.Collections.Generic;

namespace PRUEBA_MINERD_RDUVERGE.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Telefono { get; set; } = null!;
}
