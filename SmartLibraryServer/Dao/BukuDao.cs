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
        private string strSql = string.Empty;

        public BukuDao()
        {
            string appDir = System.IO.Directory.GetCurrentDirectory();
            string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + appDir + "\\DbPerpus.mdb;User Id=admin;Password=;";
            conn = new OleDbConnection(strConn);
            conn.Open();
        }

        public int Delete(Buku Entity)
        {
            Console.WriteLine("Method Delete dieksekusi di sisi server");

            strSql = "DELETE FROM buku WHERE isbn = @1";
            using (OleDbCommand cmd = new OleDbCommand(strSql, conn))
            {
                cmd.Parameters.AddWithValue("@1", Entity.isbn);

                return cmd.ExecuteNonQuery();
            }
        }

        public List<Buku> GetAll()
        {
            Console.WriteLine("Method GetAll dieksekusi di sisi server");

            List<Buku> daftarBuku = new List<Buku>();

            strSql = "SELECT isbn, judul, edisi, bahasa, nama AS pengaran " +
                     "FROM buku INNER JOIN penerbit ON buku.penerbit_id = penerbit.id " +
                     "ORDER BY judul";
            using (OleDbCommand cmd = new OleDbCommand(strSql, conn))
            {
                using (OleDbDataReader dtr = cmd.ExecuteReader())
                {
                    while (dtr.Read())
                    {
                        Buku buku = MappingDtrToObject(dtr);
                        daftarBuku.Add(buku);
                    }
                }
            }
            return daftarBuku;
        }

        public Buku GetById(string bukuId)
        {
            Buku buku = null;

            strSql = "SELECT isbn, judul, edisi, bahasa, nama AS pengaran " +
                     "FROM buku INNER JOIN penerbit ON buku.penerbit_id = penerbit.id " +
                     "WHERE isbn = @1";
            using (OleDbCommand cmd = new OleDbCommand(strSql, conn))
            {
                cmd.Parameters.AddWithValue("@1", bukuId);
                using (OleDbDataReader dtr = cmd.ExecuteReader())
                {
                    if (dtr.Read())
                    {
                        buku = MappingDtrToObject(dtr);
                    }
                }
            }
            return buku;

        }

        public List<Buku> GetByName(string judul)
        {
            Console.WriteLine("Method GetByName dieksekusi di sisi server");

            List<Buku> daftarBuku = new List<Buku>();

            strSql = "SELECT isbn, judul, edisi, bahasa, nama AS pengaran " +
                     "FROM buku INNER JOIN penerbit ON buku.penerbit_id = penerbit.id " +
                     "WHERE judul LIKE @1 " +
                     "ORDER BY judul";
            using (OleDbCommand cmd = new OleDbCommand(strSql, conn))
            {
                cmd.Parameters.AddWithValue("@1", "%" + judul + "%");
                using (OleDbDataReader dtr = cmd.ExecuteReader())
                {
                    while (dtr.Read())
                    {
                        Buku buku = MappingDtrToObject(dtr);
                        daftarBuku.Add(buku);
                    }
                }
            }
            return daftarBuku;

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
           Console.WriteLine("Method Save dieksekusi di sisi server");

            strSql = "INSERT INTO buku (isbn, judul, edisi, bahasa, penerbit_id) " +
                     "VALUES (@1, @2, @3, @4, @5)";
            using (OleDbCommand cmd = new OleDbCommand(strSql, conn))
            {
                cmd.Parameters.AddWithValue("@1", Entity.isbn);
                cmd.Parameters.AddWithValue("@2", Entity.judul);
                cmd.Parameters.AddWithValue("@3", Entity.edisi);
                cmd.Parameters.AddWithValue("@4", Entity.bahasa);
                cmd.Parameters.AddWithValue("@5", Entity.penerbit);

                return cmd.ExecuteNonQuery();
            }
        }

        public int Update(Buku Entity)
        {
            Console.WriteLine("Method Update dieksekusi di sisi server");

            strSql = "UPDATE buku SET judul = @1, edisi = @2, bahasa = @3, penerbit_id = @4 " +
                     "WHERE isbn = @5";
            using (OleDbCommand cmd = new OleDbCommand(strSql, conn))
            {
                cmd.Parameters.AddWithValue("@1", Entity.judul);
                cmd.Parameters.AddWithValue("@2", Entity.edisi);
                cmd.Parameters.AddWithValue("@3", Entity.bahasa);
                cmd.Parameters.AddWithValue("@4", Entity.penerbit);
                cmd.Parameters.AddWithValue("@5", Entity.isbn);

                return cmd.ExecuteNonQuery();
            }
        }

        private static Buku MappingDtrToObject(OleDbDataReader dtr)
        {
            Buku buku = NewMethod(dtr);

            return buku;
        }

        private static Buku NewMethod(OleDbDataReader dtr)
        {
            Buku buku = new Buku();
            buku.isbn = dtr[0] is DBNull ? string.Empty : dtr.GetString(0);
            buku.judul = dtr[1] is DBNull ? string.Empty : dtr.GetString(1);
            buku.edisi = dtr[2] is DBNull ? string.Empty : dtr.GetString(2);
            buku.bahasa = dtr[3] is DBNull ? string.Empty : dtr.GetString(3);
            buku.penerbit.nama = dtr[4] is DBNull ? string.Empty : dtr.GetString(4);
            return buku;
        }
    }
}
