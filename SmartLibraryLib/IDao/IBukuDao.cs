using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartLibraryLib.Model;

namespace SmartLibraryLib.IDao
{
    public interface IBukuDao:IDao<Buku>
    {
        List<Buku> GetByName(string judul);
        Buku GetById(string bukuId);
        DataSet GetReportByName(string judul);
    }
}
