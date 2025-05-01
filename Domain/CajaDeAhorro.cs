using Dsw2025Ej8.Domain.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej8.Domain;

class CajaDeAhorro : CuentaBancaria
{
    public decimal TasaDeInteres { get; init; }

    public CajaDeAhorro(string numero, decimal saldo, string[] titulares) 
        : base(numero, saldo, titulares)
    {
    }

    public void AplicarInteres()
    {
        _saldo += _saldo * TasaDeInteres;
    }

    public override void Retirar(decimal monto)
    {
        if(_estado != Estado.Activa)
        {
            throw new CuentaNoActiva();
        }
        if (monto <= 0)
        {
            throw new MontoNoValido();
        }
        _saldo -= monto;
    }
}
