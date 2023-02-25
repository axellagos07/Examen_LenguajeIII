namespace AxelLagos
{
    partial class Menu
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
            this.formularioDeInteresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularioDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularioDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formularioDeInteresToolStripMenuItem,
            this.formularioDeProductosToolStripMenuItem,
            this.formularioDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(782, 99);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formularioDeInteresToolStripMenuItem
            // 
            this.formularioDeInteresToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.formularioDeInteresToolStripMenuItem.Font = new System.Drawing.Font("Cambria Math", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formularioDeInteresToolStripMenuItem.Image = global::AxelLagos.Properties.Resources.interesar2;
            this.formularioDeInteresToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.formularioDeInteresToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.formularioDeInteresToolStripMenuItem.Name = "formularioDeInteresToolStripMenuItem";
            this.formularioDeInteresToolStripMenuItem.Size = new System.Drawing.Size(287, 93);
            this.formularioDeInteresToolStripMenuItem.Text = "Formulario de Interes";
            this.formularioDeInteresToolStripMenuItem.Click += new System.EventHandler(this.formularioDeInteresToolStripMenuItem_Click);
            // 
            // formularioDeProductosToolStripMenuItem
            // 
            this.formularioDeProductosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.formularioDeProductosToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formularioDeProductosToolStripMenuItem.Image = global::AxelLagos.Properties.Resources.carrito_de_compras;
            this.formularioDeProductosToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.formularioDeProductosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.formularioDeProductosToolStripMenuItem.Name = "formularioDeProductosToolStripMenuItem";
            this.formularioDeProductosToolStripMenuItem.Size = new System.Drawing.Size(255, 93);
            this.formularioDeProductosToolStripMenuItem.Text = "Formulario de Productos";
            this.formularioDeProductosToolStripMenuItem.Click += new System.EventHandler(this.formularioDeProductosToolStripMenuItem_Click);
            // 
            // formularioDeToolStripMenuItem
            // 
            this.formularioDeToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.formularioDeToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formularioDeToolStripMenuItem.Image = global::AxelLagos.Properties.Resources._5;
            this.formularioDeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.formularioDeToolStripMenuItem.Name = "formularioDeToolStripMenuItem";
            this.formularioDeToolStripMenuItem.Size = new System.Drawing.Size(228, 93);
            this.formularioDeToolStripMenuItem.Text = "Formulario Multiplos";
            this.formularioDeToolStripMenuItem.Click += new System.EventHandler(this.formularioDeToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 213);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formularioDeInteresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formularioDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formularioDeToolStripMenuItem;
    }
}