namespace Construtor_AIML
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rtb_Pattern = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtb_Template = new System.Windows.Forms.RichTextBox();
            this.bt_GerarAIML = new System.Windows.Forms.Button();
            this.bt_Atualizar = new System.Windows.Forms.Button();
            this.bt_Sair = new System.Windows.Forms.Button();
            this.rtb_VisualizarAIML = new System.Windows.Forms.RichTextBox();
            this.tb_CaminhoAIMLCarregado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_CarregarAIML = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_CaminhoAIMLGerado = new System.Windows.Forms.TextBox();
            this.bt_LimparDados = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.rtb_Random = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtb_Pattern
            // 
            this.rtb_Pattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_Pattern.Location = new System.Drawing.Point(12, 270);
            this.rtb_Pattern.Name = "rtb_Pattern";
            this.rtb_Pattern.Size = new System.Drawing.Size(776, 65);
            this.rtb_Pattern.TabIndex = 3;
            this.rtb_Pattern.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(581, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Construtor AIML";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pattern:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Template:";
            // 
            // rtb_Template
            // 
            this.rtb_Template.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_Template.Location = new System.Drawing.Point(12, 373);
            this.rtb_Template.Name = "rtb_Template";
            this.rtb_Template.Size = new System.Drawing.Size(776, 65);
            this.rtb_Template.TabIndex = 4;
            this.rtb_Template.Text = "";
            // 
            // bt_GerarAIML
            // 
            this.bt_GerarAIML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_GerarAIML.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_GerarAIML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_GerarAIML.Location = new System.Drawing.Point(524, 139);
            this.bt_GerarAIML.Name = "bt_GerarAIML";
            this.bt_GerarAIML.Size = new System.Drawing.Size(153, 56);
            this.bt_GerarAIML.TabIndex = 2;
            this.bt_GerarAIML.Text = "Gerar AIML";
            this.bt_GerarAIML.UseVisualStyleBackColor = true;
            this.bt_GerarAIML.Click += new System.EventHandler(this.bt_GerarAIML_Click);
            // 
            // bt_Atualizar
            // 
            this.bt_Atualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Atualizar.Enabled = false;
            this.bt_Atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_Atualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Atualizar.Location = new System.Drawing.Point(73, 604);
            this.bt_Atualizar.Name = "bt_Atualizar";
            this.bt_Atualizar.Size = new System.Drawing.Size(153, 56);
            this.bt_Atualizar.TabIndex = 6;
            this.bt_Atualizar.Text = "Salvar";
            this.bt_Atualizar.UseVisualStyleBackColor = true;
            this.bt_Atualizar.Click += new System.EventHandler(this.bt_Atualizar_Click);
            // 
            // bt_Sair
            // 
            this.bt_Sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Sair.Location = new System.Drawing.Point(635, 604);
            this.bt_Sair.Name = "bt_Sair";
            this.bt_Sair.Size = new System.Drawing.Size(153, 56);
            this.bt_Sair.TabIndex = 8;
            this.bt_Sair.Text = "Sair";
            this.bt_Sair.UseVisualStyleBackColor = true;
            this.bt_Sair.Click += new System.EventHandler(this.bt_Sair_Click);
            // 
            // rtb_VisualizarAIML
            // 
            this.rtb_VisualizarAIML.Enabled = false;
            this.rtb_VisualizarAIML.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_VisualizarAIML.Location = new System.Drawing.Point(812, 68);
            this.rtb_VisualizarAIML.Name = "rtb_VisualizarAIML";
            this.rtb_VisualizarAIML.ReadOnly = true;
            this.rtb_VisualizarAIML.Size = new System.Drawing.Size(440, 601);
            this.rtb_VisualizarAIML.TabIndex = 8;
            this.rtb_VisualizarAIML.Text = "";
            // 
            // tb_CaminhoAIMLCarregado
            // 
            this.tb_CaminhoAIMLCarregado.Enabled = false;
            this.tb_CaminhoAIMLCarregado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CaminhoAIMLCarregado.Location = new System.Drawing.Point(12, 87);
            this.tb_CaminhoAIMLCarregado.Name = "tb_CaminhoAIMLCarregado";
            this.tb_CaminhoAIMLCarregado.ReadOnly = true;
            this.tb_CaminhoAIMLCarregado.Size = new System.Drawing.Size(395, 22);
            this.tb_CaminhoAIMLCarregado.TabIndex = 9;
            this.tb_CaminhoAIMLCarregado.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(12, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Caminho AIML Carregado";
            // 
            // bt_CarregarAIML
            // 
            this.bt_CarregarAIML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_CarregarAIML.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_CarregarAIML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_CarregarAIML.Location = new System.Drawing.Point(524, 68);
            this.bt_CarregarAIML.Name = "bt_CarregarAIML";
            this.bt_CarregarAIML.Size = new System.Drawing.Size(153, 56);
            this.bt_CarregarAIML.TabIndex = 1;
            this.bt_CarregarAIML.Text = "Carregar AIML";
            this.bt_CarregarAIML.UseVisualStyleBackColor = true;
            this.bt_CarregarAIML.Click += new System.EventHandler(this.bt_CarregarAIML_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(413, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "<---------------";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(714, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "--------------->";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(298, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Adicionar no AIML";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(413, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "<---------------";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(714, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "--------------->";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(12, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Caminho AIML Gerado";
            // 
            // tb_CaminhoAIMLGerado
            // 
            this.tb_CaminhoAIMLGerado.Enabled = false;
            this.tb_CaminhoAIMLGerado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CaminhoAIMLGerado.Location = new System.Drawing.Point(12, 160);
            this.tb_CaminhoAIMLGerado.Name = "tb_CaminhoAIMLGerado";
            this.tb_CaminhoAIMLGerado.ReadOnly = true;
            this.tb_CaminhoAIMLGerado.Size = new System.Drawing.Size(395, 22);
            this.tb_CaminhoAIMLGerado.TabIndex = 17;
            this.tb_CaminhoAIMLGerado.TabStop = false;
            // 
            // bt_LimparDados
            // 
            this.bt_LimparDados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_LimparDados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_LimparDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_LimparDados.Location = new System.Drawing.Point(284, 604);
            this.bt_LimparDados.Name = "bt_LimparDados";
            this.bt_LimparDados.Size = new System.Drawing.Size(153, 56);
            this.bt_LimparDados.TabIndex = 7;
            this.bt_LimparDados.Text = "Limpar Dados";
            this.bt_LimparDados.UseVisualStyleBackColor = true;
            this.bt_LimparDados.Click += new System.EventHandler(this.bt_LimparDados_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(12, 455);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Random";
            // 
            // rtb_Random
            // 
            this.rtb_Random.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_Random.Location = new System.Drawing.Point(12, 474);
            this.rtb_Random.Name = "rtb_Random";
            this.rtb_Random.Size = new System.Drawing.Size(776, 111);
            this.rtb_Random.TabIndex = 5;
            this.rtb_Random.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(139, 455);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(560, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "Separar Random com ; (Ponto e Vírgula)  ----->  (Exemplo: Primeira frase ; Segund" +
    "a Frase ......)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1197, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Versão !.0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(961, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(154, 16);
            this.label14.TabIndex = 24;
            this.label14.Text = "Arquivo AIML Carregado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.rtb_Random);
            this.Controls.Add(this.bt_LimparDados);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_CaminhoAIMLGerado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bt_CarregarAIML);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_CaminhoAIMLCarregado);
            this.Controls.Add(this.rtb_VisualizarAIML);
            this.Controls.Add(this.bt_Sair);
            this.Controls.Add(this.bt_Atualizar);
            this.Controls.Add(this.bt_GerarAIML);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtb_Template);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtb_Pattern);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Construtor AIML";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_Pattern;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtb_Template;
        private System.Windows.Forms.Button bt_GerarAIML;
        private System.Windows.Forms.Button bt_Atualizar;
        private System.Windows.Forms.Button bt_Sair;
        private System.Windows.Forms.RichTextBox rtb_VisualizarAIML;
        private System.Windows.Forms.TextBox tb_CaminhoAIMLCarregado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_CarregarAIML;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_CaminhoAIMLGerado;
        private System.Windows.Forms.Button bt_LimparDados;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox rtb_Random;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

