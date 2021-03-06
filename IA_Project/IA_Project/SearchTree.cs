﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;


namespace IA_Project
{
    class SearchTree
    {
        public List<GenericNode> L_Ouverts;
        public List<GenericNode> L_Fermes;
        public double Xdestination;
        public double Ydestination;
        public char cas; //cas a b ou c en fonction du choix de l'utilisateur
        //Attributs servants à l'affichage graphique
        public PictureBox picture;
        public Graphics graphic;
        public Pen penWhite;
        //attributs relatifs au plus court chemin trouvé
        public int cptNoeuds, sommeNoeuds;
        public string tempsCalcul;
        public double tempsNavigation;
        

        //Constructeur
        public SearchTree(double X, double Y, char casEtudie, PictureBox pictureBox)
        {
            Xdestination = X;
            Ydestination = Y;
            cas = casEtudie;
            picture = pictureBox;
            graphic = picture.CreateGraphics();
            penWhite = new Pen(Color.White);
            cptNoeuds = 0;
            sommeNoeuds = 0;
            tempsCalcul = " ";
            tempsNavigation = 0;
        }

        public int CountInOpenList()
        {
            return L_Ouverts.Count;
        }
        public int CountInClosedList()
        {
            return L_Fermes.Count;
        }

        private GenericNode ChercheNodeDansFermes(GenericNode N2)
        {
            int i = 0;

            while (i < L_Fermes.Count)
            {
                if (L_Fermes[i].IsEqual(N2))
                    return L_Fermes[i];
                i++;
            }
            return null;
        }

        private GenericNode ChercheNodeDansOuverts(GenericNode N2)
        {
            int i = 0;

            while (i < L_Ouverts.Count)
            {
                if (L_Ouverts[i].IsEqual(N2))
                    return L_Ouverts[i];
                i++;
            }
            return null;
        }

        public List<GenericNode> RechercheSolutionAEtoile(GenericNode N0)
        {
            //Démarrage du chrono pour calculer le temps que met l'algorithme à trouver la solution
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            L_Ouverts = new List<GenericNode>();
            L_Fermes = new List<GenericNode>();
            // Le noeud passé en paramètre est supposé être le noeud initial
            GenericNode N = N0;
            L_Ouverts.Add(N0);

            // tant que le noeud n'est pas terminal et que ouverts n'est pas vide
            while (L_Ouverts.Count != 0 && N.EndState(Xdestination, Ydestination) == false)
            {
                // Le meilleur noeud des ouverts est supposé placé en tête de liste
                // On le place dans les fermés
                L_Ouverts.Remove(N);
                L_Fermes.Add(N);

                // Il faut trouver les noeuds successeurs de N
                this.MAJSuccesseurs(N);
                // Inutile de retrier car les insertions ont été faites en respectant l'ordre

                // On prend le meilleur, donc celui en position 0, pour continuer à explorer les états
                // A condition qu'il existe bien sûr
                if (L_Ouverts.Count > 0)
                {
                    N = L_Ouverts[0];
                }
                else
                {
                    N = null;
                }
            }

            //Fin du chrono et récupération de la valeur
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            tempsCalcul = String.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);

            // A* terminé
            // On retourne le chemin qui va du noeud initial au noeud final sous forme de liste
            // Le chemin est retrouvé en partant du noeud final et en accédant aux parents de manière
            // itérative jusqu'à ce qu'on tombe sur le noeud initial
            List<GenericNode> _LN = new List<GenericNode>();
            if (N != null)
            {
                _LN.Add(N);

                while (N != N0)
                {
                    N = N.GetNoeud_Parent();
                    _LN.Insert(0, N);  // On insère en position 1
                }
                
            }
            //On veut tracer le chemin final trouvé par l'algorithme comme étant le meilleur
            //Pour cela on part du noeud final et on trace un segment en lui et son parent et ainsi de suite
            NodeSailBoat NoeudFinal = (NodeSailBoat)_LN[_LN.Count()-1];
            NodeSailBoat NoeudDeDepart = (NodeSailBoat)N0;
            NodeSailBoat NoeudEnCours = NoeudFinal;
            //On met égalament un compteur pour connaitre le nombre de noeud de la solution
            cptNoeuds = 0;
            //Tant qu'on n'est pas arrivé noeud initial on continu de chercher le noeud parent et de tracer des segments
            while (NoeudEnCours.coorX != NoeudDeDepart.coorX && NoeudEnCours.coorY != NoeudDeDepart.coorY)
            {
                NodeSailBoat NoeudParent = (NodeSailBoat)NoeudEnCours.GetNoeud_Parent();
                DessinerSegment(NoeudParent.coorX, NoeudEnCours.coorX, NoeudParent.coorY, NoeudEnCours.coorY, new Pen(Color.Blue));
                tempsNavigation += NoeudEnCours.time_estimation(NoeudParent.coorX, NoeudParent.coorY, NoeudEnCours.coorX, NoeudEnCours.coorY, cas);
                NoeudEnCours = NoeudParent; //Le noeud en cours devient le noeud parent afin de continuer la recherche
                cptNoeuds++;
            }
            tempsNavigation = Math.Round(tempsNavigation,1);

