
namespace EditorTXT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.mArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivo_Novo = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivoNova_Janela = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivo_Abrir = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivo_Salvar = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivoSalvar_Como = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditar_Desfazer = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditar_Refazer = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditar_Copiar = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditar_Recortar = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditar_Colar = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditar_Excluir = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditar_Data_Hora = new System.Windows.Forms.ToolStripMenuItem();
            this.mFormatar = new System.Windows.Forms.ToolStripMenuItem();
            this.mFormatarQuebra_Linha = new System.Windows.Forms.ToolStripMenuItem();
            this.mFormatar_Fonte = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibir = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibir_Zoom = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibirZoom_Ampliar = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibirZoom_Reduzir = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibirZoom_Restaurar = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibirBarra_Status = new System.Windows.Forms.ToolStripMenuItem();
            this.mAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mAjudaExibir_Ajuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mAjuda_Sobre = new System.Windows.Forms.ToolStripMenuItem();
            this.mSair = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.status_BarLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.txt_Conteudo = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuBar.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.AllowItemReorder = true;
            this.menuBar.BackColor = System.Drawing.Color.Gainsboro;
            this.menuBar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mArquivo,
            this.mEditar,
            this.mFormatar,
            this.mExibir,
            this.mAjuda,
            this.mSair});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.MdiWindowListItem = this.mAjuda;
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(782, 28);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuStrip1";
            this.menuBar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuBar_ItemClicked);
            // 
            // mArquivo
            // 
            this.mArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mArquivo_Novo,
            this.mArquivoNova_Janela,
            this.mArquivo_Abrir,
            this.mArquivo_Salvar,
            this.mArquivoSalvar_Como});
            this.mArquivo.Name = "mArquivo";
            this.mArquivo.Size = new System.Drawing.Size(78, 24);
            this.mArquivo.Text = "Arquivo";
            // 
            // mArquivo_Novo
            // 
            this.mArquivo_Novo.Name = "mArquivo_Novo";
            this.mArquivo_Novo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mArquivo_Novo.Size = new System.Drawing.Size(272, 26);
            this.mArquivo_Novo.Text = "Novo";
            this.mArquivo_Novo.Click += new System.EventHandler(this.mArquivo_Novo_Click);
            // 
            // mArquivoNova_Janela
            // 
            this.mArquivoNova_Janela.Name = "mArquivoNova_Janela";
            this.mArquivoNova_Janela.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.mArquivoNova_Janela.Size = new System.Drawing.Size(272, 26);
            this.mArquivoNova_Janela.Text = "Nova Janela";
            this.mArquivoNova_Janela.Click += new System.EventHandler(this.mArquivoNova_Janela_Click);
            // 
            // mArquivo_Abrir
            // 
            this.mArquivo_Abrir.Name = "mArquivo_Abrir";
            this.mArquivo_Abrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mArquivo_Abrir.Size = new System.Drawing.Size(272, 26);
            this.mArquivo_Abrir.Text = "Abrir";
            this.mArquivo_Abrir.Click += new System.EventHandler(this.mArquivo_Abrir_Click);
            // 
            // mArquivo_Salvar
            // 
            this.mArquivo_Salvar.Name = "mArquivo_Salvar";
            this.mArquivo_Salvar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mArquivo_Salvar.Size = new System.Drawing.Size(272, 26);
            this.mArquivo_Salvar.Text = "Salvar";
            this.mArquivo_Salvar.Click += new System.EventHandler(this.mArquivo_Salvar_Click);
            // 
            // mArquivoSalvar_Como
            // 
            this.mArquivoSalvar_Como.Name = "mArquivoSalvar_Como";
            this.mArquivoSalvar_Como.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.mArquivoSalvar_Como.Size = new System.Drawing.Size(272, 26);
            this.mArquivoSalvar_Como.Text = "Salvar Como";
            this.mArquivoSalvar_Como.Click += new System.EventHandler(this.mArquivoSalvar_Como_Click);
            // 
            // mEditar
            // 
            this.mEditar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mEditar_Desfazer,
            this.mEditar_Refazer,
            this.mEditar_Copiar,
            this.mEditar_Recortar,
            this.mEditar_Colar,
            this.mEditar_Excluir,
            this.mEditar_Data_Hora});
            this.mEditar.Name = "mEditar";
            this.mEditar.Size = new System.Drawing.Size(63, 24);
            this.mEditar.Text = "Editar";
            // 
            // mEditar_Desfazer
            // 
            this.mEditar_Desfazer.Name = "mEditar_Desfazer";
            this.mEditar_Desfazer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.mEditar_Desfazer.Size = new System.Drawing.Size(266, 26);
            this.mEditar_Desfazer.Text = "Desfazer";
            this.mEditar_Desfazer.Click += new System.EventHandler(this.mEditar_Desfazer_Click);
            // 
            // mEditar_Refazer
            // 
            this.mEditar_Refazer.Name = "mEditar_Refazer";
            this.mEditar_Refazer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.mEditar_Refazer.Size = new System.Drawing.Size(266, 26);
            this.mEditar_Refazer.Text = "Refazer";
            this.mEditar_Refazer.Click += new System.EventHandler(this.mEditar_Refazer_Click);
            // 
            // mEditar_Copiar
            // 
            this.mEditar_Copiar.Name = "mEditar_Copiar";
            this.mEditar_Copiar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mEditar_Copiar.Size = new System.Drawing.Size(266, 26);
            this.mEditar_Copiar.Text = "Copiar";
            this.mEditar_Copiar.Click += new System.EventHandler(this.mEditar_Copiar_Click);
            // 
            // mEditar_Recortar
            // 
            this.mEditar_Recortar.Name = "mEditar_Recortar";
            this.mEditar_Recortar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mEditar_Recortar.Size = new System.Drawing.Size(266, 26);
            this.mEditar_Recortar.Text = "Recortar";
            this.mEditar_Recortar.Click += new System.EventHandler(this.mEditar_Recortar_Click);
            // 
            // mEditar_Colar
            // 
            this.mEditar_Colar.Name = "mEditar_Colar";
            this.mEditar_Colar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.mEditar_Colar.Size = new System.Drawing.Size(266, 26);
            this.mEditar_Colar.Text = "Colar";
            this.mEditar_Colar.Click += new System.EventHandler(this.mEditar_Colar_Click);
            // 
            // mEditar_Excluir
            // 
            this.mEditar_Excluir.Name = "mEditar_Excluir";
            this.mEditar_Excluir.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.mEditar_Excluir.Size = new System.Drawing.Size(266, 26);
            this.mEditar_Excluir.Text = "Excluir";
            this.mEditar_Excluir.Click += new System.EventHandler(this.mEditar_Excluir_Click);
            // 
            // mEditar_Data_Hora
            // 
            this.mEditar_Data_Hora.Name = "mEditar_Data_Hora";
            this.mEditar_Data_Hora.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.mEditar_Data_Hora.Size = new System.Drawing.Size(266, 26);
            this.mEditar_Data_Hora.Text = "Data e Hora";
            this.mEditar_Data_Hora.Click += new System.EventHandler(this.mEditar_Data_Hora_Click);
            // 
            // mFormatar
            // 
            this.mFormatar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFormatarQuebra_Linha,
            this.mFormatar_Fonte});
            this.mFormatar.Name = "mFormatar";
            this.mFormatar.Size = new System.Drawing.Size(86, 24);
            this.mFormatar.Text = "Formatar";
            // 
            // mFormatarQuebra_Linha
            // 
            this.mFormatarQuebra_Linha.CheckOnClick = true;
            this.mFormatarQuebra_Linha.Name = "mFormatarQuebra_Linha";
            this.mFormatarQuebra_Linha.Size = new System.Drawing.Size(207, 26);
            this.mFormatarQuebra_Linha.Text = "Quebra De Linha";
            this.mFormatarQuebra_Linha.Click += new System.EventHandler(this.mFormatarQuebra_Linha_Click);
            // 
            // mFormatar_Fonte
            // 
            this.mFormatar_Fonte.Name = "mFormatar_Fonte";
            this.mFormatar_Fonte.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.mFormatar_Fonte.Size = new System.Drawing.Size(207, 26);
            this.mFormatar_Fonte.Text = "Fonte";
            this.mFormatar_Fonte.Click += new System.EventHandler(this.mFormatar_Fonte_Click);
            // 
            // mExibir
            // 
            this.mExibir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mExibir_Zoom,
            this.mExibirBarra_Status});
            this.mExibir.Name = "mExibir";
            this.mExibir.Size = new System.Drawing.Size(62, 24);
            this.mExibir.Text = "Exibir";
            // 
            // mExibir_Zoom
            // 
            this.mExibir_Zoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mExibirZoom_Ampliar,
            this.mExibirZoom_Reduzir,
            this.mExibirZoom_Restaurar});
            this.mExibir_Zoom.Name = "mExibir_Zoom";
            this.mExibir_Zoom.Size = new System.Drawing.Size(195, 26);
            this.mExibir_Zoom.Text = "Zoom";
            // 
            // mExibirZoom_Ampliar
            // 
            this.mExibirZoom_Ampliar.Name = "mExibirZoom_Ampliar";
            this.mExibirZoom_Ampliar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Right)));
            this.mExibirZoom_Ampliar.Size = new System.Drawing.Size(281, 26);
            this.mExibirZoom_Ampliar.Text = "Ampliar";
            this.mExibirZoom_Ampliar.Click += new System.EventHandler(this.mExibirZoom_Ampliar_Click);
            // 
            // mExibirZoom_Reduzir
            // 
            this.mExibirZoom_Reduzir.Name = "mExibirZoom_Reduzir";
            this.mExibirZoom_Reduzir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Left)));
            this.mExibirZoom_Reduzir.Size = new System.Drawing.Size(281, 26);
            this.mExibirZoom_Reduzir.Text = "Reduzir";
            this.mExibirZoom_Reduzir.Click += new System.EventHandler(this.mExibirZoom_Reduzir_Click);
            // 
            // mExibirZoom_Restaurar
            // 
            this.mExibirZoom_Restaurar.Name = "mExibirZoom_Restaurar";
            this.mExibirZoom_Restaurar.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Down)));
            this.mExibirZoom_Restaurar.Size = new System.Drawing.Size(281, 26);
            this.mExibirZoom_Restaurar.Text = "Restaurar";
            this.mExibirZoom_Restaurar.Click += new System.EventHandler(this.mExibirZoom_Restaurar_Click);
            // 
            // mExibirBarra_Status
            // 
            this.mExibirBarra_Status.Checked = true;
            this.mExibirBarra_Status.CheckOnClick = true;
            this.mExibirBarra_Status.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mExibirBarra_Status.Name = "mExibirBarra_Status";
            this.mExibirBarra_Status.Size = new System.Drawing.Size(195, 26);
            this.mExibirBarra_Status.Text = "Barra de Status";
            this.mExibirBarra_Status.Click += new System.EventHandler(this.mExibirBarra_Status_Click);
            // 
            // mAjuda
            // 
            this.mAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAjudaExibir_Ajuda,
            this.mAjuda_Sobre});
            this.mAjuda.Name = "mAjuda";
            this.mAjuda.Size = new System.Drawing.Size(63, 24);
            this.mAjuda.Text = "Ajuda";
            // 
            // mAjudaExibir_Ajuda
            // 
            this.mAjudaExibir_Ajuda.Name = "mAjudaExibir_Ajuda";
            this.mAjudaExibir_Ajuda.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.mAjudaExibir_Ajuda.Size = new System.Drawing.Size(229, 26);
            this.mAjudaExibir_Ajuda.Text = "Exibir Ajuda";
            this.mAjudaExibir_Ajuda.Click += new System.EventHandler(this.mAjudaExibir_Ajuda_Click);
            // 
            // mAjuda_Sobre
            // 
            this.mAjuda_Sobre.Name = "mAjuda_Sobre";
            this.mAjuda_Sobre.Size = new System.Drawing.Size(229, 26);
            this.mAjuda_Sobre.Text = "Sobre";
            this.mAjuda_Sobre.Click += new System.EventHandler(this.mAjuda_Sobre_Click);
            // 
            // mSair
            // 
            this.mSair.Name = "mSair";
            this.mSair.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mSair.Size = new System.Drawing.Size(49, 24);
            this.mSair.Text = "Sair";
            this.mSair.Click += new System.EventHandler(this.mSair_Click);
            // 
            // statusBar
            // 
            this.statusBar.BackColor = System.Drawing.Color.Gainsboro;
            this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_BarLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 527);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(782, 26);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "statusStrip1";
            // 
            // status_BarLabel
            // 
            this.status_BarLabel.Name = "status_BarLabel";
            this.status_BarLabel.Size = new System.Drawing.Size(45, 20);
            this.status_BarLabel.Text = "100%";
            // 
            // txt_Conteudo
            // 
            this.txt_Conteudo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_Conteudo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Conteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Conteudo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_Conteudo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_Conteudo.Location = new System.Drawing.Point(0, 0);
            this.txt_Conteudo.Name = "txt_Conteudo";
            this.txt_Conteudo.Size = new System.Drawing.Size(736, 497);
            this.txt_Conteudo.TabIndex = 2;
            this.txt_Conteudo.Text = "";
            this.txt_Conteudo.WordWrap = false;
            this.txt_Conteudo.TextChanged += new System.EventHandler(this.txt_Conteudo_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(34, 499);
            this.panel1.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ContextMenuStrip = this.contextMenuStrip1;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(30, 499);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "ModoEditor";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.MouseEnter += new System.EventHandler(this.ModoEditor);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(27, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(772, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 499);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txt_Conteudo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(34, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(738, 499);
            this.panel3.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuBar;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditorTXT";
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem mArquivo;
        private System.Windows.Forms.ToolStripMenuItem mEditar;
        private System.Windows.Forms.ToolStripMenuItem mFormatar;
        private System.Windows.Forms.ToolStripMenuItem mExibir;
        private System.Windows.Forms.ToolStripMenuItem mAjuda;
        private System.Windows.Forms.ToolStripMenuItem mArquivo_Novo;
        private System.Windows.Forms.ToolStripMenuItem mArquivoNova_Janela;
        private System.Windows.Forms.ToolStripMenuItem mArquivo_Abrir;
        private System.Windows.Forms.ToolStripMenuItem mArquivo_Salvar;
        private System.Windows.Forms.ToolStripMenuItem mArquivoSalvar_Como;
        private System.Windows.Forms.ToolStripMenuItem mSair;
        private System.Windows.Forms.ToolStripMenuItem mEditar_Desfazer;
        private System.Windows.Forms.ToolStripMenuItem mEditar_Refazer;
        private System.Windows.Forms.ToolStripMenuItem mEditar_Recortar;
        private System.Windows.Forms.ToolStripMenuItem mEditar_Colar;
        private System.Windows.Forms.ToolStripMenuItem mEditar_Excluir;
        private System.Windows.Forms.ToolStripMenuItem mEditar_Data_Hora;
        private System.Windows.Forms.ToolStripMenuItem mFormatarQuebra_Linha;
        private System.Windows.Forms.ToolStripMenuItem mFormatar_Fonte;
        private System.Windows.Forms.ToolStripMenuItem mExibir_Zoom;
        private System.Windows.Forms.ToolStripMenuItem mExibirZoom_Ampliar;
        private System.Windows.Forms.ToolStripMenuItem mExibirZoom_Reduzir;
        private System.Windows.Forms.ToolStripMenuItem mExibirZoom_Restaurar;
        private System.Windows.Forms.ToolStripMenuItem mExibirBarra_Status;
        private System.Windows.Forms.ToolStripMenuItem mAjudaExibir_Ajuda;
        private System.Windows.Forms.ToolStripMenuItem mAjuda_Sobre;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel status_BarLabel;
        private System.Windows.Forms.RichTextBox txt_Conteudo;
        private System.Windows.Forms.ToolStripMenuItem mEditar_Copiar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

