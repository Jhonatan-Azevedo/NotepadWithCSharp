
namespace EditorTxt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.mArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivoNova = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivoNovaJanela = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mArquivoAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivoSalvar = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivoComo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mArquivoSair = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditarDesfazer = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditarRefazer = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditarRecortar = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditarCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditarColar = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditarExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mEditarDataEHora = new System.Windows.Forms.ToolStripMenuItem();
            this.mFormatar = new System.Windows.Forms.ToolStripMenuItem();
            this.mFormatarQuebraDeLinha = new System.Windows.Forms.ToolStripMenuItem();
            this.mFormatarFonte = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibir = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibirZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibirZoomAmpliar = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibirZoomReduzir = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibirZoomRestaurar = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibirBarraDeStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.mAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mAjudaExibirAjudar = new System.Windows.Forms.ToolStripMenuItem();
            this.mAjudaSobreOJhowTxt = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusBarLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtConteudo = new System.Windows.Forms.RichTextBox();
            this.menuBar.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuBar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mArquivo,
            this.mEditar,
            this.mFormatar,
            this.mExibir,
            this.mAjuda});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(784, 29);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuStrip1";
            // 
            // mArquivo
            // 
            this.mArquivo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mArquivoNova,
            this.mArquivoNovaJanela,
            this.toolStripSeparator1,
            this.mArquivoAbrir,
            this.mArquivoSalvar,
            this.mArquivoComo,
            this.toolStripSeparator2,
            this.mArquivoSair});
            this.mArquivo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.mArquivo.Name = "mArquivo";
            this.mArquivo.Size = new System.Drawing.Size(77, 25);
            this.mArquivo.Text = "Arquivo";
            // 
            // mArquivoNova
            // 
            this.mArquivoNova.Image = global::EditorTxt.Properties.Resources.file_solid;
            this.mArquivoNova.Name = "mArquivoNova";
            this.mArquivoNova.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mArquivoNova.Size = new System.Drawing.Size(267, 26);
            this.mArquivoNova.Text = "Novo";
            this.mArquivoNova.Click += new System.EventHandler(this.mArquivoNova_Click);
            // 
            // mArquivoNovaJanela
            // 
            this.mArquivoNovaJanela.Image = global::EditorTxt.Properties.Resources.external_link_alt_solid;
            this.mArquivoNovaJanela.Name = "mArquivoNovaJanela";
            this.mArquivoNovaJanela.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.mArquivoNovaJanela.Size = new System.Drawing.Size(267, 26);
            this.mArquivoNovaJanela.Text = "Nova Janela";
            this.mArquivoNovaJanela.Click += new System.EventHandler(this.mArquivoNovaJanela_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(264, 6);
            // 
            // mArquivoAbrir
            // 
            this.mArquivoAbrir.Image = global::EditorTxt.Properties.Resources.folder_open_solid;
            this.mArquivoAbrir.Name = "mArquivoAbrir";
            this.mArquivoAbrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mArquivoAbrir.Size = new System.Drawing.Size(267, 26);
            this.mArquivoAbrir.Text = "Abrir";
            this.mArquivoAbrir.Click += new System.EventHandler(this.mArquivoAbrir_Click);
            // 
            // mArquivoSalvar
            // 
            this.mArquivoSalvar.Image = global::EditorTxt.Properties.Resources.save_regular;
            this.mArquivoSalvar.Name = "mArquivoSalvar";
            this.mArquivoSalvar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mArquivoSalvar.Size = new System.Drawing.Size(267, 26);
            this.mArquivoSalvar.Text = "Salvar";
            this.mArquivoSalvar.Click += new System.EventHandler(this.mArquivoSalvar_Click);
            // 
            // mArquivoComo
            // 
            this.mArquivoComo.Image = global::EditorTxt.Properties.Resources.save_solid_1;
            this.mArquivoComo.Name = "mArquivoComo";
            this.mArquivoComo.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.mArquivoComo.Size = new System.Drawing.Size(267, 26);
            this.mArquivoComo.Text = "Salvar Como";
            this.mArquivoComo.Click += new System.EventHandler(this.mArquivoSalvarComo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(264, 6);
            // 
            // mArquivoSair
            // 
            this.mArquivoSair.Image = global::EditorTxt.Properties.Resources.door_open_solid;
            this.mArquivoSair.Name = "mArquivoSair";
            this.mArquivoSair.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mArquivoSair.Size = new System.Drawing.Size(267, 26);
            this.mArquivoSair.Text = "Sair";
            this.mArquivoSair.Click += new System.EventHandler(this.mArquivoSair_Click);
            // 
            // mEditar
            // 
            this.mEditar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mEditarDesfazer,
            this.mEditarRefazer,
            this.mEditarRecortar,
            this.mEditarCopiar,
            this.mEditarColar,
            this.mEditarExcluir,
            this.toolStripSeparator3,
            this.mEditarDataEHora});
            this.mEditar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.mEditar.Name = "mEditar";
            this.mEditar.Size = new System.Drawing.Size(62, 25);
            this.mEditar.Text = "Editar";
            // 
            // mEditarDesfazer
            // 
            this.mEditarDesfazer.Image = global::EditorTxt.Properties.Resources.undo_solid;
            this.mEditarDesfazer.Name = "mEditarDesfazer";
            this.mEditarDesfazer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.mEditarDesfazer.Size = new System.Drawing.Size(230, 26);
            this.mEditarDesfazer.Text = "Desfazer";
            this.mEditarDesfazer.Click += new System.EventHandler(this.mEditarDesfazer_Click);
            // 
            // mEditarRefazer
            // 
            this.mEditarRefazer.Image = global::EditorTxt.Properties.Resources.redo_solid;
            this.mEditarRefazer.Name = "mEditarRefazer";
            this.mEditarRefazer.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.mEditarRefazer.Size = new System.Drawing.Size(230, 26);
            this.mEditarRefazer.Text = "Refazer";
            this.mEditarRefazer.Click += new System.EventHandler(this.mEditarRefazer_Click);
            // 
            // mEditarRecortar
            // 
            this.mEditarRecortar.Image = global::EditorTxt.Properties.Resources.cut_solid;
            this.mEditarRecortar.Name = "mEditarRecortar";
            this.mEditarRecortar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mEditarRecortar.Size = new System.Drawing.Size(230, 26);
            this.mEditarRecortar.Text = "Recortar";
            this.mEditarRecortar.Click += new System.EventHandler(this.mEditarRecortar_Click);
            // 
            // mEditarCopiar
            // 
            this.mEditarCopiar.Image = global::EditorTxt.Properties.Resources.copy_solid;
            this.mEditarCopiar.Name = "mEditarCopiar";
            this.mEditarCopiar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mEditarCopiar.Size = new System.Drawing.Size(230, 26);
            this.mEditarCopiar.Text = "Copiar";
            this.mEditarCopiar.Click += new System.EventHandler(this.mEditarCopiar_Click);
            // 
            // mEditarColar
            // 
            this.mEditarColar.Image = global::EditorTxt.Properties.Resources.paste_solid;
            this.mEditarColar.Name = "mEditarColar";
            this.mEditarColar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.mEditarColar.Size = new System.Drawing.Size(230, 26);
            this.mEditarColar.Text = "Colar";
            this.mEditarColar.Click += new System.EventHandler(this.mEditarColar_Click);
            // 
            // mEditarExcluir
            // 
            this.mEditarExcluir.Image = global::EditorTxt.Properties.Resources.trash_alt_solid;
            this.mEditarExcluir.Name = "mEditarExcluir";
            this.mEditarExcluir.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.mEditarExcluir.Size = new System.Drawing.Size(230, 26);
            this.mEditarExcluir.Text = "Excluir";
            this.mEditarExcluir.Click += new System.EventHandler(this.mEditarExcluir_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(227, 6);
            // 
            // mEditarDataEHora
            // 
            this.mEditarDataEHora.Image = global::EditorTxt.Properties.Resources.calendar_week_solid;
            this.mEditarDataEHora.Name = "mEditarDataEHora";
            this.mEditarDataEHora.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.mEditarDataEHora.Size = new System.Drawing.Size(230, 26);
            this.mEditarDataEHora.Text = "Data e Hora";
            this.mEditarDataEHora.Click += new System.EventHandler(this.mEditarDataEHora_Click);
            // 
            // mFormatar
            // 
            this.mFormatar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFormatarQuebraDeLinha,
            this.mFormatarFonte});
            this.mFormatar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.mFormatar.Name = "mFormatar";
            this.mFormatar.Size = new System.Drawing.Size(86, 25);
            this.mFormatar.Text = "Formatar";
            // 
            // mFormatarQuebraDeLinha
            // 
            this.mFormatarQuebraDeLinha.CheckOnClick = true;
            this.mFormatarQuebraDeLinha.Name = "mFormatarQuebraDeLinha";
            this.mFormatarQuebraDeLinha.Size = new System.Drawing.Size(272, 26);
            this.mFormatarQuebraDeLinha.Text = "Quebra automática de linha";
            this.mFormatarQuebraDeLinha.Click += new System.EventHandler(this.mFormatarQuebraDeLinha_Click);
            // 
            // mFormatarFonte
            // 
            this.mFormatarFonte.Name = "mFormatarFonte";
            this.mFormatarFonte.Size = new System.Drawing.Size(272, 26);
            this.mFormatarFonte.Text = "Fonte";
            this.mFormatarFonte.Click += new System.EventHandler(this.mFormatarFonte_Click);
            // 
            // mExibir
            // 
            this.mExibir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mExibirZoom,
            this.mExibirBarraDeStatus});
            this.mExibir.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.mExibir.Name = "mExibir";
            this.mExibir.Size = new System.Drawing.Size(60, 25);
            this.mExibir.Text = "Exibir";
            // 
            // mExibirZoom
            // 
            this.mExibirZoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mExibirZoomAmpliar,
            this.mExibirZoomReduzir,
            this.mExibirZoomRestaurar});
            this.mExibirZoom.Image = global::EditorTxt.Properties.Resources.Zoom;
            this.mExibirZoom.Name = "mExibirZoom";
            this.mExibirZoom.Size = new System.Drawing.Size(183, 26);
            this.mExibirZoom.Text = "Zoom";
            // 
            // mExibirZoomAmpliar
            // 
            this.mExibirZoomAmpliar.Image = global::EditorTxt.Properties.Resources.ZoomPlus;
            this.mExibirZoomAmpliar.Name = "mExibirZoomAmpliar";
            this.mExibirZoomAmpliar.ShortcutKeyDisplayString = "Ctrl + sinal de adição";
            this.mExibirZoomAmpliar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.mExibirZoomAmpliar.Size = new System.Drawing.Size(312, 26);
            this.mExibirZoomAmpliar.Text = "Ampliar";
            this.mExibirZoomAmpliar.Click += new System.EventHandler(this.mExibirZoomAmpliar_Click);
            // 
            // mExibirZoomReduzir
            // 
            this.mExibirZoomReduzir.Image = global::EditorTxt.Properties.Resources.ZoomMinus;
            this.mExibirZoomReduzir.Name = "mExibirZoomReduzir";
            this.mExibirZoomReduzir.ShortcutKeyDisplayString = "Ctrl + sinal de subtração";
            this.mExibirZoomReduzir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.mExibirZoomReduzir.Size = new System.Drawing.Size(312, 26);
            this.mExibirZoomReduzir.Text = "Reduzir";
            this.mExibirZoomReduzir.Click += new System.EventHandler(this.mExibirZoomReduzir_Click);
            // 
            // mExibirZoomRestaurar
            // 
            this.mExibirZoomRestaurar.Image = global::EditorTxt.Properties.Resources.restaurar;
            this.mExibirZoomRestaurar.Name = "mExibirZoomRestaurar";
            this.mExibirZoomRestaurar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.mExibirZoomRestaurar.Size = new System.Drawing.Size(312, 26);
            this.mExibirZoomRestaurar.Text = "Restaurar";
            this.mExibirZoomRestaurar.Click += new System.EventHandler(this.mExibirZoomRestaurar_Click);
            // 
            // mExibirBarraDeStatus
            // 
            this.mExibirBarraDeStatus.Checked = true;
            this.mExibirBarraDeStatus.CheckOnClick = true;
            this.mExibirBarraDeStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mExibirBarraDeStatus.Name = "mExibirBarraDeStatus";
            this.mExibirBarraDeStatus.Size = new System.Drawing.Size(183, 26);
            this.mExibirBarraDeStatus.Text = "Barra de status";
            this.mExibirBarraDeStatus.Click += new System.EventHandler(this.mExibirBarraDeStatus_Click);
            // 
            // mAjuda
            // 
            this.mAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAjudaExibirAjudar,
            this.mAjudaSobreOJhowTxt});
            this.mAjuda.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.mAjuda.Name = "mAjuda";
            this.mAjuda.Size = new System.Drawing.Size(62, 25);
            this.mAjuda.Text = "Ajuda";
            // 
            // mAjudaExibirAjudar
            // 
            this.mAjudaExibirAjudar.Name = "mAjudaExibirAjudar";
            this.mAjudaExibirAjudar.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mAjudaExibirAjudar.Size = new System.Drawing.Size(195, 26);
            this.mAjudaExibirAjudar.Text = "Exibir Ajudar";
            this.mAjudaExibirAjudar.Click += new System.EventHandler(this.mAjudaExibirAjudar_Click);
            // 
            // mAjudaSobreOJhowTxt
            // 
            this.mAjudaSobreOJhowTxt.Name = "mAjudaSobreOJhowTxt";
            this.mAjudaSobreOJhowTxt.Size = new System.Drawing.Size(195, 26);
            this.mAjudaSobreOJhowTxt.Text = "Sobre o JhowTxt";
            this.mAjudaSobreOJhowTxt.Click += new System.EventHandler(this.mAjudaSobreOJhowTxt_Click);
            // 
            // statusBar
            // 
            this.statusBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 539);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(784, 22);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "statusStrip1";
            // 
            // statusBarLabel
            // 
            this.statusBarLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statusBarLabel.Name = "statusBarLabel";
            this.statusBarLabel.Size = new System.Drawing.Size(38, 17);
            this.statusBarLabel.Text = "100 %";
            // 
            // txtConteudo
            // 
            this.txtConteudo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtConteudo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConteudo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtConteudo.Location = new System.Drawing.Point(0, 29);
            this.txtConteudo.Margin = new System.Windows.Forms.Padding(1);
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.Size = new System.Drawing.Size(784, 510);
            this.txtConteudo.TabIndex = 4;
            this.txtConteudo.Text = "";
            this.txtConteudo.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.txtConteudo);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Location = new System.Drawing.Point(0, 29);
            this.MainMenuStrip = this.menuBar;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JhowEditTxt";
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem mArquivoNova;
        private System.Windows.Forms.ToolStripMenuItem mArquivoNovaJanela;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mArquivoAbrir;
        private System.Windows.Forms.ToolStripMenuItem mArquivoSalvar;
        private System.Windows.Forms.ToolStripMenuItem mArquivoComo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mArquivoSair;
        private System.Windows.Forms.ToolStripMenuItem mEditarDesfazer;
        private System.Windows.Forms.ToolStripMenuItem mEditarRefazer;
        private System.Windows.Forms.ToolStripMenuItem mEditarRecortar;
        private System.Windows.Forms.ToolStripMenuItem mEditarCopiar;
        private System.Windows.Forms.ToolStripMenuItem mEditarColar;
        private System.Windows.Forms.ToolStripMenuItem mEditarExcluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mEditarDataEHora;
        private System.Windows.Forms.ToolStripMenuItem mFormatarQuebraDeLinha;
        private System.Windows.Forms.ToolStripMenuItem mFormatarFonte;
        private System.Windows.Forms.ToolStripMenuItem mExibirZoom;
        private System.Windows.Forms.ToolStripMenuItem mExibirZoomAmpliar;
        private System.Windows.Forms.ToolStripMenuItem mExibirZoomReduzir;
        private System.Windows.Forms.ToolStripMenuItem mExibirZoomRestaurar;
        private System.Windows.Forms.ToolStripMenuItem mExibirBarraDeStatus;
        private System.Windows.Forms.ToolStripMenuItem mAjudaExibirAjudar;
        private System.Windows.Forms.ToolStripMenuItem mAjudaSobreOJhowTxt;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusBarLabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.RichTextBox txtConteudo;
    }
}

