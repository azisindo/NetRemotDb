﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLibraryLib.Model
{
    [Serializable]
    public class Penerbit
    {
        private int _penerbitId;
        public int penerbitId
        {
            get { return _penerbitId; }
            set { _penerbitId = value; }
        }

        private string _nama;
        public string nama
        {
            get { return _nama; }
            set { _nama = value; }
        }
    }
}
