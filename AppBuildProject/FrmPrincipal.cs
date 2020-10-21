using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace AppBuildProject
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void ExecutarCmdGit(string comando)
        {
            System.Diagnostics.Process ProcessoGit = System.Diagnostics.Process.Start("cmd.exe", @"/C " + comando);                  
            ProcessoGit.WaitForExit(); // Aguardar finalizar git clone            
        }

        private void ClonarGit()
        {
            try
            {
                btnGerarEXE.Enabled = false;

                string DirEXE = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory.ToString());
                string RepWork = @"" + TxtFolderWork.Text;

                lstLogDeploy.Items.Clear();
                lstLogDeploy.Items.Add("----------------Inicio(Clone)----------------");

                if (Directory.Exists(RepWork))
                {
                    ExecutarCMD(@"RMDIR " + RepWork + "/S /Q");
                    lstLogDeploy.Items.Add("Excluído Diretório: " + RepWork);
                }

                ExecutarCMD(@"mkdir " + RepWork);
                lstLogDeploy.Items.Add("Criado Diretório: " + RepWork);
                string RepSip = lstRepositorio.Items[0].ToString(); // Repositório SIP - GIT
                lstLogDeploy.Items.Add("Clonando: " + TxtDeployBrach.Text + " >> " + TxtFolderWork.Text);
                lstLogDeploy.Items.Add("Aguarde fim do processo git clone... ");

                ExecutarCmdGit("cd " + RepWork + " & git clone -b " + TxtDeployBrach.Text + " " + RepSip);                
                ExecutarCMD("cd " + RepWork + @"\sip-logistica & git status >> " + DirEXE + @"\git_status.txt");

                // -- Ler arquivo Status git //
                if (LerArquivoLog())
                {
                    TxtDeployBrach.ForeColor = System.Drawing.Color.DarkGreen;
                    lstLogDeploy.Items.Add("git clone finalizado.");
                    lstLogDeploy.Items.Add("----------------Fim(Clone)----------------");
                    PercorrerArquivosTrabalho();
                    btnGerarEXE.Enabled = true;
                }
                else
                {
                    lstLogDeploy.Items.Add("git clone finalizado com erros.");
                    lstLogDeploy.Items.Add("Ajustar problemas e clonar branch novamente.");
                }                
            }
            catch (Exception ex)
            {
                lstLogDeploy.Items.Add(ex.Message.ToString());
                TxtDeployBrach.ForeColor = System.Drawing.Color.DarkRed;
                lstLogDeploy.ForeColor = System.Drawing.Color.DarkRed;
            }
        }

        private bool LerArquivoLog()
        {
            string arquivo = @"./git_status.txt";

            if (File.Exists(arquivo))
            {
                try
                {                    
                    using (StreamReader sr = new StreamReader(arquivo))
                    {
                        String linha;

                        while (((linha = sr.ReadLine()) != null) && ((linha = sr.ReadLine()) != string.Empty))
                        {
                            lstLogDeploy.Items.Add(linha);
                        }                     
                    }

                    File.Delete(arquivo);

                    return true;
                }
                catch (Exception ex)
                {
                    lstLogDeploy.Items.Add(ex.Message);                    
                    lstLogDeploy.ForeColor = System.Drawing.Color.DarkRed;
                    return false;
                }
            }
            else
            {
                lstLogDeploy.Items.Add(" O arquivo [" + arquivo + "] não foi localizado!");
                lstLogDeploy.ForeColor = System.Drawing.Color.DarkRed;
                return false;
            }
        }

        private void ExecutarCMD(string comando)
        {           
            using (System.Diagnostics.Process processo = new System.Diagnostics.Process())
            {
                processo.StartInfo.FileName = Environment.GetEnvironmentVariable("comspec");
                // Formata a string para passar como argumento para o cmd.exe
                processo.StartInfo.Arguments = string.Format("/c {0}", comando);

                processo.StartInfo.RedirectStandardOutput = true;
                processo.StartInfo.UseShellExecute = false;
                processo.StartInfo.CreateNoWindow = true;

                processo.Start();
                processo.WaitForExit();
                processo.StandardOutput.ReadToEnd();                
            }
        }

        private void PercorrerArquivosTrabalho()
        {
            string DiretorioSip = TxtFolderWork.Text + @"\sip-logistica";

            lstLogFilesWork.Items.Clear();

            if (Directory.Exists(DiretorioSip))
            {
                foreach (string s in System.IO.Directory.GetFiles(DiretorioSip))
                {
                    lstLogFilesWork.Items.Add(s + Environment.NewLine);
                }
                lbTotalArquivos.Text = lstLogFilesWork.Items.Count.ToString();
            }                
        }

        private void CarregarConfiguracoesXML()
        {
            XmlReader xmlReader = XmlReader.Create(@"./configuracao.xml");

            while (xmlReader.Read())
            {
                if (xmlReader.IsStartElement()) 
                {
                    //return only when you have START tag  
                    switch (xmlReader.Name.ToString())
                    {
                        case "Git":
                            lstRepositorio.Items.Add(xmlReader.ReadString());
                            break;
                        case "Delphi":
                            lstConfigDelphi.Items.Add(xmlReader.ReadString());
                            break;
                        case "FolderWork":
                            TxtFolderWork.Text = xmlReader.ReadString();
                            break;
                    }
                }             
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            CarregarConfiguracoesXML();            
        }               

        private void BtnTestesDev_Click(object sender, EventArgs e)
        {
            // testes Dev
        }

        private void BtnClonarGit_Click(object sender, EventArgs e)
        {
            BtnClonarGit.Enabled = false;
            ClonarGit();
            BtnClonarGit.Enabled = true;
        }
    }   
}
