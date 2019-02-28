namespace InterfaceMagasinier
{
    partial class FormMagasinier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMagasinier));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.finishedOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unfinishedOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.unfinishedOrders1 = new InterfaceMagasinier.UnfinishedOrders();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.finishedOrdersToolStripMenuItem,
            this.unfinishedOrdersToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(55, 22);
            this.toolStripDropDownButton1.Text = "Orders";
            // 
            // finishedOrdersToolStripMenuItem
            // 
            this.finishedOrdersToolStripMenuItem.Name = "finishedOrdersToolStripMenuItem";
            this.finishedOrdersToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.finishedOrdersToolStripMenuItem.Text = "Finished orders";
            // 
            // unfinishedOrdersToolStripMenuItem
            // 
            this.unfinishedOrdersToolStripMenuItem.Name = "unfinishedOrdersToolStripMenuItem";
            this.unfinishedOrdersToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.unfinishedOrdersToolStripMenuItem.Text = "Unfinished orders";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(40, 22);
            this.toolStripButton1.Text = "Stock";
            // 
            // unfinishedOrders1
            // 
            this.unfinishedOrders1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unfinishedOrders1.Location = new System.Drawing.Point(21, 28);
            this.unfinishedOrders1.Name = "unfinishedOrders1";
            this.unfinishedOrders1.Size = new System.Drawing.Size(767, 449);
            this.unfinishedOrders1.TabIndex = 1;
            // 
            // FormMagasinier
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.unfinishedOrders1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormMagasinier";
            this.Text = "KitBox - Magasinier";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem finishedOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unfinishedOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private UnfinishedOrders unfinishedOrders1;
    }
}

