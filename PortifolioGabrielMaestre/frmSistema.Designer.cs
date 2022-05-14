
namespace PortifolioGabrielMaestre
{
    partial class frmSistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSistema));
            this.lnklblGithub = new System.Windows.Forms.LinkLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuGeralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.adcUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.userManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenu1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenu2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.otherMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFunctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFunction3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionSystemDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especialMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disabledMenuAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.functionMySqlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lnklblGithub
            // 
            this.lnklblGithub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnklblGithub.AutoSize = true;
            this.lnklblGithub.BackColor = System.Drawing.Color.White;
            this.lnklblGithub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblGithub.Location = new System.Drawing.Point(666, 542);
            this.lnklblGithub.Name = "lnklblGithub";
            this.lnklblGithub.Size = new System.Drawing.Size(113, 15);
            this.lnklblGithub.TabIndex = 1;
            this.lnklblGithub.TabStop = true;
            this.lnklblGithub.Text = "Link do Repositório";
            this.lnklblGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblGithub_LinkClicked);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGeralToolStripMenuItem,
            this.otherMenuToolStripMenuItem,
            this.especialMenuToolStripMenuItem,
            this.disabledMenuAdminToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuGeralToolStripMenuItem
            // 
            this.menuGeralToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.adcUsuarioToolStripMenuItem,
            this.editUserToolStripMenuItem,
            this.searchUserToolStripMenuItem,
            this.disableUserToolStripMenuItem,
            this.toolStripSeparator2,
            this.userManagerToolStripMenuItem});
            this.menuGeralToolStripMenuItem.Name = "menuGeralToolStripMenuItem";
            this.menuGeralToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.menuGeralToolStripMenuItem.Text = "Menu Geral (visual)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // adcUsuarioToolStripMenuItem
            // 
            this.adcUsuarioToolStripMenuItem.Name = "adcUsuarioToolStripMenuItem";
            this.adcUsuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adcUsuarioToolStripMenuItem.Text = "Add User";
            // 
            // editUserToolStripMenuItem
            // 
            this.editUserToolStripMenuItem.Name = "editUserToolStripMenuItem";
            this.editUserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editUserToolStripMenuItem.Text = "Edit User";
            // 
            // searchUserToolStripMenuItem
            // 
            this.searchUserToolStripMenuItem.Name = "searchUserToolStripMenuItem";
            this.searchUserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.searchUserToolStripMenuItem.Text = "Search User";
            // 
            // disableUserToolStripMenuItem
            // 
            this.disableUserToolStripMenuItem.Name = "disableUserToolStripMenuItem";
            this.disableUserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.disableUserToolStripMenuItem.Text = "Disable User";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // userManagerToolStripMenuItem
            // 
            this.userManagerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenu1ToolStripMenuItem,
            this.toolStripSeparator3,
            this.toolStripTextBox1,
            this.toolStripSeparator4,
            this.toolStripMenuItem1});
            this.userManagerToolStripMenuItem.Name = "userManagerToolStripMenuItem";
            this.userManagerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.userManagerToolStripMenuItem.Text = "User Manager";
            // 
            // subMenu1ToolStripMenuItem
            // 
            this.subMenu1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenu2ToolStripMenuItem,
            this.toolStripComboBox1});
            this.subMenu1ToolStripMenuItem.Name = "subMenu1ToolStripMenuItem";
            this.subMenu1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.subMenu1ToolStripMenuItem.Text = "SubMenu1";
            // 
            // subMenu2ToolStripMenuItem
            // 
            this.subMenu2ToolStripMenuItem.Name = "subMenu2ToolStripMenuItem";
            this.subMenu2ToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.subMenu2ToolStripMenuItem.Text = "SubMenu2";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "OPT1",
            "OPT2",
            "OPT3"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "Alert";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // otherMenuToolStripMenuItem
            // 
            this.otherMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFunctionToolStripMenuItem,
            this.newFunction3ToolStripMenuItem,
            this.functionSystemDetailsToolStripMenuItem,
            this.functionMySqlToolStripMenuItem});
            this.otherMenuToolStripMenuItem.Name = "otherMenuToolStripMenuItem";
            this.otherMenuToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.otherMenuToolStripMenuItem.Text = "Esse menu funciona";
            // 
            // newFunctionToolStripMenuItem
            // 
            this.newFunctionToolStripMenuItem.Name = "newFunctionToolStripMenuItem";
            this.newFunctionToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.newFunctionToolStripMenuItem.Text = "Function Timer";
            this.newFunctionToolStripMenuItem.Click += new System.EventHandler(this.newFunctionToolStripMenuItem_Click);
            // 
            // newFunction3ToolStripMenuItem
            // 
            this.newFunction3ToolStripMenuItem.Name = "newFunction3ToolStripMenuItem";
            this.newFunction3ToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.newFunction3ToolStripMenuItem.Text = "Function Browser";
            this.newFunction3ToolStripMenuItem.Click += new System.EventHandler(this.newFunction3ToolStripMenuItem_Click);
            // 
            // functionSystemDetailsToolStripMenuItem
            // 
            this.functionSystemDetailsToolStripMenuItem.Name = "functionSystemDetailsToolStripMenuItem";
            this.functionSystemDetailsToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.functionSystemDetailsToolStripMenuItem.Text = "Function System Details";
            this.functionSystemDetailsToolStripMenuItem.Click += new System.EventHandler(this.functionSystemDetailsToolStripMenuItem_Click);
            // 
            // especialMenuToolStripMenuItem
            // 
            this.especialMenuToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.especialMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lastMenuToolStripMenuItem});
            this.especialMenuToolStripMenuItem.Name = "especialMenuToolStripMenuItem";
            this.especialMenuToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.especialMenuToolStripMenuItem.Text = "Especial Menu";
            // 
            // lastMenuToolStripMenuItem
            // 
            this.lastMenuToolStripMenuItem.Name = "lastMenuToolStripMenuItem";
            this.lastMenuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lastMenuToolStripMenuItem.Text = "Exemplo";
            // 
            // disabledMenuAdminToolStripMenuItem
            // 
            this.disabledMenuAdminToolStripMenuItem.Enabled = false;
            this.disabledMenuAdminToolStripMenuItem.Name = "disabledMenuAdminToolStripMenuItem";
            this.disabledMenuAdminToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.disabledMenuAdminToolStripMenuItem.Text = "Disabled Menu (Admin)";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 539);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Não é recomendado ter uma Imagem de fundo quando se usa IsMdiContainer";
            // 
            // functionMySqlToolStripMenuItem
            // 
            this.functionMySqlToolStripMenuItem.Name = "functionMySqlToolStripMenuItem";
            this.functionMySqlToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.functionMySqlToolStripMenuItem.Text = "Function MySql";
            this.functionMySqlToolStripMenuItem.Click += new System.EventHandler(this.functionMySqlToolStripMenuItem_Click);
            // 
            // frmSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lnklblGithub);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Name = "frmSistema";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSistema_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnklblGithub;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuGeralToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem adcUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem userManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subMenu1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subMenu2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem otherMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especialMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lastMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disabledMenuAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFunctionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFunction3ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem functionSystemDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem functionMySqlToolStripMenuItem;
    }
}