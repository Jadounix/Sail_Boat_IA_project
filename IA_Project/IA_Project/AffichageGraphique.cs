using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IA_Project
{
    public partial class AffichageGraphique : Form
    {
        SearchTree tree;
        private double xInit, yInit, xDest, yDest;
        static double tailleMap = 300;
        private char cas;


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
        public char Cas { get => cas; set => cas = value; }

        public AffichageGraphique()
        {
            InitializeComponent();
        }

       //Listeners des boutons : à supprimer
        /*private void casAButton_Click(object sender, EventArgs e)
        {
            char cas = 'a';
            XInit = 100; YInit = 200; XDest = 200; YDest = 100;

            // déterminer le Node0
            NodeSailBoat node0 = new NodeSailBoat(XInit, YInit);

            //cree le searchTree
            tree = new SearchTree(XDest,YDest,cas,mapSeaBox);

            // appeler RechecheA et afficher la solution*
            List<GenericNode> solution = tree.RechercheSolutionAEtoile(node0);
            tree.GetSearchTree(treeViewBox);
            AffichageResultats(tree);

        }

        private void casBButton_Click(object sender, EventArgs e)
        {
            char cas = 'b';
            XInit = 100; YInit = 200; XDest = 200; YDest = 100;

            NodeSailBoat node0 = new NodeSailBoat(XInit, YInit);
            tree = new SearchTree(XDest, YDest, cas, mapSeaBox);

            List<GenericNode> solution = tree.RechercheSolutionAEtoile(node0);

            tree.GetSearchTree(treeViewBox);
            AffichageResultats(tree);

        }

        private void casCButton_Click(object sender, EventArgs e)
        {
            char cas = 'c';
            XInit = 200; YInit = 100; XDest = 100; YDest = 200;

            NodeSailBoat node0 = new NodeSailBoat(XInit, YInit);
            tree = new SearchTree(XDest, YDest, cas, mapSeaBox);

            List<GenericNode> solution = tree.RechercheSolutionAEtoile(node0);

            tree.GetSearchTree(treeViewBox);
            AffichageResultats(tree);

        }
        */

        //selection du vent permet de déterminer le cas et d'instancier les valeurs par défaut d'arrivée et de départ
        private void selectionVent(object sender, EventArgs e)
        {
            string typeVent = ((RadioButton)(sender)).Name;
            if(typeVent == "radioCasA")
            {
                Cas = 'a';
                XInit = 100; YInit = 200; XDest = 200; YDest = 100;

                //on met à jour les textBox pour afficher les valeurs par défaut de départ et d'arrivée : 
                xDestBox.Text = XDest.ToString();
                yDestBox.Text = YDest.ToString();

                xInitBox.Text = XInit.ToString();
                yInitBox.Text = YInit.ToString();

            }
            else if (typeVent == "radioCasB")
            {
                Cas = 'b';
                XInit = 100; YInit = 200; XDest = 200; YDest = 100;

                //on met à jour les textBox pour afficher les valeurs par défaut de départ et d'arrivée : 
                xDestBox.Text = XDest.ToString();
                yDestBox.Text = YDest.ToString();

                xInitBox.Text = XInit.ToString();
                yInitBox.Text = YInit.ToString();
            }
            else
            {
                Cas = 'c';
                XInit = 200; YInit = 100; XDest = 100; YDest = 200;

                //on met à jour les textBox pour afficher les valeurs par défaut de départ et d'arrivée : 
                xDestBox.Text = XDest.ToString();
                yDestBox.Text = YDest.ToString();

                xInitBox.Text = XInit.ToString();
                yInitBox.Text = YInit.ToString();
            }
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



        //reinitilise les valeurs du form 
        private void reinitButton_Click(object sender, EventArgs e)
        {

            //réinitialise le vent selectionné
            Cas = '\0';
            radioCasA.Checked = false;
            radioCasB.Checked = false;
            radioCasC.Checked = false;



            //reinitialise les valeurs de départ et d'arrivée
            double valDefaut = 0;
            xInitBox.Text = valDefaut.ToString();
            yInitBox.Text = valDefaut.ToString();
            xDestBox.Text = valDefaut.ToString();
            yDestBox.Text = valDefaut.ToString();

            
            
        }



        //on lance l'éxecution du code pour chercher le plus court chemin
        private void btnLancerRecherche_Click(object sender, EventArgs e)
        {

            //refresh la map et les valeurs de calcul du premier chemin
            
            ReinitiatiliserResultats();
            NodeSailBoat node0 = new NodeSailBoat(XInit, YInit);
            tree = new SearchTree(XDest, YDest, Cas, mapSeaBox);

            List<GenericNode> solution = tree.RechercheSolutionAEtoile(node0);

            tree.GetSearchTree(treeViewBox);
            AffichageResultats(tree);

        }




        private void ReinitiatiliserResultats()
        {

            //mapSeaBox.Image = Image.FromFile("sea.jpg");
            txtTempsNav.Text = "";
            txtTempsCalcul.Text = "";
            txtSommeNoeuds.Text = "";
            txtNbNoeuds.Text = "";
        }


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



        private void AffichageResultats(SearchTree tree)
        {
            txtNbNoeuds.Text = tree.cptNoeuds.ToString();
            txtSommeNoeuds.Text = tree.sommeNoeuds.ToString();
            txtTempsCalcul.Text = tree.tempsCalcul;
            txtTempsNav.Text = tree.tempsNavigation.ToString() + " heure(s)";
        }

    }
}
