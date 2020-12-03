using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;


namespace ExamenTopicosU3
{
    public partial class FrmInicio : MetroForm
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
           
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            if (cmbCorredores.Text == "" || cmbVueltas.Text == "")
            {
                MessageBox.Show("Asegúrese de ingresar todo los datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                String NumCorre = cmbCorredores.Text;
                String NumVueltas = cmbVueltas.Text;
                FrmCarrera Ingresar = new FrmCarrera(NumCorre, NumVueltas);
                Ingresar.Show();
                this.Hide();
            }
        }
    }
}
