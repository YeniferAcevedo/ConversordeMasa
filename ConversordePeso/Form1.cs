using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversordePeso
{
    public partial class Form1 : Form
    {
        Miligramos miligramos = new Miligramos();
        Gramos gramos = new Gramos();
        Decagramos decagramos = new Decagramos();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (!rdbMiligramos.Checked && !rdbGramos.Checked && !rdbDecagramos.Checked)
            {
                MessageBox.Show("Debes seleccionar una Unidad de Masa");
            }
            else
            {
                miligramos.setValorIngresado(double.Parse(txtPesoKg.Text));
                gramos.setValorIngresado(double.Parse(txtPesoKg.Text));
                decagramos.setValorIngresado(double.Parse(txtPesoKg.Text));

                if (rdbMiligramos.Checked == true)
                {
                    lblResultado.Text = Convert.ToString(string.Format("{0:n0}", miligramos.convertirAMiligramos()) + " mg");
                }
                                
                else if (rdbGramos.Checked == true)
                {
                    lblResultado.Text = Convert.ToString(string.Format("{0:n0}", gramos.convertirAGramos()) + " g");
                }

                else if (rdbDecagramos.Checked == true)
                {
                    lblResultado.Text = Convert.ToString(string.Format("{0:n0}", decagramos.convertirADecagramos()) + " dg");
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtPesoKg.Text = string.Empty;
            lblResultado.Text = "0";
            rdbMiligramos.Checked = false;
            rdbGramos.Checked = false;
            rdbDecagramos.Checked = false;
            txtPesoKg.Focus();
        }
    }
}
