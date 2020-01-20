using Composite.Services;
using Composite.Services.Interfaces;
using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InicializarAplicacion();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
        static void InicializarAplicacion()
        {
            IRecuperadorClavesPresupuestal Recuperador = new RecuperadorClavesPresupuestal();
            IClavePresupuestalComponent Component = Recuperador.RecuperarClavePresupuestal();           
            ICliente cliente = new Cliente();
            decimal dTotal = cliente.ObtenerTotal(Component);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(string.Format("Suma Cuentas Total: {0}", dTotal));
        }        
    }
}
