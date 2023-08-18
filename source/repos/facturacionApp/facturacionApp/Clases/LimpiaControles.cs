using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace facturacionApp.Clases
{
    internal class LimpiaControles
    {
        public static void LimpiaControl(Control control)
        {
            foreach (Control childControl in control.Controls)
            {
                if (childControl is TextBox)
                {
                    ((TextBox)childControl).Clear();
                }
                else if (childControl is ComboBox)
                {
                    ((ComboBox)childControl).SelectedIndex = -1;
                }
                else if (childControl is CheckBox)
                {
                    ((CheckBox)childControl).Checked = false;
                }
                else if (childControl is RadioButton)
                {
                    ((RadioButton)childControl).Checked = false;
                }
                // Agrega más tipos de controles si los necesitas

                // Llama recursivamente a la función para limpiar los controles secundarios
                LimpiaControl(childControl);
            }
        }

    }
}
