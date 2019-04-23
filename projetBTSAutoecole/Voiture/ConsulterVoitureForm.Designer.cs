namespace projetBTSAutoecole.Voiture
{
	partial class ConsulterVoitureForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsulterVoitureForm));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gearboxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buyDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.autoecoleDataSet = new projetBTSAutoecole.autoecoleDataSet();
			this.carTableAdapter = new projetBTSAutoecole.autoecoleDataSetTableAdapters.CarTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.autoecoleDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modelDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.gearboxDataGridViewTextBoxColumn,
            this.buyDateDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.carBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(776, 426);
			this.dataGridView1.TabIndex = 0;
			// 
			// modelDataGridViewTextBoxColumn
			// 
			this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
			this.modelDataGridViewTextBoxColumn.HeaderText = "Modèle";
			this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
			// 
			// brandDataGridViewTextBoxColumn
			// 
			this.brandDataGridViewTextBoxColumn.DataPropertyName = "brand";
			this.brandDataGridViewTextBoxColumn.HeaderText = "Marque";
			this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
			// 
			// gearboxDataGridViewTextBoxColumn
			// 
			this.gearboxDataGridViewTextBoxColumn.DataPropertyName = "gearbox";
			this.gearboxDataGridViewTextBoxColumn.HeaderText = "Boite de vitesse";
			this.gearboxDataGridViewTextBoxColumn.Name = "gearboxDataGridViewTextBoxColumn";
			// 
			// buyDateDataGridViewTextBoxColumn
			// 
			this.buyDateDataGridViewTextBoxColumn.DataPropertyName = "BuyDate";
			this.buyDateDataGridViewTextBoxColumn.HeaderText = "Date d\'achat";
			this.buyDateDataGridViewTextBoxColumn.Name = "buyDateDataGridViewTextBoxColumn";
			// 
			// carBindingSource
			// 
			this.carBindingSource.DataMember = "Car";
			this.carBindingSource.DataSource = this.autoecoleDataSet;
			// 
			// autoecoleDataSet
			// 
			this.autoecoleDataSet.DataSetName = "autoecoleDataSet";
			this.autoecoleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// carTableAdapter
			// 
			this.carTableAdapter.ClearBeforeFill = true;
			// 
			// ConsulterVoitureForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridView1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ConsulterVoitureForm";
			this.Text = "Consulter les voitures";
			this.Load += new System.EventHandler(this.ConsulterVoitureForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.autoecoleDataSet)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private autoecoleDataSet autoecoleDataSet;
		private System.Windows.Forms.BindingSource carBindingSource;
		private autoecoleDataSetTableAdapters.CarTableAdapter carTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn gearboxDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn buyDateDataGridViewTextBoxColumn;
	}
}