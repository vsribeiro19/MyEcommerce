using System.Data;

namespace Api.Data
{
    public interface IDbSession
    {
        IDbConnection Connection { get; }
    }
}
