namespace Gerenciamento_de_Times
{
    partial class Cadastrar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbxPosicaoJogador = new System.Windows.Forms.ComboBox();
            this.cbxTimes = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCadastrarJogador = new System.Windows.Forms.Button();
            this.txtCamisaJogador = new System.Windows.Forms.TextBox();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeTime = new System.Windows.Forms.TextBox();
            this.txtNomeTreinador = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCadastrarTime = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 362);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbxPosicaoJogador);
            this.groupBox3.Controls.Add(this.cbxTimes);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnCadastrarJogador);
            this.groupBox3.Controls.Add(this.txtCamisaJogador);
            this.groupBox3.Controls.Add(this.txtNomeJogador);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(6, 157);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(255, 194);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cadastrar Jogadores";
            // 
            // cbxPosicaoJogador
            // 
            this.cbxPosicaoJogador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPosicaoJogador.FormattingEnabled = true;
            this.cbxPosicaoJogador.Items.AddRange(new object[] {
            "Goleiro",
            "Defesa",
            "Meia",
            "Atacante"});
            this.cbxPosicaoJogador.Location = new System.Drawing.Point(116, 115);
            this.cbxPosicaoJogador.Name = "cbxPosicaoJogador";
            this.cbxPosicaoJogador.Size = new System.Drawing.Size(121, 21);
            this.cbxPosicaoJogador.TabIndex = 17;
            // 
            // cbxTimes
            // 
            this.cbxTimes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTimes.FormattingEnabled = true;
            this.cbxTimes.Location = new System.Drawing.Point(116, 32);
            this.cbxTimes.Name = "cbxTimes";
            this.cbxTimes.Size = new System.Drawing.Size(121, 21);
            this.cbxTimes.TabIndex = 8;
            this.cbxTimes.SelectedIndexChanged += new System.EventHandler(this.cbxTimes_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Selecione o Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nome do Jogador";
            // 
            // btnCadastrarJogador
            // 
            this.btnCadastrarJogador.Enabled = false;
            this.btnCadastrarJogador.Location = new System.Drawing.Point(116, 142);
            this.btnCadastrarJogador.Name = "btnCadastrarJogador";
            this.btnCadastrarJogador.Size = new System.Drawing.Size(121, 26);
            this.btnCadastrarJogador.TabIndex = 11;
            this.btnCadastrarJogador.Text = "Cadastrar Jogador";
            this.btnCadastrarJogador.UseVisualStyleBackColor = true;
            this.btnCadastrarJogador.Click += new System.EventHandler(this.btnCadastrarJogador_Click);
            // 
            // txtCamisaJogador
            // 
            this.txtCamisaJogador.Location = new System.Drawing.Point(116, 90);
            this.txtCamisaJogador.Name = "txtCamisaJogador";
            this.txtCamisaJogador.Size = new System.Drawing.Size(121, 20);
            this.txtCamisaJogador.TabIndex = 15;
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Location = new System.Drawing.Point(116, 64);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(121, 20);
            this.txtNomeJogador.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Posição";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Numero da Camisa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtNomeTime);
            this.groupBox2.Controls.Add(this.txtNomeTreinador);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnCadastrarTime);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 132);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cadastrar Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome do Time";
            // 
            // txtNomeTime
            // 
            this.txtNomeTime.Location = new System.Drawing.Point(116, 22);
            this.txtNomeTime.Name = "txtNomeTime";
            this.txtNomeTime.Size = new System.Drawing.Size(121, 20);
            this.txtNomeTime.TabIndex = 1;
            // 
            // txtNomeTreinador
            // 
            this.txtNomeTreinador.Location = new System.Drawing.Point(116, 48);
            this.txtNomeTreinador.Name = "txtNomeTreinador";
            this.txtNomeTreinador.Size = new System.Drawing.Size(121, 20);
            this.txtNomeTreinador.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome do Treinador";
            // 
            // btnCadastrarTime
            // 
            this.btnCadastrarTime.Location = new System.Drawing.Point(116, 74);
            this.btnCadastrarTime.Name = "btnCadastrarTime";
            this.btnCadastrarTime.Size = new System.Drawing.Size(121, 25);
            this.btnCadastrarTime.TabIndex = 4;
            this.btnCadastrarTime.Text = "Cadastrar Time";
            this.btnCadastrarTime.UseVisualStyleBackColor = true;
            this.btnCadastrarTime.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 384);
            this.Controls.Add(this.groupBox1);
            this.Name = "Cadastrar";
            this.Text = "Cadastrar";
            this.Load += new System.EventHandler(this.Cadastrar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeTime;
        private System.Windows.Forms.TextBox txtNomeTreinador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCadastrarTime;
        private System.Windows.Forms.Button btnCadastrarJogador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCamisaJogador;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbxTimes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxPosicaoJogador;
    }
}

