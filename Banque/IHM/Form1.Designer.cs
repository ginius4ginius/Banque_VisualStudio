namespace Banque
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opérationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créditerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.débiterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.découvertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label = new System.Windows.Forms.Label();
            this.tb = new System.Windows.Forms.TextBox();
            this.bt = new System.Windows.Forms.Button();
            this.dataGd = new System.Windows.Forms.DataGridView();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGd)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opérationToolStripMenuItem,
            this.modificationToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(462, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opérationToolStripMenuItem
            // 
            this.opérationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créditerToolStripMenuItem,
            this.débiterToolStripMenuItem});
            this.opérationToolStripMenuItem.Name = "opérationToolStripMenuItem";
            this.opérationToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.opérationToolStripMenuItem.Text = "Opération";
            // 
            // créditerToolStripMenuItem
            // 
            this.créditerToolStripMenuItem.Name = "créditerToolStripMenuItem";
            this.créditerToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.créditerToolStripMenuItem.Text = "Créditer";
            this.créditerToolStripMenuItem.Click += new System.EventHandler(this.créditerToolStripMenuItem_Click);
            // 
            // débiterToolStripMenuItem
            // 
            this.débiterToolStripMenuItem.Name = "débiterToolStripMenuItem";
            this.débiterToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.débiterToolStripMenuItem.Text = "Débiter";
            this.débiterToolStripMenuItem.Click += new System.EventHandler(this.DebiterToolStripMenuItem_Click);
            // 
            // modificationToolStripMenuItem
            // 
            this.modificationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.découvertToolStripMenuItem,
            this.clientToolStripMenuItem});
            this.modificationToolStripMenuItem.Name = "modificationToolStripMenuItem";
            this.modificationToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.modificationToolStripMenuItem.Text = "Modification";
            // 
            // découvertToolStripMenuItem
            // 
            this.découvertToolStripMenuItem.Name = "découvertToolStripMenuItem";
            this.découvertToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.découvertToolStripMenuItem.Text = "Découvert";
            this.découvertToolStripMenuItem.Click += new System.EventHandler(this.DecouvertToolStripMenuItem_Click);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.clientToolStripMenuItem.Text = "Client";
            this.clientToolStripMenuItem.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(79, 221);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 13);
            this.label.TabIndex = 2;
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(191, 218);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(100, 20);
            this.tb.TabIndex = 3;
            // 
            // bt
            // 
            this.bt.Location = new System.Drawing.Point(127, 266);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(128, 36);
            this.bt.TabIndex = 4;
            this.bt.UseVisualStyleBackColor = true;
            this.bt.Click += new System.EventHandler(this.bt_Click);
            // 
            // dataGd
            // 
            this.dataGd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGd.Location = new System.Drawing.Point(13, 28);
            this.dataGd.Name = "dataGd";
            this.dataGd.Size = new System.Drawing.Size(408, 184);
            this.dataGd.TabIndex = 7;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(191, 242);
            this.tb2.Name = "tb2";
            this.tb2.ReadOnly = true;
            this.tb2.Size = new System.Drawing.Size(100, 20);
            this.tb2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 242);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Découvert autorisé : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 309);
            this.Controls.Add(this.dataGd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.bt);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.label);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Gestion Comptes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opérationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créditerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem débiterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem découvertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Button bt;
        public System.Windows.Forms.DataGridView dataGd;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Label label1;
    }
}

