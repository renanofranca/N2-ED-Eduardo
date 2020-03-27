namespace Gerenciamento_de_Times
{
    partial class Remover
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdbTime = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbJogador = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbTime
            // 
            this.rdbTime.AutoSize = true;
            this.rdbTime.Location = new System.Drawing.Point(74, 32);
            this.rdbTime.Name = "rdbTime";
            this.rdbTime.Size = new System.Drawing.Size(48, 17);
            this.rdbTime.TabIndex = 0;
            this.rdbTime.TabStop = true;
            this.rdbTime.Text = "Time";
            this.rdbTime.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemover);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rdbJogador);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdbTime);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 129);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(146, 99);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 5;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(74, 69);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(147, 20);
            this.txtNome.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // rdbJogador
            // 
            this.rdbJogador.AutoSize = true;
            this.rdbJogador.Location = new System.Drawing.Point(150, 32);
            this.rdbJogador.Name = "rdbJogador";
            this.rdbJogador.Size = new System.Drawing.Size(63, 17);
            this.rdbJogador.TabIndex = 2;
            this.rdbJogador.TabStop = true;
            this.rdbJogador.Text = "Jogador";
            this.rdbJogador.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Remover:";
            // 
            // Remover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 153);
            this.Controls.Add(this.groupBox1);
            this.Name = "Remover";
            this.Text = "Remover";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbJogador;
        private System.Windows.Forms.Label label1;
    }
}