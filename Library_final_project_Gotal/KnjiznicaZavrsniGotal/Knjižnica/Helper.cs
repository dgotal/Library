using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;
using ZXing;
using ZXing.QrCode;
using ZXing.Common;
using System.Data.SqlClient;
using System.Configuration;

namespace KnjiznicaZavrsniGotal.Knjižnica
{
    public static class Helper
    {
        public static SqlConnection ConnectToDB()
        {
            return new SqlConnection("Data Source=qullix.com;Initial Catalog=DavorZavrsni.Development;Persist Security Info=True;User ID=davor_admin;Password=SSss!!11");
            
        }
       
      
    }
}
