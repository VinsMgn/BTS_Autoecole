﻿namespace projetBTSAutoecole.Eleve
{
	partial class ModiferEleveForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModiferEleveForm));
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.learnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.autoecoleDataSet1 = new projetBTSAutoecole.autoecoleDataSet1();
			this.label1 = new System.Windows.Forms.Label();
			this.learnerTableAdapter = new projetBTSAutoecole.autoecoleDataSet1TableAdapters.LearnerTableAdapter();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.learnerBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.autoecoleDataSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.DataSource = this.learnerBindingSource;
			this.comboBox1.DisplayMember = "name";
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(151, 15);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(550, 24);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Liste des élèves";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// learnerTableAdapter
			// 
			this.learnerTableAdapter.ClearBeforeFill = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(151, 84);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(184, 22);
			this.textBox1.TabIndex = 2;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(151, 132);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(184, 22);
			this.textBox2.TabIndex = 3;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(151, 178);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(184, 22);
			this.textBox3.TabIndex = 4;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(151, 232);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(184, 22);
			this.textBox4.TabIndex = 5;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(151, 282);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(184, 22);
			this.textBox5.TabIndex = 6;
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(151, 333);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(184, 22);
			this.textBox6.TabIndex = 7;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(501, 101);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(271, 22);
			this.dateTimePicker1.TabIndex = 8;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Location = new System.Drawing.Point(501, 183);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(271, 22);
			this.dateTimePicker2.TabIndex = 9;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 89);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 17);
			this.label2.TabIndex = 10;
			this.label2.Text = "Nom";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(16, 136);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 17);
			this.label3.TabIndex = 11;
			this.label3.Text = "Prénom";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(16, 182);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 17);
			this.label4.TabIndex = 12;
			this.label4.Text = "Adresse";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(16, 232);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(83, 17);
			this.label5.TabIndex = 13;
			this.label5.Text = "Code postal";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(19, 282);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(34, 17);
			this.label6.TabIndex = 14;
			this.label6.Text = "Ville";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(19, 333);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(89, 17);
			this.label7.TabIndex = 15;
			this.label7.Text = "Adresse mail";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(368, 100);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(126, 17);
			this.label8.TabIndex = 16;
			this.label8.Text = "Date de naissance";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(368, 182);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(117, 17);
			this.label9.TabIndex = 17;
			this.label9.Text = "Date d\'inscription";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Navy;
			this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.Window;
			this.button1.Location = new System.Drawing.Point(587, 260);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(185, 95);
			this.button1.TabIndex = 18;
			this.button1.Text = "Supprimer l\'élève";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Navy;
			this.button2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.SystemColors.Window;
			this.button2.Location = new System.Drawing.Point(362, 260);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(185, 95);
			this.button2.TabIndex = 19;
			this.button2.Text = "Modifier l\'élève";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// ModiferEleveForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dateTimePicker2);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ModiferEleveForm";
			this.Text = "Modifer des informations sur les élèves";
			this.Load += new System.EventHandler(this.ModiferEleveForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.learnerBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.autoecoleDataSet1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private autoecoleDataSet1 autoecoleDataSet1;
		private System.Windows.Forms.BindingSource learnerBindingSource;
		private autoecoleDataSet1TableAdapters.LearnerTableAdapter learnerTableAdapter;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}