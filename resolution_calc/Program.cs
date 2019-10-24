// alpha version
// author: Samuele Albani
// email: kronikle@disroot.org


using System;
using Gtk;

namespace resolution_calc
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Application.Init();
            MainWindow win = new MainWindow();
            win.Show();
            Application.Run();
        }
    }
}
