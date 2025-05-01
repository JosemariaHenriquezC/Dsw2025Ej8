using Dsw2025Ej8.Domain.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej8.Domain;


class CuentaCorriente : CuentaBancaria
{
    public decimal LimiteDeDescubierto { get; init; }

    public CuentaCorriente(string numero, decimal saldo, string[] titulares)
        : base(numero, saldo, titulares)
    {
    }
    public override void Retirar(decimal monto)
    {
        if (_estado != Estado.Activa)
        {
            throw new CuentaNoActiva();
        }
        if (monto <= 0)
        {
            throw new MontoNoValido();
        }
        if (_saldo - monto < -LimiteDeDescubierto)
        {
            base.Suspender();
            throw new SaldoInsuficiente();
        }

        _saldo -= monto;
    }
}