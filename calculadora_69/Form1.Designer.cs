namespace calculadora_69
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
            this.btnsuma = new System.Windows.Forms.Button();
            this.btnresta = new System.Windows.Forms.Button();
            this.btnmultiplica = new System.Windows.Forms.Button();
            this.btndivision = new System.Windows.Forms.Button();
            this.lblresultado = new System.Windows.Forms.Label();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnsuma
            // 
            this.btnsuma.Location = new System.Drawing.Point(93, 264);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(75, 23);
            this.btnsuma.TabIndex = 0;
            this.btnsuma.Text = "Suma";
            this.btnsuma.UseVisualStyleBackColor = true;
            this.btnsuma.Click += new System.EventHandler(this.btnsuma_Click);
            // 
            // btnresta
            // 
            this.btnresta.Location = new System.Drawing.Point(254, 264);
            this.btnresta.Name = "btnresta";
            this.btnresta.Size = new System.Drawing.Size(75, 23);
            this.btnresta.TabIndex = 1;
            this.btnresta.Text = "Resta";
            this.btnresta.UseVisualStyleBackColor = true;
            this.btnresta.Click += new System.EventHandler(this.btnresta_Click);
            // 
            // btnmultiplica
            // 
            this.btnmultiplica.Location = new System.Drawing.Point(442, 264);
            this.btnmultiplica.Name = "btnmultiplica";
            this.btnmultiplica.Size = new System.Drawing.Size(75, 23);
            this.btnmultiplica.TabIndex = 2;
            this.btnmultiplica.Text = "Multiplica";
            this.btnmultiplica.UseVisualStyleBackColor = true;
            this.btnmultiplica.Click += new System.EventHandler(this.btnmultiplica_Click);
            // 
            // btndivision
            // 
            this.btndivision.Location = new System.Drawing.Point(638, 264);
            this.btndivision.Name = "btndivision";
            this.btndivision.Size = new System.Drawing.Size(75, 23);
            this.btndivision.TabIndex = 3;
            this.btndivision.Text = "Division";
            this.btndivision.UseVisualStyleBackColor = true;
            this.btndivision.Click += new System.EventHandler(this.btndivision_Click);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(371, 68);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(69, 16);
            this.lblresultado.TabIndex = 4;
            this.lblresultado.Text = "Resultado";
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(483, 136);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(100, 22);
            this.txtnum2.TabIndex = 5;
            this.txtnum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnum2_KeyPress);
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(206, 136);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(100, 22);
            this.txtnum1.TabIndex = 6;
            this.txtnum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnum1_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.btndivision);
            this.Controls.Add(this.btnmultiplica);
            this.Controls.Add(this.btnresta);
            this.Controls.Add(this.btnsuma);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsuma;
        private System.Windows.Forms.Button btnresta;
        private System.Windows.Forms.Button btnmultiplica;
        private System.Windows.Forms.Button btndivision;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.TextBox txtnum1;
    }
}

