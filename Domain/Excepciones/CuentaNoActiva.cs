using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej8.Domain.Excepciones;

public class CuentaNoActiva : Exception
{
    public CuentaNoActiva() : base("La cuenta no está activa.") { }
}
