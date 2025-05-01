using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej8.Domain.Excepciones;

public class SaldoInsuficiente : Exception
{
    public SaldoInsuficiente() : base("El saldo es insuficiente.") { }
}


