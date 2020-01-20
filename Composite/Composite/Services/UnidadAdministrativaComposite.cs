using Composite.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace Composite.Services
{
    public class UnidadAdministrativaComposite : IClavePresupuestalComponent
    {
        public string UnidadAdministrativa { set; get; }

        protected List<IClavePresupuestalComponent> _children = new List<IClavePresupuestalComponent>();

        public UnidadAdministrativaComposite()
        {
        }

        public void Add(IClavePresupuestalComponent component)
        {
            this._children.Add(component);
        }

        public void Remove(IClavePresupuestalComponent component)
        {
            this._children.Remove(component);
        }
        public decimal ObtenerTotal()
        {
            decimal dTotal = 0;
            foreach (IClavePresupuestalComponent item in this._children)
            {
                dTotal = dTotal + item.ObtenerTotal();
            }
            Console.WriteLine(string.Format("UA {0} con suma de cuentas con valor de {1}", UnidadAdministrativa, dTotal));
            return dTotal;
        }
    }
}
