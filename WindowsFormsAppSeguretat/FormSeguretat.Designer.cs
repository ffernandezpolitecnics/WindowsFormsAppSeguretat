namespace WindowsFormsAppSeguretat
{
    partial class FormSeguretat
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSeguretat));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.seguretatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sortirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seguretatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(689, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // seguretatToolStripMenuItem
            // 
            this.seguretatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rolsToolStripMenuItem,
            this.usuarisToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sortirToolStripMenuItem});
            this.seguretatToolStripMenuItem.Name = "seguretatToolStripMenuItem";
            this.seguretatToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.seguretatToolStripMenuItem.Text = "Administrador";
            // 
            // rolsToolStripMenuItem
            // 
            this.rolsToolStripMenuItem.Name = "rolsToolStripMenuItem";
            this.rolsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.rolsToolStripMenuItem.Text = "Rols";
            this.rolsToolStripMenuItem.Click += new System.EventHandler(this.rolsToolStripMenuItem_Click);
            // 
            // usuarisToolStripMenuItem
            // 
            this.usuarisToolStripMenuItem.Name = "usuarisToolStripMenuItem";
            this.usuarisToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.usuarisToolStripMenuItem.Text = "Usuaris";
            this.usuarisToolStripMenuItem.Click += new System.EventHandler(this.usuarisToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(139, 6);
            // 
            // sortirToolStripMenuItem
            // 
            this.sortirToolStripMenuItem.Image = global::WindowsFormsAppSeguretat.Properties.Resources.logout;
            this.sortirToolStripMenuItem.Name = "sortirToolStripMenuItem";
            this.sortirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.sortirToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.sortirToolStripMenuItem.Text = "Sortir";
            this.sortirToolStripMenuItem.Click += new System.EventHandler(this.sortirToolStripMenuItem_Click);
            // 
            // FormSeguretat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsAppSeguretat.Properties.Resources.seguridad1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(689, 411);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormSeguretat";
            this.Text = "Seguretat";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormSeguretat_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seguretatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarisToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sortirToolStripMenuItem;
    }
}

