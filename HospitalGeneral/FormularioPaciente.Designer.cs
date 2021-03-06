﻿
namespace HospitalGeneral
{
    partial class FormularioPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPaciente));
            System.Windows.Forms.Label idpacienteLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidosLabel;
            System.Windows.Forms.Label localidadLabel;
            System.Windows.Forms.Label alergiasLabel;
            System.Windows.Forms.Label adestacarLabel;
            this.hospitalDataSet = new HospitalGeneral.hospitalDataSet();
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacientesTableAdapter = new HospitalGeneral.hospitalDataSetTableAdapters.pacientesTableAdapter();
            this.tableAdapterManager = new HospitalGeneral.hospitalDataSetTableAdapters.TableAdapterManager();
            this.pacientesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.pacientesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idpacienteLabel1 = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.localidadTextBox = new System.Windows.Forms.TextBox();
            this.alergiasTextBox = new System.Windows.Forms.TextBox();
            this.adestacarTextBox = new System.Windows.Forms.TextBox();
            idpacienteLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidosLabel = new System.Windows.Forms.Label();
            localidadLabel = new System.Windows.Forms.Label();
            alergiasLabel = new System.Windows.Forms.Label();
            adestacarLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingNavigator)).BeginInit();
            this.pacientesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // hospitalDataSet
            // 
            this.hospitalDataSet.DataSetName = "hospitalDataSet";
            this.hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataMember = "pacientes";
            this.pacientesBindingSource.DataSource = this.hospitalDataSet;
            // 
            // pacientesTableAdapter
            // 
            this.pacientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.atencsmedicasTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.especialidadesTableAdapter = null;
            this.tableAdapterManager.medicosTableAdapter = null;
            this.tableAdapterManager.pacientesTableAdapter = this.pacientesTableAdapter;
            this.tableAdapterManager.UpdateOrder = HospitalGeneral.hospitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pacientesBindingNavigator
            // 
            this.pacientesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pacientesBindingNavigator.BindingSource = this.pacientesBindingSource;
            this.pacientesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pacientesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pacientesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.pacientesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pacientesBindingNavigatorSaveItem});
            this.pacientesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pacientesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pacientesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pacientesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pacientesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pacientesBindingNavigator.Name = "pacientesBindingNavigator";
            this.pacientesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pacientesBindingNavigator.Size = new System.Drawing.Size(530, 27);
            this.pacientesBindingNavigator.TabIndex = 0;
            this.pacientesBindingNavigator.Text = "bindingNavigator1";
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
            // pacientesBindingNavigatorSaveItem
            // 
            this.pacientesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pacientesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pacientesBindingNavigatorSaveItem.Image")));
            this.pacientesBindingNavigatorSaveItem.Name = "pacientesBindingNavigatorSaveItem";
            this.pacientesBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.pacientesBindingNavigatorSaveItem.Text = "Guardar datos";
            this.pacientesBindingNavigatorSaveItem.Click += new System.EventHandler(this.pacientesBindingNavigatorSaveItem_Click);
            // 
            // idpacienteLabel
            // 
            idpacienteLabel.AutoSize = true;
            idpacienteLabel.Location = new System.Drawing.Point(162, 71);
            idpacienteLabel.Name = "idpacienteLabel";
            idpacienteLabel.Size = new System.Drawing.Size(77, 17);
            idpacienteLabel.TabIndex = 1;
            idpacienteLabel.Text = "idpaciente:";
            // 
            // idpacienteLabel1
            // 
            this.idpacienteLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "idpaciente", true));
            this.idpacienteLabel1.Location = new System.Drawing.Point(245, 71);
            this.idpacienteLabel1.Name = "idpacienteLabel1";
            this.idpacienteLabel1.Size = new System.Drawing.Size(100, 23);
            this.idpacienteLabel1.TabIndex = 2;
            this.idpacienteLabel1.Text = "label1";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(162, 100);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(60, 17);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(245, 97);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 22);
            this.nombreTextBox.TabIndex = 4;
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.Location = new System.Drawing.Point(162, 128);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(68, 17);
            apellidosLabel.TabIndex = 5;
            apellidosLabel.Text = "apellidos:";
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "apellidos", true));
            this.apellidosTextBox.Location = new System.Drawing.Point(245, 125);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.Size = new System.Drawing.Size(100, 22);
            this.apellidosTextBox.TabIndex = 6;
            // 
            // localidadLabel
            // 
            localidadLabel.AutoSize = true;
            localidadLabel.Location = new System.Drawing.Point(162, 156);
            localidadLabel.Name = "localidadLabel";
            localidadLabel.Size = new System.Drawing.Size(68, 17);
            localidadLabel.TabIndex = 7;
            localidadLabel.Text = "localidad:";
            // 
            // localidadTextBox
            // 
            this.localidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "localidad", true));
            this.localidadTextBox.Location = new System.Drawing.Point(245, 153);
            this.localidadTextBox.Name = "localidadTextBox";
            this.localidadTextBox.Size = new System.Drawing.Size(100, 22);
            this.localidadTextBox.TabIndex = 8;
            // 
            // alergiasLabel
            // 
            alergiasLabel.AutoSize = true;
            alergiasLabel.Location = new System.Drawing.Point(162, 184);
            alergiasLabel.Name = "alergiasLabel";
            alergiasLabel.Size = new System.Drawing.Size(62, 17);
            alergiasLabel.TabIndex = 9;
            alergiasLabel.Text = "alergias:";
            // 
            // alergiasTextBox
            // 
            this.alergiasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "alergias", true));
            this.alergiasTextBox.Location = new System.Drawing.Point(245, 181);
            this.alergiasTextBox.Name = "alergiasTextBox";
            this.alergiasTextBox.Size = new System.Drawing.Size(100, 22);
            this.alergiasTextBox.TabIndex = 10;
            // 
            // adestacarLabel
            // 
            adestacarLabel.AutoSize = true;
            adestacarLabel.Location = new System.Drawing.Point(162, 212);
            adestacarLabel.Name = "adestacarLabel";
            adestacarLabel.Size = new System.Drawing.Size(75, 17);
            adestacarLabel.TabIndex = 11;
            adestacarLabel.Text = "adestacar:";
            // 
            // adestacarTextBox
            // 
            this.adestacarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "adestacar", true));
            this.adestacarTextBox.Location = new System.Drawing.Point(245, 209);
            this.adestacarTextBox.Name = "adestacarTextBox";
            this.adestacarTextBox.Size = new System.Drawing.Size(100, 22);
            this.adestacarTextBox.TabIndex = 12;
            // 
            // FormularioPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 294);
            this.Controls.Add(idpacienteLabel);
            this.Controls.Add(this.idpacienteLabel1);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(apellidosLabel);
            this.Controls.Add(this.apellidosTextBox);
            this.Controls.Add(localidadLabel);
            this.Controls.Add(this.localidadTextBox);
            this.Controls.Add(alergiasLabel);
            this.Controls.Add(this.alergiasTextBox);
            this.Controls.Add(adestacarLabel);
            this.Controls.Add(this.adestacarTextBox);
            this.Controls.Add(this.pacientesBindingNavigator);
            this.Name = "FormularioPaciente";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormularioPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingNavigator)).EndInit();
            this.pacientesBindingNavigator.ResumeLayout(false);
            this.pacientesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private hospitalDataSet hospitalDataSet;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private hospitalDataSetTableAdapters.pacientesTableAdapter pacientesTableAdapter;
        private hospitalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pacientesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pacientesBindingNavigatorSaveItem;
        private System.Windows.Forms.Label idpacienteLabel1;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidosTextBox;
        private System.Windows.Forms.TextBox localidadTextBox;
        private System.Windows.Forms.TextBox alergiasTextBox;
        private System.Windows.Forms.TextBox adestacarTextBox;
    }
}