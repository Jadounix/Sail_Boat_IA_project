using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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


        //A faire : edit un label pour dire qu'il y a une erreur
        public double XInit { 
            get => xInit;
            set
            {
                if(value<0)
                {
                    xInit = 0;
                }
                else if (value> tailleMap)
                {
                    xInit = tailleMap;
                }
                else xInit = value;

            }
        }
        public double YInit { 
            get => yInit;
            set
            {
                if (value < 0)
                {
                    yInit = 0;
                }
                else if (value > tailleMap)
                {
                    yInit = tailleMap;
                }
                else yInit = value;
            }
        }
        public double XDest { 
            get => xDest;
            set
            {
                if (value < 0)
                {
                    xDest = 0;
                }
                else if (value > tailleMap)
                {
                    xDest = tailleMap;
                }
                else xDest = value;
            }
        }
        public double YDest { 
            get => yDest; 
            set
            {
                if (value < 0)
                {
                    yDest = 0;
                }
                else if (value > tailleMap)
                {
                    yDest = tailleMap;
                }
                else yDest = value;
            }
        }

        public AffichageGraphique()
        {
            InitializeComponent();
        }

       //Listeners des boutons
        private void casAButton_Click(object sender, EventArgs e)
        {
            char cas = 'a';
            XInit = 100; YInit = 200; XDest = 200; YDest = 100;

            // déterminer le Node0
            NodeSailBoat node0 = new NodeSailBoat(XInit, YInit);

            //cree le searchTree
            tree = new SearchTree(XDest,YDest,cas,mapSeaBox);

            // appeler RechecheA*
            List<GenericNode> solution = tree.RechercheSolutionAEtoile(node0);
            tree.GetSearchTree(treeViewBox);
        }

        private void casBButton_Click(object sender, EventArgs e)
        {
            char cas = 'b';
            XInit = 100; YInit = 200; XDest = 200; YDest = 100;

            NodeSailBoat node0 = new NodeSailBoat(XInit, YInit);
            tree = new SearchTree(XDest, YDest, cas, mapSeaBox);

            List<GenericNode> solution = tree.RechercheSolutionAEtoile(node0);

            tree.GetSearchTree(treeViewBox);
        }

        private void casCButton_Click(object sender, EventArgs e)
        {
            char cas = 'c';
            XInit = 200; YInit = 100; XDest = 100; YDest = 200;

            NodeSailBoat node0 = new NodeSailBoat(XInit, YInit);
            tree = new SearchTree(XDest, YDest, cas, mapSeaBox);

            List<GenericNode> solution = tree.RechercheSolutionAEtoile(node0);

            tree.GetSearchTree(treeViewBox);
        }


        //si on selectionne l'un des radio button on peut écrire dans les textbox associés, pas dans les autres
        private void radioPosInit_CheckedChanged(object sender, EventArgs e)
        {
            //on change les paramètres des textBox de la destination pour rendre impossible la modification des valeurs
            xDestBox.Enabled = false;
            yDestBox.Enabled = false;

            // les textBox associées peuvent être modifiées
            xInitBox.Enabled = true;
            yInitBox.Enabled = true;
        }


        private void radioPosFinale_CheckedChanged(object sender, EventArgs e)
        {
            //on change les paramètres des textBox de la position initiale pour rendre impossible la modification des valeurs
            xInitBox.Enabled = false;
            yInitBox.Enabled = false;

            // les textBox associées peuvent être modifiées
            xDestBox.Enabled = true;
            yDestBox.Enabled = true;
        }

        //reinitilise les positions de depart et d'arrivee et l'image de fond
        private void reinitButton_Click(object sender, EventArgs e)
        {
            double valDefaut = 0;
            xInitBox.Text = valDefaut.ToString();
            yInitBox.Text = valDefaut.ToString();
            xDestBox.Text = valDefaut.ToString();
            yDestBox.Text = valDefaut.ToString();
            mapSeaBox.Image = Image.FromFile("sea.jpg");
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

        //permet d'obtenir les coordonnées du point cliqué sur la map
        private void mapSeaBox_Click(object sender, EventArgs e)
        {
            int x, y;
            MouseEventArgs me = (MouseEventArgs)e;
            x = me.X;
            y = me.Y;

            //si position initiale selectionné on change les valeurs des textBox de la position initiale
            if(radioPosInit.Checked)
            {
                xInitBox.Text = x.ToString();
                yInitBox.Text = y.ToString();

            }
            //si position finale selectionné on change les valeurs des textBox de la position finale
            else
            {
                xDestBox.Text = x.ToString();
                yDestBox.Text = y.ToString();
            }
        } 

    }
}
