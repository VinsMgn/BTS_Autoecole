namespace projetBTSAutoecole.Moniteur
{
	partial class ModifierMoniteurForm
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.moniteurDB = new projetBTSAutoecole.MoniteurDB();
			this.moniteurDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.autoecoleDataSet3 = new projetBTSAutoecole.autoecoleDataSet3();
			this.instructorBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.instructorTableAdapter = new projetBTSAutoecole.autoecoleDataSet3TableAdapters.InstructorTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.moniteurDB)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.moniteurDBBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.autoecoleDataSet3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.DataSource = this.instructorBindingSource;
			this.comboBox1.DisplayMember = "firstname";
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(226, 22);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(446, 24);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(35, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Moniteur";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(41, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Nom";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(41, 112);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 17);
			this.label3.TabIndex = 3;
			this.label3.Text = "Prénom";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(41, 160);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 17);
			this.label4.TabIndex = 4;
			this.label4.Text = "Adresse";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(41, 209);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 17);
			this.label5.TabIndex = 5;
			this.label5.Text = "Salaire";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(41, 265);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(126, 17);
			this.label6.TabIndex = 6;
			this.label6.Text = "Date de naissance";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(41, 315);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(119, 17);
			this.label7.TabIndex = 7;
			this.label7.Text = "Date d\'embauche";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(226, 68);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(263, 22);
			this.textBox1.TabIndex = 8;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(226, 107);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(263, 22);
			this.textBox2.TabIndex = 9;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(226, 160);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(263, 22);
			this.textBox3.TabIndex = 10;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(226, 209);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(263, 22);
			this.textBox4.TabIndex = 11;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(226, 265);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(263, 22);
			this.dateTimePicker1.TabIndex = 12;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Location = new System.Drawing.Point(226, 315);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(263, 22);
			this.dateTimePicker2.TabIndex = 13;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Navy;
			this.button1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.Window;
			this.button1.Location = new System.Drawing.Point(536, 107);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(252, 117);
			this.button1.TabIndex = 14;
			this.button1.Text = "Modifier le moniteur";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Navy;
			this.button2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.SystemColors.Window;
			this.button2.Location = new System.Drawing.Point(536, 260);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(252, 120);
			this.button2.TabIndex = 15;
			this.button2.Text = "Supprimer le moniteur";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// moniteurDB
			// 
			this.moniteurDB.DataSetName = "MoniteurDB";
			this.moniteurDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// moniteurDBBindingSource
			// 
			this.moniteurDBBindingSource.DataSource = this.moniteurDB;
			this.moniteurDBBindingSource.Position = 0;
			// 
			// autoecoleDataSet3
			// 
			this.autoecoleDataSet3.DataSetName = "autoecoleDataSet3";
			this.autoecoleDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// instructorBindingSource
			// 
			this.instructorBindingSource.DataMember = "Instructor";
			this.instructorBindingSource.DataSource = this.autoecoleDataSet3;
			// 
			// instructorTableAdapter
			// 
			this.instructorTableAdapter.ClearBeforeFill = true;
			// 
			// ModifierMoniteurForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dateTimePicker2);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox1);
			this.Name = "ModifierMoniteurForm";
			this.Text = "ModifierMoniteurForm";
			this.Load += new System.EventHandler(this.ModifierMoniteurForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.moniteurDB)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.moniteurDBBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.autoecoleDataSet3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private MoniteurDB moniteurDB;
		private System.Windows.Forms.BindingSource moniteurDBBindingSource;
		private autoecoleDataSet3 autoecoleDataSet3;
		private System.Windows.Forms.BindingSource instructorBindingSource;
		private autoecoleDataSet3TableAdapters.InstructorTableAdapter instructorTableAdapter;
	}
}