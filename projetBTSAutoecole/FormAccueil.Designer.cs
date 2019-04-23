namespace projetBTSAutoecole
{
	partial class FormAccueil
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccueil));
			this.buttonLearner = new System.Windows.Forms.Button();
			this.buttonCar = new System.Windows.Forms.Button();
			this.buttonMonitor = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonLearner
			// 
			this.buttonLearner.BackColor = System.Drawing.Color.Navy;
			this.buttonLearner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.buttonLearner.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonLearner.ForeColor = System.Drawing.SystemColors.Window;
			this.buttonLearner.Location = new System.Drawing.Point(1, 203);
			this.buttonLearner.Name = "buttonLearner";
			this.buttonLearner.Size = new System.Drawing.Size(218, 116);
			this.buttonLearner.TabIndex = 0;
			this.buttonLearner.Text = "Gérer les élèves";
			this.buttonLearner.UseVisualStyleBackColor = false;
			this.buttonLearner.Click += new System.EventHandler(this.button1_Click);
			// 
			// buttonCar
			// 
			this.buttonCar.BackColor = System.Drawing.Color.Navy;
			this.buttonCar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCar.ForeColor = System.Drawing.SystemColors.Window;
			this.buttonCar.Location = new System.Drawing.Point(274, 203);
			this.buttonCar.Name = "buttonCar";
			this.buttonCar.Size = new System.Drawing.Size(226, 116);
			this.buttonCar.TabIndex = 1;
			this.buttonCar.Text = "Gérer les voitures";
			this.buttonCar.UseVisualStyleBackColor = false;
			this.buttonCar.Click += new System.EventHandler(this.button2_Click);
			// 
			// buttonMonitor
			// 
			this.buttonMonitor.BackColor = System.Drawing.Color.Navy;
			this.buttonMonitor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonMonitor.ForeColor = System.Drawing.SystemColors.Window;
			this.buttonMonitor.Location = new System.Drawing.Point(565, 203);
			this.buttonMonitor.Name = "buttonMonitor";
			this.buttonMonitor.Size = new System.Drawing.Size(223, 116);
			this.buttonMonitor.TabIndex = 2;
			this.buttonMonitor.Text = "Gérer les moniteurs";
			this.buttonMonitor.UseVisualStyleBackColor = false;
			this.buttonMonitor.Click += new System.EventHandler(this.button3_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(86, 93);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(615, 33);
			this.label1.TabIndex = 3;
			this.label1.Text = "Bienvenue sur votre plateforme de gestion d\'autoecole";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// FormAccueil
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonMonitor);
			this.Controls.Add(this.buttonCar);
			this.Controls.Add(this.buttonLearner);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormAccueil";
			this.Text = "Auto ecole";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonLearner;
		private System.Windows.Forms.Button buttonCar;
		private System.Windows.Forms.Button buttonMonitor;
		private System.Windows.Forms.Label label1;
	}
}

