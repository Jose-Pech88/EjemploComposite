namespace Composite.Data.Entities.Interface
{
    public interface ICuentasPresupuestalDTO
    {
        int iId { set; get; }
        decimal dTotalEnero { set; get; }
        decimal dTotalFebrero { set; get; }
        decimal dTotalMarzo { set; get; }
        decimal dTotalAbril { set; get; }
    }
}
