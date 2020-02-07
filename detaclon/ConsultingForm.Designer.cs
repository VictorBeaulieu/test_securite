namespace detaclon
{
    partial class ConsultingForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultingForm));
            this.btn_exit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.affichageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.magasinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rayonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.utilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deconnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.detaclonProductDataSet = new detaclon.detaclonProductDataSet();
            this.detaclonProductDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_add_product = new System.Windows.Forms.Button();
            this.btn_add_store = new System.Windows.Forms.Button();
            this.btn_add_aisle = new System.Windows.Forms.Button();
            this.btn_del_product = new System.Windows.Forms.Button();
            this.btn_del_aisle = new System.Windows.Forms.Button();
            this.btn_del_store = new System.Windows.Forms.Button();
            this.btn_del_user = new System.Windows.Forms.Button();
            this.btn_add_user = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox_firstname = new System.Windows.Forms.TextBox();
            this.textbox_lastname = new System.Windows.Forms.TextBox();
            this.textbox_loginID = new System.Windows.Forms.TextBox();
            this.textbox_pwd = new System.Windows.Forms.TextBox();
            this.textbox_role = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_validate_profil = new System.Windows.Forms.Button();
            this.product_quantity = new System.Windows.Forms.NumericUpDown();
            this.btn_product_modify = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textbox_ville = new System.Windows.Forms.TextBox();
            this.tb_ville = new System.Windows.Forms.TextBox();
            this.btn_rayon = new System.Windows.Forms.Button();
            this.btn_aisle_all = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detaclonProductDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detaclonProductDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(419, 415);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Quitter";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.affichageToolStripMenuItem1,
            this.optionToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(506, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // affichageToolStripMenuItem1
            // 
            this.affichageToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.magasinToolStripMenuItem,
            this.rayonToolStripMenuItem,
            this.produitToolStripMenuItem});
            this.affichageToolStripMenuItem1.Name = "affichageToolStripMenuItem1";
            this.affichageToolStripMenuItem1.Size = new System.Drawing.Size(70, 20);
            this.affichageToolStripMenuItem1.Text = "Affichage";
            // 
            // magasinToolStripMenuItem
            // 
            this.magasinToolStripMenuItem.Image = global::detaclon.Properties.Resources.store;
            this.magasinToolStripMenuItem.Name = "magasinToolStripMenuItem";
            this.magasinToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.magasinToolStripMenuItem.Text = "Magasin";
            this.magasinToolStripMenuItem.Click += new System.EventHandler(this.magasinToolStripMenuItem_Click);
            // 
            // rayonToolStripMenuItem
            // 
            this.rayonToolStripMenuItem.Image = global::detaclon.Properties.Resources.aisle;
            this.rayonToolStripMenuItem.Name = "rayonToolStripMenuItem";
            this.rayonToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.rayonToolStripMenuItem.Text = "Rayon";
            this.rayonToolStripMenuItem.Click += new System.EventHandler(this.rayonToolStripMenuItem_Click);
            // 
            // produitToolStripMenuItem
            // 
            this.produitToolStripMenuItem.Image = global::detaclon.Properties.Resources.product;
            this.produitToolStripMenuItem.Name = "produitToolStripMenuItem";
            this.produitToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.produitToolStripMenuItem.Text = "Produit";
            this.produitToolStripMenuItem.Click += new System.EventHandler(this.produitToolStripMenuItem_Click);
            // 
            // optionToolStripMenuItem1
            // 
            this.optionToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilisateurToolStripMenuItem,
            this.monCompteToolStripMenuItem,
            this.deconnectionToolStripMenuItem});
            this.optionToolStripMenuItem1.Name = "optionToolStripMenuItem1";
            this.optionToolStripMenuItem1.Size = new System.Drawing.Size(56, 20);
            this.optionToolStripMenuItem1.Text = "Option";
            // 
            // utilisateurToolStripMenuItem
            // 
            this.utilisateurToolStripMenuItem.Image = global::detaclon.Properties.Resources.user;
            this.utilisateurToolStripMenuItem.Name = "utilisateurToolStripMenuItem";
            this.utilisateurToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.utilisateurToolStripMenuItem.Text = "Gestion utilisateur";
            this.utilisateurToolStripMenuItem.Click += new System.EventHandler(this.utilisateurToolStripMenuItem_Click);
            // 
            // monCompteToolStripMenuItem
            // 
            this.monCompteToolStripMenuItem.Image = global::detaclon.Properties.Resources.user_2;
            this.monCompteToolStripMenuItem.Name = "monCompteToolStripMenuItem";
            this.monCompteToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.monCompteToolStripMenuItem.Text = "Mon compte";
            this.monCompteToolStripMenuItem.Click += new System.EventHandler(this.monCompteToolStripMenuItem_Click);
            // 
            // deconnectionToolStripMenuItem
            // 
            this.deconnectionToolStripMenuItem.Image = global::detaclon.Properties.Resources.logout;
            this.deconnectionToolStripMenuItem.Name = "deconnectionToolStripMenuItem";
            this.deconnectionToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.deconnectionToolStripMenuItem.Text = "Déconnexion";
            this.deconnectionToolStripMenuItem.Click += new System.EventHandler(this.deconnectionToolStripMenuItem_Click);
            // 
            // affichageToolStripMenuItem
            // 
            this.affichageToolStripMenuItem.Name = "affichageToolStripMenuItem";
            this.affichageToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.affichageToolStripMenuItem.Text = "Affichage";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Déconnexion";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 27);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(401, 411);
            this.dataGridView.TabIndex = 4;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // detaclonProductDataSet
            // 
            this.detaclonProductDataSet.DataSetName = "detaclonProductDataSet";
            this.detaclonProductDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detaclonProductDataSetBindingSource
            // 
            this.detaclonProductDataSetBindingSource.DataSource = this.detaclonProductDataSet;
            this.detaclonProductDataSetBindingSource.Position = 0;
            // 
            // btn_add_product
            // 
            this.btn_add_product.Location = new System.Drawing.Point(419, 27);
            this.btn_add_product.Name = "btn_add_product";
            this.btn_add_product.Size = new System.Drawing.Size(75, 39);
            this.btn_add_product.TabIndex = 6;
            this.btn_add_product.Text = "Ajouter un produit";
            this.btn_add_product.UseVisualStyleBackColor = true;
            this.btn_add_product.Click += new System.EventHandler(this.btn_add_product_Click);
            // 
            // btn_add_store
            // 
            this.btn_add_store.Location = new System.Drawing.Point(419, 27);
            this.btn_add_store.Name = "btn_add_store";
            this.btn_add_store.Size = new System.Drawing.Size(75, 39);
            this.btn_add_store.TabIndex = 7;
            this.btn_add_store.Text = "Ajouter un magasin";
            this.btn_add_store.UseVisualStyleBackColor = true;
            this.btn_add_store.Click += new System.EventHandler(this.btn_add_store_Click);
            // 
            // btn_add_aisle
            // 
            this.btn_add_aisle.Location = new System.Drawing.Point(419, 27);
            this.btn_add_aisle.Name = "btn_add_aisle";
            this.btn_add_aisle.Size = new System.Drawing.Size(75, 39);
            this.btn_add_aisle.TabIndex = 8;
            this.btn_add_aisle.Text = "Ajouter un rayon";
            this.btn_add_aisle.UseVisualStyleBackColor = true;
            this.btn_add_aisle.Click += new System.EventHandler(this.btn_add_aisle_Click);
            // 
            // btn_del_product
            // 
            this.btn_del_product.Location = new System.Drawing.Point(419, 72);
            this.btn_del_product.Name = "btn_del_product";
            this.btn_del_product.Size = new System.Drawing.Size(75, 39);
            this.btn_del_product.TabIndex = 9;
            this.btn_del_product.Text = "Supprimer un produit";
            this.btn_del_product.UseVisualStyleBackColor = true;
            this.btn_del_product.Click += new System.EventHandler(this.btn_del_product_Click);
            // 
            // btn_del_aisle
            // 
            this.btn_del_aisle.Location = new System.Drawing.Point(419, 72);
            this.btn_del_aisle.Name = "btn_del_aisle";
            this.btn_del_aisle.Size = new System.Drawing.Size(75, 39);
            this.btn_del_aisle.TabIndex = 10;
            this.btn_del_aisle.Text = "Supprimer un rayon";
            this.btn_del_aisle.UseVisualStyleBackColor = true;
            this.btn_del_aisle.Click += new System.EventHandler(this.btn_del_aisle_Click);
            // 
            // btn_del_store
            // 
            this.btn_del_store.Location = new System.Drawing.Point(419, 72);
            this.btn_del_store.Name = "btn_del_store";
            this.btn_del_store.Size = new System.Drawing.Size(75, 39);
            this.btn_del_store.TabIndex = 11;
            this.btn_del_store.Text = "Supprimer un magasin";
            this.btn_del_store.UseVisualStyleBackColor = true;
            this.btn_del_store.Click += new System.EventHandler(this.btn_del_store_Click);
            // 
            // btn_del_user
            // 
            this.btn_del_user.Location = new System.Drawing.Point(419, 72);
            this.btn_del_user.Name = "btn_del_user";
            this.btn_del_user.Size = new System.Drawing.Size(75, 39);
            this.btn_del_user.TabIndex = 13;
            this.btn_del_user.Text = "Supprimer un utilisateur";
            this.btn_del_user.UseVisualStyleBackColor = true;
            this.btn_del_user.Click += new System.EventHandler(this.btn_del_user_Click);
            // 
            // btn_add_user
            // 
            this.btn_add_user.Location = new System.Drawing.Point(419, 27);
            this.btn_add_user.Name = "btn_add_user";
            this.btn_add_user.Size = new System.Drawing.Size(75, 39);
            this.btn_add_user.TabIndex = 12;
            this.btn_add_user.Text = "Ajouter un utilisateur";
            this.btn_add_user.UseVisualStyleBackColor = true;
            this.btn_add_user.Click += new System.EventHandler(this.btn_add_user_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Prénom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Login ID";
            // 
            // textbox_firstname
            // 
            this.textbox_firstname.Enabled = false;
            this.textbox_firstname.Location = new System.Drawing.Point(105, 27);
            this.textbox_firstname.Name = "textbox_firstname";
            this.textbox_firstname.ReadOnly = true;
            this.textbox_firstname.Size = new System.Drawing.Size(100, 20);
            this.textbox_firstname.TabIndex = 18;
            // 
            // textbox_lastname
            // 
            this.textbox_lastname.Enabled = false;
            this.textbox_lastname.Location = new System.Drawing.Point(105, 55);
            this.textbox_lastname.Name = "textbox_lastname";
            this.textbox_lastname.ReadOnly = true;
            this.textbox_lastname.Size = new System.Drawing.Size(100, 20);
            this.textbox_lastname.TabIndex = 19;
            // 
            // textbox_loginID
            // 
            this.textbox_loginID.Enabled = false;
            this.textbox_loginID.Location = new System.Drawing.Point(105, 81);
            this.textbox_loginID.Name = "textbox_loginID";
            this.textbox_loginID.ReadOnly = true;
            this.textbox_loginID.Size = new System.Drawing.Size(100, 20);
            this.textbox_loginID.TabIndex = 20;
            // 
            // textbox_pwd
            // 
            this.textbox_pwd.Enabled = false;
            this.textbox_pwd.Location = new System.Drawing.Point(105, 107);
            this.textbox_pwd.Name = "textbox_pwd";
            this.textbox_pwd.ReadOnly = true;
            this.textbox_pwd.Size = new System.Drawing.Size(100, 20);
            this.textbox_pwd.TabIndex = 21;
            // 
            // textbox_role
            // 
            this.textbox_role.Enabled = false;
            this.textbox_role.Location = new System.Drawing.Point(105, 133);
            this.textbox_role.Name = "textbox_role";
            this.textbox_role.ReadOnly = true;
            this.textbox_role.Size = new System.Drawing.Size(100, 20);
            this.textbox_role.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Mot de passe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Rôle";
            // 
            // btn_validate_profil
            // 
            this.btn_validate_profil.Location = new System.Drawing.Point(419, 27);
            this.btn_validate_profil.Name = "btn_validate_profil";
            this.btn_validate_profil.Size = new System.Drawing.Size(75, 39);
            this.btn_validate_profil.TabIndex = 25;
            this.btn_validate_profil.Text = "Changer mot de passe";
            this.btn_validate_profil.UseVisualStyleBackColor = true;
            this.btn_validate_profil.Click += new System.EventHandler(this.btn_validate_profil_Click);
            // 
            // product_quantity
            // 
            this.product_quantity.Location = new System.Drawing.Point(419, 166);
            this.product_quantity.Name = "product_quantity";
            this.product_quantity.Size = new System.Drawing.Size(75, 20);
            this.product_quantity.TabIndex = 27;
            // 
            // btn_product_modify
            // 
            this.btn_product_modify.Location = new System.Drawing.Point(419, 192);
            this.btn_product_modify.Name = "btn_product_modify";
            this.btn_product_modify.Size = new System.Drawing.Size(75, 39);
            this.btn_product_modify.TabIndex = 13;
            this.btn_product_modify.Text = "Modifier la quantité";
            this.btn_product_modify.UseVisualStyleBackColor = true;
            this.btn_product_modify.Click += new System.EventHandler(this.btn_product_modify_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Ville";
            // 
            // textbox_ville
            // 
            this.textbox_ville.Enabled = false;
            this.textbox_ville.Location = new System.Drawing.Point(105, 159);
            this.textbox_ville.Name = "textbox_ville";
            this.textbox_ville.ReadOnly = true;
            this.textbox_ville.Size = new System.Drawing.Size(100, 20);
            this.textbox_ville.TabIndex = 28;
            // 
            // tb_ville
            // 
            this.tb_ville.Location = new System.Drawing.Point(419, 166);
            this.tb_ville.Name = "tb_ville";
            this.tb_ville.Size = new System.Drawing.Size(75, 20);
            this.tb_ville.TabIndex = 30;
            // 
            // btn_rayon
            // 
            this.btn_rayon.Location = new System.Drawing.Point(419, 192);
            this.btn_rayon.Name = "btn_rayon";
            this.btn_rayon.Size = new System.Drawing.Size(75, 56);
            this.btn_rayon.TabIndex = 13;
            this.btn_rayon.Text = "Afficher les rayons d\'une ville";
            this.btn_rayon.UseVisualStyleBackColor = true;
            this.btn_rayon.Click += new System.EventHandler(this.btn_rayon_Click);
            // 
            // btn_aisle_all
            // 
            this.btn_aisle_all.Location = new System.Drawing.Point(419, 254);
            this.btn_aisle_all.Name = "btn_aisle_all";
            this.btn_aisle_all.Size = new System.Drawing.Size(75, 39);
            this.btn_aisle_all.TabIndex = 13;
            this.btn_aisle_all.Text = "Afficher tout";
            this.btn_aisle_all.UseVisualStyleBackColor = true;
            this.btn_aisle_all.Click += new System.EventHandler(this.btn_aisle_all_Click);
            // 
            // ConsultingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 450);
            this.Controls.Add(this.tb_ville);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textbox_ville);
            this.Controls.Add(this.product_quantity);
            this.Controls.Add(this.btn_validate_profil);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textbox_role);
            this.Controls.Add(this.textbox_pwd);
            this.Controls.Add(this.textbox_loginID);
            this.Controls.Add(this.textbox_lastname);
            this.Controls.Add(this.textbox_firstname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_rayon);
            this.Controls.Add(this.btn_product_modify);
            this.Controls.Add(this.btn_aisle_all);
            this.Controls.Add(this.btn_del_user);
            this.Controls.Add(this.btn_add_user);
            this.Controls.Add(this.btn_del_store);
            this.Controls.Add(this.btn_del_aisle);
            this.Controls.Add(this.btn_del_product);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_add_store);
            this.Controls.Add(this.btn_add_product);
            this.Controls.Add(this.btn_add_aisle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ConsultingForm";
            this.Text = "Detaclon";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detaclonProductDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detaclonProductDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem affichageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem affichageToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deconnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem magasinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rayonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produitToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView;
        private detaclonProductDataSet detaclonProductDataSet;
        private System.Windows.Forms.BindingSource detaclonProductDataSetBindingSource;
        private System.Windows.Forms.Button btn_add_product;
        private System.Windows.Forms.Button btn_add_store;
        private System.Windows.Forms.Button btn_add_aisle;
        private System.Windows.Forms.Button btn_del_product;
        private System.Windows.Forms.Button btn_del_aisle;
        private System.Windows.Forms.Button btn_del_store;
        private System.Windows.Forms.ToolStripMenuItem utilisateurToolStripMenuItem;
        private System.Windows.Forms.Button btn_del_user;
        private System.Windows.Forms.Button btn_add_user;
        private System.Windows.Forms.ToolStripMenuItem monCompteToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbox_firstname;
        private System.Windows.Forms.TextBox textbox_lastname;
        private System.Windows.Forms.TextBox textbox_loginID;
        private System.Windows.Forms.TextBox textbox_pwd;
        private System.Windows.Forms.TextBox textbox_role;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_validate_profil;
        private System.Windows.Forms.NumericUpDown product_quantity;
        private System.Windows.Forms.Button btn_product_modify;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textbox_ville;
        private System.Windows.Forms.TextBox tb_ville;
        private System.Windows.Forms.Button btn_rayon;
        private System.Windows.Forms.Button btn_aisle_all;
    }
}