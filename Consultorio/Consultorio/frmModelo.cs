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
    public partial class frmModelo : Form
    {
        public enum Status
        {
            scInserindo,
            scNavegando,
            scEditando
        }

        private Status sStatus;

        public frmModelo()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmModelo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void LimpaControles()
        {
            foreach (Control ctr in this.Controls)
            {
                if (ctr is TextBox)
                    (ctr as TextBox).Text = "";

                if (ctr is ComboBox)
                    (ctr as ComboBox).SelectedIndex = -1;

                if (ctr is ListBox)
                    (ctr as ListBox).SelectedIndex = -1;

                if (ctr is RadioButton)
                    (ctr as RadioButton).Checked = false;

                if (ctr is CheckBox)
                    (ctr as CheckBox).Checked = false;

                if (ctr is CheckedListBox)
                {
                    foreach (ListControl item in (ctr as CheckedListBox).Items)
                        item.SelectedIndex = -1;
                }
            }
        }

        public virtual bool Salvar()
        {
            return false;
        }

        public virtual bool Excluir()
        {
            return false;
        }

        public virtual bool Localizar()
        {
            return false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Salvar())
            {
                sStatus = Status.scNavegando;
                LimpaControles();
                MessageBox.Show("Registro salvo com sucesso.", "Consultório Médico 1.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("O Registro não foi salvo, por favor verifique os erros!", "Consultório Médico 1.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Excluir())
            {
                sStatus = Status.scNavegando;
                HabilitaDesabilita(false);
                LimpaControles();
                MessageBox.Show("Registro excluído com sucesso.", "Consultório Médico 1.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("O Registro não foi excluído, por favor verifique os erros!", "Consultório Médico 1.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            sStatus = Status.scInserindo;
            HabilitaDesabilita(true);
            LimpaControles();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            if (Localizar())
            {
                sStatus = Status.scEditando;
                HabilitaDesabilita(true);
            }
        }

        private void HabilitaDesabilita(bool Valor)
        {
            // percorre os controles da tela e os habilta ou desabilita
            // conforme o valor passado por parâmetro (Valor)
            foreach (Control ctr in this.Controls)
            {
                // Verifica se o controle é um toolstrip. Se for ele continua, ou seja,
                // ele vai para o próximo controle. (Neste caso ele habilita e nem desabilita)
                if (ctr is ToolStrip)
                    continue;

                ctr.Enabled = Valor;

                // Será habilitado somente quando for navegação
                btnAdicionar.Enabled = (sStatus == Status.scNavegando);

                btnSalvar.Enabled = (sStatus == Status.scNavegando || sStatus == Status.scInserindo);
                btnExcluir.Enabled = (sStatus == Status.scEditando);
                btnLocalizar.Enabled = (sStatus == Status.scNavegando);
                btnFechar.Enabled = true;
            }
        }

        private void frmModelo_Load(object sender, EventArgs e)
        {
            sStatus = Status.scNavegando;
            HabilitaDesabilita(false);
            LimpaControles();
        }
    }
}
