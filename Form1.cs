using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace EditorTXT
{
    public partial class Form1 : Form
    {
        Thread t1;
        public Form1()
        {
            InitializeComponent();
        }

        private void menuBar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        #region MenuArquivo

        private void mArquivo_Novo_Click(object sender, EventArgs e)
        {
            txt_Conteudo.Clear();
            mArquivo_Salvar.Enabled = true;
            Text = Application.ProductName;
        }

        private void mArquivo_Abrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Abrir...";
            dialog.Filter = "Richie Text File | *.rtf|texto|*.txt|todos|*.*";

            DialogResult result = dialog.ShowDialog();
            if (result != DialogResult.Cancel && result != DialogResult.Abort)
            {
                if (File.Exists(dialog.FileName))
                {
                    FileInfo file = new FileInfo(dialog.FileName);
                    Text = Application.ProductName + " - " + file.Name;

                    Gerenciador.FolderPath = file.DirectoryName + "\\";
                    Gerenciador.FileName = file.Name.Remove(file.Name.LastIndexOf("."));
                    Gerenciador.FileExt = file.Extension;

                    StreamReader stream = null;

                    try
                    {
                        stream = new StreamReader(file.FullName, true);
                        txt_Conteudo.Text = stream.ReadToEnd();

                        mArquivo_Salvar.Enabled = true;
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Formato de Arquivo não Suportado. \n" + ex.Message);
                    }
                    finally
                    {
                        stream.Close();
                    }
                }
            }
        }

        private void mArquivo_Salvar_Click(object sender, EventArgs e)
        {
            if (File.Exists(Gerenciador.FilePath))
            {
                SalvarArquivo(Gerenciador.FilePath);
            }
            else
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Title = "Salvar";
                dialog.Filter = "Richie Text File | *.rtf|texto|*.txt|todos|*.*";
                dialog.CheckFileExists = false;
                dialog.CheckPathExists = true;

                var result = dialog.ShowDialog();
                if(result != DialogResult.Cancel && result != DialogResult.Abort)
                {
                    SalvarArquivo(dialog.FileName);
                }
            }
        }

        private void mArquivoSalvar_Como_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Salvar Como?";
            dialog.Filter = "Richie Text File | *.rtf|texto|*.txt|todos|*.*";
            dialog.CheckFileExists = false;
            dialog.CheckPathExists = true;

            var result = dialog.ShowDialog();
            if (result != DialogResult.Cancel && result != DialogResult.Abort)
            {
                SalvarArquivo(dialog.FileName);
            }
        }

        private void mArquivoNova_Janela_Click(object sender, EventArgs e)
        {
            //this.Close();

            #region Thread Normal

            t1 = new Thread(AbrirNova);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();

            void AbrirNova(object obj)
            {
                Application.Run(new Form1());
            }

            #endregion

            #region Thread Metodo Lambda

            /*Thread t = new Thread(() => Application.Run(new Form1()));
            t.Start();*/

            #endregion

        }

        private void txt_Conteudo_TextChanged(object sender, EventArgs e)
        {
            mArquivo_Salvar.Enabled = true;
        }

        #region Metodo Salvar Arquivo

        private void SalvarArquivo(string path)
        {
            // Objeto responsavel por escrever arquivos.
            StreamWriter writer = null;

            try
            {
                writer = new StreamWriter(path, false);
                writer.Write(txt_Conteudo.Text);

                FileInfo file = new FileInfo(path);
                Gerenciador.FolderPath = file.DirectoryName + "\\";
                Gerenciador.FileName = file.Name.Remove(file.Name.LastIndexOf("."));
                Gerenciador.FileExt = file.Extension;

                Text = Application.ProductName + " - " + file.Name;

                mArquivo_Salvar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Salvar o Arquivo: \n" + ex.Message);
            }
            finally
            {
                writer.Close();
            }
        }

        #endregion

        #endregion

        #region Menu Editar

        private void mEditar_Copiar_Click(object sender, EventArgs e)
        {
            txt_Conteudo.Copy();
        }

        private void mEditar_Colar_Click(object sender, EventArgs e)
        {
            txt_Conteudo.Paste();
        }

        private void mEditar_Data_Hora_Click(object sender, EventArgs e)
        {
            int index = txt_Conteudo.SelectionStart;
            string dataHora = DateTime.Now.ToString();
            if (txt_Conteudo.SelectionStart == txt_Conteudo.Text.Length)
            {
                txt_Conteudo.Text = txt_Conteudo.Text + dataHora;
                txt_Conteudo.SelectionStart = index + dataHora.Length;
                return;
            }

            string temp = "";
            for(int i = 0; i < txt_Conteudo.Text.Length; i++)
            {
                if(i == txt_Conteudo.SelectionStart)
                {
                    temp += dataHora;
                    temp += txt_Conteudo.Text[i];
                }
                else
                {
                    temp += txt_Conteudo.Text[i];
                }
            }

            txt_Conteudo.Text = temp;
            txt_Conteudo.SelectionStart = index + dataHora.Length;
        }

        private void mEditar_Desfazer_Click(object sender, EventArgs e)
        {
            txt_Conteudo.Undo();
        }

        private void mEditar_Excluir_Click(object sender, EventArgs e)
        {
            txt_Conteudo.Text = txt_Conteudo.Text.Remove(txt_Conteudo.SelectionStart, txt_Conteudo.SelectedText.Length);
        }

        private void mEditar_Recortar_Click(object sender, EventArgs e)
        {
            txt_Conteudo.Cut();
        }

        private void mEditar_Refazer_Click(object sender, EventArgs e)
        {
            txt_Conteudo.Redo();
        }

        #endregion

        #region Menu Formatar

        private void mFormatar_Fonte_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            font.ShowColor = true;
            font.ShowEffects = true;

            font.Font = txt_Conteudo.Font;
            font.Color = txt_Conteudo.ForeColor;

            DialogResult result = font.ShowDialog();
            if (result == DialogResult.OK)
            {
                txt_Conteudo.Font = font.Font;
                txt_Conteudo.ForeColor = font.Color;
            }
        }

        private void mFormatarQuebra_Linha_Click(object sender, EventArgs e)
        {
            txt_Conteudo.WordWrap = mFormatarQuebra_Linha.Checked;
        }

        #endregion

        #region Menu Exibir

        private void mExibirZoom_Ampliar_Click(object sender, EventArgs e)
        {
            txt_Conteudo.ZoomFactor += 0.1f;
            AtualizarZoom_StatusBar(txt_Conteudo.ZoomFactor);
        }

        private void mExibirZoom_Reduzir_Click(object sender, EventArgs e)
        {
            txt_Conteudo.ZoomFactor -= 0.1f;
            AtualizarZoom_StatusBar(txt_Conteudo.ZoomFactor);
        }

        private void mExibirZoom_Restaurar_Click(object sender, EventArgs e)
        {
            txt_Conteudo.ZoomFactor = 1f;
            AtualizarZoom_StatusBar(txt_Conteudo.ZoomFactor);
        }

        private void mExibirBarra_Status_Click(object sender, EventArgs e)
        {
            statusBar.Visible = mExibirBarra_Status.Checked;
        }

        #region Metodo para atualizar zoom
        private void AtualizarZoom_StatusBar(float zoom)
        {
            status_BarLabel.Text = $"{Math.Round(zoom * 100)}%";
        }

        #endregion

        #endregion

        #region Menu Ajuda
        private void mAjudaExibir_Ajuda_Click(object sender, EventArgs e)
        {
            FormAjuda f = new FormAjuda();
            f.Show();
        }

        private void mAjuda_Sobre_Click(object sender, EventArgs e)
        {
            FormSobre f = new FormSobre();
            f.Show();
        }
        #endregion

        #region Menu Sair
        private void mSair_Click(object sender, EventArgs e)
        {
            #region Metodo Sair
            DialogResult res = MessageBox.Show("Deseja Encerrar A Aplicação?", "Sair?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(res == DialogResult.Yes)
            {
                Application.Exit();
            }
            #endregion
        }


        #endregion

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            txt_Conteudo.BackColor = Color.Black;
            txt_Conteudo.ForeColor = Color.LightGreen;

            txt_Conteudo.Text = "Void Conteudo" +
                "\n private void txt.conteudo" +
                "\n txt_Conteudo.BackColor = Color.Black;";
        }

        private void ModoEditor(object sender, EventArgs e)
        {
            contextMenuStrip1.Text = "Modo Editor";
        }
    }
}
