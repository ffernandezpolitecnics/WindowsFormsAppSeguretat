namespace WindowsFormsAppSeguretat
{
    partial class FormUsuari
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProviderUsuari = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxRol = new System.Windows.Forms.ComboBox();
            this.textBoxContrasenya = new System.Windows.Forms.TextBox();
            this.labelContrasenya = new System.Windows.Forms.Label();
            this.textBoxConfContrasenya = new System.Windows.Forms.TextBox();
            this.labelConfContrasenya = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUsuari)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Correu";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(107, 17);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(498, 20);
            this.textBoxEmail.TabIndex = 1;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(107, 43);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(498, 20);
            this.textBoxNom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom";
            // 
            // errorProviderUsuari
            // 
            this.errorProviderUsuari.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rol";
            // 
            // comboBoxRol
            // 
            this.comboBoxRol.FormattingEnabled = true;
            this.comboBoxRol.Location = new System.Drawing.Point(107, 70);
            this.comboBoxRol.Name = "comboBoxRol";
            this.comboBoxRol.Size = new System.Drawing.Size(498, 21);
            this.comboBoxRol.TabIndex = 5;
            // 
            // textBoxContrasenya
            // 
            this.textBoxContrasenya.Location = new System.Drawing.Point(107, 97);
            this.textBoxContrasenya.Name = "textBoxContrasenya";
            this.textBoxContrasenya.PasswordChar = '*';
            this.textBoxContrasenya.Size = new System.Drawing.Size(498, 20);
            this.textBoxContrasenya.TabIndex = 7;
            // 
            // labelContrasenya
            // 
            this.labelContrasenya.AutoSize = true;
            this.labelContrasenya.Location = new System.Drawing.Point(22, 100);
            this.labelContrasenya.Name = "labelContrasenya";
            this.labelContrasenya.Size = new System.Drawing.Size(66, 13);
            this.labelContrasenya.TabIndex = 6;
            this.labelContrasenya.Text = "Contrasenya";
            // 
            // textBoxConfContrasenya
            // 
            this.textBoxConfContrasenya.Location = new System.Drawing.Point(107, 123);
            this.textBoxConfContrasenya.Name = "textBoxConfContrasenya";
            this.textBoxConfContrasenya.PasswordChar = '*';
            this.textBoxConfContrasenya.Size = new System.Drawing.Size(498, 20);
            this.textBoxConfContrasenya.TabIndex = 9;
            // 
            // labelConfContrasenya
            // 
            this.labelConfContrasenya.AutoSize = true;
            this.labelConfContrasenya.Location = new System.Drawing.Point(22, 126);
            this.labelConfContrasenya.Name = "labelConfContrasenya";
            this.labelConfContrasenya.Size = new System.Drawing.Size(66, 13);
            this.labelConfContrasenya.TabIndex = 8;
            this.labelConfContrasenya.Text = "Contrasenya";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(449, 149);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 34);
            this.buttonCancelar.TabIndex = 11;
            this.buttonCancelar.Text = "Cancel·lar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(530, 149);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 34);
            this.buttonGuardar.TabIndex = 10;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // FormUsuari
            // 
            this.AcceptButton = this.buttonGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 198);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.textBoxConfContrasenya);
            this.Controls.Add(this.labelConfContrasenya);
            this.Controls.Add(this.textBoxContrasenya);
            this.Controls.Add(this.labelContrasenya);
            this.Controls.Add(this.comboBoxRol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormUsuari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuari";
            this.Load += new System.EventHandler(this.FormUsuari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUsuari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProviderUsuari;
        private System.Windows.Forms.TextBox textBoxConfContrasenya;
        private System.Windows.Forms.Label labelConfContrasenya;
        private System.Windows.Forms.TextBox textBoxContrasenya;
        private System.Windows.Forms.Label labelContrasenya;
        private System.Windows.Forms.ComboBox comboBoxRol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonGuardar;
    }
}