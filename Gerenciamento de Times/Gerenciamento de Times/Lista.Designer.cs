namespace Gerenciamento_de_Times
{
    partial class Lista
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
            this.btnListar = new System.Windows.Forms.Button();
            this.txtLista = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbListar = new System.Windows.Forms.RadioButton();
            this.rdbInvertido = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(186, 23);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(122, 25);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // txtLista
            // 
            this.txtLista.Location = new System.Drawing.Point(14, 67);
            this.txtLista.Multiline = true;
            this.txtLista.Name = "txtLista";
            this.txtLista.Size = new System.Drawing.Size(294, 377);
            this.txtLista.TabIndex = 1;
            this.txtLista.TextChanged += new System.EventHandler(this.txtLista_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbInvertido);
            this.groupBox1.Controls.Add(this.rdbListar);
            this.groupBox1.Controls.Add(this.btnListar);
            this.groupBox1.Controls.Add(this.txtLista);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 459);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listar";
            // 
            // rdbListar
            // 
            this.rdbListar.AutoSize = true;
            this.rdbListar.Location = new System.Drawing.Point(14, 27);
            this.rdbListar.Name = "rdbListar";
            this.rdbListar.Size = new System.Drawing.Size(50, 17);
            this.rdbListar.TabIndex = 1;
            this.rdbListar.TabStop = true;
            this.rdbListar.Text = "Listar";
            this.rdbListar.UseVisualStyleBackColor = true;
            // 
            // rdbInvertido
            // 
            this.rdbInvertido.AutoSize = true;
            this.rdbInvertido.Location = new System.Drawing.Point(90, 27);
            this.rdbInvertido.Name = "rdbInvertido";
            this.rdbInvertido.Size = new System.Drawing.Size(94, 17);
            this.rdbInvertido.TabIndex = 2;
            this.rdbInvertido.TabStop = true;
            this.rdbInvertido.Text = "Listar Invertido";
            this.rdbInvertido.UseVisualStyleBackColor = true;
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 480);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Lista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.TextBox txtLista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbInvertido;
        private System.Windows.Forms.RadioButton rdbListar;
    }
}