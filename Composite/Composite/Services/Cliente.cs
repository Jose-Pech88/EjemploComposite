using Composite.Services.Interfaces;

namespace Composite.Services
{
    public class Cliente : ICliente
    {
        public decimal ObtenerTotal(IClavePresupuestalComponent _clavePresupuestalComponent)
        {
            return _clavePresupuestalComponent.ObtenerTotal();
        }
    }
}
