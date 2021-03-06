﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalGeneral
{
    public partial class FormularioPrincipal : Form
    {
        ArrayList idMedicos = new ArrayList();
        ArrayList idPacientes = new ArrayList();
        private object db;

        public FormularioPrincipal()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        //TODO: esta línea de código carga datos en la tabla 'hospitalDataSet.medicos' Puede moverla o quitarla según sea necesario.
            this.medicosTableAdapter.Fill(this.hospitalDataSet.medicos);
            // TODO: esta línea de código carga datos en la tabla 'hospitalDataSet.medicos' Puede moverla o quitarla según sea necesario.
            this.medicosTableAdapter.Fill(this.hospitalDataSet.medicos);

            cargarComboEspecialidad();
            timer1.Start();


        }

        private void cbMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarComboPacientes();
            cargarPanelMedicos();
            cbPaciente.Enabled = true;
        }

        private void cbPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarPanelPacientes();
        }

        private void cargarComboMedicos()
        {
            hospitalDataSet db = new hospitalDataSet();
            idMedicos.Clear();
            cbMedico.Items.Clear();
            hospitalDataSetTableAdapters.medicosTableAdapter medicosTableAdapter = new hospitalDataSetTableAdapters.medicosTableAdapter();
            medicosTableAdapter.FillByNombre(db.medicos, cbEspecialidad.Text.ToString());

            for (int i = 0; i < db.medicos.Count; i++)
            {
                cbMedico.Items.Add(db.medicos[i].nombre);
                idMedicos.Add(db.medicos[i].idmedico);

            }
        }
        private void cargarComboEspecialidad()
        {
            hospitalDataSet db = new hospitalDataSet();
            hospitalDataSetTableAdapters.especialidadesTableAdapter medicosTableAdapter = new hospitalDataSetTableAdapters.especialidadesTableAdapter();
            medicosTableAdapter.FillByEspecialidad(db.especialidades);

            for (int i = 0; i < db.especialidades.Count; i++)
            {
                cbEspecialidad.Items.Add(db.especialidades[i].especialidad);

            }
        }

        private void cbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMedico.Enabled = true;
            cargarComboMedicos();
        }
        private void cargarComboPacientes()
        {
            hospitalDataSet db = new hospitalDataSet();
            hospitalDataSetTableAdapters.pacientesTableAdapter PacientesTableAdapter = new hospitalDataSetTableAdapters.pacientesTableAdapter();
            PacientesTableAdapter.FillByNombreApellidos(db.pacientes);

            for (int i = 0; i < db.pacientes.Count; i++)
            {
                cbPaciente.Items.Add(db.pacientes[i].nombre + " " + db.pacientes[i].apellidos);
                idPacientes.Add(db.pacientes[i].idpaciente);

            }
        }

        private void cargarComboDiagnostico()
        {


        }

        private void cargarPanelMedicos()
        {
            int pos = cbMedico.SelectedIndex;
            int id = (int)idMedicos[pos];

            hospitalDataSet db = new hospitalDataSet();

            idmedicoLabel1.Text = db.medicos[0].idmedico.ToString();
            nombreTextBox.Text = db.medicos[0].nombre;
            apellidosTextBox.Text = db.medicos[0].apellidos;
            movilTextBox.Text = db.medicos[0].movil;
            especialidadTextBox.Text = db.medicos[0].especialidad;

            //Una vez ejecutada la consulta sobre la tabla médicos, y cargado el DataSet correspondiente
            //1º Se comprueba si en esa tabla devuelta con la consulta sobre los médicos hay algún registro
            if (db.medicos.Rows.Count > 0)
            {
                //Inicializamos una fila de datos en la cual se almacenaran todos los datos de la fila seleccionada
                //En este ejemplo nos quedamos con la primera
                DataRow myRow = db.medicos.Rows[0];

                //Se almacena el campo foto de la tabla en el array de bytes
                byte[] MyData = (byte[])myRow["foto"];
                //Se inicializa un flujo en memoria del array de bytes
                MemoryStream stream = new MemoryStream(MyData);
                //En el picture box se muestra la imagen que esta almacenada en el flujo en memoria 
                //el cual contiene el array de bytes
                pictureBox3.Image = Image.FromStream(stream);
            }

        }

        private void cargarPanelPacientes()
        {
            int pos = cbPaciente.SelectedIndex;
            int id = (int)idPacientes[pos];

            hospitalDataSet db = new hospitalDataSet();
            hospitalDataSetTableAdapters.pacientesTableAdapter pacientesTableAdapter = new hospitalDataSetTableAdapters.pacientesTableAdapter();
            pacientesTableAdapter.FillById(db.pacientes, id);

            idpacienteTextBox.Text = db.pacientes[0].idpaciente.ToString();
            nombreTextBox1.Text = db.pacientes[0].nombre.ToString();
            apellidosTextBox1.Text = db.pacientes[0].apellidos.ToString();
            localidadTextBox.Text = db.pacientes[0].localidad.ToString();
            alergiasTextBox.Text = db.pacientes[0].alergias.ToString();
            adestacarTextBox.Text = db.pacientes[0].adestacar.ToString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToLongDateString();
        }

        private void btnGestionMedicos_Click(object sender, EventArgs e)
        {
            FormularioMedicos fr = new FormularioMedicos();
            fr.ShowDialog();
        }

        private void btnGestionPacientes_Click(object sender, EventArgs e)
        {
            FormularioPaciente fr = new FormularioPaciente();
            fr.ShowDialog();
        }

        private void medicosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.medicosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalDataSet);

        }

        private void medicosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.medicosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalDataSet);

        }
    }
}
