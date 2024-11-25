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
    public partial class FixDecimal : DevExpress.XtraEditors.XtraForm
    {
        public FixDecimal()
        {
            InitializeComponent();
        }

        private void FixDecimal_Load(object sender, EventArgs e)
        {
            conversion_type.SelectedIndex = 0;
        }

        private void conversion_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(conversion_type.SelectedIndex == 0)
            {
                from_base_label.Text = "2";
                to_base_label.Text = "10";
                label_nb_bits.Visible = nb_bits.Visible = false;
            }
            else
            {
                from_base_label.Text = "10";
                to_base_label.Text = "2";
                label_nb_bits.Visible = nb_bits.Visible = true;
            }
        }

        private bool verify_base(string text, int b = 2)
        {
            int l = text.Length;

            for (int i = 0; i < l; i++)
            {
                if (b == 2)
                {
                    if (!text[i].Equals('0') && !text[i].Equals('1') && !text[i].Equals(',') && !text[i].Equals('.'))
                    {
                        return false;
                    }
                }
                else if (b == 10)
                {
                    if (!text[i].Equals('0') && !text[i].Equals('1') &&
                        !text[i].Equals('2') && !text[i].Equals('3') &&
                        !text[i].Equals('4') && !text[i].Equals('5') &&
                        !text[i].Equals('6') && !text[i].Equals('7') &&
                        !text[i].Equals('8') && !text[i].Equals('9') &&
                        !text[i].Equals(',') && !text[i].Equals('.') &&
                        !text[i].Equals('+') && !text[i].Equals('-'))
                        return false;
                }
            }

            if(text.Contains(",") || text.Contains("."))
            {
                string tmp = text.Replace(",", ".");
                string[] parts = tmp.Split('.');
                if (parts.Length > 2) return false;
            }

            return true;
        }

        // Fonction qui converti les parties décimales binaires vers la base 10
        private string dp_decimal_to_binary(string text)
        {
            string finalValue = "";
            try
            {
                string m_text = "0," + text;

                int max_bits = int.Parse(nb_bits.Text);
                double nb = double.Parse(m_text);

                for(int i = 1; i <= max_bits; i++)
                {
                    if (nb >= Math.Pow(2, -i))
                    {
                        nb -= Math.Pow(2, -i);
                        finalValue += "1";
                    }
                    else finalValue += "0";
                        
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur:dp_decimal_to_binary", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            return finalValue;
        }

        // Fonction qui converti les entiers de la base 10 vers la base 2 
        private string full_decimal_to_binary(string text)
        {
            int base_nb = 2;
            int nb = int.Parse(text);
            int q = nb;
            string tmpValue = "";

            // Division du nombre dans ses 2 parties

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

        // Fontion de passage de la base 2 à la base 10
        private string binary_to_decimal(string text)
        {
            // Correction rapide du nombre
            string tmp = text.Replace(',', '.');

            // Pour converver les valeurs maximales et minimales representables
            double max_pos_value = 0, min_pos_value = 0,
                max_neg_value = 0, min_neg_value = 0;

            string max_pos_binary = "0", min_pos_binary = "0",
                max_neg_binary = "1", min_neg_binary = "1";

            // Récupérer les différentes parties
            // Bit de signe
            char sign = tmp[0];

            //Partie entière
            string[] parts = tmp.Split('.');
            string pa = "", pd = "";

            for(int i = 1; i < parts[0].Length; i++)
            {
                pa += parts[0][i];
            }

            if(parts.Length > 1)
            {
                // Partie décimale
                pd = parts[1];
            }

            // nombre sans signe ni virgule
            string nb = pa + pd;

            // Valeur partie entière
            int p_max = pa.Length - 1;
            int p_min = 0 - pd.Length;

            double finalValue = 0;

            for (int i = 0; i < nb.Length; i++)
            {
                int bit = int.Parse(nb[i].ToString());
                finalValue += bit * Math.Pow(2, p_max - i);
            }

            string type = sign.Equals('1') ? "negatif" :  "positif";

            if (sign.Equals('1'))finalValue *= -1;

            // Calcul du plus grand nombre représentable avec cette convention de bits
            double max_value = 0, min_value = 0;
            string max_binary = "", min_binary = "";

            for (int i = p_min; i <= p_max; i++)
            {
                max_value += Math.Pow(2, i);
            }

            for (int i = 0; i <= nb.Length; i++ )
            {
                if (i == pa.Length)
                {
                    max_binary += ".";
                    min_binary += ".";
                }
                else if(i == nb.Length)
                {
                    max_binary += "1";
                    min_binary += "1";
                }
                else
                {
                    max_binary += "1";
                    min_binary += "0";
                }
            }

            // Calcul du plus petit nombre représentable avec cette convention de bits
            min_value = Math.Pow(2, p_min);

            max_pos_value = max_value; // Plus grande valeur positive
            max_neg_value = -1 * min_value; // Plus grande valeur négative
            min_pos_value = min_value; // Plus petite valeur positive
            min_neg_value = -1 * max_value; // Plus petite valeur négative

            max_pos_binary += max_binary; // Plus grande valeur positive
            max_neg_binary += min_binary; // Plus grande valeur négative
            min_pos_binary += min_binary; // Plus petite valeur positive
            min_neg_binary += max_binary; // Plus petite valeur négative

            // Compléter les informations supplémentaires
            sign_information.Text = String.Format("Le nombre {0} en base 2 est écrit sur {1} bits. \nLe premier bit ({2}) est celui du signe, il indique que le nombre est {3}", text, nb.Length + 1, sign, type);
            epart_information.Text = String.Format("La partie entière {0} est écrite sur {1} bits", pa, pa.Length);
            dpart_information.Text = String.Format("La partie décimale {0} est écrite sur {1} bits", pd, pd.Length);
            biggest_numbers.Text = String.Format("La plus grande valeur positive est ({0})_2 = ({1})_10 \nLa plus grande valeur négative est ({2})_2 = ({3})_10 ", max_pos_binary, max_pos_value, max_neg_binary, max_neg_value);
            smallest_numbers.Text = String.Format("La plus petite valeur positive est ({0})_2 = ({1})_10 \nLa plus petite valeur négative est ({2})_2 = ({3})_10 ", min_pos_binary, min_pos_value, min_neg_binary, min_neg_value);

            return finalValue.ToString();
        }

        // Fonction de passage de la base 10 à la base 2
        private string decimal_to_binary(string text)
        {
            // Correction rapide du nombre
            string tmp = text.Replace(',', '.');

            // Pour converver les valeurs maximales et minimales representables
            double max_pos_value = 0, min_pos_value = 0,
                max_neg_value = 0, min_neg_value = 0;

            string max_pos_binary = "0", min_pos_binary = "0",
                max_neg_binary = "1", min_neg_binary = "1";

            // Récupérer les différentes parties
            // Bit de signe
            char sign = tmp[0];

            //Partie entière
            string[] parts = tmp.Split('.');
            string pa = "", pd = "";

            int go = sign.Equals('-') ? 1 : 0;

            for (int i = go; i < parts[0].Length; i++)
            {
                pa += parts[0][i];
            }

            if (parts.Length > 1)
            {
                // Partie décimale
                pd = parts[1];
            }

            string pa_to_decimal = full_decimal_to_binary(pa);
            string pd_to_decimal = "0";
            string finalValue = "";

            if (pd != "")
                pd_to_decimal = dp_decimal_to_binary(pd);

            // Fusionn de la partie entière et de la partie décimale
            finalValue = go + pa_to_decimal + "." + pd_to_decimal;

            this.binary_to_decimal(finalValue);
            return finalValue;
        }

        private void convert_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int fb = int.Parse(from_base_label.Text);

                if (!this.verify_base(from_value_text.Text, fb))
                {
                    MessageBox.Show("La valeur entrée n'appartient pas à la base sélectionnée( base " + from_base_label.Text + ")", "Valeur non autorisée", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int tb = int.Parse(to_base_label.Text);

                    // De la base 2 à la base 10
                    if (fb == 2 && tb == 10)
                    {
                        to_value_text.Text = this.binary_to_decimal(from_value_text.Text);
                    }
                        // De la base 10 à la base 2
                    else if (fb == 10 && tb == 2)
                    {
                        to_value_text.Text = this.decimal_to_binary(from_value_text.Text);
                    }
                    // Si les bases d'entrées et de sorties sont similaires
                    else to_value_text.Text = from_value_text.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nb_bits_Leave(object sender, EventArgs e)
        {
            try
            {
                int nb = int.Parse(nb_bits.Text);
                if(nb < 0 || nb > 20)
                {
                    nb_bits.Text = "2";
                    MessageBox.Show("Veuillez entrer un entier compris entre 2 et 20", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}