using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicnaKartaWindowsForms
{
    class MyListBox : ListBox
    {
        int WM_KILLFOCUS = 0x8;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg != WM_KILLFOCUS)
            {
                base.WndProc(ref m);
            }
        }
    }
}
