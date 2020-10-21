namespace AppBuildProject
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.pnlConfigs = new System.Windows.Forms.Panel();
            this.gpbConfigs = new System.Windows.Forms.GroupBox();
            this.gpbPerfilUsuario = new System.Windows.Forms.GroupBox();
            this.rbTester = new System.Windows.Forms.RadioButton();
            this.rbDesenv = new System.Windows.Forms.RadioButton();
            this.lstConfigDelphi = new System.Windows.Forms.ListBox();
            this.BtnClonarGit = new System.Windows.Forms.Button();
            this.TxtDeployBrach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstRepositorio = new System.Windows.Forms.ListBox();
            this.pnlRepositorioLocal = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbTotalArquivos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstLogFilesWork = new System.Windows.Forms.ListBox();
            this.TxtFolderWork = new System.Windows.Forms.TextBox();
            this.pnlLogDeploy = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lstLogDeploy = new System.Windows.Forms.ListBox();
            this.pnlRodaPe = new System.Windows.Forms.Panel();
            this.btnGerarEXE = new System.Windows.Forms.Button();
            this.BtnTestesDev = new System.Windows.Forms.Button();
            this.pnlConfigs.SuspendLayout();
            this.gpbConfigs.SuspendLayout();
            this.gpbPerfilUsuario.SuspendLayout();
            this.pnlRepositorioLocal.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlLogDeploy.SuspendLayout();
            this.pnlRodaPe.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlConfigs
            // 
            this.pnlConfigs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlConfigs.Controls.Add(this.gpbConfigs);
            this.pnlConfigs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlConfigs.Location = new System.Drawing.Point(0, 0);
            this.pnlConfigs.Name = "pnlConfigs";
            this.pnlConfigs.Size = new System.Drawing.Size(981, 158);
            this.pnlConfigs.TabIndex = 0;
            // 
            // gpbConfigs
            // 
            this.gpbConfigs.Controls.Add(this.gpbPerfilUsuario);
            this.gpbConfigs.Controls.Add(this.lstConfigDelphi);
            this.gpbConfigs.Controls.Add(this.BtnClonarGit);
            this.gpbConfigs.Controls.Add(this.TxtDeployBrach);
            this.gpbConfigs.Controls.Add(this.label3);
            this.gpbConfigs.Controls.Add(this.lstRepositorio);
            this.gpbConfigs.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpbConfigs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbConfigs.Location = new System.Drawing.Point(0, 0);
            this.gpbConfigs.Name = "gpbConfigs";
            this.gpbConfigs.Size = new System.Drawing.Size(977, 153);
            this.gpbConfigs.TabIndex = 0;
            this.gpbConfigs.TabStop = false;
            this.gpbConfigs.Text = " Configuração:Repositório(GIT)/Delphi";
            // 
            // gpbPerfilUsuario
            // 
            this.gpbPerfilUsuario.Controls.Add(this.rbTester);
            this.gpbPerfilUsuario.Controls.Add(this.rbDesenv);
            this.gpbPerfilUsuario.Location = new System.Drawing.Point(776, 19);
            this.gpbPerfilUsuario.Name = "gpbPerfilUsuario";
            this.gpbPerfilUsuario.Size = new System.Drawing.Size(198, 121);
            this.gpbPerfilUsuario.TabIndex = 3;
            this.gpbPerfilUsuario.TabStop = false;
            this.gpbPerfilUsuario.Text = "Perfil de Usuário";
            // 
            // rbTester
            // 
            this.rbTester.AutoSize = true;
            this.rbTester.Location = new System.Drawing.Point(16, 65);
            this.rbTester.Name = "rbTester";
            this.rbTester.Size = new System.Drawing.Size(124, 17);
            this.rbTester.TabIndex = 1;
            this.rbTester.Text = "Qualidade/Tester";
            this.rbTester.UseVisualStyleBackColor = true;
            // 
            // rbDesenv
            // 
            this.rbDesenv.AutoSize = true;
            this.rbDesenv.Checked = true;
            this.rbDesenv.Location = new System.Drawing.Point(16, 28);
            this.rbDesenv.Name = "rbDesenv";
            this.rbDesenv.Size = new System.Drawing.Size(110, 17);
            this.rbDesenv.TabIndex = 1;
            this.rbDesenv.TabStop = true;
            this.rbDesenv.Text = "Desenvolvedor";
            this.rbDesenv.UseVisualStyleBackColor = true;
            // 
            // lstConfigDelphi
            // 
            this.lstConfigDelphi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstConfigDelphi.FormattingEnabled = true;
            this.lstConfigDelphi.Location = new System.Drawing.Point(391, 19);
            this.lstConfigDelphi.Name = "lstConfigDelphi";
            this.lstConfigDelphi.Size = new System.Drawing.Size(359, 121);
            this.lstConfigDelphi.TabIndex = 2;
            // 
            // BtnClonarGit
            // 
            this.BtnClonarGit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnClonarGit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnClonarGit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClonarGit.Location = new System.Drawing.Point(264, 119);
            this.BtnClonarGit.Name = "BtnClonarGit";
            this.BtnClonarGit.Size = new System.Drawing.Size(100, 22);
            this.BtnClonarGit.TabIndex = 5;
            this.BtnClonarGit.Text = "Clonar Branch";
            this.BtnClonarGit.UseVisualStyleBackColor = false;
            this.BtnClonarGit.Click += new System.EventHandler(this.BtnClonarGit_Click);
            // 
            // TxtDeployBrach
            // 
            this.TxtDeployBrach.ForeColor = System.Drawing.Color.DarkRed;
            this.TxtDeployBrach.Location = new System.Drawing.Point(5, 120);
            this.TxtDeployBrach.Name = "TxtDeployBrach";
            this.TxtDeployBrach.Size = new System.Drawing.Size(256, 20);
            this.TxtDeployBrach.TabIndex = 4;
            this.TxtDeployBrach.Text = "feature/Winterfell_WIN-493";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Deploy de branch";
            // 
            // lstRepositorio
            // 
            this.lstRepositorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRepositorio.FormattingEnabled = true;
            this.lstRepositorio.Location = new System.Drawing.Point(4, 19);
            this.lstRepositorio.Name = "lstRepositorio";
            this.lstRepositorio.Size = new System.Drawing.Size(360, 82);
            this.lstRepositorio.TabIndex = 1;
            // 
            // pnlRepositorioLocal
            // 
            this.pnlRepositorioLocal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlRepositorioLocal.Controls.Add(this.groupBox2);
            this.pnlRepositorioLocal.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRepositorioLocal.Location = new System.Drawing.Point(0, 158);
            this.pnlRepositorioLocal.Name = "pnlRepositorioLocal";
            this.pnlRepositorioLocal.Size = new System.Drawing.Size(981, 158);
            this.pnlRepositorioLocal.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbTotalArquivos);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lstLogFilesWork);
            this.groupBox2.Controls.Add(this.TxtFolderWork);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(977, 158);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Repositório de Trabalho(local):";
            // 
            // lbTotalArquivos
            // 
            this.lbTotalArquivos.AutoSize = true;
            this.lbTotalArquivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalArquivos.ForeColor = System.Drawing.Color.DarkRed;
            this.lbTotalArquivos.Location = new System.Drawing.Point(218, 13);
            this.lbTotalArquivos.Name = "lbTotalArquivos";
            this.lbTotalArquivos.Size = new System.Drawing.Size(35, 13);
            this.lbTotalArquivos.TabIndex = 0;
            this.lbTotalArquivos.Text = "0000";
            this.lbTotalArquivos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(111, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total de Arquivos:";
            // 
            // lstLogFilesWork
            // 
            this.lstLogFilesWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLogFilesWork.FormattingEnabled = true;
            this.lstLogFilesWork.Location = new System.Drawing.Point(4, 30);
            this.lstLogFilesWork.Name = "lstLogFilesWork";
            this.lstLogFilesWork.Size = new System.Drawing.Size(968, 121);
            this.lstLogFilesWork.TabIndex = 2;
            // 
            // TxtFolderWork
            // 
            this.TxtFolderWork.Location = new System.Drawing.Point(271, 10);
            this.TxtFolderWork.Name = "TxtFolderWork";
            this.TxtFolderWork.ReadOnly = true;
            this.TxtFolderWork.Size = new System.Drawing.Size(591, 18);
            this.TxtFolderWork.TabIndex = 1;
            // 
            // pnlLogDeploy
            // 
            this.pnlLogDeploy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLogDeploy.Controls.Add(this.label1);
            this.pnlLogDeploy.Controls.Add(this.lstLogDeploy);
            this.pnlLogDeploy.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogDeploy.Location = new System.Drawing.Point(0, 316);
            this.pnlLogDeploy.Name = "pnlLogDeploy";
            this.pnlLogDeploy.Size = new System.Drawing.Size(981, 158);
            this.pnlLogDeploy.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log for Deploy";
            // 
            // lstLogDeploy
            // 
            this.lstLogDeploy.ForeColor = System.Drawing.Color.DarkGreen;
            this.lstLogDeploy.FormattingEnabled = true;
            this.lstLogDeploy.Location = new System.Drawing.Point(4, 20);
            this.lstLogDeploy.Name = "lstLogDeploy";
            this.lstLogDeploy.Size = new System.Drawing.Size(970, 134);
            this.lstLogDeploy.TabIndex = 1;
            // 
            // pnlRodaPe
            // 
            this.pnlRodaPe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlRodaPe.Controls.Add(this.btnGerarEXE);
            this.pnlRodaPe.Controls.Add(this.BtnTestesDev);
            this.pnlRodaPe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRodaPe.Location = new System.Drawing.Point(0, 478);
            this.pnlRodaPe.Name = "pnlRodaPe";
            this.pnlRodaPe.Size = new System.Drawing.Size(981, 41);
            this.pnlRodaPe.TabIndex = 3;
            // 
            // btnGerarEXE
            // 
            this.btnGerarEXE.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnGerarEXE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarEXE.Location = new System.Drawing.Point(828, 7);
            this.btnGerarEXE.Name = "btnGerarEXE";
            this.btnGerarEXE.Size = new System.Drawing.Size(146, 27);
            this.btnGerarEXE.TabIndex = 1;
            this.btnGerarEXE.Text = "Gerar EXE";
            this.btnGerarEXE.UseVisualStyleBackColor = false;
            // 
            // BtnTestesDev
            // 
            this.BtnTestesDev.Location = new System.Drawing.Point(4, 7);
            this.BtnTestesDev.Name = "BtnTestesDev";
            this.BtnTestesDev.Size = new System.Drawing.Size(146, 27);
            this.BtnTestesDev.TabIndex = 0;
            this.BtnTestesDev.Text = "Testes Dev";
            this.BtnTestesDev.UseVisualStyleBackColor = true;
            this.BtnTestesDev.Click += new System.EventHandler(this.BtnTestesDev_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 519);
            this.Controls.Add(this.pnlRodaPe);
            this.Controls.Add(this.pnlLogDeploy);
            this.Controls.Add(this.pnlRepositorioLocal);
            this.Controls.Add(this.pnlConfigs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deploy  de Projetos Delphi(Team Protege)";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.pnlConfigs.ResumeLayout(false);
            this.gpbConfigs.ResumeLayout(false);
            this.gpbConfigs.PerformLayout();
            this.gpbPerfilUsuario.ResumeLayout(false);
            this.gpbPerfilUsuario.PerformLayout();
            this.pnlRepositorioLocal.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlLogDeploy.ResumeLayout(false);
            this.pnlLogDeploy.PerformLayout();
            this.pnlRodaPe.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlConfigs;
        private System.Windows.Forms.GroupBox gpbConfigs;
        private System.Windows.Forms.Button BtnClonarGit;
        private System.Windows.Forms.TextBox TxtDeployBrach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstRepositorio;
        private System.Windows.Forms.ListBox lstConfigDelphi;
        private System.Windows.Forms.GroupBox gpbPerfilUsuario;
        private System.Windows.Forms.Panel pnlRepositorioLocal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbTotalArquivos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstLogFilesWork;
        private System.Windows.Forms.TextBox TxtFolderWork;
        private System.Windows.Forms.Panel pnlLogDeploy;
        private System.Windows.Forms.Panel pnlRodaPe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstLogDeploy;
        private System.Windows.Forms.Button btnGerarEXE;
        private System.Windows.Forms.Button BtnTestesDev;
        private System.Windows.Forms.RadioButton rbTester;
        private System.Windows.Forms.RadioButton rbDesenv;
    }
}

