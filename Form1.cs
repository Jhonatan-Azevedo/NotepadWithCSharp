using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorTxt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Menu Arquivo
        private void mArquivoNova_Click(object sender, EventArgs e)
        {
            txtConteudo.Clear();
            mArquivoSalvar.Enabled = true;
            Text = Application.ProductName;

        }
        private void mArquivoNovaJanela_Click(object sender, EventArgs e)
        {
            //var f = new Form1();
            //f.Show();

            Thread t = new Thread(() => Application.Run(new Form1()));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void mArquivoAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
                dialog.Title = "Abrir...";
                dialog.Filter = "rich text file| *.rtf| texto| *.txt| todos| *.*";
            DialogResult result = dialog.ShowDialog();
            if (result != DialogResult.Cancel && result != DialogResult.Abort)
            {
                if (File.Exists(dialog.FileName))
                {
                    var file = new FileInfo(dialog.FileName);
                    Text = Application.ProductName + "-" + file.Name;

                    Gerenciador.FolderPath = file.DirectoryName + "\\";
                    Gerenciador.FileName = file.Name.Remove(file.Name.LastIndexOf("."));
                    Gerenciador.FileExt = file.Extension;

                    StreamReader stream = null;
                    try
                    {
                        stream = new StreamReader(file.FullName, true);
                        txtConteudo.Text += stream.ReadToEnd();
                        mArquivoSalvar.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Formato de arquivo não suportado. \n" + ex.Message);
                    }
                    finally
                    {
                        stream.Close();
                    }
                }
            }
        }

        private void mArquivoSalvar_Click(object sender, EventArgs e)
        {
            if (File.Exists(Gerenciador.FilePath))
            {
                SalvarArquivo(Gerenciador.FilePath);
            }
            else
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Title = "Salvar...";
                dialog.Filter = "rich text file|*.rtf|texto|*.txt|todos|*.*";
                dialog.CheckFileExists = false;
                dialog.CheckPathExists = true;

                var result = dialog.ShowDialog();

                if (result != DialogResult.Cancel && result != DialogResult.Abort)
                {
                    SalvarArquivo(dialog.FileName);
                }
            }
        }

        private void mArquivoSalvarComo_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Salvar Como...";
            dialog.Filter = "rich text file|*.rtf|texto|*.txt|todos| *.*";
            dialog.CheckFileExists = false;
            dialog.CheckPathExists = true;

            var result = dialog.ShowDialog();

            if (result != DialogResult.Cancel && result != DialogResult.Abort)
            {
                SalvarArquivo(dialog.FileName);
            }
        }

        private void SalvarArquivo(string path)
        {
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(path, false);
                writer.Write(txtConteudo.Text);

                var file = new FileInfo(path);
                Gerenciador.FolderPath = file.DirectoryName + "\\";
                Gerenciador.FileName = file.Name.Remove(file.Name.LastIndexOf("."));
                Gerenciador.FileExt = file.Extension;
                Text = Application.ProductName + "-" + file.Name;
                mArquivoSalvar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro Salvar Arquivo: \n" + ex.Message);
            }
            finally
            {
                writer.Close();
            }

        }

        private void mArquivoSair_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente sair?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) { Application.Exit(); }

        }

        private void txtConteudo_TextChanged(object sender, EventArgs e)
        {
            mArquivoSalvar.Enabled = true;

        }



        #endregion

        #region Menu Editar
        private void mEditarDesfazer_Click(object sender, EventArgs e)
        {
            txtConteudo.Undo();
        }

        private void mEditarRefazer_Click(object sender, EventArgs e)
        {
            txtConteudo.Redo();
        }

        private void mEditarRecortar_Click(object sender, EventArgs e)
        {
            txtConteudo.Cut();
        }

        private void mEditarCopiar_Click(object sender, EventArgs e)
        {
            txtConteudo.Copy();
        }

        private void mEditarColar_Click(object sender, EventArgs e)
        {
            txtConteudo.Paste();
        }

        private void mEditarExcluir_Click(object sender, EventArgs e)
        {
            txtConteudo.Text = txtConteudo.Text.Remove(txtConteudo.SelectionStart, txtConteudo.SelectedText.Length);
        }

        private void mEditarDataEHora_Click(object sender, EventArgs e)
        {
            int index = txtConteudo.SelectionStart;
            string dataHora = DateTime.Now.ToString(); 
            if(txtConteudo.SelectionStart == txtConteudo.SelectedText.Length)
            {
                txtConteudo.Text = txtConteudo.Text + dataHora;
                txtConteudo.SelectionStart = index + dataHora.Length;
                return;
            }
            string temp = "";
            for(int i =0; i< txtConteudo.Text.Length; i++)
            {
                if (i == txtConteudo.SelectionStart)
                {
                    temp += dataHora;
                    temp += txtConteudo.Text[i];
                }
                else
                {
                    temp += txtConteudo.Text[i];
                }
            }
            txtConteudo.Text = temp;
            txtConteudo.SelectionStart = index + dataHora.Length;
        }
        #endregion

        #region Menu Formatar

        private void mFormatarQuebraDeLinha_Click(object sender, EventArgs e)
        {
            txtConteudo.WordWrap = mFormatarQuebraDeLinha.Checked;
        }

        private void mFormatarFonte_Click(object sender, EventArgs e)
        {
            var font = new FontDialog();
            font.ShowColor = true;
            font.ShowEffects = true;

            font.Font = txtConteudo.Font;
            font.Color = txtConteudo.ForeColor;

            DialogResult result = font.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtConteudo.Font = font.Font;
                txtConteudo.ForeColor = font.Color;
            }
        }
        #endregion

        #region Menu Exibir
        private void mExibirZoomAmpliar_Click(object sender, EventArgs e)
        {
            txtConteudo.ZoomFactor += 0.1f;
            AtualizarStatusBar(txtConteudo.ZoomFactor);
        }

        private void mExibirZoomReduzir_Click(object sender, EventArgs e)
        {
            txtConteudo.ZoomFactor -= 0.1f;
            AtualizarStatusBar(txtConteudo.ZoomFactor);
        }

        private void mExibirZoomRestaurar_Click(object sender, EventArgs e)
        {
            txtConteudo.ZoomFactor = 1f;
            AtualizarStatusBar(txtConteudo.ZoomFactor);
        }
        private void mExibirBarraDeStatus_Click(object sender, EventArgs e)
        {
            statusBar.Visible = mExibirBarraDeStatus.Checked;
        }

        private void AtualizarStatusBar(float zoom)
        {
            statusBarLabel.Text = $"{Math.Round(zoom * 100)}%";
        }
        #endregion

        #region Menu Ajuda
        private void mAjudaExibirAjudar_Click(object sender, EventArgs e)
        {
            var f = new FormAjuda();
            f.Show();
        }

        private void mAjudaSobreOJhowTxt_Click(object sender, EventArgs e)
        {
            var f = new FormSobre();
            f.Show();
        }
        #endregion
    }
}
