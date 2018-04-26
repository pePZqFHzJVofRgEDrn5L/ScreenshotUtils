using System;
using System.Text;
using System.Windows.Forms;
using System.Security.Permissions;
using ScreenshotUtils.Utils;

namespace lxzh {
    public partial class TextInput : TextBox {

        protected override CreateParams CreateParams
        {
            get
            {
                //new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Demand();
                //CreateParams cp = base.CreateParams;
                //cp.ExStyle |= 0x20;
                //return cp;
                CreateParams prams = base.CreateParams;
                if (Win32.LoadLibrary("msftedit.dll") != IntPtr.Zero) {
                    prams.ExStyle |= 0x020; // transparent 
                    //prams.ClassName = "RICHEDIT50W";
                }
                return prams;
            }
        }

        public TextInput() {
            InitializeComponent();
        }
    }
}
