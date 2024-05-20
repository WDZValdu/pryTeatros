namespace pryTeatros
{
    partial class frmRealizarReserva
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTeatro = new System.Windows.Forms.ComboBox();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTeatro);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione Un Teatro";
            // 
            // cmbTeatro
            // 
            this.cmbTeatro.FormattingEnabled = true;
            this.cmbTeatro.Items.AddRange(new object[] {
            "Teatro Quenaken",
            "Teatro Onas",
            "Teatro Tobas"});
            this.cmbTeatro.Location = new System.Drawing.Point(6, 19);
            this.cmbTeatro.Name = "cmbTeatro";
            this.cmbTeatro.Size = new System.Drawing.Size(214, 21);
            this.cmbTeatro.TabIndex = 0;
            this.cmbTeatro.SelectedIndexChanged += new System.EventHandler(this.cmbTeatro_SelectedIndexChanged);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Location = new System.Drawing.Point(12, 72);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(474, 446);
            this.pnlPrincipal.TabIndex = 1;
            // 
            // frmRealizarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 526);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRealizarReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRealizarReserva";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.ComboBox cmbTeatro;
    }
}