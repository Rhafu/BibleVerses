namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblVersiculosTotal = new System.Windows.Forms.Label();
            this.lblVersiTotal = new System.Windows.Forms.Label();
            this.lstBoxVersos = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarVersiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.limparVersículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comoUsarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comoImportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFechar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblBibleVerses = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHonra = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtMostrarVersi = new System.Windows.Forms.RichTextBox();
            this.MenuRichTXT = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.limparToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.nmrUDCapit = new System.Windows.Forms.NumericUpDown();
            this.nmrUDVersiFin = new System.Windows.Forms.NumericUpDown();
            this.cmbBoxLivros = new System.Windows.Forms.ComboBox();
            this.lblLivros = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nmrUDVersicIn = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selecionarTudoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MenuRichTXT.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUDCapit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUDVersiFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUDVersicIn)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVersiculosTotal
            // 
            this.lblVersiculosTotal.AutoSize = true;
            this.lblVersiculosTotal.Font = new System.Drawing.Font("Harlow Solid Italic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersiculosTotal.Location = new System.Drawing.Point(14, 96);
            this.lblVersiculosTotal.Name = "lblVersiculosTotal";
            this.lblVersiculosTotal.Size = new System.Drawing.Size(186, 30);
            this.lblVersiculosTotal.TabIndex = 14;
            this.lblVersiculosTotal.Text = "Versículos Totais:";
            // 
            // lblVersiTotal
            // 
            this.lblVersiTotal.AutoSize = true;
            this.lblVersiTotal.Font = new System.Drawing.Font("Harlow Solid Italic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersiTotal.Location = new System.Drawing.Point(195, 96);
            this.lblVersiTotal.Name = "lblVersiTotal";
            this.lblVersiTotal.Size = new System.Drawing.Size(25, 30);
            this.lblVersiTotal.TabIndex = 15;
            this.lblVersiTotal.Text = "0";
            // 
            // lstBoxVersos
            // 
            this.lstBoxVersos.BackColor = System.Drawing.Color.Gainsboro;
            this.lstBoxVersos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstBoxVersos.FormattingEnabled = true;
            this.lstBoxVersos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lstBoxVersos.Location = new System.Drawing.Point(17, 129);
            this.lstBoxVersos.Name = "lstBoxVersos";
            this.lstBoxVersos.Size = new System.Drawing.Size(359, 197);
            this.lstBoxVersos.TabIndex = 16;
            this.lstBoxVersos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstBoxVersos_MouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(578, 34);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            this.menuStrip1.MouseHover += new System.EventHandler(this.menuStrip1_MouseHover);
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseMove);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarVersiculosToolStripMenuItem,
            this.toolStripMenuItem1,
            this.limparVersículosToolStripMenuItem,
            this.toolStripMenuItem2,
            this.salvarToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(57, 30);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // importarVersiculosToolStripMenuItem
            // 
            this.importarVersiculosToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.fileimport_120157;
            this.importarVersiculosToolStripMenuItem.Name = "importarVersiculosToolStripMenuItem";
            this.importarVersiculosToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.importarVersiculosToolStripMenuItem.Text = "Importar Versiculos";
            this.importarVersiculosToolStripMenuItem.Click += new System.EventHandler(this.importarVersiculosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(207, 6);
            // 
            // limparVersículosToolStripMenuItem
            // 
            this.limparVersículosToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.iconfinder_broom_clean_service_labor_website_4622511_122412;
            this.limparVersículosToolStripMenuItem.Name = "limparVersículosToolStripMenuItem";
            this.limparVersículosToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.limparVersículosToolStripMenuItem.Text = "Limpar Versículos";
            this.limparVersículosToolStripMenuItem.Click += new System.EventHandler(this.limparVersículosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(207, 6);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.saveas_5165;
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comoUsarToolStripMenuItem,
            this.comoImportarToolStripMenuItem});
            this.ajudaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajudaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(55, 30);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // comoUsarToolStripMenuItem
            // 
            this.comoUsarToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Help_icon_icons_com_55891;
            this.comoUsarToolStripMenuItem.Name = "comoUsarToolStripMenuItem";
            this.comoUsarToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.comoUsarToolStripMenuItem.Text = "Como usar ?";
            this.comoUsarToolStripMenuItem.Click += new System.EventHandler(this.comoUsarToolStripMenuItem_Click);
            // 
            // comoImportarToolStripMenuItem
            // 
            this.comoImportarToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Help_icon_icons_com_55891;
            this.comoImportarToolStripMenuItem.Name = "comoImportarToolStripMenuItem";
            this.comoImportarToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.comoImportarToolStripMenuItem.Text = "Como Importar ?";
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFechar.Location = new System.Drawing.Point(537, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(30, 34);
            this.btnFechar.TabIndex = 18;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(497, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 34);
            this.button1.TabIndex = 19;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblBibleVerses
            // 
            this.lblBibleVerses.BackColor = System.Drawing.Color.White;
            this.lblBibleVerses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBibleVerses.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblBibleVerses.Font = new System.Drawing.Font("Matura MT Script Capitals", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBibleVerses.ForeColor = System.Drawing.Color.Black;
            this.lblBibleVerses.Location = new System.Drawing.Point(17, 47);
            this.lblBibleVerses.Name = "lblBibleVerses";
            this.lblBibleVerses.Size = new System.Drawing.Size(241, 39);
            this.lblBibleVerses.TabIndex = 21;
            this.lblBibleVerses.Text = "BibleVerses";
            this.lblBibleVerses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Microsoft Himalaya", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(338, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 39);
            this.label4.TabIndex = 22;
            this.label4.Text = "Produzido por: Rhafu";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHonra
            // 
            this.lblHonra.BackColor = System.Drawing.Color.White;
            this.lblHonra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblHonra.Font = new System.Drawing.Font("Microsoft Himalaya", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHonra.ForeColor = System.Drawing.Color.Black;
            this.lblHonra.Location = new System.Drawing.Point(338, 66);
            this.lblHonra.Name = "lblHonra";
            this.lblHonra.Size = new System.Drawing.Size(241, 60);
            this.lblHonra.TabIndex = 23;
            this.lblHonra.Text = "Toda honra e glória seja dada ao Deus de Israel";
            this.lblHonra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.icons8_holy_bible_96;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(471, 332);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 105);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // txtMostrarVersi
            // 
            this.txtMostrarVersi.ContextMenuStrip = this.MenuRichTXT;
            this.txtMostrarVersi.Location = new System.Drawing.Point(376, 129);
            this.txtMostrarVersi.Name = "txtMostrarVersi";
            this.txtMostrarVersi.ReadOnly = true;
            this.txtMostrarVersi.Size = new System.Drawing.Size(175, 197);
            this.txtMostrarVersi.TabIndex = 24;
            this.txtMostrarVersi.Text = "Clique duas vezes no versículo para mostra-lo aqui";
            // 
            // MenuRichTXT
            // 
            this.MenuRichTXT.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.limparToolStripMenuItem,
            this.selecionarTudoToolStripMenuItem,
            this.copiarToolStripMenuItem});
            this.MenuRichTXT.Name = "MenuRichTXT";
            this.MenuRichTXT.Size = new System.Drawing.Size(159, 70);
            this.MenuRichTXT.Text = "Caixa de Texto";
            // 
            // limparToolStripMenuItem
            // 
            this.limparToolStripMenuItem.Name = "limparToolStripMenuItem";
            this.limparToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.limparToolStripMenuItem.Text = "Limpar";
            this.limparToolStripMenuItem.Click += new System.EventHandler(this.limparToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 443);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(578, 22);
            this.statusStrip1.TabIndex = 25;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(149, 17);
            this.lblStatus.Text = "Versículo da Caixa de Texto";
            // 
            // nmrUDCapit
            // 
            this.nmrUDCapit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nmrUDCapit.Location = new System.Drawing.Point(153, 33);
            this.nmrUDCapit.Name = "nmrUDCapit";
            this.nmrUDCapit.ReadOnly = true;
            this.nmrUDCapit.Size = new System.Drawing.Size(120, 20);
            this.nmrUDCapit.TabIndex = 2;
            // 
            // nmrUDVersiFin
            // 
            this.nmrUDVersiFin.Location = new System.Drawing.Point(310, 76);
            this.nmrUDVersiFin.Name = "nmrUDVersiFin";
            this.nmrUDVersiFin.ReadOnly = true;
            this.nmrUDVersiFin.Size = new System.Drawing.Size(120, 20);
            this.nmrUDVersiFin.TabIndex = 3;
            // 
            // cmbBoxLivros
            // 
            this.cmbBoxLivros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxLivros.FormattingEnabled = true;
            this.cmbBoxLivros.Items.AddRange(new object[] {
            "Gênesis",
            "Êxodo",
            "Levítico",
            "Números",
            "Deuteronômio",
            "Josué",
            "Juízes",
            "Rute",
            "1 Samuel",
            "2 Samuel",
            "1 Reis",
            "2 Reis",
            "1 Crônicas",
            "2 Crônicas",
            "Esdras",
            "Neemias",
            "Ester",
            "Jó",
            "Salmos",
            "Provérbios",
            "Eclesiastes",
            "Cantares",
            "Isaías",
            "Jeremias",
            "Lamentações",
            "Ezequiel",
            "Daniel",
            "Oseias",
            "Joel",
            "Amós",
            "Obadias",
            "Jonas",
            "Miqueias",
            "Naum",
            "Habacuque",
            "Sofonias",
            "Ageu",
            "Zacarias",
            "Malaquias",
            "Mateus",
            "Marcos",
            "Lucas",
            "João",
            "Atos dos Apóstolos",
            "Romanos",
            "1 Coríntios",
            "2 Coríntios",
            "Gálatas",
            "Efésios",
            "Filipenses",
            "Colossenses",
            "1 Tessanolicenses",
            "2 Tessanolicenses",
            "1 Timóteo",
            "2 Timóteo",
            "Tito",
            "Filemon",
            "Hebreus",
            "Tiago",
            "1 Pedro",
            "2 Pedro",
            "1 João",
            "2 João",
            "3 João",
            "Judas",
            "Apocalipse"});
            this.cmbBoxLivros.Location = new System.Drawing.Point(14, 33);
            this.cmbBoxLivros.Name = "cmbBoxLivros";
            this.cmbBoxLivros.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxLivros.TabIndex = 4;
            // 
            // lblLivros
            // 
            this.lblLivros.AutoSize = true;
            this.lblLivros.Location = new System.Drawing.Point(11, 18);
            this.lblLivros.Name = "lblLivros";
            this.lblLivros.Size = new System.Drawing.Size(35, 13);
            this.lblLivros.TabIndex = 5;
            this.lblLivros.Text = "Livros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Capítulo";
            // 
            // nmrUDVersicIn
            // 
            this.nmrUDVersicIn.Location = new System.Drawing.Point(310, 34);
            this.nmrUDVersicIn.Name = "nmrUDVersicIn";
            this.nmrUDVersicIn.ReadOnly = true;
            this.nmrUDVersicIn.Size = new System.Drawing.Size(120, 20);
            this.nmrUDVersicIn.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Versículos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "até";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.MintCream;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Image = global::WindowsFormsApp1.Properties.Resources.icons8_add_property_24;
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionar.Location = new System.Drawing.Point(14, 59);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(121, 36);
            this.btnAdicionar.TabIndex = 12;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.MintCream;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Image = global::WindowsFormsApp1.Properties.Resources.icons8_delete_list_32;
            this.btnApagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApagar.Location = new System.Drawing.Point(153, 59);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(120, 37);
            this.btnApagar.TabIndex = 13;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnApagar);
            this.groupBox1.Controls.Add(this.btnAdicionar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nmrUDVersicIn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblLivros);
            this.groupBox1.Controls.Add(this.cmbBoxLivros);
            this.groupBox1.Controls.Add(this.nmrUDVersiFin);
            this.groupBox1.Controls.Add(this.nmrUDCapit);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 329);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 108);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Versic";
            // 
            // selecionarTudoToolStripMenuItem
            // 
            this.selecionarTudoToolStripMenuItem.Name = "selecionarTudoToolStripMenuItem";
            this.selecionarTudoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selecionarTudoToolStripMenuItem.Text = "Selecionar Tudo";
            this.selecionarTudoToolStripMenuItem.Click += new System.EventHandler(this.selecionarTudoToolStripMenuItem_Click);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copiarToolStripMenuItem.Text = "Copiar ";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(578, 465);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtMostrarVersi);
            this.Controls.Add(this.lblHonra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblBibleVerses);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblVersiTotal);
            this.Controls.Add(this.lblVersiculosTotal);
            this.Controls.Add(this.lstBoxVersos);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BibleVerse";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MenuRichTXT.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUDCapit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUDVersiFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUDVersicIn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblVersiculosTotal;
        private System.Windows.Forms.Label lblVersiTotal;
        private System.Windows.Forms.ListBox lstBoxVersos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarVersiculosToolStripMenuItem;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem limparVersículosToolStripMenuItem;
        private System.Windows.Forms.Label lblBibleVerses;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHonra;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comoUsarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comoImportarToolStripMenuItem;
        private System.Windows.Forms.RichTextBox txtMostrarVersi;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ContextMenuStrip MenuRichTXT;
        private System.Windows.Forms.ToolStripMenuItem limparToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown nmrUDCapit;
        private System.Windows.Forms.NumericUpDown nmrUDVersiFin;
        private System.Windows.Forms.ComboBox cmbBoxLivros;
        private System.Windows.Forms.Label lblLivros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmrUDVersicIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripMenuItem selecionarTudoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
    }
}

