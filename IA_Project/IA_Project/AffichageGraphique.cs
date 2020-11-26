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
        static double tailleMap = 300; // on définit que la taille de la map est fixe et déterminée à 300.
        private char cas;


        public double XInit { 
            get => xInit;
            set
            {
                if(value<0) //si on essaie de mettre un point de départ à une position x inférieur à 0, on force la limite à 0
                {
                    xInitBox.Text = 0.ToString();
                }
                else if (value> tailleMap) // Pareil pour un point de départ position > la taille de la map
                {
                    xInitBox.Text = tailleMap.ToString();
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
                    yInitBox.Text = 0.ToString();
                }
                else if (value > tailleMap)
                {
                    yInitBox.Text = tailleMap.ToString();
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
                    xDestBox.Text = 0.ToString();
                }
                else if (value > tailleMap)
                {
                    xDestBox.Text = tailleMap.ToString();
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
                    yDestBox.Text = 0.ToString();
                }
                else if (value > tailleMap)
                {
                    yDestBox.Text = tailleMap.ToString();
                }
                else yDest = value;
            }
        }
        public char Cas { get => cas; set => cas = value; }

        public AffichageGraphique()
        {
            InitializeComponent();

            //on initialise les valeurs par défaut du form : cas A et coordonnées associées
            cas = 'a';
            XInit = 100; YInit = 200; XDest = 200; YDest = 100;
            //on met à jour les textBox pour afficher les valeurs par défaut de départ et d'arrivée : 
            xDestBox.Text = XDest.ToString();
            yDestBox.Text = YDest.ToString();

            xInitBox.Text = XInit.ToString();
            yInitBox.Text = YInit.ToString();
        }


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



        //si on selectionne l'un des radio button de position,
        //on peut écrire dans les textbox associés, pas dans les autres
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



        //reinitilise les valeurs et résultats du form 
        private void reinitButton_Click(object sender, EventArgs e)
        {

            //réinitialise le vent selectionné
            radioCasA.Checked = true;
            Cas = 'a';



            //reinitialise les valeurs de départ et d'arrivée pour le cas A
            XInit = 100; YInit = 200; XDest = 200; YDest = 100;

            //on met à jour les textBox pour afficher les valeurs par défaut de départ et d'arrivée : 
            xDestBox.Text = XDest.ToString();
            yDestBox.Text = YDest.ToString();

            xInitBox.Text = XInit.ToString();
            yInitBox.Text = YInit.ToString();

            //reinitialiser la partie résultats : map + search tree + données dans textBox
            ReinitiatiliserResultats();




        }



        //on lance l'éxecution du code pour chercher le plus court chemin
        private void btnLancerRecherche_Click(object sender, EventArgs e)
        {

            NodeSailBoat node0 = new NodeSailBoat(XInit, YInit, tailleMap);
            tree = new SearchTree(XDest, YDest, Cas, mapSeaBox);

            List<GenericNode> solution = tree.RechercheSolutionAEtoile(node0);

            tree.GetSearchTree(treeViewBox);
            AffichageResultats(tree);

        }



        //réinitiailise les resultats : searchtree, textBox et Map
        private void ReinitiatiliserResultats()
        {

            mapSeaBox.Image = Image.FromFile("sea.jpg");
            treeViewBox.Nodes.Clear();
            txtTempsNav.Text = "";
            txtTempsCalcul.Text = "";
            txtSommeNoeuds.Text = "";
            txtNbNoeuds.Text = "";

        }


        //chaque fois que le textBox est modifié, on met à jour la variable X ou Y associée
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

            //si 'position initiale' selectionnée, on change les valeurs des textBox de la position initiale
            if(radioPosInit.Checked)
            {
                xInitBox.Text = x.ToString();
                yInitBox.Text = y.ToString();

            }
            //si position finale selectionnée on change les valeurs des textBox de la position finale
            else if(radioPosFinale.Checked)
            {
                xDestBox.Text = x.ToString();
                yDestBox.Text = y.ToString();
            }
        } 



        //affiche les différentes informations textuelles concernant le plus court chemin trouvé
        private void AffichageResultats(SearchTree tree)
        {
            txtNbNoeuds.Text = tree.cptNoeuds.ToString(); //nb noeuds du chemin trouvé
            txtSommeNoeuds.Text = tree.sommeNoeuds.ToString(); //nb noeuds étudiés pendant la recherche
            txtTempsCalcul.Text = tree.tempsCalcul; //temps passé par le compilateur pour trouver la solution
            txtTempsNav.Text = ConvertirTempsNav(tree.tempsNavigation); // temps de navigation pour parcourir le plus court chemin
        }

        // fonction qui convertit le temps donné en double en un temps en TimeSpan (passe donc de 3.7h à 3h42 par exemple)
        private string ConvertirTempsNav(double temps)
        {
            string tempsNav = TimeSpan.FromHours(temps).ToString();
            return tempsNav;
        }

    }
}
