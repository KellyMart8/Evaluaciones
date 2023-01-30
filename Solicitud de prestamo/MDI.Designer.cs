namespace Solicitud_de_prestamo
{
    partial class MDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eVALUACIONESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitudPrestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depreciacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eVALUACIONESToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eVALUACIONESToolStripMenuItem
            // 
            this.eVALUACIONESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solicitudPrestamoToolStripMenuItem,
            this.depreciacionToolStripMenuItem});
            this.eVALUACIONESToolStripMenuItem.Name = "eVALUACIONESToolStripMenuItem";
            this.eVALUACIONESToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.eVALUACIONESToolStripMenuItem.Text = "EVALUACIONES";
            // 
            // solicitudPrestamoToolStripMenuItem
            // 
            this.solicitudPrestamoToolStripMenuItem.Name = "solicitudPrestamoToolStripMenuItem";
            this.solicitudPrestamoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.solicitudPrestamoToolStripMenuItem.Text = "Solicitud Prestamo";
            this.solicitudPrestamoToolStripMenuItem.Click += new System.EventHandler(this.solicitudPrestamoToolStripMenuItem_Click);
            // 
            // depreciacionToolStripMenuItem
            // 
            this.depreciacionToolStripMenuItem.Name = "depreciacionToolStripMenuItem";
            this.depreciacionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.depreciacionToolStripMenuItem.Text = "Depreciacion";
            this.depreciacionToolStripMenuItem.Click += new System.EventHandler(this.depreciacionToolStripMenuItem_Click);
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDI";
            this.Text = "MDI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eVALUACIONESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitudPrestamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depreciacionToolStripMenuItem;
    }
}