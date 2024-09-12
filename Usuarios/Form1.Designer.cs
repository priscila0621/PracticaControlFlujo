namespace Usuarios
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
            this.lblNick = new System.Windows.Forms.Label();
            this.tbNick = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbRegistrados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Usuarios";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNick
            // 
            this.lblNick.AutoSize = true;
            this.lblNick.Location = new System.Drawing.Point(39, 62);
            this.lblNick.Name = "lblNick";
            this.lblNick.Size = new System.Drawing.Size(32, 13);
            this.lblNick.TabIndex = 1;
            this.lblNick.Text = "Nick:";
            // 
            // tbNick
            // 
            this.tbNick.Location = new System.Drawing.Point(77, 59);
            this.tbNick.Name = "tbNick";
            this.tbNick.Size = new System.Drawing.Size(115, 20);
            this.tbNick.TabIndex = 2;
            this.tbNick.TextChanged += new System.EventHandler(this.tbNick_TextChanged);
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(7, 101);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(64, 13);
            this.lblpassword.TabIndex = 3;
            this.lblpassword.Text = "Contraseña:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(77, 98);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(117, 20);
            this.tbPassword.TabIndex = 4;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(59, 143);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(106, 30);
            this.btnRegistro.TabIndex = 5;
            this.btnRegistro.Text = "Registrar";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Usuarios registrados";
            // 
            // lbRegistrados
            // 
            this.lbRegistrados.FormattingEnabled = true;
            this.lbRegistrados.Location = new System.Drawing.Point(26, 219);
            this.lbRegistrados.Name = "lbRegistrados";
            this.lbRegistrados.Size = new System.Drawing.Size(191, 69);
            this.lbRegistrados.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 322);
            this.Controls.Add(this.lbRegistrados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.tbNick);
            this.Controls.Add(this.lblNick);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNick;
        private System.Windows.Forms.TextBox tbNick;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbRegistrados;
    }
}

