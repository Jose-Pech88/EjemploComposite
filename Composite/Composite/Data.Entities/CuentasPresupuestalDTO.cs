using Composite.Data.Entities.Interface;

namespace Composite.Data.Entities
{
    public class CuentasPresupuestalDTO : ICuentasPresupuestalDTO
    {
        public int iId { set; get; }
        public decimal dTotalEnero { set; get; }
        public decimal dTotalFebrero { set; get; }
        public decimal dTotalMarzo { set; get; }
        public decimal dTotalAbril { set; get; }
    }
}
