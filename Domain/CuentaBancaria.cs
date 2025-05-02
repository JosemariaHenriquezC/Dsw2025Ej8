namespace Dsw2025Ej8.Domain;
using Dsw2025Ej8.Domain.Excepciones;

public abstract class CuentaBancaria
{
    public string _numero { get; }
    public decimal _saldo { get; protected set; }
    public Estado _estado { get; private set; }
    public decimal _comision { get; private set; }
    public string[] _titulares { get; }

    public CuentaBancaria(string numero, decimal saldo, string[] titulares)
    {
        _numero = numero;
        _saldo = saldo;
        _estado = Estado.Activa;
        _titulares = titulares;
    }

    public void Desactivar()
    {
        _estado = Estado.Inactiva;
    }

    public void Activar()
    {
        _estado = Estado.Activa;
    }

    public void Suspender()
    {
        _estado = Estado.Suspendida;
    }
    public void Depositar(decimal monto)
    {

        if (_estado != Estado.Activa)
        {
            throw new CuentaNoActiva();
        }
        if (monto <= 0)
        {
            throw new MontoNoValido();
        }
        _saldo += monto;
    }
    public abstract void Retirar(decimal monto);

}
