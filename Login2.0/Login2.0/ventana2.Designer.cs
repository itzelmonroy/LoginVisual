namespace Login2._0
{
    partial class ventana2
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
            this.checkBox_visual = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_visualbasic = new System.Windows.Forms.CheckBox();
            this.button_compras = new System.Windows.Forms.Button();
            this.button_salir = new System.Windows.Forms.Button();
            this.radioButton_tarjeta = new System.Windows.Forms.RadioButton();
            this.radioButton_paypal = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // checkBox_visual
            // 
            this.checkBox_visual.AutoSize = true;
            this.checkBox_visual.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_visual.Location = new System.Drawing.Point(45, 93);
            this.checkBox_visual.Name = "checkBox_visual";
            this.checkBox_visual.Size = new System.Drawing.Size(112, 30);
            this.checkBox_visual.TabIndex = 0;
            this.checkBox_visual.Text = "Visual C#";
            this.checkBox_visual.UseVisualStyleBackColor = true;
            this.checkBox_visual.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cursos en venta ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(477, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Formas de pago";
            // 
            // checkBox_visualbasic
            // 
            this.checkBox_visualbasic.AutoSize = true;
            this.checkBox_visualbasic.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_visualbasic.Location = new System.Drawing.Point(45, 142);
            this.checkBox_visualbasic.Name = "checkBox_visualbasic";
            this.checkBox_visualbasic.Size = new System.Drawing.Size(139, 30);
            this.checkBox_visualbasic.TabIndex = 3;
            this.checkBox_visualbasic.Text = "Visual Basic ";
            this.checkBox_visualbasic.UseVisualStyleBackColor = true;
            // 
            // button_compras
            // 
            this.button_compras.Location = new System.Drawing.Point(45, 272);
            this.button_compras.Name = "button_compras";
            this.button_compras.Size = new System.Drawing.Size(207, 76);
            this.button_compras.TabIndex = 6;
            this.button_compras.Text = "Comprar ";
            this.button_compras.UseVisualStyleBackColor = true;
            this.button_compras.Click += new System.EventHandler(this.Button_compras_Click);
            // 
            // button_salir
            // 
            this.button_salir.Location = new System.Drawing.Point(483, 272);
            this.button_salir.Name = "button_salir";
            this.button_salir.Size = new System.Drawing.Size(195, 76);
            this.button_salir.TabIndex = 8;
            this.button_salir.Text = "Salir";
            this.button_salir.UseVisualStyleBackColor = true;
            this.button_salir.Click += new System.EventHandler(this.Button_salir_Click);
            // 
            // radioButton_tarjeta
            // 
            this.radioButton_tarjeta.AutoSize = true;
            this.radioButton_tarjeta.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_tarjeta.Location = new System.Drawing.Point(509, 80);
            this.radioButton_tarjeta.Name = "radioButton_tarjeta";
            this.radioButton_tarjeta.Size = new System.Drawing.Size(244, 25);
            this.radioButton_tarjeta.TabIndex = 9;
            this.radioButton_tarjeta.TabStop = true;
            this.radioButton_tarjeta.Text = "Tarjeta de crédito";
            this.radioButton_tarjeta.UseVisualStyleBackColor = true;
            // 
            // radioButton_paypal
            // 
            this.radioButton_paypal.AutoSize = true;
            this.radioButton_paypal.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_paypal.Location = new System.Drawing.Point(509, 132);
            this.radioButton_paypal.Name = "radioButton_paypal";
            this.radioButton_paypal.Size = new System.Drawing.Size(100, 25);
            this.radioButton_paypal.TabIndex = 10;
            this.radioButton_paypal.TabStop = true;
            this.radioButton_paypal.Text = "PayPal";
            this.radioButton_paypal.UseVisualStyleBackColor = true;
            this.radioButton_paypal.CheckedChanged += new System.EventHandler(this.RadioButton_paypal_CheckedChanged);
            // 
            // ventana2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 450);
            this.Controls.Add(this.radioButton_paypal);
            this.Controls.Add(this.radioButton_tarjeta);
            this.Controls.Add(this.button_salir);
            this.Controls.Add(this.button_compras);
            this.Controls.Add(this.checkBox_visualbasic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox_visual);
            this.Name = "ventana2";
            this.Load += new System.EventHandler(this.Ventana2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_visual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_visualbasic;
        private System.Windows.Forms.Button button_compras;
        private System.Windows.Forms.Button button_salir;
        private System.Windows.Forms.RadioButton radioButton_tarjeta;
        private System.Windows.Forms.RadioButton radioButton_paypal;
    }
}