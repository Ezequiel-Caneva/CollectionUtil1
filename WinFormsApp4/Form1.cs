using Calc.core.Interfaces;
using CalculadoraCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        private Icalc _calc;

        private List<Button> lista;
        public Form1(Icalc calc)
        {
            _calc = calc;
            _calc.Procesando += Calc_Procesando_Demo;
            _calc.Termino += Calc_Termino_Demo;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var resultado = _calc.Suma(1, 1);
            label1.Text = resultado.ToString();
        }
        private void Calc_Procesando_Demo(object sender, EventArgs e)
        {
            Estado.Text = "procesando";
        }
        private void Calc_Termino_Demo(object sender, EventArgs e)
        {
            Estado.Text = "Termino";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                Hashtable botones = CollectionsUtil.CreateCaseInsensitiveHashtable();
                botones["Sumar"] = "Suma";
                botones["Restar"] = "Resta";
                botones["Dividir"] = "Division";
                botones["Multiplicar"] = "Multiplicacion";

                List<String> otralist= new List<String>();

                otralist.Add("SUMAR");
                otralist.Add("rEsTar");
                otralist.Add("DivIDir");
                otralist.Add("MulTIPLIcar");

                lista = new List<Button>();
                for (int i = 0; i < 4; i++)
                {
                    var boton = new Button();
                    boton.Text = botones[otralist[i]].ToString();
                    boton.Location = new Point((10),(i* 20));
                    panelCalc.Controls.Add(boton);
                    lista.Add(boton);
                }


                for (int i = 0; i < 10; i++)
                {
                    var b = new Button();
                    b.Text = i.ToString();

                    b.Location = new Point((100), (i * 20));


                    panelCalc.Controls.Add(b);
                    lista.Add(b);
                }
                
            /* OPCION 2
            //Creación de los botones

            var bAdd = new Button();
            bAdd.Text = botones["SumAr"].ToString(); //Muestra el valor Suma

            bAdd.Location = new Point(90, 0);
            panelCalc.Controls.Add(bAdd);

            lista.Add(bAdd);

            var bResta = new Button();
            bResta.Text = botones["RESTAr"].ToString(); //Muestra el valor Resta

            bResta.Location = new Point(180, 0);
            panelCalc.Controls.Add(bResta);

            lista.Add(bResta);

            var bMulti = new Button();
            bMulti.Text = botones["MultIPlicacion"].ToString(); //Muestra el valor Multiplicar

            bMulti.Location = new Point(180, 20);
            panelCalc.Controls.Add(bMulti);

            lista.Add(bMulti);

            var bDiv = new Button();
            bDiv.Text = botones["DivISion"].ToString(); //Muestra el valor Dividir

            bDiv.Location = new Point(270, 40);
            panelCalc.Controls.Add(bDiv);

            lista.Add(bDiv); */


            }

        }

        private void Remove_Click(object sender, EventArgs e)
        {

            if (lista.Count != 0)
            {

                lista.Remove(lista.ElementAt(0));
                panelCalc.Controls.RemoveAt(0);
            }

        }
    }
}
