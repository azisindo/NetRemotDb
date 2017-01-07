using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLibraryLib.IDao
{
    public interface IDao<T>
    {
        int Save(T Entity);
        int Update(T Entity);
        int Delete(T Entity);

        List<T> GetAll();
        DataSet GetReportAll();
    }
}
