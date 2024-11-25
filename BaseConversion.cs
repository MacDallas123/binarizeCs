using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BinarizeFormApplication
{
    public partial class BaseConversion : DevExpress.XtraEditors.XtraForm
    {
        public BaseConversion()
        {
            InitializeComponent();
        }

        private void BaseConversion_Load(object sender, EventArgs e)
        {
            from_combo.SelectedIndex = 0;
            to_combo.SelectedIndex = 2;
        }

        private void from_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            from_base_label.Text = from_combo.SelectedItem.ToString();
        }

        private void to_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            to_base_label.Text = to_combo.SelectedItem.ToString();
        }

        private bool verify_base(string text, int b=2)
        {
            int l = text.Length;

            for (int i = 0; i < l; i++)
            {
                if(b == 2)
                {
                    if (!text[i].Equals('0') && !text[i].Equals('1'))
                    {
                        return false;
                    }
                }
                else if (b == 8) {
                    if (!text[i].Equals('0') && !text[i].Equals('1') &&
                        !text[i].Equals('2') && !text[i].Equals('3') &&
                        !text[i].Equals('4') && !text[i].Equals('5') &&
                        !text[i].Equals('6') && !text[i].Equals('7'))
                        return false;
                }
                else if (b == 10) {
                    if (!text[i].Equals('0') && !text[i].Equals('1') &&
                        !text[i].Equals('2') && !text[i].Equals('3') &&
                        !text[i].Equals('4') && !text[i].Equals('5') &&
                        !text[i].Equals('6') && !text[i].Equals('7') &&
                        !text[i].Equals('8') && !text[i].Equals('9'))
                        return false;
                }
                else if (b == 16) {
                    if (!text[i].Equals('0') && !text[i].Equals('1') &&
                        !text[i].Equals('2') && !text[i].Equals('3') &&
                        !text[i].Equals('4') && !text[i].Equals('5') &&
                        !text[i].Equals('6') && !text[i].Equals('7') &&
                        !text[i].Equals('8') && !text[i].Equals('9') &&
                        !text[i].Equals('A') && !text[i].Equals('a') &&
                        !text[i].Equals('B') && !text[i].Equals('b') &&
                        !text[i].Equals('C') && !text[i].Equals('c') &&
                        !text[i].Equals('D') && !text[i].Equals('d') &&
                        !text[i].Equals('E') && !text[i].Equals('e') &&
                        !text[i].Equals('F') && !text[i].Equals('f'))
                        return false;
                }
            }
            
            return true;
        }

        // Fonction de passage de la base 10 à la base 2
        private string decimal_to_binary(string text)
        {
            int base_nb = 2;
            int nb = int.Parse(text);
            int q = nb;
            string tmpValue = "";

            while (q != 0)
            {
                tmpValue += q % base_nb;
                double m = q / base_nb;
                q = (int)Math.Floor(m);
            }

            string finalValue = "";
            // Inversion des restes de division
            for (int i = tmpValue.Length - 1; i > -1; i--)
            {
                finalValue += tmpValue[i];
            }

            return finalValue;
        }

        // Fonction de passage de la base 10 à la base 8
        private string decimal_to_octal(string text)
        {
            int base_nb = 8;
            int nb = int.Parse(text);
            int q = nb;
            string tmpValue = "";

            while (q != 0)
            {
                tmpValue += q % base_nb;
                double m = q / base_nb;
                q = (int)Math.Floor(m);
            }

            string finalValue = "";
            // Inversion des restes de division
            for (int i = tmpValue.Length - 1; i > -1; i--)
            {
                finalValue += tmpValue[i];
            }

            return finalValue;
        }

        // Fonction de passage de la base 10 à la base 8
        private string decimal_to_hexadecimal(string text)
        {
            int base_nb = 16;
            int nb = int.Parse(text);
            int q = nb;
            string tmpValue = "";

            while (q != 0)
            {
                int r = q % base_nb;

                if (r == 10) tmpValue += "A";
                else if (r == 11) tmpValue += "B";
                else if (r == 12) tmpValue += "C";
                else if (r == 13) tmpValue += "D";
                else if (r == 14) tmpValue += "E";
                else if (r == 15) tmpValue += "F";
                else tmpValue += r;

                double m = q / base_nb;
                q = (int)Math.Floor(m);
            }

            string finalValue = "";
            // Inversion des restes de division
            for (int i = tmpValue.Length - 1; i > -1; i--)
            {
                finalValue += tmpValue[i];
            }

            return finalValue;
        }

        // Fontion de passage de la base 2 à la base 10
        private string binary_to_decimal(string text)
        {
            // Poids max
            int p_max = text.Length - 1;
            int finalValue = 0;

            for (int i = 0; i < text.Length; i++)
            {
                int bit = int.Parse(text[i].ToString());
                finalValue += (int)(bit * Math.Pow(2, p_max - i));
            }

            return finalValue.ToString();
        }

        // Fonction de passage de la base 2 à la base 8
        private string binary_to_octal(string text)
        {
            // pour cette fonction on a un compteur 3 qui représente le nombre de bits à retenir par itération
            int c = 3;
            int l = text.Length;
            int nb_zeros = c - l % c;
            string tmp = text, finalText = "";

            // Ajout des 0 pour équilibrer le nombre de bits
            for (int i = 0; i < nb_zeros && nb_zeros < c; i++)
            {
                tmp = "0" + tmp;
            }

            // nombre d'iterations
            int nb_iter = tmp.Length / c;

            // Itérer 3 bits après trois bits
            for(int i = 0; i < nb_iter; i++)
            {
                string loc = tmp.Substring(i * c, c);
                finalText += this.binary_to_decimal(loc);

                Console.WriteLine("loc = " + loc + "; final = " + finalText);
            }

            return finalText;
        }

        // Fonction de passage de la base 2 à la base 16
        private string binary_to_hexadecimal(string text)
        {
            // pour cette fonction on a un compteur 4 qui représente le nombre de bits à retenir par itération
            int c = 4;
            int l = text.Length;
            int nb_zeros = c - l % c;
            string tmp = text, finalText = "";

            // Ajout des 0 pour équilibrer le nombre de bits
            for (int i = 0; i < nb_zeros && nb_zeros < c; i++)
            {
                tmp = "0" + tmp;
            }

            // nombre d'iterations
            int nb_iter = tmp.Length / c;

            // Itérer 4 bits après 4 bits
            for (int i = 0; i < nb_iter; i++)
            {
                string loc = tmp.Substring(i * c, c);
                int hexa_nb = int.Parse(this.binary_to_decimal(loc));
                if (hexa_nb == 10) finalText += "A";
                else if (hexa_nb == 11) finalText += "B";
                else if (hexa_nb == 12) finalText += "C";
                else if (hexa_nb == 13) finalText += "D";
                else if (hexa_nb == 14) finalText += "E";
                else if (hexa_nb == 15) finalText += "F";
                else finalText += hexa_nb;

                Console.WriteLine(i + " - final = " + finalText);
            }

            return finalText;
        }

        // Fontion de passage de la base 8 à la base 10
        private string octal_to_decimal(string text)
        {
            // Poids max
            int p_max = text.Length - 1;
            int finalValue = 0;

            for (int i = 0; i < text.Length; i++)
            {
                int bit = int.Parse(text[i].ToString());
                finalValue += (int)(bit * Math.Pow(8, p_max - i));
            }

            return finalValue.ToString();
        }

        // Fonction de passage de la base 8 à la base 2
        private string octal_to_binary(string text)
        {
            string decimalValue = this.octal_to_decimal(text);

            return this.decimal_to_binary(decimalValue);
        }

        // Fonction de passage de la base 8 à la base 16
        private string octal_to_hexadecimal(string text)
        {
            string binaryValue = this.octal_to_binary(text);

            return this.binary_to_hexadecimal(binaryValue);
        }

        // Fontion de passage de la base 16 à la base 2
        private string hexadecimal_to_decimal(string text)
        {
            // Poids max
            int p_max = text.Length - 1;
            int finalValue = 0;

            for (int i = 0; i < text.Length; i++)
            {
                int bit = 0;
                if (text[i].Equals('A') || text[i].Equals('a')) bit = 10;
                else if (text[i].Equals('B') || text[i].Equals('b')) bit = 11;
                else if (text[i].Equals('C') || text[i].Equals('c')) bit = 12;
                else if (text[i].Equals('D') || text[i].Equals('d')) bit = 13;
                else if (text[i].Equals('E') || text[i].Equals('e')) bit = 14;
                else if (text[i].Equals('F') || text[i].Equals('f')) bit = 15;
                else bit = int.Parse(text[i].ToString());
                finalValue += (int)(bit * Math.Pow(16, p_max - i));
            }

            return finalValue.ToString();
        }

        // Fonction de passage de la base 16 à la base 2
        private string hexadecimal_to_binary(string text)
        {
            string decimalValue = this.hexadecimal_to_decimal(text);

            return this.decimal_to_binary(decimalValue);
        }

        // Fonction de passage de la base 16 à la base 8
        private string hexadecimal_to_octal(string text)
        {
            string binaryValue = this.hexadecimal_to_binary(text);

            return this.binary_to_octal(binaryValue);
        }

        private void convert_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int fb = int.Parse(from_base_label.Text);

                if(!this.verify_base(from_value_text.Text, fb))
                {
                    MessageBox.Show("La valeur entrée n'appartient pas à la base sélectionnée( base " + from_base_label.Text + ")", "Valeur non autorisée", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int tb = int.Parse(to_base_label.Text);

                    // De la base 2 à la base n
                    if(fb == 2 && tb == 8)
                    {
                        to_value_text.Text = this.binary_to_octal(from_value_text.Text);
                    }
                    else if(fb == 2 && tb == 10)
                    {
                        to_value_text.Text = this.binary_to_decimal(from_value_text.Text);
                    }
                    else if (fb == 2 && tb == 16)
                    {
                        to_value_text.Text = this.binary_to_hexadecimal(from_value_text.Text);
                    }
                    // De la base 8 à la base n
                    else if (fb == 8 && tb == 2)
                    {
                        to_value_text.Text = this.octal_to_binary(from_value_text.Text);
                    }
                    else if (fb == 8 && tb == 10)
                    {
                        to_value_text.Text = this.octal_to_decimal(from_value_text.Text);
                    }
                    else if (fb == 8 && tb == 16)
                    {
                        to_value_text.Text = this.octal_to_hexadecimal(from_value_text.Text);
                    }
                    // De la base 10 à la base n
                    else if (fb == 10 && tb == 2)
                    {
                        to_value_text.Text = this.decimal_to_binary(from_value_text.Text);
                    }
                    else if (fb == 10 && tb == 8)
                    {
                        to_value_text.Text = this.decimal_to_octal(from_value_text.Text);
                    }
                    else if (fb == 10 && tb == 16)
                    {
                        to_value_text.Text = this.decimal_to_hexadecimal(from_value_text.Text);
                    }
                    // De la base 16 à la base n
                    else if (fb == 16 && tb == 2)
                    {
                        to_value_text.Text = this.hexadecimal_to_binary(from_value_text.Text);
                    }
                    else if (fb == 16 && tb == 8)
                    {
                        to_value_text.Text = this.hexadecimal_to_octal(from_value_text.Text);
                    }
                    else if (fb == 16 && tb == 10)
                    {
                        to_value_text.Text = this.hexadecimal_to_decimal(from_value_text.Text);
                    }
                    // Si les bases d'entrées et de sorties sont similaires
                    else to_value_text.Text = from_value_text.Text;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}