using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult opcion = MessageBox.Show("¿Esta Seguro/a que Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (opcion == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            string numero1 = this.txtNumero1.Text; 
            string numero2 = this.txtNumero2.Text;
            string operador = this.cmbOperador.Text;
            double resultado;

            if (string.IsNullOrEmpty(operador))
            {
                operador = '+'.ToString();
            }

            resultado = Operar(numero1, numero2, operador);

            this.lblResultado.Text = resultado.ToString();
            this.lstOperaciones.Items.Add($"{numero1} {operador} {numero2} = {resultado}");            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando conversorBinario = new Operando();
            string binario;

            binario = conversorBinario.DecimalBinario(double.Parse(lblResultado.Text));

            if (string.IsNullOrEmpty(binario))
            {
                binario = "No";
            }

            this.lstOperaciones.Items.Add($"{lblResultado.Text} a Binario: {binario}");
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando conversorDecimal = new Operando();
            string numDecimal;
            
            numDecimal = conversorDecimal.BinarioDecimal(lblResultado.Text);

            this.lstOperaciones.Items.Add($"{lblResultado.Text} a Decimal: {numDecimal}");

        }

        private static double Operar(string numero1, string numero2, string operador)
        {

            double resultado;
            Operando operando1 = new Operando();
            Operando operando2 = new Operando();

            operando1.Numero = numero1;
            operando2.Numero = numero2;

            resultado = Calculadora.Operar(operando1, operando2, char.Parse(operador));

            return resultado;
        }

        private void Limpiar()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            lstOperaciones.Items.Clear();
            cmbOperador.Items.Clear();
            cmbOperador.Items.Add(string.Empty);
            cmbOperador.Items.Add($"+");
            cmbOperador.Items.Add($"-");
            cmbOperador.Items.Add($"/");
            cmbOperador.Items.Add($"*");
            lblResultado.Text = 0.ToString();
        }
    }
}
