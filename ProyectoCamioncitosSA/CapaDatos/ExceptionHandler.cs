using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaControlador
{
    public static class ExceptionHandler
      //Muestra un nensaje al cliente de acuerdo a la excepcion detectada 
    {
        public static void HandleException(Exception ex, string errorMessage)
        {
            MessageBox.Show(errorMessage + ": " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
