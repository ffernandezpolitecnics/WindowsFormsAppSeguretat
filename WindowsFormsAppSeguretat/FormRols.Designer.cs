namespace WindowsFormsAppSeguretat
{
    partial class FormRols
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAfegir = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEsborrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewRols = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRols)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAfegir,
            this.toolStripButtonEsborrar,
            this.toolStripSeparator1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAfegir
            // 
            this.toolStripButtonAfegir.Image = global::WindowsFormsAppSeguretat.Properties.Resources.plus;
            this.toolStripButtonAfegir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAfegir.Name = "toolStripButtonAfegir";
            this.toolStripButtonAfegir.Size = new System.Drawing.Size(59, 22);
            this.toolStripButtonAfegir.Text = "Afegir";
            this.toolStripButtonAfegir.Click += new System.EventHandler(this.toolStripButtonAfegir_Click);
            // 
            // toolStripButtonEsborrar
            // 
            this.toolStripButtonEsborrar.Image = global::WindowsFormsAppSeguretat.Properties.Resources.rubbish_bin;
            this.toolStripButtonEsborrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEsborrar.Name = "toolStripButtonEsborrar";
            this.toolStripButtonEsborrar.Size = new System.Drawing.Size(70, 22);
            this.toolStripButtonEsborrar.Text = "Esborrar";
            this.toolStripButtonEsborrar.Click += new System.EventHandler(this.toolStripButtonEsborrar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::WindowsFormsAppSeguretat.Properties.Resources.logout;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(55, 22);
            this.toolStripButton1.Text = "Sortir";
            this.toolStripButton1.ToolTipText = "Sortir";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // dataGridViewRols
            // 
            this.dataGridViewRols.AllowUserToAddRows = false;
            this.dataGridViewRols.AllowUserToDeleteRows = false;
            this.dataGridViewRols.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRols.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nom});
            this.dataGridViewRols.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRols.Location = new System.Drawing.Point(0, 25);
            this.dataGridViewRols.Name = "dataGridViewRols";
            this.dataGridViewRols.ReadOnly = true;
            this.dataGridViewRols.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRols.Size = new System.Drawing.Size(800, 487);
            this.dataGridViewRols.TabIndex = 1;
            this.dataGridViewRols.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRols_CellDoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // nom
            // 
            this.nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nom.DataPropertyName = "nom";
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            // 
            // FormRols
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.dataGridViewRols);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormRols";
            this.Text = "Rols";
            this.Load += new System.EventHandler(this.FormRols_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRols)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dataGridViewRols;
        private System.Windows.Forms.ToolStripButton toolStripButtonAfegir;
        private System.Windows.Forms.ToolStripButton toolStripButtonEsborrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
    }
}