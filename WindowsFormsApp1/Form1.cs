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
using System.Runtime.InteropServices;
using System.Net;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form 
    {
        public Form1()
        {
            InitializeComponent();

        }
        private int QuantidadeVersiculos { get; set; }
        private bool verifSeImportou { get; set; }
        private bool caixaVazia { get; set; } = true;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr ptr, int msg, int wParam, int LPAR);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        private void button1_Click(object sender, EventArgs e)
        {
            if (
                                    nmrUDVersiFin.Value != 0

                                    && nmrUDVersicIn.Value != nmrUDVersiFin.Value

                                    && cmbBoxLivros.Text != ""

                                    && nmrUDCapit.Value != 0

                                    && MessageBox.Show("Deseja adicionar "
                                    + cmbBoxLivros.SelectedItem.ToString()
                                    + " " + nmrUDCapit.Value.ToString()
                                    + ":" + nmrUDVersicIn.Value.ToString()
                                    + "-" + nmrUDVersiFin.Value.ToString() + "?"
                                    , "Adicionar ?"
                                    , MessageBoxButtons.YesNo
                                    , MessageBoxIcon.Question) == DialogResult.Yes



                                    ) 
            { 
                    lstBoxVersos.Items.Add(cmbBoxLivros.SelectedItem.ToString() 
                                            + " " + nmrUDCapit.Value.ToString() 
                                            + ":" + nmrUDVersicIn.Value.ToString() 
                                            + "-" + nmrUDVersiFin.Value.ToString());


                    for (int i = 0; nmrUDVersicIn.Value <= nmrUDVersiFin.Value; i++)
                    {
                        i++;
                        nmrUDVersicIn.Value += 1;
                        QuantidadeVersiculos += 1;
                    }

                    nmrUDVersiFin.Value = 0;

                    nmrUDVersicIn.Value = 0;

                    nmrUDCapit.Value = 0;

                lblVersiTotal.Text = QuantidadeVersiculos.ToString();
            }
            else if ( nmrUDVersiFin.Value == 0 && nmrUDCapit.Value != 0 && nmrUDVersicIn.Value != 0
                    && MessageBox.Show("Deseja adicionar "
                                    + cmbBoxLivros.SelectedItem.ToString()
                                    + " " + nmrUDCapit.Value.ToString()
                                    + ":" + nmrUDVersicIn.Value.ToString()
                                    + "?"
                                    , "Adicionar ?"
                                    , MessageBoxButtons.YesNo
                                    , MessageBoxIcon.Question) == DialogResult.Yes
                )
            {
                QuantidadeVersiculos += 1;

                lstBoxVersos.Items.Add(cmbBoxLivros.SelectedItem.ToString()
                                            + " " + nmrUDCapit.Value.ToString()
                                            + ":" + nmrUDVersicIn.Value.ToString());

                lblVersiTotal.Text = QuantidadeVersiculos.ToString();

                nmrUDVersiFin.Value = 0;

                nmrUDVersicIn.Value = 0;

                nmrUDCapit.Value = 0;
            }

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            
            if(lstBoxVersos.SelectedIndex == -1)
            {
                MessageBox.Show("Nenhum item foi selecionado!",
                                "Selecione um Item",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);

            }
            else //Apagando mais de um Versiculo
            {
                int posiçaoI = lstBoxVersos.SelectedIndex;

                if ( lstBoxVersos.SelectedItem.ToString().IndexOf("-") != -1
                     && MessageBox.Show("Deseja excluir mesmo o Item ?" 
                                    + lstBoxVersos.SelectedItem.ToString(),
                                    "Excluir",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) == DialogResult.Yes
                                    
                                    )
                {
                    int versiIn = 0;
                    int versiFin = 0;


                    string palavraExc = lstBoxVersos.SelectedItem.ToString();

                    int posiçaoEspaço = palavraExc.IndexOf(":");

                    string palavra = palavraExc.Remove(0, posiçaoEspaço + 1);

                    string[] versiculos = palavra.Split('-');

                    versiIn = Convert.ToInt32(versiculos[0]);
                    versiFin = Convert.ToInt32(versiculos[1]);

                    for (int i = 0; versiIn <= versiFin; i++)
                    {
                        i++;
                        versiIn += 1;
                        QuantidadeVersiculos -= 1;
                    }

                    lblVersiTotal.Text = QuantidadeVersiculos.ToString();
                    lstBoxVersos.Items.RemoveAt(posiçaoI);


                }
                //Apagando Versículo Unico
                else if (MessageBox.Show("Deseja excluir mesmo o Item ?"
                                    + lstBoxVersos.SelectedItem.ToString(),
                                    "Excluir",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int posiçaoII = lstBoxVersos.SelectedIndex;

                    QuantidadeVersiculos -= 1;

                    lblVersiTotal.Text = QuantidadeVersiculos.ToString();

                    lstBoxVersos.Items.RemoveAt(posiçaoII);
                }
            }
        }

        private void importarVersiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileInfo infoTxt = new FileInfo(@"./versiculos.txt");

            if (infoTxt.Exists && verifSeImportou != true)
            {
                using (StreamReader it = infoTxt.OpenText())
                {
                    lstBoxVersos.Items.Clear();
                    string linha = "";
                     while((linha = it.ReadLine()) != null)
                    {
                        if(linha.IndexOf("-") != -1)
                        {
                            int versiIn = 0;
                            int versiFin = 0;

                            int posiçaoPontos = linha.IndexOf(":");
                            string palavraExc = linha.Remove(0, posiçaoPontos + 1);

                            string[] versiculos = palavraExc.Split('-');

                            versiIn = Convert.ToInt32(versiculos[0]);
                            versiFin = Convert.ToInt32(versiculos[1]);

                            QuantidadeVersiculos += versiFin - versiIn + 1;


                        }

                        else
                        {
                            QuantidadeVersiculos += 1;
                        }
                        
                        lstBoxVersos.Items.Add(linha);
                        lblVersiTotal.Text = QuantidadeVersiculos.ToString();
                    }
                }
            }
            else if (verifSeImportou == true)
            {
                MessageBox.Show("Primeiro limpe a lista!", "Limpe a lista", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            verifSeImportou = true;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            FileInfo verif = new FileInfo(@"./versiculos.txt");

            if(verif.Exists && MessageBox.Show("Foi encontrado versículos salvos, deseja importa-los ?"
                                                , "BibleVerses"
                                                , MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                importarVersiculosToolStripMenuItem.PerformClick();
            }

        }

        private void limparVersículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstBoxVersos.Items.Clear();
            QuantidadeVersiculos = 0;
            lblVersiTotal.Text = QuantidadeVersiculos.ToString();
            verifSeImportou = false;
        }

        private void lstBoxVersos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            

            int index = this.lstBoxVersos.IndexFromPoint(e.Location);
            string comAcentos = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç";
            string semAcentos = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCc";

            if (index != ListBox.NoMatches)
            {
                string versiculo = this.lstBoxVersos.SelectedItem.ToString().Replace(':', '_').Replace(" ", "_");

                for (int i = 0; i < comAcentos.Length; i++)
                {
                    versiculo = versiculo.Replace(comAcentos[i].ToString(), semAcentos[i].ToString());
                }

                string link = "https://www.bibliaon.com/versiculo/" + versiculo;

                if (caixaVazia)
                {
                    caixaVazia = false;
                    txtMostrarVersi.Clear();
                    try
                    {

                        HtmlAgilityPack.HtmlWeb site = new HtmlAgilityPack.HtmlWeb();

                        HtmlAgilityPack.HtmlDocument abri = site.Load(link);

                        foreach (var item in abri.DocumentNode.SelectNodes("//div[@id='versiculo_especif']"))
                        {
                            txtMostrarVersi.Text += item.InnerText;
                        }

                        lblStatus.Text = lstBoxVersos.SelectedItem.ToString();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERRO: " + ex.Message);
                        
                    }
                }

            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileInfo ver = new FileInfo(@"./versiculos.txt");


            if (ver.Exists == false && lstBoxVersos.Items.Count > 0)
            {
                StreamWriter esc = new StreamWriter(@".\versiculos.txt");

                try
                {
                    foreach (var item in lstBoxVersos.Items)
                    {
                        esc.WriteLine(item);


                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro: " + erro.Message.ToString());
                }


                esc.Close();
            }


            else if (lstBoxVersos.Items.Count > 0 && MessageBox.Show("Arquivo Versiculos.Txt já existe, deseja substitui-lo ?",
                                    "Atenção",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                StreamWriter esc = new StreamWriter(@".\versiculos.txt");

                try
                {
                    foreach (var item in lstBoxVersos.Items)
                    {
                        esc.WriteLine(item);


                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro: " + erro.Message.ToString());
                }

                esc.Close();
            }


            else if (lstBoxVersos.Items.Count < 1) 
            {
                MessageBox.Show("Adicione versiculos para salvar :P", "Salvar ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void comoUsarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjuda n = new FormAjuda();
            n.ShowDialog();
        }

        private void menuStrip1_MouseHover(object sender, EventArgs e)
        {
            Focus();
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!Focused)
            {
                Focus();
            }
        }

        private void limparToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMostrarVersi.Clear();
            lblStatus.Text = "Nenhum versiculo sendo mostrado";
            txtMostrarVersi.Text = "Clique duas vezes no versículo para mostra-lo aqui";
            caixaVazia = true;
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void selecionarTudoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMostrarVersi.Focus();
            txtMostrarVersi.SelectAll();
        }
    }
}
