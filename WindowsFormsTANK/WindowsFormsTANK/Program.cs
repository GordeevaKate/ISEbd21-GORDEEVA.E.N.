using System;
using System.Windows.Forms;

namespace WindowsFormsTANK
{
    public delegate void TankDelegate(ITransport tank);
    static class Program
    {
       
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new  FormBase());
        }
    }
}
