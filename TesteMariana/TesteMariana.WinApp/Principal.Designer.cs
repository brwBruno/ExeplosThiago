namespace TesteMariana.WinApp
{
    partial class Principal
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.panControl = new System.Windows.Forms.Panel();
            this.toolbar = new System.Windows.Forms.ToolStrip();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnSet = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.description = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.caToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disciplinasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matériasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.toolbar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 450);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(832, 30);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(100, 25);
            this.lblStatus.Text = "mensagem";
            // 
            // panControl
            // 
            this.panControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panControl.Location = new System.Drawing.Point(18, 105);
            this.panControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panControl.Name = "panControl";
            this.panControl.Size = new System.Drawing.Size(796, 315);
            this.panControl.TabIndex = 6;
            // 
            // toolbar
            // 
            this.toolbar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDelete,
            this.btnSet,
            this.btnAdd,
            this.toolStripSeparator1,
            this.description});
            this.toolbar.Location = new System.Drawing.Point(0, 35);
            this.toolbar.Name = "toolbar";
            this.toolbar.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolbar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolbar.Size = new System.Drawing.Size(832, 31);
            this.toolbar.TabIndex = 5;
            this.toolbar.Text = "toolStrip1";
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelete.Enabled = false;
            this.btnDelete.Image = global::TesteMariana.WinApp.Properties.Resources.Symbol_Pencil;
            this.btnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnDelete.Size = new System.Drawing.Size(40, 28);
            this.btnDelete.Text = "toolStripButton3";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSet
            // 
            this.btnSet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSet.Enabled = false;
            this.btnSet.Image = global::TesteMariana.WinApp.Properties.Resources.Symbol_Delete;
            this.btnSet.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSet.Name = "btnSet";
            this.btnSet.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSet.Size = new System.Drawing.Size(40, 28);
            this.btnSet.Text = "toolStripButton2";
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Enabled = false;
            this.btnAdd.Image = global::TesteMariana.WinApp.Properties.Resources.Symbol_Add;
            this.btnAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAdd.Size = new System.Drawing.Size(40, 28);
            this.btnAdd.Text = "toolStripButton1";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // description
            // 
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(0, 28);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(832, 35);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // caToolStripMenuItem
            // 
            this.caToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testeToolStripMenuItem,
            this.serieToolStripMenuItem,
            this.disciplinasToolStripMenuItem,
            this.matériasToolStripMenuItem,
            this.questãoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.caToolStripMenuItem.Name = "caToolStripMenuItem";
            this.caToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
            this.caToolStripMenuItem.Text = "Cadastros";
            // 
            // testeToolStripMenuItem
            // 
            this.testeToolStripMenuItem.Enabled = false;
            this.testeToolStripMenuItem.Name = "testeToolStripMenuItem";
            this.testeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.testeToolStripMenuItem.Size = new System.Drawing.Size(243, 30);
            this.testeToolStripMenuItem.Text = "Testes";
            // 
            // serieToolStripMenuItem
            // 
            this.serieToolStripMenuItem.Name = "serieToolStripMenuItem";
            this.serieToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.serieToolStripMenuItem.Size = new System.Drawing.Size(243, 30);
            this.serieToolStripMenuItem.Text = "Série";
            this.serieToolStripMenuItem.Click += new System.EventHandler(this.serieToolStripMenuItem_Click);
            // 
            // disciplinasToolStripMenuItem
            // 
            this.disciplinasToolStripMenuItem.Name = "disciplinasToolStripMenuItem";
            this.disciplinasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.disciplinasToolStripMenuItem.Size = new System.Drawing.Size(243, 30);
            this.disciplinasToolStripMenuItem.Text = "Disciplinas";
            this.disciplinasToolStripMenuItem.Click += new System.EventHandler(this.disciplinasToolStripMenuItem_Click);
            // 
            // matériasToolStripMenuItem
            // 
            this.matériasToolStripMenuItem.Name = "matériasToolStripMenuItem";
            this.matériasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.matériasToolStripMenuItem.Size = new System.Drawing.Size(243, 30);
            this.matériasToolStripMenuItem.Text = "Matérias";
            this.matériasToolStripMenuItem.Click += new System.EventHandler(this.matériasToolStripMenuItem_Click);
            // 
            // questãoToolStripMenuItem
            // 
            this.questãoToolStripMenuItem.Name = "questãoToolStripMenuItem";
            this.questãoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.questãoToolStripMenuItem.Size = new System.Drawing.Size(243, 30);
            this.questãoToolStripMenuItem.Text = "Questão";
            this.questãoToolStripMenuItem.Click += new System.EventHandler(this.questãoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(243, 30);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 480);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panControl);
            this.Controls.Add(this.toolbar);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mariana";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panControl;
        private System.Windows.Forms.ToolStrip toolbar;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnSet;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel description;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem caToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disciplinasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matériasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem questãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripMenuItem serieToolStripMenuItem;
    }
}

