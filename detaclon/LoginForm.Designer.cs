namespace detaclon
{
    partial class LoginForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_connect = new System.Windows.Forms.Button();
            this.login_PWD = new System.Windows.Forms.TextBox();
            this.login_ID = new System.Windows.Forms.TextBox();
            this.label_PWD = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(197, 67);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "Quitter";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(197, 22);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 23);
            this.btn_connect.TabIndex = 1;
            this.btn_connect.Text = "Connexion";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // login_PWD
            // 
            this.login_PWD.Location = new System.Drawing.Point(12, 70);
            this.login_PWD.Name = "login_PWD";
            this.login_PWD.Size = new System.Drawing.Size(174, 20);
            this.login_PWD.TabIndex = 4;
            // 
            // login_ID
            // 
            this.login_ID.Location = new System.Drawing.Point(12, 25);
            this.login_ID.Name = "login_ID";
            this.login_ID.Size = new System.Drawing.Size(174, 20);
            this.login_ID.TabIndex = 5;
            // 
            // label_PWD
            // 
            this.label_PWD.AutoSize = true;
            this.label_PWD.Location = new System.Drawing.Point(12, 54);
            this.label_PWD.Name = "label_PWD";
            this.label_PWD.Size = new System.Drawing.Size(71, 13);
            this.label_PWD.TabIndex = 6;
            this.label_PWD.Text = "Mot de passe";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(12, 9);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(84, 13);
            this.label_ID.TabIndex = 7;
            this.label_ID.Text = "Nom d\'utilisateur";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.label_PWD);
            this.Controls.Add(this.login_ID);
            this.Controls.Add(this.login_PWD);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.btn_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "Authentification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.TextBox login_PWD;
        private System.Windows.Forms.TextBox login_ID;
        private System.Windows.Forms.Label label_PWD;
        private System.Windows.Forms.Label label_ID;
    }
}

