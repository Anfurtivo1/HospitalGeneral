
namespace HospitalGeneral
{
    partial class FormularioPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idatencLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label medicoLabel;
            System.Windows.Forms.Label pacienteLabel;
            System.Windows.Forms.Label diagnosticoLabel;
            System.Windows.Forms.Label idmedicoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidosLabel;
            System.Windows.Forms.Label movilLabel;
            System.Windows.Forms.Label especialidadLabel;
            System.Windows.Forms.Label idpacienteLabel;
            System.Windows.Forms.Label nombreLabel1;
            System.Windows.Forms.Label apellidosLabel1;
            System.Windows.Forms.Label localidadLabel;
            System.Windows.Forms.Label alergiasLabel;
            System.Windows.Forms.Label adestacarLabel;
            System.Windows.Forms.Label idmedicoLabel2;
            System.Windows.Forms.Label especialidadLabel1;
            System.Windows.Forms.Label nombreLabel2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPrincipal));
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbEspecialidad = new System.Windows.Forms.ComboBox();
            this.cbPaciente = new System.Windows.Forms.ComboBox();
            this.cbMedico = new System.Windows.Forms.ComboBox();
            this.btnAnadirCita = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.idatencLabel1 = new System.Windows.Forms.Label();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGestionMedicos = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.idmedicoLabel1 = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.movilTextBox = new System.Windows.Forms.TextBox();
            this.especialidadTextBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGestionPacientes = new System.Windows.Forms.Button();
            this.idpacienteTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox1 = new System.Windows.Forms.TextBox();
            this.apellidosTextBox1 = new System.Windows.Forms.TextBox();
            this.localidadTextBox = new System.Windows.Forms.TextBox();
            this.alergiasTextBox = new System.Windows.Forms.TextBox();
            this.adestacarTextBox = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.nombreComboBox = new System.Windows.Forms.ComboBox();
            this.btnActualizarDiagnostico = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHistorialClinico = new System.Windows.Forms.Button();
            this.btnPacientesMedicoDia = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.medicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new HospitalGeneral.hospitalDataSetTableAdapters.TableAdapterManager();
            this.medicosTableAdapter = new HospitalGeneral.hospitalDataSetTableAdapters.medicosTableAdapter();
            idatencLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            medicoLabel = new System.Windows.Forms.Label();
            pacienteLabel = new System.Windows.Forms.Label();
            diagnosticoLabel = new System.Windows.Forms.Label();
            idmedicoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidosLabel = new System.Windows.Forms.Label();
            movilLabel = new System.Windows.Forms.Label();
            especialidadLabel = new System.Windows.Forms.Label();
            idpacienteLabel = new System.Windows.Forms.Label();
            nombreLabel1 = new System.Windows.Forms.Label();
            apellidosLabel1 = new System.Windows.Forms.Label();
            localidadLabel = new System.Windows.Forms.Label();
            alergiasLabel = new System.Windows.Forms.Label();
            adestacarLabel = new System.Windows.Forms.Label();
            idmedicoLabel2 = new System.Windows.Forms.Label();
            especialidadLabel1 = new System.Windows.Forms.Label();
            nombreLabel2 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idatencLabel
            // 
            idatencLabel.AutoSize = true;
            idatencLabel.Location = new System.Drawing.Point(224, 42);
            idatencLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idatencLabel.Name = "idatencLabel";
            idatencLabel.Size = new System.Drawing.Size(58, 17);
            idatencLabel.TabIndex = 0;
            idatencLabel.Text = "idatenc:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(224, 79);
            fechaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(47, 17);
            fechaLabel.TabIndex = 2;
            fechaLabel.Text = "fecha:";
            // 
            // medicoLabel
            // 
            medicoLabel.AutoSize = true;
            medicoLabel.Location = new System.Drawing.Point(224, 136);
            medicoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            medicoLabel.Name = "medicoLabel";
            medicoLabel.Size = new System.Drawing.Size(57, 17);
            medicoLabel.TabIndex = 4;
            medicoLabel.Text = "medico:";
            // 
            // pacienteLabel
            // 
            pacienteLabel.AutoSize = true;
            pacienteLabel.Location = new System.Drawing.Point(225, 168);
            pacienteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pacienteLabel.Name = "pacienteLabel";
            pacienteLabel.Size = new System.Drawing.Size(66, 17);
            pacienteLabel.TabIndex = 6;
            pacienteLabel.Text = "paciente:";
            // 
            // diagnosticoLabel
            // 
            diagnosticoLabel.AutoSize = true;
            diagnosticoLabel.Location = new System.Drawing.Point(223, 106);
            diagnosticoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            diagnosticoLabel.Name = "diagnosticoLabel";
            diagnosticoLabel.Size = new System.Drawing.Size(92, 17);
            diagnosticoLabel.TabIndex = 8;
            diagnosticoLabel.Text = "Especialidad:";
            // 
            // idmedicoLabel
            // 
            idmedicoLabel.AutoSize = true;
            idmedicoLabel.Location = new System.Drawing.Point(175, 23);
            idmedicoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idmedicoLabel.Name = "idmedicoLabel";
            idmedicoLabel.Size = new System.Drawing.Size(68, 17);
            idmedicoLabel.TabIndex = 9;
            idmedicoLabel.Text = "idmedico:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(175, 55);
            nombreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(60, 17);
            nombreLabel.TabIndex = 2;
            nombreLabel.Text = "nombre:";
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.Location = new System.Drawing.Point(175, 87);
            apellidosLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(68, 17);
            apellidosLabel.TabIndex = 4;
            apellidosLabel.Text = "apellidos:";
            // 
            // movilLabel
            // 
            movilLabel.AutoSize = true;
            movilLabel.Location = new System.Drawing.Point(175, 119);
            movilLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            movilLabel.Name = "movilLabel";
            movilLabel.Size = new System.Drawing.Size(44, 17);
            movilLabel.TabIndex = 6;
            movilLabel.Text = "movil:";
            // 
            // especialidadLabel
            // 
            especialidadLabel.AutoSize = true;
            especialidadLabel.Location = new System.Drawing.Point(175, 151);
            especialidadLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            especialidadLabel.Name = "especialidadLabel";
            especialidadLabel.Size = new System.Drawing.Size(91, 17);
            especialidadLabel.TabIndex = 8;
            especialidadLabel.Text = "especialidad:";
            // 
            // idpacienteLabel
            // 
            idpacienteLabel.AutoSize = true;
            idpacienteLabel.Location = new System.Drawing.Point(105, 16);
            idpacienteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idpacienteLabel.Name = "idpacienteLabel";
            idpacienteLabel.Size = new System.Drawing.Size(77, 17);
            idpacienteLabel.TabIndex = 0;
            idpacienteLabel.Text = "idpaciente:";
            // 
            // nombreLabel1
            // 
            nombreLabel1.AutoSize = true;
            nombreLabel1.Location = new System.Drawing.Point(105, 48);
            nombreLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nombreLabel1.Name = "nombreLabel1";
            nombreLabel1.Size = new System.Drawing.Size(60, 17);
            nombreLabel1.TabIndex = 2;
            nombreLabel1.Text = "nombre:";
            // 
            // apellidosLabel1
            // 
            apellidosLabel1.AutoSize = true;
            apellidosLabel1.Location = new System.Drawing.Point(105, 80);
            apellidosLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            apellidosLabel1.Name = "apellidosLabel1";
            apellidosLabel1.Size = new System.Drawing.Size(68, 17);
            apellidosLabel1.TabIndex = 4;
            apellidosLabel1.Text = "apellidos:";
            // 
            // localidadLabel
            // 
            localidadLabel.AutoSize = true;
            localidadLabel.Location = new System.Drawing.Point(105, 112);
            localidadLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            localidadLabel.Name = "localidadLabel";
            localidadLabel.Size = new System.Drawing.Size(68, 17);
            localidadLabel.TabIndex = 6;
            localidadLabel.Text = "localidad:";
            // 
            // alergiasLabel
            // 
            alergiasLabel.AutoSize = true;
            alergiasLabel.Location = new System.Drawing.Point(105, 144);
            alergiasLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            alergiasLabel.Name = "alergiasLabel";
            alergiasLabel.Size = new System.Drawing.Size(62, 17);
            alergiasLabel.TabIndex = 8;
            alergiasLabel.Text = "alergias:";
            // 
            // adestacarLabel
            // 
            adestacarLabel.AutoSize = true;
            adestacarLabel.Location = new System.Drawing.Point(105, 204);
            adestacarLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            adestacarLabel.Name = "adestacarLabel";
            adestacarLabel.Size = new System.Drawing.Size(75, 17);
            adestacarLabel.TabIndex = 10;
            adestacarLabel.Text = "adestacar:";
            // 
            // idmedicoLabel2
            // 
            idmedicoLabel2.AutoSize = true;
            idmedicoLabel2.Location = new System.Drawing.Point(257, 119);
            idmedicoLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idmedicoLabel2.Name = "idmedicoLabel2";
            idmedicoLabel2.Size = new System.Drawing.Size(68, 17);
            idmedicoLabel2.TabIndex = 24;
            idmedicoLabel2.Text = "idmedico:";
            // 
            // especialidadLabel1
            // 
            especialidadLabel1.AutoSize = true;
            especialidadLabel1.Location = new System.Drawing.Point(257, 87);
            especialidadLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            especialidadLabel1.Name = "especialidadLabel1";
            especialidadLabel1.Size = new System.Drawing.Size(91, 17);
            especialidadLabel1.TabIndex = 23;
            especialidadLabel1.Text = "especialidad:";
            // 
            // nombreLabel2
            // 
            nombreLabel2.AutoSize = true;
            nombreLabel2.Location = new System.Drawing.Point(257, 54);
            nombreLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nombreLabel2.Name = "nombreLabel2";
            nombreLabel2.Size = new System.Drawing.Size(57, 17);
            nombreLabel2.TabIndex = 22;
            nombreLabel2.Text = "medico:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.cbEspecialidad);
            this.panel3.Controls.Add(this.cbPaciente);
            this.panel3.Controls.Add(this.cbMedico);
            this.panel3.Controls.Add(this.btnAnadirCita);
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Controls.Add(idatencLabel);
            this.panel3.Controls.Add(this.idatencLabel1);
            this.panel3.Controls.Add(fechaLabel);
            this.panel3.Controls.Add(this.fechaDateTimePicker);
            this.panel3.Controls.Add(medicoLabel);
            this.panel3.Controls.Add(pacienteLabel);
            this.panel3.Controls.Add(diagnosticoLabel);
            this.panel3.Location = new System.Drawing.Point(602, 35);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 273);
            this.panel3.TabIndex = 2;
            // 
            // cbEspecialidad
            // 
            this.cbEspecialidad.FormattingEnabled = true;
            this.cbEspecialidad.Location = new System.Drawing.Point(315, 103);
            this.cbEspecialidad.Name = "cbEspecialidad";
            this.cbEspecialidad.Size = new System.Drawing.Size(265, 24);
            this.cbEspecialidad.TabIndex = 16;
            this.cbEspecialidad.SelectedIndexChanged += new System.EventHandler(this.cbEspecialidad_SelectedIndexChanged);
            // 
            // cbPaciente
            // 
            this.cbPaciente.Enabled = false;
            this.cbPaciente.FormattingEnabled = true;
            this.cbPaciente.Location = new System.Drawing.Point(315, 168);
            this.cbPaciente.Name = "cbPaciente";
            this.cbPaciente.Size = new System.Drawing.Size(269, 24);
            this.cbPaciente.TabIndex = 15;
            this.cbPaciente.SelectedIndexChanged += new System.EventHandler(this.cbPaciente_SelectedIndexChanged);
            // 
            // cbMedico
            // 
            this.cbMedico.Enabled = false;
            this.cbMedico.FormattingEnabled = true;
            this.cbMedico.Location = new System.Drawing.Point(317, 136);
            this.cbMedico.Name = "cbMedico";
            this.cbMedico.Size = new System.Drawing.Size(265, 24);
            this.cbMedico.TabIndex = 14;
            this.cbMedico.SelectedIndexChanged += new System.EventHandler(this.cbMedico_SelectedIndexChanged);
            // 
            // btnAnadirCita
            // 
            this.btnAnadirCita.Location = new System.Drawing.Point(71, 226);
            this.btnAnadirCita.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnadirCita.Name = "btnAnadirCita";
            this.btnAnadirCita.Size = new System.Drawing.Size(280, 28);
            this.btnAnadirCita.TabIndex = 13;
            this.btnAnadirCita.Text = "Añadir cita";
            this.btnAnadirCita.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(21, 26);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(195, 193);
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // idatencLabel1
            // 
            this.idatencLabel1.Location = new System.Drawing.Point(317, 42);
            this.idatencLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idatencLabel1.Name = "idatencLabel1";
            this.idatencLabel1.Size = new System.Drawing.Size(267, 28);
            this.idatencLabel1.TabIndex = 1;
            this.idatencLabel1.Text = "label9";
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.Location = new System.Drawing.Point(317, 74);
            this.fechaDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.fechaDateTimePicker.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(27, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 201);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "CIF - A13121212Q";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tlfno. 926 20 00 00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 81);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "C/ La Salud nº7 - 13005 - C.R";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(183, 43);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "HOSPITAL GENERAL";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(9, 43);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(153, 132);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 23);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Datos del hospital";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.btnGestionMedicos);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(idmedicoLabel);
            this.panel2.Controls.Add(this.idmedicoLabel1);
            this.panel2.Controls.Add(nombreLabel);
            this.panel2.Controls.Add(this.nombreTextBox);
            this.panel2.Controls.Add(apellidosLabel);
            this.panel2.Controls.Add(this.apellidosTextBox);
            this.panel2.Controls.Add(movilLabel);
            this.panel2.Controls.Add(this.movilTextBox);
            this.panel2.Controls.Add(especialidadLabel);
            this.panel2.Controls.Add(this.especialidadTextBox);
            this.panel2.Location = new System.Drawing.Point(13, 268);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(437, 215);
            this.panel2.TabIndex = 4;
            // 
            // btnGestionMedicos
            // 
            this.btnGestionMedicos.Location = new System.Drawing.Point(109, 175);
            this.btnGestionMedicos.Margin = new System.Windows.Forms.Padding(4);
            this.btnGestionMedicos.Name = "btnGestionMedicos";
            this.btnGestionMedicos.Size = new System.Drawing.Size(187, 28);
            this.btnGestionMedicos.TabIndex = 13;
            this.btnGestionMedicos.Text = "Gestión de medicos";
            this.btnGestionMedicos.UseVisualStyleBackColor = true;
            this.btnGestionMedicos.Click += new System.EventHandler(this.btnGestionMedicos_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(24, 31);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(140, 137);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Medico";
            // 
            // idmedicoLabel1
            // 
            this.idmedicoLabel1.Location = new System.Drawing.Point(252, 23);
            this.idmedicoLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idmedicoLabel1.Name = "idmedicoLabel1";
            this.idmedicoLabel1.Size = new System.Drawing.Size(165, 28);
            this.idmedicoLabel1.TabIndex = 10;
            this.idmedicoLabel1.Text = "label2";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(275, 52);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.ReadOnly = true;
            this.nombreTextBox.Size = new System.Drawing.Size(132, 22);
            this.nombreTextBox.TabIndex = 3;
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.Location = new System.Drawing.Point(275, 84);
            this.apellidosTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.ReadOnly = true;
            this.apellidosTextBox.Size = new System.Drawing.Size(132, 22);
            this.apellidosTextBox.TabIndex = 5;
            // 
            // movilTextBox
            // 
            this.movilTextBox.Location = new System.Drawing.Point(275, 116);
            this.movilTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.movilTextBox.Name = "movilTextBox";
            this.movilTextBox.ReadOnly = true;
            this.movilTextBox.Size = new System.Drawing.Size(132, 22);
            this.movilTextBox.TabIndex = 7;
            // 
            // especialidadTextBox
            // 
            this.especialidadTextBox.Location = new System.Drawing.Point(275, 148);
            this.especialidadTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.especialidadTextBox.Name = "especialidadTextBox";
            this.especialidadTextBox.ReadOnly = true;
            this.especialidadTextBox.Size = new System.Drawing.Size(132, 22);
            this.especialidadTextBox.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.btnGestionPacientes);
            this.panel4.Controls.Add(idpacienteLabel);
            this.panel4.Controls.Add(this.idpacienteTextBox);
            this.panel4.Controls.Add(nombreLabel1);
            this.panel4.Controls.Add(this.nombreTextBox1);
            this.panel4.Controls.Add(apellidosLabel1);
            this.panel4.Controls.Add(this.apellidosTextBox1);
            this.panel4.Controls.Add(localidadLabel);
            this.panel4.Controls.Add(this.localidadTextBox);
            this.panel4.Controls.Add(alergiasLabel);
            this.panel4.Controls.Add(this.alergiasTextBox);
            this.panel4.Controls.Add(adestacarLabel);
            this.panel4.Controls.Add(this.adestacarTextBox);
            this.panel4.Location = new System.Drawing.Point(51, 508);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(369, 304);
            this.panel4.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(5, 36);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(92, 165);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Paciente";
            // 
            // btnGestionPacientes
            // 
            this.btnGestionPacientes.Location = new System.Drawing.Point(4, 224);
            this.btnGestionPacientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnGestionPacientes.Name = "btnGestionPacientes";
            this.btnGestionPacientes.Size = new System.Drawing.Size(111, 69);
            this.btnGestionPacientes.TabIndex = 22;
            this.btnGestionPacientes.Text = "Gestion de pacientes";
            this.btnGestionPacientes.UseVisualStyleBackColor = true;
            this.btnGestionPacientes.Click += new System.EventHandler(this.btnGestionPacientes_Click);
            // 
            // idpacienteTextBox
            // 
            this.idpacienteTextBox.Location = new System.Drawing.Point(192, 12);
            this.idpacienteTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.idpacienteTextBox.Name = "idpacienteTextBox";
            this.idpacienteTextBox.ReadOnly = true;
            this.idpacienteTextBox.Size = new System.Drawing.Size(132, 22);
            this.idpacienteTextBox.TabIndex = 1;
            // 
            // nombreTextBox1
            // 
            this.nombreTextBox1.Location = new System.Drawing.Point(192, 44);
            this.nombreTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.nombreTextBox1.Name = "nombreTextBox1";
            this.nombreTextBox1.ReadOnly = true;
            this.nombreTextBox1.Size = new System.Drawing.Size(132, 22);
            this.nombreTextBox1.TabIndex = 3;
            // 
            // apellidosTextBox1
            // 
            this.apellidosTextBox1.Location = new System.Drawing.Point(192, 76);
            this.apellidosTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.apellidosTextBox1.Name = "apellidosTextBox1";
            this.apellidosTextBox1.ReadOnly = true;
            this.apellidosTextBox1.Size = new System.Drawing.Size(132, 22);
            this.apellidosTextBox1.TabIndex = 5;
            // 
            // localidadTextBox
            // 
            this.localidadTextBox.Location = new System.Drawing.Point(192, 108);
            this.localidadTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.localidadTextBox.Name = "localidadTextBox";
            this.localidadTextBox.ReadOnly = true;
            this.localidadTextBox.Size = new System.Drawing.Size(132, 22);
            this.localidadTextBox.TabIndex = 7;
            // 
            // alergiasTextBox
            // 
            this.alergiasTextBox.Location = new System.Drawing.Point(192, 140);
            this.alergiasTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.alergiasTextBox.Multiline = true;
            this.alergiasTextBox.Name = "alergiasTextBox";
            this.alergiasTextBox.ReadOnly = true;
            this.alergiasTextBox.Size = new System.Drawing.Size(132, 52);
            this.alergiasTextBox.TabIndex = 9;
            // 
            // adestacarTextBox
            // 
            this.adestacarTextBox.Location = new System.Drawing.Point(192, 201);
            this.adestacarTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.adestacarTextBox.Multiline = true;
            this.adestacarTextBox.Name = "adestacarTextBox";
            this.adestacarTextBox.ReadOnly = true;
            this.adestacarTextBox.Size = new System.Drawing.Size(132, 82);
            this.adestacarTextBox.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel5.Controls.Add(this.nombreComboBox);
            this.panel5.Controls.Add(idmedicoLabel2);
            this.panel5.Controls.Add(especialidadLabel1);
            this.panel5.Controls.Add(nombreLabel2);
            this.panel5.Controls.Add(this.btnActualizarDiagnostico);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Location = new System.Drawing.Point(570, 520);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(673, 422);
            this.panel5.TabIndex = 6;
            // 
            // nombreComboBox
            // 
            this.nombreComboBox.FormattingEnabled = true;
            this.nombreComboBox.Location = new System.Drawing.Point(321, 51);
            this.nombreComboBox.Name = "nombreComboBox";
            this.nombreComboBox.Size = new System.Drawing.Size(121, 24);
            this.nombreComboBox.TabIndex = 25;
            // 
            // btnActualizarDiagnostico
            // 
            this.btnActualizarDiagnostico.Location = new System.Drawing.Point(412, 146);
            this.btnActualizarDiagnostico.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizarDiagnostico.Name = "btnActualizarDiagnostico";
            this.btnActualizarDiagnostico.Size = new System.Drawing.Size(233, 55);
            this.btnActualizarDiagnostico.TabIndex = 22;
            this.btnActualizarDiagnostico.Text = "Actualizar Medicos";
            this.btnActualizarDiagnostico.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Citas del medico";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 36);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnHistorialClinico
            // 
            this.btnHistorialClinico.Location = new System.Drawing.Point(1048, 392);
            this.btnHistorialClinico.Margin = new System.Windows.Forms.Padding(4);
            this.btnHistorialClinico.Name = "btnHistorialClinico";
            this.btnHistorialClinico.Size = new System.Drawing.Size(113, 92);
            this.btnHistorialClinico.TabIndex = 9;
            this.btnHistorialClinico.Text = "Historial Clinico";
            this.btnHistorialClinico.UseVisualStyleBackColor = true;
            // 
            // btnPacientesMedicoDia
            // 
            this.btnPacientesMedicoDia.Location = new System.Drawing.Point(908, 392);
            this.btnPacientesMedicoDia.Margin = new System.Windows.Forms.Padding(4);
            this.btnPacientesMedicoDia.Name = "btnPacientesMedicoDia";
            this.btnPacientesMedicoDia.Size = new System.Drawing.Size(120, 92);
            this.btnPacientesMedicoDia.TabIndex = 8;
            this.btnPacientesMedicoDia.Text = "Pacientes medico/dia";
            this.btnPacientesMedicoDia.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel6.Controls.Add(this.lblFechaHora);
            this.panel6.Location = new System.Drawing.Point(602, 384);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(271, 112);
            this.panel6.TabIndex = 7;
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.Location = new System.Drawing.Point(18, 46);
            this.lblFechaHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(0, 17);
            this.lblFechaHora.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // medicosBindingSource
            // 
            this.medicosBindingSource.DataMember = "medicos";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.atencsmedicasTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.especialidadesTableAdapter = null;
            this.tableAdapterManager.medicosTableAdapter = this.medicosTableAdapter;
            this.tableAdapterManager.pacientesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HospitalGeneral.hospitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // medicosTableAdapter
            // 
            this.medicosTableAdapter.ClearBeforeFill = true;
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 960);
            this.Controls.Add(this.btnHistorialClinico);
            this.Controls.Add(this.btnPacientesMedicoDia);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "FormularioPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAnadirCita;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label idatencLabel1;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGestionMedicos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label idmedicoLabel1;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidosTextBox;
        private System.Windows.Forms.TextBox movilTextBox;
        private System.Windows.Forms.TextBox especialidadTextBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGestionPacientes;
        private System.Windows.Forms.TextBox idpacienteTextBox;
        private System.Windows.Forms.TextBox nombreTextBox1;
        private System.Windows.Forms.TextBox apellidosTextBox1;
        private System.Windows.Forms.TextBox localidadTextBox;
        private System.Windows.Forms.TextBox alergiasTextBox;
        private System.Windows.Forms.TextBox adestacarTextBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnActualizarDiagnostico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHistorialClinico;
        private System.Windows.Forms.Button btnPacientesMedicoDia;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblFechaHora;
        private System.Windows.Forms.ComboBox cbPaciente;
        private System.Windows.Forms.ComboBox cbMedico;
        private System.Windows.Forms.ComboBox cbEspecialidad;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox nombreComboBox;
        private System.Windows.Forms.BindingSource medicosBindingSource;
        private hospitalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private hospitalDataSetTableAdapters.medicosTableAdapter medicosTableAdapter;
    }
}

