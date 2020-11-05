using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IA_Project
{
    public partial class AffichageGraphique : Form
    {
        SearchTree arbre;
        private double xInit, yInit, xDest, yDest;

        public double XInit { 
            get => xInit;
            set
            {
                //a penser
                //edit un label pour dire qu'il y a une erreur
                if(value<0)
                {
                    xInit = 0;
                }
                else if (value>300)
                {
                    xInit = 300;
                }
                else xInit = value;

                //Console.WriteLine("xinit" + xInit);
            }
        }
        public double YInit { 
            get => yInit;
            set
            {
                //a penser
                //edit un label pour dire qu'il y a une erreur
                if (value < 0)
                {
                    yInit = 0;
                }
                else if (value > 300)
                {
                    yInit = 300;
                }
                else yInit = value;
            }
        }
        public double XDest { 
            get => xDest;
            set
            {
                //a penser
                //edit un label pour dire qu'il y a une erreur
                if (value < 0)
                {
                    xDest = 0;
                }
                else if (value > 300)
                {
                    xDest = 300;
                }
                else xDest = value;
            }
        }
        public double YDest { 
            get => yDest; 
            set
            {
                //a penser
                //edit un label pour dire qu'il y a une erreur
                if (value < 0)
                {
                    yDest = 0;
                }
                else if (value > 300)
                {
                    yDest = 300;
                }
                else yDest = value;
            }
        }

        public AffichageGraphique()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //on récupère la position initiale du bateau
            // on récupère la position de la destination du bateau
            // se fera par défaut dès que l'utilisateur va rentrer des valeurs

            Console.WriteLine("xinit " + xInit + "\n yinit"+ yInit);

            // déterminer le Node0

            // appeler RechecheA*


            // on initiailise ce qu'il faut initialiser



            arbre = new SearchTree();

            // appel d'une fonction ?
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void RecupererPositions()
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        // verifier si on garde listener sur textChanged : risque de changer la valeur au milieu de l'execution du code ? 




        //textbox x initial
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            XInit = Convert.ToDouble(textBox1.Text);
        }

        //textbox y initial
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            YInit = Convert.ToDouble(textBox2.Text);
        }

        // textbox x final
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            XDest = Convert.ToDouble(textBox4.Text);
        }

        // textbox y final
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            YDest = Convert.ToDouble(textBox3.Text);
        }
    }
}
