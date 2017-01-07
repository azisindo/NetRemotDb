using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SmartLibraryLib.IDao;
using SmartLibraryLib.Model;

using System.Data.OleDb;
using System.Data;

namespace SmartLibraryServer
{
    public class BukuDao : MarshalByRefObject, IBukuDao
    {
        private OleDbConnection conn = null;
        private string strsql = string.Empty;

        public BukuDao()
        {

        }

        public int Delete(Buku Entity)
        {
            throw new NotImplementedException();
        }

        public List<Buku> GetAll()
        {
            throw new NotImplementedException();
        }

        public Buku GetById(string bukuId)
        {
            throw new NotImplementedException();
        }

        public List<Buku> GetByName(string judul)
        {
            throw new NotImplementedException();
        }

        public DataSet GetReportAll()
        {
            throw new NotImplementedException();
        }

        public DataSet GetReportByName(string judul)
        {
            throw new NotImplementedException();
        }

        public int Save(Buku Entity)
        {
            throw new NotImplementedException();
        }

        public int Update(Buku Entity)
        {
            throw new NotImplementedException();
        }
    }
}
