using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SmartLibraryLib.Model;
using System.Data;

namespace SmartLibraryLib.IDao
{
    public interface IPenerbit:IDao<Penerbit>
    {
        List<Penerbit> GetByName(string penerbit);
        DataSet GetReportByName(string penerbit);
    }
}
