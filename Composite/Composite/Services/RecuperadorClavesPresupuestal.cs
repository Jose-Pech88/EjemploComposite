using Composite.Data.Entities;
using Composite.Data.Entities.Interface;
using Composite.Services.Interfaces;
using System;

namespace Composite.Services
{
    public class RecuperadorClavesPresupuestal : IRecuperadorClavesPresupuestal
    {
        public IClavePresupuestalComponent RecuperarClavePresupuestal()
        {
            ClavePresupuestal Clave111_1 = new ClavePresupuestal(LlenarDTO());
            UnidadAdministrativaComposite component111 = LlenarUA("1.1.1", Clave111_1);

            ClavePresupuestal Clave112_1 = new ClavePresupuestal(LlenarDTO());
            UnidadAdministrativaComposite component112 = LlenarUA("1.1.2", Clave112_1);          

            ClavePresupuestal Clave121_1 = new ClavePresupuestal(LlenarDTO());
            UnidadAdministrativaComposite component121 = LlenarUA("1.2.1", Clave121_1);

            ClavePresupuestal Clave122_1 = new ClavePresupuestal(LlenarDTO());
            UnidadAdministrativaComposite component122 = LlenarUA("1.2.2", Clave122_1);

            UnidadAdministrativaComposite component11 = LlenarUA("1.1", component111);
            component11.Add(component112);

            UnidadAdministrativaComposite component12 = LlenarUA("1.2", component121);
            component12.Add(component122);

            UnidadAdministrativaComposite component1 = LlenarUA("1", component11);
            component1.Add(component12);

            ClavePresupuestal Clave211_1 = new ClavePresupuestal(LlenarDTO());
            UnidadAdministrativaComposite component211 = LlenarUA("2.1.1", Clave211_1);

            ClavePresupuestal Clave212_1 = new ClavePresupuestal(LlenarDTO());
            UnidadAdministrativaComposite component212 = LlenarUA("2.1.2", Clave212_1);

            ClavePresupuestal Clave221_1 = new ClavePresupuestal(LlenarDTO());
            UnidadAdministrativaComposite component221 = LlenarUA("2.2.1", Clave221_1);

            ClavePresupuestal Clave222_1 = new ClavePresupuestal(LlenarDTO());
            UnidadAdministrativaComposite component222 = LlenarUA("2.2.2", Clave222_1);

            UnidadAdministrativaComposite component21 = LlenarUA("2.1", component211);
            component21.Add(component212);

            UnidadAdministrativaComposite component22 = LlenarUA("2.2", component221);
            component22.Add(component222);

            UnidadAdministrativaComposite component2 = LlenarUA("2", component21);
            component2.Add(component22);           

            ClavePresupuestal Clave311_1 = new ClavePresupuestal(LlenarDTO());           

            UnidadAdministrativaComposite component31 = LlenarUA("3.1", Clave311_1);        

            UnidadAdministrativaComposite component3 = LlenarUA("3", component31);

            ClavePresupuestal Clave41_1 = new ClavePresupuestal(LlenarDTO());

            UnidadAdministrativaComposite component4 = LlenarUA("4", Clave41_1);

            UnidadAdministrativaComposite component = LlenarUA("X", component1);
            component.Add(component2);
            component.Add(component3);
            component.Add(component4);
            return component;
        }
        private ICuentasPresupuestalDTO LlenarDTO()
        {
            ICuentasPresupuestalDTO cuentas = new CuentasPresupuestalDTO();
            Random random = new Random();
            cuentas.iId = random.Next(1, 1000);
            cuentas.dTotalEnero = random.Next(1001, 2000);
            cuentas.dTotalFebrero = random.Next(2001, 3000);
            cuentas.dTotalMarzo = random.Next(3001, 4000);
            cuentas.dTotalAbril = random.Next(4001, 5000);
            return cuentas;
        }

        private UnidadAdministrativaComposite LlenarUA(string _cClave, IClavePresupuestalComponent _clavePresupuestalComponent)
        {
            UnidadAdministrativaComposite unidad = new UnidadAdministrativaComposite();
            unidad.UnidadAdministrativa = _cClave;
            unidad.Add(_clavePresupuestalComponent);
            return unidad;
        }
    }
}
