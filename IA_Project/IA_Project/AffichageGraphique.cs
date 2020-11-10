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
        SearchTree tree;
        private double xInit, yInit, xDest, yDest;
        static double tailleMap = 300;

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


        /*private void RecupererPositions()
        {

        }*/



        // a supprimer dans l'affichage graphique
        private void label1_Click(object sender, EventArgs e)
        {

        }




        //listener des boutons : 

        private void casAButton_Click(object sender, EventArgs e)
        {
            //on récupère la position initiale du bateau
            // on récupère la position de la destination du bateau
            // se fera par défaut dès que l'utilisateur va rentrer des valeurs

            Console.WriteLine("xinit " + xInit + "\n yinit" + yInit);

            // déterminer le Node0
            NodeSailBoat node0 = new NodeSailBoat(xInit, yInit);

            //cree le searchTree
            tree = new SearchTree();

            // appeler RechecheA*

            List<GenericNode> solution = tree.RechercheSolutionAEtoile(node0);

            tree.GetSearchTree(treeViewBox);

            // graphique (avoir un truc jouli
            // point de départ en cliquant plutot qu'en saisissant des coordonnées
            // avoir le chemin graphique (dessiner des segments)
            //ergonomie mon amie
            //animer la trajectoire ?

            //diagonales
            // passer les valeurs en parametre et pas en dur

            // heuristique 
            
        }

        private void casBButton_Click(object sender, EventArgs e)
        {

        }

        private void casCButton_Click(object sender, EventArgs e)
        {

        }


        // verifier si on garde listener sur textChanged : risque de changer la valeur au milieu de l'execution du code ? 
        //events lorsque le texte des textbox est modifié : 

        private void xInitBox_TextChanged(object sender, EventArgs e)
        {
            XInit = Convert.ToDouble(xInitBox.Text);
        }

        private void yInitBox_TextChanged(object sender, EventArgs e)
        {
            YInit = Convert.ToDouble(yInitBox.Text);
        }

        private void xDestBox_TextChanged(object sender, EventArgs e)
        {
            XDest = Convert.ToDouble(xDestBox.Text);
        }

        private void yDestBox_TextChanged(object sender, EventArgs e)
        {
            YDest = Convert.ToDouble(yDestBox.Text);
        }

                
    }
}
