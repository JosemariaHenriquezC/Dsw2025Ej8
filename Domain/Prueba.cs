using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej8.Domain;

public static class Prueba
{
    public static string[] _titulares =
    {
        "Facu",
        "Franco"
    };
    public static List<CuentaBancaria> Cuentas { get; private set; } = new List<CuentaBancaria>();

    public static void GuardarDatos()
    {
        CajaDeAhorro cuentaAhorro1 = new CajaDeAhorro("123456", 1000, _titulares)
        {
            TasaDeInteres = 0.05m
        };
        CajaDeAhorro cuentaAhorro2 = new CajaDeAhorro("654321", 500, _titulares)
        {
            TasaDeInteres = 1.0m
        }
        ;
        CuentaCorriente cuentaCorriente1 = new CuentaCorriente("789012", 2000, _titulares)
        {
            LimiteDeDescubierto = 500
        };
        CuentaCorriente cuentaCorriente2 = new CuentaCorriente("210987", -500, _titulares)
        {
            LimiteDeDescubierto = 1000
        };

        Cuentas.Add(cuentaAhorro1);
        Cuentas.Add(cuentaAhorro2);
        Cuentas.Add(cuentaCorriente1);
        Cuentas.Add(cuentaCorriente2);
    }

    public static void FalloActiva()
    {
        Cuentas[0].Desactivar();
        Cuentas[0].Depositar(500);
    }

    public static void Deposito()
    {
        Console.WriteLine($"Saldo de la cuenta {Cuentas[0]._numero} es {Cuentas[0]._saldo}");
        Cuentas[0].Depositar(500);
        Console.WriteLine($"Saldo de la cuenta {Cuentas[0]._numero} es {Cuentas[0]._saldo}");
        Console.WriteLine("En tres segundo se dara una excepcion");
        System.Threading.Thread.Sleep(3000);
        Cuentas[0].Depositar(-1);
    }

    public static void Retiro()
    {
        Console.WriteLine($"Saldo de la cuenta {Cuentas[0]._numero} es {Cuentas[0]._saldo}");
        Cuentas[0].Retirar(501);
        Console.WriteLine($"Saldo de la cuenta {Cuentas[0]._numero} es {Cuentas[0]._saldo}");
        Console.WriteLine($"Saldo de la cuenta {Cuentas[0]._numero} es {Cuentas[0]._saldo}");
        Console.WriteLine("En tres segundo se dara una excepcion");
        System.Threading.Thread.Sleep(3000);
        Cuentas[0].Retirar(500);
    }

    public static void RetiroDescubierto()
    {
        Console.WriteLine($"Saldo de la cuenta {Cuentas[2]._numero} es {Cuentas[2]._saldo}");
        Cuentas[2].Retirar(2001);
        Console.WriteLine($"Saldo de la cuenta {Cuentas[2]._numero} es {Cuentas[2]._saldo}");
        Console.WriteLine("En tres segundo se dara una excepcion");
        System.Threading.Thread.Sleep(3000);
        Cuentas[2].Retirar(500);
    }

    public static void Interes()
    {
        if (Cuentas[1] is CajaDeAhorro cuentaAhorro)
        {
            Console.WriteLine($"Saldo de la cuenta {cuentaAhorro._numero} es {cuentaAhorro._saldo}");
            cuentaAhorro.AplicarInteres();
            Console.WriteLine($"Saldo de la cuenta {cuentaAhorro._numero} es {cuentaAhorro._saldo}");
        }
    }

}