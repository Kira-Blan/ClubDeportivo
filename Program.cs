using System;
using System.Linq;
using System.Windows.Forms;

namespace clubDeportivo
{
    internal static class Program
    {
       
        private static System.Windows.Forms.Timer appTimer;
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            
            appTimer = new System.Windows.Forms.Timer();
            appTimer.Interval = 500; //500ms, 0,5s
            appTimer.Tick += MirarForms;
            appTimer.Start();

            Application.Run(new FormLogin());
        }


        private static void MirarForms(object sender, EventArgs e)
        {
            //Esto es para que se cierre el programa si no hay ningún form visible,
            //hay otras formas de hacerlo pero esta era la más fácil jaja.
            bool visible = Application.OpenForms.Cast<Form>().Any(f => f.Visible);
            if (!visible)
            {
                Application.Exit();
            }
        }
    }
}