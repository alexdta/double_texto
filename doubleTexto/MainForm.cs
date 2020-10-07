using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace doubleTexto
{

    public partial class MainForm : Form
    {

        Dictionary<double, string> cifras = new Dictionary<double, string>()
        {
            { 0, "cero" },
            { 1, "uno" },
            { 2, "dos" },
            { 3, "tres" },
            { 4, "cuatro" },
            { 5, "cinco" },
            { 6, "seis" },
            { 7, "siete" },
            { 8, "ocho" },
            { 9, "nueve" },
            { 10, "diez" },
            { 11, "once" },
            { 12, "doce" },
            { 13, "trece" },
            { 14, "catorce" },
            { 15, "quince" },
            { 20, "veinte" },
            { 30, "treinta" },
            { 40, "cuarenta" },
            { 50, "cincuenta" },
            { 60, "sesenta" },
            { 70, "setenta" },
            { 80, "ochenta" },
            { 90, "noventa" },
            { 100, "cien" },
            { 500, "quinientos" },
            { 700, "setecientos" },
            { 900, "novecientos" },
            { 1000, "mil"},
            { 1000000, "un millón"},
            { 1000000000000, "un billón"}
        };

        #region Constructor

        public MainForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Metodos

        private string cifraLetras(double pValor)
        {
            double lCifra = Math.Truncate(pValor);

            string lResultado = numeroTexto(lCifra);

            var lDecimales = Math.Round((pValor - lCifra) * 100, 2);

            if (lDecimales > 0)
            {
                lResultado += " con " + lDecimales.ToString() + "/100";
            }

            return lResultado;
        }

        private string numeroTexto(double pValor)
        {
            string lNum2Text = "";

            try
            {
                if (pValor >= 0 && pValor <= 15)
                {
                    //0 - 15
                    lNum2Text = cifras[pValor];
                }
                else if (pValor < 20)
                {
                    //16 - 19
                    lNum2Text = "dieci" + numeroTexto(pValor - 10);
                }
                else if (pValor == 20)
                {
                    //20
                    lNum2Text = cifras[pValor];
                }
                else if (pValor < 30)
                {
                    //21-29
                    lNum2Text = "veinti" + numeroTexto(pValor - 20);
                }
                else if (pValor < 100 && pValor % 10 == 0)
                {
                    lNum2Text = cifras[pValor];
                }
                else if (pValor < 100 && pValor % 10 != 0)
                {
                    double a = (Math.Truncate(pValor / 10)) * 10;
                    double b = pValor % 10;
                    lNum2Text = cifras[a] + " y " + cifras[b];
                }
                else if (pValor == 100)
                {
                    lNum2Text = cifras[pValor];
                }
                else if (pValor < 200)
                {
                    lNum2Text = "ciento " + numeroTexto(pValor - 100);
                }
                else if (pValor < 1000 && (new List<double> { 200, 300, 400, 600, 800 }).Contains(pValor))
                {
                    lNum2Text = numeroTexto(Math.Truncate(pValor / 100)) + "cientos";
                }
                else if (pValor < 1000 && (new List<double> { 500, 700, 900 }).Contains(pValor))
                {
                    lNum2Text = cifras[pValor];
                }
                else if (pValor < 1000)
                {
                    lNum2Text = numeroTexto(Math.Truncate(pValor / 100) * 100) + " " + numeroTexto(pValor % 100);
                }
                else if (pValor == 1000)
                {
                    lNum2Text = cifras[pValor];
                }
                else if (pValor < 2000)
                {
                    double a = 1000;
                    double b = pValor % a;
                    lNum2Text = cifras[a] + " " + numeroTexto(b);
                }
                else if (pValor < 1000000)
                {
                    double a = Math.Truncate(pValor / 1000);
                    double b = pValor % 1000;

                    lNum2Text = numeroTexto(a) + " " + cifras[1000];

                    if ((pValor % 1000) > 0)
                    {
                        lNum2Text = lNum2Text + " " + numeroTexto(b);
                    }
                }
                else if (pValor == 1000000)
                {
                    lNum2Text = cifras[pValor];
                }
                else if (pValor < 2000000)
                {
                    double a = 1000000;
                    double b = pValor % a;
                    lNum2Text = cifras[a] + " " + numeroTexto(b);
                }
                else if (pValor < 1000000000000)
                {
                    lNum2Text = numeroTexto(Math.Truncate(pValor / 1000000)) + " millones ";

                    if ((pValor - Math.Truncate(pValor / 1000000) * 1000000) > 0)
                    {
                        lNum2Text = lNum2Text + numeroTexto(pValor - Math.Truncate(pValor / 1000000) * 1000000);
                    }
                }
                else if (pValor == 1000000000000)
                {
                    lNum2Text = cifras[pValor];
                }
                else if (pValor < 2000000000000)
                {
                    lNum2Text =
                        cifras[1000000000000] + " " + numeroTexto(pValor - Math.Truncate(pValor / 1000000000000) * 1000000000000);
                }
                else
                {
                    lNum2Text = numeroTexto(Math.Truncate(pValor / 1000000000000)) + " billones";

                    if ((pValor - Math.Truncate(pValor / 1000000000000) * 1000000000000) > 0)
                    {
                        lNum2Text = lNum2Text + " " + numeroTexto(pValor - Math.Truncate(pValor / 1000000000000) * 1000000000000);
                    }
                }
            }
            catch (Exception lExcp)
            {
                MessageBox.Show(lExcp.Message);
            }

            return lNum2Text;
        }

        #endregion

        #region Botones

        void BtnConvert_Click(object sender, EventArgs e)
        {
            this.cdrTexto.Clear();
            this.cdrTexto.Text += cifraLetras(Convert.ToDouble(this.cdrNumer.Text));
        }

        #endregion

    }
}