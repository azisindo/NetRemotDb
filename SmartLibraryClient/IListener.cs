using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLibraryClient
{
    public interface IListener
    {
        void Ok(bool addData, object[] data);
    }
}
