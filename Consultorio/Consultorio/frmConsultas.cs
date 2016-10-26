using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultorio
{
    public partial class frmConsultas : Form
    {
        public frmConsultas()
        {
            InitializeComponent();
        }

        private void consultasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            // Variável do tipo boleano inicia com false
            bool valida = false;

            // Se o valor de cboMedico for fazio então mostre a mensagem Campo Obrigatório
            // e torna o valor da variável true. Senão não mostre a mensagem
            if(cboMedico.Text == "")
            {
                epErro.SetError(cboMedico, "Campo obrigatório");
                valida = true;
            }
            else
            {
                epErro.SetError(cboMedico, null);
            }

            // Se o valor de cboPaciente for vazio então mostre a mensagem Campo Obrigatório
            // e torna o valor da variável true. Senão não mostre a mensagem

            if(cboPaciente.Text == "")
            {
                epErro.SetError(cboPaciente, "Campo obrigatório");
                valida = true;
            }
            else
            {
                epErro.SetError(cboPaciente, null);
            }

            if(valida != true)
            {
                this.Validate();
                this.consultasBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.consultorioDataSet);
            }

        }

        private void frmConsultas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'consultorioDataSet.Pacientes' table. You can move, or remove it, as needed.
            this.pacientesTableAdapter.Fill(this.consultorioDataSet.Pacientes);
            // TODO: This line of code loads data into the 'consultorioDataSet.Medicos' table. You can move, or remove it, as needed.
            this.medicosTableAdapter.Fill(this.consultorioDataSet.Medicos);
            // TODO: This line of code loads data into the 'consultorioDataSet.Consultas' table. You can move, or remove it, as needed.
            this.consultasTableAdapter.Fill(this.consultorioDataSet.Consultas);

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultas_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
