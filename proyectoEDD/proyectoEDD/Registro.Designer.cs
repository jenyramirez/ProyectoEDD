namespace proyectoEDD
{
    partial class Registro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.contrasena = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.contraAdministrador = new System.Windows.Forms.TextBox();
            this.labelContraAdministrador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese su nombre";
            // 
            // nombre
            // 
            this.nombre.Font = new System.Drawing.Font("OCR A Extended", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(253, 121);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(300, 25);
            this.nombre.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("OCR A Extended", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ingrese su contraseña";
            // 
            // contrasena
            // 
            this.contrasena.Font = new System.Drawing.Font("OCR A Extended", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrasena.Location = new System.Drawing.Point(253, 167);
            this.contrasena.Name = "contrasena";
            this.contrasena.Size = new System.Drawing.Size(300, 25);
            this.contrasena.TabIndex = 4;
            this.contrasena.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("OCR A Extended", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(298, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Seleccione el tipo de usuario";
            // 
            // comboTipo
            // 
            this.comboTipo.Font = new System.Drawing.Font("OCR A Extended", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Items.AddRange(new object[] {
            "Administrador",
            "Gestor de operaciones"});
            this.comboTipo.Location = new System.Drawing.Point(326, 218);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(227, 26);
            this.comboTipo.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(191, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 56);
            this.button1.TabIndex = 7;
            this.button1.Text = "ACEPTAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contraAdministrador
            // 
            this.contraAdministrador.Enabled = false;
            this.contraAdministrador.Font = new System.Drawing.Font("OCR A Extended", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraAdministrador.Location = new System.Drawing.Point(326, 265);
            this.contraAdministrador.Name = "contraAdministrador";
            this.contraAdministrador.Size = new System.Drawing.Size(227, 25);
            this.contraAdministrador.TabIndex = 8;
            this.contraAdministrador.UseSystemPasswordChar = true;
            this.contraAdministrador.Visible = false;
            // 
            // labelContraAdministrador
            // 
            this.labelContraAdministrador.AutoSize = true;
            this.labelContraAdministrador.BackColor = System.Drawing.Color.Transparent;
            this.labelContraAdministrador.Font = new System.Drawing.Font("OCR A Extended", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContraAdministrador.Location = new System.Drawing.Point(122, 254);
            this.labelContraAdministrador.Name = "labelContraAdministrador";
            this.labelContraAdministrador.Size = new System.Drawing.Size(198, 36);
            this.labelContraAdministrador.TabIndex = 9;
            this.labelContraAdministrador.Text = "Ingrese contraseña \r\ndel administrador\r\n";
            this.labelContraAdministrador.Visible = false;
            this.labelContraAdministrador.Click += new System.EventHandler(this.labelContraAdministrador_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::proyectoEDD.Properties.Resources.fondoLOGIN4;
            this.ClientSize = new System.Drawing.Size(565, 400);
            this.Controls.Add(this.labelContraAdministrador);
            this.Controls.Add(this.contraAdministrador);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboTipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.contrasena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registro";
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox contrasena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox contraAdministrador;
        private System.Windows.Forms.Label labelContraAdministrador;
    }
}