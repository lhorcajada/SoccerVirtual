using Lhg.SoccerVirtual.Backend.Data.Model;

namespace Lhg.SoccerVirtual.Backend.Data
{
    public interface IDataFactory
    {
        SoccerVirtualContext GetSoccerVirtualContext();
    }
}