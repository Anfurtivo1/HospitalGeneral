using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalGeneral
{
    public partial class FormularioPaciente : Form
    {
        public FormularioPaciente()
        {
            InitializeComponent();
        }

        private void pacientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pacientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalDataSet);

        }

        private void FormularioPaciente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hospitalDataSet.pacientes' Puede moverla o quitarla según sea necesario.
            //this.pacientesTableAdapter.Fill(this.hospitalDataSet.pacientes);

        }
    }
}
