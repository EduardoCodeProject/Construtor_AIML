using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Construtor_AIML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Sair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente sair? ", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
                this.Dispose();
        }

        private void bt_CarregarAIML_Click(object sender, EventArgs e)
        {
            bt_Atualizar.Enabled = true;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            // openFileDialog.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog.Title = "Localizar AIML";
            openFileDialog.DefaultExt = "*.aiml";
            openFileDialog.Filter = "AIML files (*.aiml)|*.aiml|All files (*.*)|*.*";
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.ReadOnlyChecked = true;
            // openFileDialog.ShowReadOnly = true;

            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                tb_CaminhoAIMLCarregado.Text = openFileDialog.FileName;
            }
            Limpar();
        }

        private void bt_GerarAIML_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            //saveFileDialog.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog.Title = "Salvar AIML Como";
            saveFileDialog.Filter = "AIML files (.aiml)|.aiml";
            saveFileDialog.FileName = "FileAIML.aiml";
            saveFileDialog.DefaultExt = ".aiml";
            saveFileDialog.RestoreDirectory = true;

            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                tb_CaminhoAIMLGerado.Text = saveFileDialog.FileName;
                XmlDocument xmlDoc = new XmlDocument();

                XmlDeclaration declaration = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
                xmlDoc.AppendChild(declaration);

                XmlNode rootNode = xmlDoc.CreateElement("aiml");
                xmlDoc.AppendChild(rootNode);

                xmlDoc.Save(saveFileDialog.FileName);

                rtb_VisualizarAIML.Text = xmlDoc.OuterXml;

                Limpar();
            }
        }

        private void bt_Atualizar_Click(object sender, EventArgs e)
        {
            if (tb_CaminhoAIMLCarregado.Text != "" || tb_CaminhoAIMLGerado.Text != "")
            {
                if (rtb_Template.Text != "" && rtb_Random.Text != "")
                    MessageBox.Show("Não é permitido adicionar Pattern e Random ao mesmo tempo!", "Não Permitido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    XmlDocument xmlDocument = new XmlDocument();
                    if (tb_CaminhoAIMLCarregado.Text != "")
                        xmlDocument.Load(tb_CaminhoAIMLCarregado.Text);
                    else
                        xmlDocument.Load(tb_CaminhoAIMLGerado.Text);

                    XmlNode xmlNode = xmlDocument.SelectSingleNode("aiml");

                    XmlNode categoryNode = xmlDocument.CreateElement("category");

                    XmlNode patternNode = xmlDocument.CreateElement("pattern");

                    if (rtb_Pattern.Text != "")
                        patternNode.InnerText = rtb_Pattern.Text;
                    categoryNode.AppendChild(patternNode);

                    XmlNode templateNode = xmlDocument.CreateElement("template");
                    if (rtb_Template.Text != "" && rtb_Random.Text == "")
                        templateNode.InnerText = rtb_Template.Text;
                    // categoryNode.AppendChild(templateNode);
                    rtb_VisualizarAIML.Text = xmlDocument.OuterXml;

                    if (rtb_Template.Text == "")
                    {
                        XmlNode randomNode = xmlDocument.CreateElement("random");

                        string[] randomArray = rtb_Random.Text.Split(';');
                        foreach (string randomString in randomArray)
                        {
                            XmlNode liNode = xmlDocument.CreateElement("li");
                            if (rtb_Random.Text != "")
                            {
                                liNode.InnerText = randomString;
                            }
                            randomNode.AppendChild(liNode);
                        }

                        templateNode.AppendChild(randomNode);
                    }

                    categoryNode.AppendChild(templateNode);

                    xmlNode.AppendChild(categoryNode);

                    if(tb_CaminhoAIMLCarregado.Text != "")
                    xmlDocument.Save(@tb_CaminhoAIMLCarregado.Text);
                    else
                        xmlDocument.Save(tb_CaminhoAIMLGerado.Text);

                    rtb_VisualizarAIML.Text = xmlDocument.OuterXml;
                }
            }
            else
                MessageBox.Show("Carregue ou crie um arquivo AIML primeiro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpar();
        }

        private void bt_LimparDados_Click(object sender, EventArgs e)
        {
            Limpar();
            rtb_VisualizarAIML.Clear();
            tb_CaminhoAIMLCarregado.Clear();
            tb_CaminhoAIMLGerado.Clear();
        }

        private void Limpar()
        {
            rtb_Pattern.Clear();
            rtb_Random.Clear();
            rtb_Template.Clear();
        }
    }
}
