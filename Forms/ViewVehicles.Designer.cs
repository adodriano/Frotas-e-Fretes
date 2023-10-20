namespace Frotas_e_Fretes.Forms
{

    partial class ViewVehicles
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
            this.listData = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listData
            // 
            this.listData.HideSelection = false;
            this.listData.Location = new System.Drawing.Point(0, 0);
            this.listData.Name = "listData";
            this.listData.Size = new System.Drawing.Size(450, 350);
            this.listData.TabIndex = 0;
            this.listData.UseCompatibleStateImageBehavior = false;
            // 
            // ViewVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 350);
            this.Controls.Add(this.listData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ViewVehicles";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "ViewVehicles";
            this.Load += new System.EventHandler(this.ViewVehicles_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listData;
    }
}