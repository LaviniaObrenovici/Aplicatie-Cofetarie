using Cofetarie.Controller;
using System.Windows.Forms;

namespace Cofetarie
{
    class ProgramPrincipal
    {
            static void Main()
            { 
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                CAutentificare ca = new CAutentificare();
                Application.Run(ca.GetVAutentificare()); 
        }
        
    }
}