            //Calcul de la somme de noeuds
            sommeNoeuds = L_Ouverts.Count() + L_Fermes.Count();

            return _LN;
        }

        private void MAJSuccesseurs(GenericNode N)
        {
            // On fait appel à GetListSucc, méthode abstraite qu'on doit réécrire pour chaque
            // problème. Elle doit retourner la liste complète des noeuds successeurs de N.
            List<GenericNode> listsucc = N.GetListSucc();
            foreach (GenericNode N2 in listsucc)
            {
                // N2 est-il une copie d'un nœud déjà vu et placé dans la liste des fermés ?
                GenericNode N2bis = ChercheNodeDansFermes(N2);
                if (N2bis == null)
                {
                    // Rien dans les fermés. Est-il dans les ouverts ?
                    N2bis = ChercheNodeDansOuverts(N2);
                    if (N2bis != null)
                    {
                        // Il existe, donc on l'a déjà vu, N2 n'est qu'une copie de N2Bis
                        // Le nouveau chemin passant par N est-il meilleur ?
                        if (N.GetGCost() + N.GetArcCost(N2,cas) < N2bis.GetGCost())
                        {
                            // Mise à jour de N2bis
                            N2bis.SetGCost(N.GetGCost() + N.GetArcCost(N2,cas));
                            // HCost pas recalculé car toujours bon
                            N2bis.RecalculeCoutTotal(); // somme de GCost et HCost
                            // Mise à jour de la famille ....
                            N2bis.Supprime_Liens_Parent();
                            N2bis.SetNoeud_Parent(N);
                            // Mise à jour des ouverts
                            L_Ouverts.Remove(N2bis);
                            this.InsertNewNodeInOpenList(N2bis);
                        }
                        // else on ne fait rien, car le nouveau chemin est moins bon
                    }
                    else
                    {
                        // N2 est nouveau, MAJ et insertion dans les ouverts
                        NodeSailBoat N2sail = (NodeSailBoat)N2;
                        NodeSailBoat Nsail = (NodeSailBoat)N;

                        double distancePoint = Math.Sqrt((Nsail.coorX - Xdestination) * (Nsail.coorX - Xdestination) + (Nsail.coorY - Ydestination) * (Nsail.coorY - Ydestination));

                        N2.SetGCost(N.GetGCost() + N.GetArcCost(N2,cas));
                        N2.SetNoeud_Parent(N);
                        N2.calculCoutTotal(Xdestination,Ydestination,cas, distancePoint); // somme de GCost et HCost
                        this.InsertNewNodeInOpenList(N2);

                        //Affichage en blanc de la recherche de l'algorithme en traçant des segments entre le noeud en cours et le suivant
                        DessinerSegment(Nsail.coorX, N2sail.coorX, Nsail.coorY, N2sail.coorY, this.penWhite);
                    }
                }
                // else il est dans les fermés donc on ne fait rien,
                // car on a déjà trouvé le plus court chemin pour aller en N2
            }
        }

        public void InsertNewNodeInOpenList(GenericNode NewNode)
        {
            // Insertion pour respecter l'ordre du cout total le plus petit au plus grand
            if (this.L_Ouverts.Count == 0)
            { L_Ouverts.Add(NewNode); }
            else
            {
                GenericNode N = L_Ouverts[0];
                bool trouve = false;
                int i = 0;
                do
                    if (NewNode.Cout_Total < N.Cout_Total)
                    {
                        L_Ouverts.Insert(i, NewNode);
                        trouve = true;
                    }
                    else
                    {
                        i++;
                        if (L_Ouverts.Count == i)
                        {
                            N = null;
                            L_Ouverts.Insert(i, NewNode);
                        }
                        else
                        { N = L_Ouverts[i]; }
                    }
                while ((N != null) && (trouve == false));
            }
        }

        // Si on veut afficher l'arbre de recherche, il suffit de passer un treeview en paramètres
        // Celui-ci est mis à jour avec les noeuds de la liste des fermés, on ne tient pas compte des ouverts
        public void GetSearchTree(TreeView TV)
        {
            if (L_Fermes == null) return;
            if (L_Fermes.Count == 0) return;

            // On suppose le TreeView préexistant
            TV.Nodes.Clear();

            TreeNode TN = new TreeNode(L_Fermes[0].ToString());
            TV.Nodes.Add(TN);
            

            AjouteBranche(L_Fermes[0], TN);
        }

        // AjouteBranche est exclusivement appelée par GetSearchTree; les noeuds sont ajoutés de manière récursive
        private void AjouteBranche(GenericNode GN, TreeNode TN)
        {
            foreach (GenericNode GNfils in GN.GetEnfants())
            {
                TreeNode TNfils = new TreeNode(GNfils.ToString());
                TN.Nodes.Add(TNfils);
                if (GNfils.GetEnfants().Count > 0)
                {
                    AjouteBranche(GNfils, TNfils);
                }
            }
        }

        //Dessin du chemin
        // soient x1, y1, x2, y2 des double utilisés pour définir les 2 extrémités d’un segment.
        private void DessinerSegment(double x1, double x2, double y1, double y2, Pen pen)
        {
            graphic.DrawLine(pen, new Point((int)x1,(int)y1),
            new Point((int)x2,(int)y2));
        }

    }
}
