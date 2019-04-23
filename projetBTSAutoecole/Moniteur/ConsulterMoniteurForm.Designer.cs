namespace projetBTSAutoecole.Moniteur
{
	partial class ConsulterMoniteurForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsulterMoniteurForm));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.learnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.autoecoleDataSetMoniteur = new projetBTSAutoecole.autoecoleDataSetMoniteur();
			this.learnerTableAdapter = new projetBTSAutoecole.autoecoleDataSetMoniteurTableAdapters.LearnerTableAdapter();
			this.autoecoleDataSetMoniteurBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.moniteurDB = new projetBTSAutoecole.MoniteurDB();
			this.instructorBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.instructorTableAdapter = new projetBTSAutoecole.MoniteurDBTableAdapters.InstructorTableAdapter();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.birthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addressMoniteurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hireDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.wageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.learnerBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.autoecoleDataSetMoniteur)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.autoecoleDataSetMoniteurBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.moniteurDB)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.birthDataGridViewTextBoxColumn,
            this.addressMoniteurDataGridViewTextBoxColumn,
            this.hireDateDataGridViewTextBoxColumn,
            this.wageDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.instructorBindingSource;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(800, 450);
			this.dataGridView1.TabIndex = 0;
			// 
			// learnerBindingSource
			// 
			this.learnerBindingSource.DataMember = "Learner";
			this.learnerBindingSource.DataSource = this.autoecoleDataSetMoniteur;
			// 
			// autoecoleDataSetMoniteur
			// 
			this.autoecoleDataSetMoniteur.DataSetName = "autoecoleDataSetMoniteur";
			this.autoecoleDataSetMoniteur.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// learnerTableAdapter
			// 
			this.learnerTableAdapter.ClearBeforeFill = true;
			// 
			// autoecoleDataSetMoniteurBindingSource
			// 
			this.autoecoleDataSetMoniteurBindingSource.DataSource = this.autoecoleDataSetMoniteur;
			this.autoecoleDataSetMoniteurBindingSource.Position = 0;
			// 
			// moniteurDB
			// 
			this.moniteurDB.DataSetName = "MoniteurDB";
			this.moniteurDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// instructorBindingSource
			// 
			this.instructorBindingSource.DataMember = "Instructor";
			this.instructorBindingSource.DataSource = this.moniteurDB;
			// 
			// instructorTableAdapter
			// 
			this.instructorTableAdapter.ClearBeforeFill = true;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Nom";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// firstnameDataGridViewTextBoxColumn
			// 
			this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname";
			this.firstnameDataGridViewTextBoxColumn.HeaderText = "Prénom";
			this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
			this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// birthDataGridViewTextBoxColumn
			// 
			this.birthDataGridViewTextBoxColumn.DataPropertyName = "birth";
			this.birthDataGridViewTextBoxColumn.HeaderText = "Date de naissance";
			this.birthDataGridViewTextBoxColumn.Name = "birthDataGridViewTextBoxColumn";
			this.birthDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// addressMoniteurDataGridViewTextBoxColumn
			// 
			this.addressMoniteurDataGridViewTextBoxColumn.DataPropertyName = "address_Moniteur";
			this.addressMoniteurDataGridViewTextBoxColumn.HeaderText = "Adresse";
			this.addressMoniteurDataGridViewTextBoxColumn.Name = "addressMoniteurDataGridViewTextBoxColumn";
			this.addressMoniteurDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// hireDateDataGridViewTextBoxColumn
			// 
			this.hireDateDataGridViewTextBoxColumn.DataPropertyName = "hireDate";
			this.hireDateDataGridViewTextBoxColumn.HeaderText = "Date d\'embauche";
			this.hireDateDataGridViewTextBoxColumn.Name = "hireDateDataGridViewTextBoxColumn";
			this.hireDateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// wageDataGridViewTextBoxColumn
			// 
			this.wageDataGridViewTextBoxColumn.DataPropertyName = "wage";
			this.wageDataGridViewTextBoxColumn.HeaderText = "Salaire";
			this.wageDataGridViewTextBoxColumn.Name = "wageDataGridViewTextBoxColumn";
			this.wageDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// ConsulterMoniteurForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridView1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ConsulterMoniteurForm";
			this.Text = "Consulter les moniteurs";
			this.Load += new System.EventHandler(this.ConsulterMoniteurForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.learnerBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.autoecoleDataSetMoniteur)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.autoecoleDataSetMoniteurBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.moniteurDB)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private autoecoleDataSetMoniteur autoecoleDataSetMoniteur;
		private System.Windows.Forms.BindingSource learnerBindingSource;
		private autoecoleDataSetMoniteurTableAdapters.LearnerTableAdapter learnerTableAdapter;
		private System.Windows.Forms.BindingSource autoecoleDataSetMoniteurBindingSource;
		private MoniteurDB moniteurDB;
		private System.Windows.Forms.BindingSource instructorBindingSource;
		private MoniteurDBTableAdapters.InstructorTableAdapter instructorTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn birthDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn addressMoniteurDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn hireDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn wageDataGridViewTextBoxColumn;
	}
}