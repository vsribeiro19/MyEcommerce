using System.Data;

namespace WebApplication1.Data
{
    public interface IDbSession
    {
        IDbConnection Connection { get; }
    }
}
