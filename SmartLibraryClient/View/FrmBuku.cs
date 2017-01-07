using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SmartLibraryLib.IDao;
using SmartLibraryLib.Model;


namespace SmartLibraryClient.View
{
    public partial class FrmBuku : Form
    {
        private IBukuDao bukuDao = null;

        public FrmBuku()
        {
            InitializeComponent();
            string server = "localhost";
            string port = "1234";
            string uri = "SmartLibraryServer.BukuDao";

            string url = "tcp://" + server + ":" + port + "/" + uri;

            // mendapatkan proxy untuk remote object dari class BukuDao
            bukuDao = (IBukuDao)Activator.GetObject(typeof(IBukuDao), url);


        }

        private void FrmBuku_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAddEditBuku frm = new FrmAddEditBuku(true, this.bukuDao, new object[] { });
          //  frm.Listener = this;
          
            frm.ShowDialog();
        }
    }
}
