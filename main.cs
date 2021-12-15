using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ccO2urMNHFLXGD;
using System.Data.SqlClient;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.SuperGrid;
using CrystalDecisions.CrystalReports.Engine;
using System.IO;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing.Imaging;
using QRCoder;

namespace gym_management_system
{
    public partial class Form1 : DevComponents.DotNetBar.Metro.MetroForm
    {
    private void btn_save_memb_Click(object sender, EventArgs e)
        {
        dev_msg.showAlert("Successfully saved!", "\uf00c", eDesktopAlertColor.Green, eAlertPosition.BottomRight);
        }
    }
}    
