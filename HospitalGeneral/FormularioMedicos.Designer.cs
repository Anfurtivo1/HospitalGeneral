
namespace HospitalGeneral
{
    partial class FormularioMedicos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioMedicos));
            System.Windows.Forms.Label idmedicoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidosLabel;
            System.Windows.Forms.Label movilLabel;
            System.Windows.Forms.Label especialidadLabel;
            System.Windows.Forms.Label fotoLabel;
            this.hospitalDataSet = new HospitalGeneral.hospitalDataSet();
            this.medicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicosTableAdapter = new HospitalGeneral.hospitalDataSetTableAdapters.medicosTableAdapter();
            this.tableAdapterManager = new HospitalGeneral.hospitalDataSetTableAdapters.TableAdapterManager();
            this.medicosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.medicosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idmedicoLabel1 = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.movilTextBox = new System.Windows.Forms.TextBox();
            this.especialidadComboBox = new System.Windows.Forms.ComboBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            idmedicoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidosLabel = new System.Windows.Forms.Label();
            movilLabel = new System.Windows.Forms.Label();
            especialidadLabel = new System.Windows.Forms.Label();
            fotoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingNavigator)).BeginInit();
            this.medicosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // hospitalDataSet
            // 
            this.hospitalDataSet.DataSetName = "hospitalDataSet";
            this.hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicosBindingSource
            // 
            this.medicosBindingSource.DataMember = "medicos";
            this.medicosBindingSource.DataSource = this.hospitalDataSet;
            // 
            // medicosTableAdapter
            // 
            this.medicosTableAdapter.ClearBeforeFill = true;
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
            // medicosBindingNavigator
            // 
            this.medicosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.medicosBindingNavigator.BindingSource = this.medicosBindingSource;
            this.medicosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.medicosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.medicosBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.medicosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.medicosBindingNavigatorSaveItem});
            this.medicosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.medicosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.medicosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.medicosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.medicosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.medicosBindingNavigator.Name = "medicosBindingNavigator";
            this.medicosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.medicosBindingNavigator.Size = new System.Drawing.Size(549, 27);
            this.medicosBindingNavigator.TabIndex = 0;
            this.medicosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // medicosBindingNavigatorSaveItem
            // 
            this.medicosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.medicosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("medicosBindingNavigatorSaveItem.Image")));
            this.medicosBindingNavigatorSaveItem.Name = "medicosBindingNavigatorSaveItem";
            this.medicosBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.medicosBindingNavigatorSaveItem.Text = "Guardar datos";
            this.medicosBindingNavigatorSaveItem.Click += new System.EventHandler(this.medicosBindingNavigatorSaveItem_Click_1);
            // 
            // idmedicoLabel
            // 
            idmedicoLabel.AutoSize = true;
            idmedicoLabel.Location = new System.Drawing.Point(285, 55);
            idmedicoLabel.Name = "idmedicoLabel";
            idmedicoLabel.Size = new System.Drawing.Size(68, 17);
            idmedicoLabel.TabIndex = 1;
            idmedicoLabel.Text = "idmedico:";
            // 
            // idmedicoLabel1
            // 
            this.idmedicoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicosBindingSource, "idmedico", true));
            this.idmedicoLabel1.Location = new System.Drawing.Point(382, 55);
            this.idmedicoLabel1.Name = "idmedicoLabel1";
            this.idmedicoLabel1.Size = new System.Drawing.Size(121, 23);
            this.idmedicoLabel1.TabIndex = 2;
            this.idmedicoLabel1.Text = "label1";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(285, 84);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(60, 17);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicosBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(382, 81);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(121, 22);
            this.nombreTextBox.TabIndex = 4;
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.Location = new System.Drawing.Point(285, 112);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(68, 17);
            apellidosLabel.TabIndex = 5;
            apellidosLabel.Text = "apellidos:";
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicosBindingSource, "apellidos", true));
            this.apellidosTextBox.Location = new System.Drawing.Point(382, 109);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.Size = new System.Drawing.Size(121, 22);
            this.apellidosTextBox.TabIndex = 6;
            // 
            // movilLabel
            // 
            movilLabel.AutoSize = true;
            movilLabel.Location = new System.Drawing.Point(285, 140);
            movilLabel.Name = "movilLabel";
            movilLabel.Size = new System.Drawing.Size(44, 17);
            movilLabel.TabIndex = 7;
            movilLabel.Text = "movil:";
            // 
            // movilTextBox
            // 
            this.movilTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicosBindingSource, "movil", true));
            this.movilTextBox.Location = new System.Drawing.Point(382, 137);
            this.movilTextBox.Name = "movilTextBox";
            this.movilTextBox.Size = new System.Drawing.Size(121, 22);
            this.movilTextBox.TabIndex = 8;
            // 
            // especialidadLabel
            // 
            especialidadLabel.AutoSize = true;
            especialidadLabel.Location = new System.Drawing.Point(285, 168);
            especialidadLabel.Name = "especialidadLabel";
            especialidadLabel.Size = new System.Drawing.Size(91, 17);
            especialidadLabel.TabIndex = 9;
            especialidadLabel.Text = "especialidad:";
            // 
            // especialidadComboBox
            // 
            this.especialidadComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicosBindingSource, "especialidad", true));
            this.especialidadComboBox.FormattingEnabled = true;
            this.especialidadComboBox.Location = new System.Drawing.Point(382, 165);
            this.especialidadComboBox.Name = "especialidadComboBox";
            this.especialidadComboBox.Size = new System.Drawing.Size(121, 24);
            this.especialidadComboBox.TabIndex = 10;
            // 
            // btnFoto
            // 
            this.btnFoto.Location = new System.Drawing.Point(63, 215);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(75, 23);
            this.btnFoto.TabIndex = 12;
            this.btnFoto.Text = "Foto";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // fotoLabel
            // 
            fotoLabel.AutoSize = true;
            fotoLabel.Location = new System.Drawing.Point(12, 79);
            fotoLabel.Name = "fotoLabel";
            fotoLabel.Size = new System.Drawing.Size(36, 17);
            fotoLabel.TabIndex = 12;
            fotoLabel.Text = "foto:";
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.medicosBindingSource, "foto", true));
            this.fotoPictureBox.Location = new System.Drawing.Point(54, 55);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(100, 130);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPictureBox.TabIndex = 13;
            this.fotoPictureBox.TabStop = false;
            // 
            // FormularioMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 258);
            this.Controls.Add(fotoLabel);
            this.Controls.Add(this.fotoPictureBox);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(idmedicoLabel);
            this.Controls.Add(this.idmedicoLabel1);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(apellidosLabel);
            this.Controls.Add(this.apellidosTextBox);
            this.Controls.Add(movilLabel);
            this.Controls.Add(this.movilTextBox);
            this.Controls.Add(especialidadLabel);
            this.Controls.Add(this.especialidadComboBox);
            this.Controls.Add(this.medicosBindingNavigator);
            this.Name = "FormularioMedicos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormularioMedicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingNavigator)).EndInit();
            this.medicosBindingNavigator.ResumeLayout(false);
            this.medicosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private hospitalDataSet hospitalDataSet;
        private System.Windows.Forms.BindingSource medicosBindingSource;
        private hospitalDataSetTableAdapters.medicosTableAdapter medicosTableAdapter;
        private hospitalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator medicosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton medicosBindingNavigatorSaveItem;
        private System.Windows.Forms.Label idmedicoLabel1;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidosTextBox;
        private System.Windows.Forms.TextBox movilTextBox;
        private System.Windows.Forms.ComboBox especialidadComboBox;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.PictureBox fotoPictureBox;
    }
}