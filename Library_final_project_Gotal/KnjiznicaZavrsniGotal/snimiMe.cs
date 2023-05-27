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

namespace KnjiznicaZavrsniGotal
{
    class snimiMe
    {
        private VideoCapture capture;
        private bool captureInProgress = false;
        private void ProcessFrame(object sender, EventArgs arg)
        {
            Image<Bgr, byte> colImage = capture.QueryFrame().ToImage<Bgr, byte>();
            
       }


    }
}
