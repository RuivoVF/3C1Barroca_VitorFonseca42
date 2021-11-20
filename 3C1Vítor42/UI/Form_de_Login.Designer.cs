namespace _3C1Vítor42.UI
{
    partial class Form_de_Login
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
            this.lblemail = new System.Windows.Forms.Label();
            this.lblsenha = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.linkesqueci = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(162, 78);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(42, 13);
            this.lblemail.TabIndex = 0;
            this.lblemail.Text = "E-MAIL";
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Location = new System.Drawing.Point(162, 202);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(44, 13);
            this.lblsenha.TabIndex = 1;
            this.lblsenha.Text = "SENHA";
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(469, 125);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(147, 37);
            this.btnEntrar.TabIndex = 2;
            this.btnEntrar.Text = "ENTRAR !!!!!";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(309, 75);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(141, 20);
            this.txtemail.TabIndex = 3;
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(309, 199);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '*';
            this.txtsenha.Size = new System.Drawing.Size(141, 20);
            this.txtsenha.TabIndex = 4;
            // 
            // linkesqueci
            // 
            this.linkesqueci.AutoSize = true;
            this.linkesqueci.Location = new System.Drawing.Point(268, 318);
            this.linkesqueci.Name = "linkesqueci";
            this.linkesqueci.Size = new System.Drawing.Size(205, 13);
            this.linkesqueci.TabIndex = 5;
            this.linkesqueci.TabStop = true;
            this.linkesqueci.Text = "ESQUECI MINHA SENHA AAAAAAAAAA";
            this.linkesqueci.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkesqueci_LinkClicked);
            // 
            // Form_de_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkesqueci);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.lblemail);
            this.Name = "Form_de_Login";
            this.Text = "Form_de_Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.LinkLabel linkesqueci;
    }
}