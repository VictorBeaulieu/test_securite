namespace detaclon
{
    partial class AddingUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddingUserForm));
            this.textbox_prenom = new System.Windows.Forms.TextBox();
            this.textbox_nom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.cb_role = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox_ville = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textbox_prenom
            // 
            this.textbox_prenom.Location = new System.Drawing.Point(12, 25);
            this.textbox_prenom.Name = "textbox_prenom";
            this.textbox_prenom.Size = new System.Drawing.Size(179, 20);
            this.textbox_prenom.TabIndex = 0;
            // 
            // textbox_nom
            // 
            this.textbox_nom.Location = new System.Drawing.Point(12, 64);
            this.textbox_nom.Name = "textbox_nom";
            this.textbox_nom.Size = new System.Drawing.Size(179, 20);
            this.textbox_nom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Prénom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Rôle";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(197, 141);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "Ajouter";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cb_role
            // 
            this.cb_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_role.FormattingEnabled = true;
            this.cb_role.Items.AddRange(new object[] {
            "patron",
            "chef de magasin",
            "employé"});
            this.cb_role.Location = new System.Drawing.Point(12, 103);
            this.cb_role.Name = "cb_role";
            this.cb_role.Size = new System.Drawing.Size(179, 21);
            this.cb_role.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ville";
            // 
            // textbox_ville
            // 
            this.textbox_ville.Location = new System.Drawing.Point(12, 144);
            this.textbox_ville.Name = "textbox_ville";
            this.textbox_ville.Size = new System.Drawing.Size(179, 20);
            this.textbox_ville.TabIndex = 12;
            // 
            // AddingUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 176);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textbox_ville);
            this.Controls.Add(this.cb_role);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox_nom);
            this.Controls.Add(this.textbox_prenom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddingUserForm";
            this.Text = "Ajout utilisateur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_prenom;
        private System.Windows.Forms.TextBox textbox_nom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox cb_role;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbox_ville;
    }
}