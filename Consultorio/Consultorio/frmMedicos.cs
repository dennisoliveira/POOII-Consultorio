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
    public partial class frmMedicos : Form
    {
        public frmMedicos()
        {
            InitializeComponent();
        }

        private void medicosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            // Faz a validação dos dados
            this.Validate();

            // Finaliza a Edição
            this.medicosBindingSource.EndEdit();

            // Faz a atualização dos dados
            this.tableAdapterManager.UpdateAll(this.consultorioDataSet);

        }

        private void frmMedicos_Load(object sender, EventArgs e)
        {
            // Por meio do método Fill do TableAdapter, é preenchido o dataset
            this.medicosTableAdapter.Fill(this.consultorioDataSet.Medicos);

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMedicos_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
