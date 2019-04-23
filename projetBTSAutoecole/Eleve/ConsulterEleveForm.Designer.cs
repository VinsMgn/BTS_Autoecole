namespace projetBTSAutoecole.Eleve
{
	partial class ConsulterEleveForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsulterEleveForm));
			this.learnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.autoecoleDataSet1 = new projetBTSAutoecole.autoecoleDataSet1();
			this.learnerTableAdapter = new projetBTSAutoecole.autoecoleDataSet1TableAdapters.LearnerTableAdapter();
			this.autoecoleDataSet2 = new projetBTSAutoecole.autoecoleDataSet2();
			this.instructorBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.instructorTableAdapter = new projetBTSAutoecole.autoecoleDataSet2TableAdapters.InstructorTableAdapter();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.birthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cp = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.town = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.signUpDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.learnerBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.autoecoleDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.autoecoleDataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// learnerBindingSource
			// 
			this.learnerBindingSource.DataMember = "Learner";
			this.learnerBindingSource.DataSource = this.autoecoleDataSet1;
			// 
			// autoecoleDataSet1
			// 
			this.autoecoleDataSet1.DataSetName = "autoecoleDataSet1";
			this.autoecoleDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// learnerTableAdapter
			// 
			this.learnerTableAdapter.ClearBeforeFill = true;
			// 
			// autoecoleDataSet2
			// 
			this.autoecoleDataSet2.DataSetName = "autoecoleDataSet2";
			this.autoecoleDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// instructorBindingSource
			// 
			this.instructorBindingSource.DataMember = "Instructor";
			this.instructorBindingSource.DataSource = this.autoecoleDataSet2;
			// 
			// instructorTableAdapter
			// 
			this.instructorTableAdapter.ClearBeforeFill = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.birthDataGridViewTextBoxColumn,
            this.mail,
            this.address,
            this.cp,
            this.town,
            this.signUpDate});
			this.dataGridView1.DataSource = this.learnerBindingSource;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1016, 530);
			this.dataGridView1.TabIndex = 0;
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
			// mail
			// 
			this.mail.DataPropertyName = "mail";
			this.mail.HeaderText = "Mail";
			this.mail.Name = "mail";
			this.mail.ReadOnly = true;
			// 
			// address
			// 
			this.address.DataPropertyName = "address";
			this.address.HeaderText = "Adresse";
			this.address.Name = "address";
			this.address.ReadOnly = true;
			// 
			// cp
			// 
			this.cp.DataPropertyName = "cp";
			this.cp.HeaderText = "Code postal";
			this.cp.Name = "cp";
			this.cp.ReadOnly = true;
			// 
			// town
			// 
			this.town.DataPropertyName = "town";
			this.town.HeaderText = "Ville";
			this.town.Name = "town";
			this.town.ReadOnly = true;
			// 
			// signUpDate
			// 
			this.signUpDate.DataPropertyName = "signUpDate";
			this.signUpDate.HeaderText = "Date d\'inscription";
			this.signUpDate.Name = "signUpDate";
			this.signUpDate.ReadOnly = true;
			// 
			// ConsulterEleveForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1016, 530);
			this.Controls.Add(this.dataGridView1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ConsulterEleveForm";
			this.Text = "Consulter les élèves inscrits";
			this.Load += new System.EventHandler(this.ConsulterEleveForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.learnerBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.autoecoleDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.autoecoleDataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private autoecoleDataSet1 autoecoleDataSet1;
		private System.Windows.Forms.BindingSource learnerBindingSource;
		private autoecoleDataSet1TableAdapters.LearnerTableAdapter learnerTableAdapter;
		private autoecoleDataSet2 autoecoleDataSet2;
		private System.Windows.Forms.BindingSource instructorBindingSource;
		private autoecoleDataSet2TableAdapters.InstructorTableAdapter instructorTableAdapter;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn birthDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn mail;
		private System.Windows.Forms.DataGridViewTextBoxColumn address;
		private System.Windows.Forms.DataGridViewTextBoxColumn cp;
		private System.Windows.Forms.DataGridViewTextBoxColumn town;
		private System.Windows.Forms.DataGridViewTextBoxColumn signUpDate;
	}
}