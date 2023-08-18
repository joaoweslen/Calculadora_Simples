namespace Operadores_Matemáticos
{
    partial class frmOperadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOperadores));
            this.lblEsquerdo = new System.Windows.Forms.Label();
            this.lblDireito = new System.Windows.Forms.Label();
            this.txtOperadorEsquerdo = new System.Windows.Forms.TextBox();
            this.txtOperadorDireito = new System.Windows.Forms.TextBox();
            this.rdbAdicao = new System.Windows.Forms.RadioButton();
            this.rdbSubtracao = new System.Windows.Forms.RadioButton();
            this.rdbDivisao = new System.Windows.Forms.RadioButton();
            this.rdbMultiplicacao = new System.Windows.Forms.RadioButton();
            this.rdbResto = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblExpressao = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtExpressao = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEsquerdo
            // 
            this.lblEsquerdo.AutoSize = true;
            this.lblEsquerdo.Location = new System.Drawing.Point(16, 27);
            this.lblEsquerdo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEsquerdo.Name = "lblEsquerdo";
            this.lblEsquerdo.Size = new System.Drawing.Size(149, 20);
            this.lblEsquerdo.TabIndex = 0;
            this.lblEsquerdo.Text = "Operador Esquerdo";
            // 
            // lblDireito
            // 
            this.lblDireito.AutoSize = true;
            this.lblDireito.Location = new System.Drawing.Point(191, 27);
            this.lblDireito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireito.Name = "lblDireito";
            this.lblDireito.Size = new System.Drawing.Size(126, 20);
            this.lblDireito.TabIndex = 1;
            this.lblDireito.Text = "Operador Direito";
            // 
            // txtOperadorEsquerdo
            // 
            this.txtOperadorEsquerdo.Location = new System.Drawing.Point(24, 52);
            this.txtOperadorEsquerdo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOperadorEsquerdo.Name = "txtOperadorEsquerdo";
            this.txtOperadorEsquerdo.Size = new System.Drawing.Size(133, 26);
            this.txtOperadorEsquerdo.TabIndex = 2;
            // 
            // txtOperadorDireito
            // 
            this.txtOperadorDireito.Location = new System.Drawing.Point(195, 52);
            this.txtOperadorDireito.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOperadorDireito.Name = "txtOperadorDireito";
            this.txtOperadorDireito.Size = new System.Drawing.Size(133, 26);
            this.txtOperadorDireito.TabIndex = 3;
            // 
            // rdbAdicao
            // 
            this.rdbAdicao.AutoSize = true;
            this.rdbAdicao.Checked = true;
            this.rdbAdicao.Location = new System.Drawing.Point(40, 102);
            this.rdbAdicao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbAdicao.Name = "rdbAdicao";
            this.rdbAdicao.Size = new System.Drawing.Size(96, 24);
            this.rdbAdicao.TabIndex = 4;
            this.rdbAdicao.TabStop = true;
            this.rdbAdicao.Text = "+ Adição";
            this.rdbAdicao.UseVisualStyleBackColor = true;
            // 
            // rdbSubtracao
            // 
            this.rdbSubtracao.AutoSize = true;
            this.rdbSubtracao.Location = new System.Drawing.Point(200, 102);
            this.rdbSubtracao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbSubtracao.Name = "rdbSubtracao";
            this.rdbSubtracao.Size = new System.Drawing.Size(117, 24);
            this.rdbSubtracao.TabIndex = 5;
            this.rdbSubtracao.Text = "- Subtração";
            this.rdbSubtracao.UseVisualStyleBackColor = true;
            // 
            // rdbDivisao
            // 
            this.rdbDivisao.AutoSize = true;
            this.rdbDivisao.Location = new System.Drawing.Point(40, 147);
            this.rdbDivisao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbDivisao.Name = "rdbDivisao";
            this.rdbDivisao.Size = new System.Drawing.Size(93, 24);
            this.rdbDivisao.TabIndex = 7;
            this.rdbDivisao.Text = "/ Divisão";
            this.rdbDivisao.UseVisualStyleBackColor = true;
            // 
            // rdbMultiplicacao
            // 
            this.rdbMultiplicacao.AutoSize = true;
            this.rdbMultiplicacao.Location = new System.Drawing.Point(200, 147);
            this.rdbMultiplicacao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbMultiplicacao.Name = "rdbMultiplicacao";
            this.rdbMultiplicacao.Size = new System.Drawing.Size(135, 24);
            this.rdbMultiplicacao.TabIndex = 6;
            this.rdbMultiplicacao.Text = "* Multiplicação";
            this.rdbMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // rdbResto
            // 
            this.rdbResto.AutoSize = true;
            this.rdbResto.Location = new System.Drawing.Point(126, 190);
            this.rdbResto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbResto.Name = "rdbResto";
            this.rdbResto.Size = new System.Drawing.Size(95, 24);
            this.rdbResto.TabIndex = 8;
            this.rdbResto.Text = "% Resto";
            this.rdbResto.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(24, 375);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(112, 35);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblExpressao
            // 
            this.lblExpressao.AutoSize = true;
            this.lblExpressao.Location = new System.Drawing.Point(20, 253);
            this.lblExpressao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpressao.Name = "lblExpressao";
            this.lblExpressao.Size = new System.Drawing.Size(88, 20);
            this.lblExpressao.TabIndex = 10;
            this.lblExpressao.Text = "Expressão:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(20, 307);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(86, 20);
            this.lblResultado.TabIndex = 11;
            this.lblResultado.Text = "Resultado:";
            // 
            // txtExpressao
            // 
            this.txtExpressao.Enabled = false;
            this.txtExpressao.Location = new System.Drawing.Point(116, 250);
            this.txtExpressao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtExpressao.Name = "txtExpressao";
            this.txtExpressao.Size = new System.Drawing.Size(188, 26);
            this.txtExpressao.TabIndex = 12;
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(116, 304);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(188, 26);
            this.txtResultado.TabIndex = 13;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(216, 375);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(112, 35);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmOperadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 438);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtExpressao);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblExpressao);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.rdbResto);
            this.Controls.Add(this.rdbDivisao);
            this.Controls.Add(this.rdbMultiplicacao);
            this.Controls.Add(this.rdbSubtracao);
            this.Controls.Add(this.rdbAdicao);
            this.Controls.Add(this.txtOperadorDireito);
            this.Controls.Add(this.txtOperadorEsquerdo);
            this.Controls.Add(this.lblDireito);
            this.Controls.Add(this.lblEsquerdo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmOperadores";
            this.Text = "Calculadora Simples";
            this.Load += new System.EventHandler(this.frmOperadores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEsquerdo;
        private System.Windows.Forms.Label lblDireito;
        private System.Windows.Forms.TextBox txtOperadorEsquerdo;
        private System.Windows.Forms.TextBox txtOperadorDireito;
        private System.Windows.Forms.RadioButton rdbAdicao;
        private System.Windows.Forms.RadioButton rdbSubtracao;
        private System.Windows.Forms.RadioButton rdbDivisao;
        private System.Windows.Forms.RadioButton rdbMultiplicacao;
        private System.Windows.Forms.RadioButton rdbResto;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblExpressao;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtExpressao;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnSair;
    }
}

