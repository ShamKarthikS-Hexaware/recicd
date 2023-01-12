using System.Collections.Generic;

namespace mongodot.Data.Interfaces
{
    public interface IGetAll<T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}
