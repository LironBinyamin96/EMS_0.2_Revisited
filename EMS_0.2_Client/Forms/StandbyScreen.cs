using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS_Client.Forms
{
    public partial class StandbyScreen : Form
    {
        Action action;

        /// <summary>
        /// Preforms an action while dispalying standby screen 
        /// </summary>
        /// <param name="act"></param>
        public StandbyScreen(Action act)
        {
            InitializeComponent();
            action = act;
            EMS_ClientMainScreen.PrimaryForms.Push(this);
            System.Drawing.Drawing2D.GraphicsPath shape = new System.Drawing.Drawing2D.GraphicsPath();
            shape.AddEllipse(5, 5, this.Width-15, this.Height-15);
            this.Region = new Region(shape);
        }

        private void StandbyScreen_Load(object sender, EventArgs e)
        {
            Task.Run(action);
        }

        #region Drag Window
        /// <summary>
        /// Controlls form movement during drag.
        /// </summary>
        void Drag(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void picStandbySphere_MouseDown(object sender, MouseEventArgs e) => Drag(e);
        private void lblStandby_MouseDown(object sender, MouseEventArgs e) => Drag(e);
        #endregion
    }
}
