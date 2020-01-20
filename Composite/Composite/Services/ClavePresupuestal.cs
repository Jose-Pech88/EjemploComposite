using Composite.Data.Entities.Interface;
using Composite.Services.Interfaces;
using System;

namespace Composite.Services
{
    public class ClavePresupuestal : IClavePresupuestalComponent
    {
        private readonly ICuentasPresupuestalDTO CuentasPresupuestalDTO;
        public ClavePresupuestal(ICuentasPresupuestalDTO _cuentasPresupuestalDTO)
        {
            CuentasPresupuestalDTO = _cuentasPresupuestalDTO ?? throw new ArgumentNullException(nameof(_cuentasPresupuestalDTO));
        }

        public decimal ObtenerTotal()
        {
            decimal dTotal = 0;
            dTotal = CuentasPresupuestalDTO.dTotalEnero + CuentasPresupuestalDTO.dTotalFebrero + CuentasPresupuestalDTO.dTotalMarzo + CuentasPresupuestalDTO.dTotalAbril;
            Console.WriteLine(string.Format("Se lee la Cuenta con Id: {0} con valor Total de {1}", CuentasPresupuestalDTO.iId, dTotal));
            return dTotal;
        }
    }
}
