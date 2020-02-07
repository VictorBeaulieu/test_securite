namespace detaclon
{
    partial class ChangePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_current_PWD = new System.Windows.Forms.TextBox();
            this.textbox_new_PWD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_validate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mot de passe actuel";
            // 
            // textbox_current_PWD
            // 
            this.textbox_current_PWD.Enabled = false;
            this.textbox_current_PWD.Location = new System.Drawing.Point(12, 25);
            this.textbox_current_PWD.Name = "textbox_current_PWD";
            this.textbox_current_PWD.ReadOnly = true;
            this.textbox_current_PWD.Size = new System.Drawing.Size(260, 20);
            this.textbox_current_PWD.TabIndex = 1;
            // 
            // textbox_new_PWD
            // 
            this.textbox_new_PWD.Location = new System.Drawing.Point(12, 64);
            this.textbox_new_PWD.Name = "textbox_new_PWD";
            this.textbox_new_PWD.Size = new System.Drawing.Size(260, 20);
            this.textbox_new_PWD.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nouveau mot de passe";
            // 
            // btn_validate
            // 
            this.btn_validate.Location = new System.Drawing.Point(197, 90);
            this.btn_validate.Name = "btn_validate";
            this.btn_validate.Size = new System.Drawing.Size(75, 23);
            this.btn_validate.TabIndex = 4;
            this.btn_validate.Text = "Valider";
            this.btn_validate.UseVisualStyleBackColor = true;
            this.btn_validate.Click += new System.EventHandler(this.btn_validate_Click);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 121);
            this.Controls.Add(this.btn_validate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textbox_new_PWD);
            this.Controls.Add(this.textbox_current_PWD);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePasswordForm";
            this.Text = "Mot de passe";
            this.Load += new System.EventHandler(this.ChangePasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbox_current_PWD;
        private System.Windows.Forms.TextBox textbox_new_PWD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_validate;
    }
}