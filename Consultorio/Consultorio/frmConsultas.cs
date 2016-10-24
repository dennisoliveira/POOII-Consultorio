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
            this.Validate();
            this.consultasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.consultorioDataSet);

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
    }
}
