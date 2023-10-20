namespace Frotas_e_Fretes.Forms
{

    partial class MainForm
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
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnAutonomy = new System.Windows.Forms.Button();
            this.btnAddFuel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.Location = new System.Drawing.Point(85, 93);
            this.btnAddVehicle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(146, 54);
            this.btnAddVehicle.TabIndex = 0;
            this.btnAddVehicle.Text = "Adicionar Veículo";
            this.btnAddVehicle.UseVisualStyleBackColor = true;
            this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(320, 93);
            this.btnView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(146, 54);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "Veiculos Cadastrados";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnAutonomy
            // 
            this.btnAutonomy.Location = new System.Drawing.Point(320, 173);
            this.btnAutonomy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAutonomy.Name = "btnAutonomy";
            this.btnAutonomy.Size = new System.Drawing.Size(146, 54);
            this.btnAutonomy.TabIndex = 2;
            this.btnAutonomy.Text = "Verificar Autonomia";
            this.btnAutonomy.UseVisualStyleBackColor = true;
            this.btnAutonomy.Click += new System.EventHandler(this.btnAutonomy_Click);
            // 
            // btnAddFuel
            // 
            this.btnAddFuel.Location = new System.Drawing.Point(85, 173);
            this.btnAddFuel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddFuel.Name = "btnAddFuel";
            this.btnAddFuel.Size = new System.Drawing.Size(146, 54);
            this.btnAddFuel.TabIndex = 3;
            this.btnAddFuel.Text = "Tabela de Combustivel";
            this.btnAddFuel.UseVisualStyleBackColor = true;
            this.btnAddFuel.Click += new System.EventHandler(this.btnAddFuel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gerenciamento de Frotas e Fretes";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 323);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddFuel);
            this.Controls.Add(this.btnAutonomy);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnAddVehicle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddVehicle;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnAutonomy;
        private System.Windows.Forms.Button btnAddFuel;
        private System.Windows.Forms.Label label1;
    }
}