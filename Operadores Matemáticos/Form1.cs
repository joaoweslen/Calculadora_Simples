using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operadores_Matemáticos
{
    public partial class frmOperadores : Form
    {
        public frmOperadores()
        {
            InitializeComponent();
        }

        private void frmOperadores_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Double OpEsquerdo=0, OpDireito=0, resultado=0;
            string operador;
            
            OpEsquerdo = double.Parse(txtOperadorEsquerdo.Text);
            OpDireito = double.Parse(txtOperadorDireito.Text);

            //Verificar qual radio está selecionado.
            if (rdbAdicao.Checked)
            {
                operador = "+";
                resultado = OpEsquerdo + OpDireito;
                txtResultado.Text = resultado.ToString();
            }
            else if (rdbSubtracao.Checked)
            {
                operador = "-";
                resultado = OpEsquerdo - OpDireito;
                txtResultado.Text = resultado.ToString();
            }
            else if (rdbMultiplicacao.Checked)
            {
                operador = "X";
                resultado = OpEsquerdo * OpDireito;
                txtResultado.Text = resultado.ToString();
            }
            else if (rdbDivisao.Checked)
            {
                operador = "/";
                if (OpDireito == 0)
                {
                    txtResultado.Text = "Impossível dividir por ZERO";
                }
                else
                {
                    resultado = OpEsquerdo / OpDireito;
                    txtResultado.Text = resultado.ToString();
                }
            }
            else
            {
                operador = "%";
                if (OpDireito == 0)
                {
                    txtResultado.Text = "Impossível dividir por ZERO";
                }
                else
                {
                    resultado = OpEsquerdo % OpDireito;
                    txtResultado.Text = resultado.ToString();
                }
            }

            txtExpressao.Text = txtOperadorEsquerdo.Text + " " + operador + " " + txtOperadorDireito.Text;

        }
    }
}
