namespace academica
{
    partial class login
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
            this.lblClaveLogin = new System.Windows.Forms.Label();
            this.txtClaveLogin = new System.Windows.Forms.TextBox();
            this.lblIdUsuarioogin = new System.Windows.Forms.Label();
            this.txtIdUsuarioLogin = new System.Windows.Forms.TextBox();
            this.LblLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblClaveLogin
            // 
            this.lblClaveLogin.AutoSize = true;
            this.lblClaveLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveLogin.Location = new System.Drawing.Point(94, 260);
            this.lblClaveLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClaveLogin.Name = "lblClaveLogin";
            this.lblClaveLogin.Size = new System.Drawing.Size(80, 29);
            this.lblClaveLogin.TabIndex = 7;
            this.lblClaveLogin.Text = "Clave:";
            // 
            // txtClaveLogin
            // 
            this.txtClaveLogin.Location = new System.Drawing.Point(228, 267);
            this.txtClaveLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtClaveLogin.Name = "txtClaveLogin";
            this.txtClaveLogin.Size = new System.Drawing.Size(333, 22);
            this.txtClaveLogin.TabIndex = 6;
            // 
            // lblIdUsuarioogin
            // 
            this.lblIdUsuarioogin.AutoSize = true;
            this.lblIdUsuarioogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdUsuarioogin.Location = new System.Drawing.Point(94, 148);
            this.lblIdUsuarioogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdUsuarioogin.Name = "lblIdUsuarioogin";
            this.lblIdUsuarioogin.Size = new System.Drawing.Size(102, 29);
            this.lblIdUsuarioogin.TabIndex = 5;
            this.lblIdUsuarioogin.Text = "Usuario:";
            // 
            // txtIdUsuarioLogin
            // 
            this.txtIdUsuarioLogin.Location = new System.Drawing.Point(228, 152);
            this.txtIdUsuarioLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdUsuarioLogin.Name = "txtIdUsuarioLogin";
            this.txtIdUsuarioLogin.Size = new System.Drawing.Size(132, 22);
            this.txtIdUsuarioLogin.TabIndex = 4;
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogin.Location = new System.Drawing.Point(194, 25);
            this.LblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(329, 29);
            this.LblLogin.TabIndex = 8;
            this.LblLogin.Text = "Bienvenido ingrese sus datos";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblLogin);
            this.Controls.Add(this.lblClaveLogin);
            this.Controls.Add(this.txtClaveLogin);
            this.Controls.Add(this.lblIdUsuarioogin);
            this.Controls.Add(this.txtIdUsuarioLogin);
            this.Name = "login";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClaveLogin;
        private System.Windows.Forms.TextBox txtClaveLogin;
        private System.Windows.Forms.Label lblIdUsuarioogin;
        private System.Windows.Forms.TextBox txtIdUsuarioLogin;
        private System.Windows.Forms.Label LblLogin;
    }
}