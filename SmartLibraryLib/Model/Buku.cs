using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLibraryLib.Model
{
    [Serializable]
    public class Buku
    {
        private string _isbn;
        public string isbn
        {
            get { return _isbn; }
            set { _isbn = value; }
        }

        private string _judul;
        public string judul
        {
            get { return _judul; }
            set { _judul = value; }
        }

        private string _edisi;
        public string edisi
        {
            get { return _edisi; }
            set { _edisi = value; }
        }

        private string _bahasa;
        public string bahasa
        {
            get { return _bahasa; }
            set { _bahasa = value; }
        }

        private Penerbit _penerbit = new Penerbit();
        public Penerbit penerbit
        {
            get { return _penerbit; }
            set { _penerbit = value; }
        }
    }
}
