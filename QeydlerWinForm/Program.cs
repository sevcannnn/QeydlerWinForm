using QeydlerWinForms;
using System;
using System.Windows.Forms;

namespace QeydlerWinForm
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}