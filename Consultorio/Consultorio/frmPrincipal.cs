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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        // Criado fora do método para que o mesmo possa estar ativo na memória enquanto o form principal estiver aberto
        frmMedicos objMedicos = new frmMedicos();

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            // Verificar se o objeto não está criado, se não estiver faço a criação
            if (objMedicos.IsDisposed)
            {
                objMedicos = new frmMedicos();

            }

            // Informo que este form, o principal é o formulário pai do formulário médico
            objMedicos.MdiParent = this;

            // Verifico se o formulário já está aberto, se não estiver abro senão envio uma mensagem de alerta
            if (objMedicos.Visible == false)
            {
                objMedicos.Show();
            }
            else
            {
                MessageBox.Show("O formulário médico já está aberto!",
                    "Consultório Médico 1.0", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        frmPacientes objPacientes = new frmPacientes();

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            if(objPacientes.IsDisposed)
            {
                objPacientes = new frmPacientes();
            }

            objPacientes.MdiParent = this;

            if(objPacientes.Visible == false)
            {
                objPacientes.Show();
            }
            else
            {
                MessageBox.Show("O formulário Paciente já está aberto",
                    "Consultório Médico 1.0", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        frmConsultas objConsultas = new frmConsultas();

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            if(objConsultas.IsDisposed)
            {
                objConsultas = new frmConsultas();
            }

            objConsultas.MdiParent = this;

            if(objConsultas.Visible == false)
            {
                objConsultas.Show();
            }
            else
            {
                MessageBox.Show("O Formulário Consultas já está aberto!",
                    "Consultório Médico 1.0", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
