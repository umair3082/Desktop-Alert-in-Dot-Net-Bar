using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using System.Drawing;
using System.Net;
namespace gym_management_system
{
   public static class dev_msg
    {
       #region Dialog msg

        public static TaskDialogInfo CreateTaskDialogInfo(string title,string icon,string header,string content,string color_,eTaskDialogButton btn)
        {
            TaskDialogInfo info = new TaskDialogInfo(title,(eTaskDialogIcon)Enum.Parse(typeof(eTaskDialogIcon),icon),header,content,btn,
                (eTaskDialogBackgroundColor)Enum.Parse(typeof(eTaskDialogBackgroundColor),color_));
            return info;
        }
        #endregion
        #region Show Alert Message

        private static void AlertClicked(long alertId)
        {
            //listBoxAdv1.Items.Insert(0, "Alert clicked, ID: " + alertId.ToString());
        }
        public static void showAlert(string msg,string iconid, eDesktopAlertColor color_,eAlertPosition position)
        {
            DesktopAlert.Show(msg, iconid, eSymbolSet.Awesome, Color.Empty, color_, position, 6, 1, AlertClicked);
        }
        #endregion
    }
}
