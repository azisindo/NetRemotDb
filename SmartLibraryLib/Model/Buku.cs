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

    }
}
