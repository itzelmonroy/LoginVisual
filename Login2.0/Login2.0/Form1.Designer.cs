namespace Login2._0
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelcontraseña = new System.Windows.Forms.Label();
            this.textBox_usuario = new System.Windows.Forms.TextBox();
            this.popo = new System.Windows.Forms.TextBox();
            this.button_ingresar = new System.Windows.Forms.Button();
            this.button_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(631, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema ultra secreto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            // 
            // labelcontraseña
            // 
            this.labelcontraseña.AutoSize = true;
            this.labelcontraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcontraseña.Location = new System.Drawing.Point(12, 216);
            this.labelcontraseña.Name = "labelcontraseña";
            this.labelcontraseña.Size = new System.Drawing.Size(140, 25);
            this.labelcontraseña.TabIndex = 2;
            this.labelcontraseña.Text = "Contraseña ";
            // 
            // textBox_usuario
            // 
            this.textBox_usuario.Location = new System.Drawing.Point(146, 151);
            this.textBox_usuario.Name = "textBox_usuario";
            this.textBox_usuario.Size = new System.Drawing.Size(510, 20);
            this.textBox_usuario.TabIndex = 3;
            this.textBox_usuario.TextChanged += new System.EventHandler(this.TextBox_usuario_TextChanged);
            // 
            // popo
            // 
            this.popo.Location = new System.Drawing.Point(158, 216);
            this.popo.Name = "popo";
            this.popo.Size = new System.Drawing.Size(393, 20);
            this.popo.TabIndex = 4;
            // 
            // button_ingresar
            // 
            this.button_ingresar.Location = new System.Drawing.Point(37, 317);
            this.button_ingresar.Name = "button_ingresar";
            this.button_ingresar.Size = new System.Drawing.Size(215, 92);
            this.button_ingresar.TabIndex = 5;
            this.button_ingresar.Text = "Ingresar ";
            this.button_ingresar.UseVisualStyleBackColor = true;
            this.button_ingresar.Click += new System.EventHandler(this.Button_ingresar_Click);
            // 
            // button_salir
            // 
            this.button_salir.Location = new System.Drawing.Point(511, 307);
            this.button_salir.Name = "button_salir";
            this.button_salir.Size = new System.Drawing.Size(210, 102);
            this.button_salir.TabIndex = 6;
            this.button_salir.Text = "salir ";
            this.button_salir.UseVisualStyleBackColor = true;
            this.button_salir.Click += new System.EventHandler(this.Button_salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_salir);
            this.Controls.Add(this.button_ingresar);
            this.Controls.Add(this.popo);
            this.Controls.Add(this.textBox_usuario);
            this.Controls.Add(this.labelcontraseña);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelcontraseña;
        private System.Windows.Forms.TextBox textBox_usuario;
        private System.Windows.Forms.TextBox popo;
        private System.Windows.Forms.Button button_ingresar;
        private System.Windows.Forms.Button button_salir;
    }
}

