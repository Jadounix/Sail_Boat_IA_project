using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA_Project
{
    class NodeSailBoat : GenericNode
    {
        public double coorX;
        public double coorY;
        public double tailleMap;

        //Constructeur
        public NodeSailBoat(double x, double y)
        {
            coorX = x; coorY = y;
            tailleMap = 300;
        }

        //Méthode ToString
        public override string ToString()
        {
            string txt = "(" + coorX + "," + coorY + ")";
            return txt;
        }

        //Méthode qui test l'égalité entre deux noeuds
        public override bool IsEqual(GenericNode noeud)
        {
            NodeSailBoat noeudBis = (NodeSailBoat)noeud;
            bool equal = false;
            if(this.coorX==noeudBis.coorX && this.coorY == noeudBis.coorY)
            {
                equal = true;
            }
            return equal;
        }

        //Méthode qui donne le cout d'un chemin entre deux deux noeuds
        public override double GetArcCost(GenericNode noeudDestination, char cas)
        {
            NodeSailBoat noeudSuivant = (NodeSailBoat)noeudDestination;
            return time_estimation(this.coorX, this.coorY, noeudSuivant.coorX, noeudSuivant.coorY,cas);
        }

        //Méthode qui retourne vrai si le bateau est arrivé à sa destinatio et faux sinon
        public override bool EndState(double xArrivee, double yArrivee)
        {
            bool fini = false;
            if(this.coorX == xArrivee && this.coorY == yArrivee)
            {
                fini = true;
            }
            return fini;
        }

        //Méthode qui donne la liste des successeurs 
        public override List<GenericNode> GetListSucc()
        {
            List<GenericNode> lsucc = new List<GenericNode>();

            //à chaque fois on teste si le noeud est en dehors de la map ou pas
            if(!TestEnDehorsMap(this.coorX + 1, this.coorY))
            {
                lsucc.Add(new NodeSailBoat(this.coorX + 1, this.coorY));
            }
            if (!TestEnDehorsMap(this.coorX - 1, this.coorY))
            {
                lsucc.Add(new NodeSailBoat(this.coorX - 1, this.coorY));
            }
            if (!TestEnDehorsMap(this.coorX, this.coorY + 1))
            {
                lsucc.Add(new NodeSailBoat(this.coorX, this.coorY + 1));
            }
            if (!TestEnDehorsMap(this.coorX, this.coorY - 1))
            {
                lsucc.Add(new NodeSailBoat(this.coorX, this.coorY - 1));
            }
            //Déplacements en diaonale
            if (!TestEnDehorsMap(this.coorX + 1, this.coorY + 1)) 
            {
                lsucc.Add(new NodeSailBoat(this.coorX + 1, this.coorY + 1));
            }
            if (!TestEnDehorsMap(this.coorX + 1, this.coorY - 1))
            {
                lsucc.Add(new NodeSailBoat(this.coorX + 1, this.coorY - 1));
            }
            if (!TestEnDehorsMap(this.coorX - 1, this.coorY + 1))
            {
                lsucc.Add(new NodeSailBoat(this.coorX - 1, this.coorY + 1));
            }
            if (!TestEnDehorsMap(this.coorX - 1, this.coorY - 1))
            {
                lsucc.Add(new NodeSailBoat(this.coorX - 1, this.coorY - 1));
            }
            return lsucc;
        }

        public bool TestEnDehorsMap(double X, double Y)
        {
            bool dehors = false;
            if (X > tailleMap || X < 0 || Y > tailleMap || Y < 0) 
            {
                dehors = true;
            }
            return dehors;
        }

        public override double CalculeHCost(double xArivee, double yArrivee, char cas, double distancePoint)
        {
            //Calcul de la distance entre deux points
            double cost = 0;
            double distance = Math.Sqrt((this.coorX - xArivee) * (this.coorX - xArivee) + (this.coorY - yArrivee) * (this.coorY - yArrivee));
            //Calcul de la vitesse max du bateau en fonction du cas et à un angle de 45°
            double vitesseMax = 0.9*50; //maximum dela fonction vitesse du bateau, à multiplier par la vitesse du vent

            if (distance > distancePoint)
            {
                cost = 10000000;
            }
            else
            {
                cost = distance / vitesseMax;
            }
            return (cost);
        }

        public override void calculCoutTotal(double xArivee, double yArrivee, char cas,double distancePoint)
        {
            HCost = CalculeHCost(xArivee,yArrivee,cas, distancePoint);
            TotalCost = GCost + HCost;
        }


        //fonction qui calcule le temps de navigation entre 2 points proches (x1,y1) et (x2,y2)
        public double time_estimation(double x1, double y1, double x2, double y2, char cas)
        {
            double distance = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            if (distance > 10) return 1000000;
            double windspeed = get_wind_speed((x1 + x2) / 2.0, ((y1 + y2) / 2.0),cas);
            double winddirection = get_wind_direction((x1 + x2) / 2.0, ((y1 + y2) / 2.0),cas);
            double boatspeed;
            double boatdirection = Math.Atan2(y2 - y1, x2 - x1) * 180 / Math.PI;

            // On ramène entre 0 et 360
            if (boatdirection < 0) boatdirection = boatdirection + 360;

            // calcul de la différence angulaire
            double alpha = Math.Abs(boatdirection - winddirection);

            // On se ramène à une différence entre 0 et 180 :
            if (alpha > 180) alpha = 360 - alpha;
            if (alpha <= 45)
            {
                /* (0.6 + 0.3α / 45) v_v */
                boatspeed = (0.6 + 0.3 * alpha / 45) * windspeed;
            }
            else if (alpha <= 90)
            {
                /*v_b=(0.9-0.2(α-45)/45) v_v */
                boatspeed = (0.9 - 0.2 * (alpha - 45) / 45) * windspeed;
            }
            else if (alpha < 150)
            {
                /* v_b=0.7(1-(α-90)/60) v_v */
                boatspeed = 0.7 * (1 - (alpha - 90) / 60) * windspeed;
            }
            else 
                return 1000000;
            // estimation du temps de navigation entre p1 et p2
            return (distance / boatspeed);
        }

        //fonctions pour la vitesse et la direction du vent
        public double get_wind_speed(double x, double y, char cas)
        {
            if (cas == 'a')
                return 50;
            else if (cas == 'b')
                if (y > 150)
                    return 50;
                else return 20;
            else if (y > 150)
                return 50;
            else return 20;
        }

        public double get_wind_direction(double x, double y, char cas)
        {
            if (cas == 'a')
                return 30;
            else if (cas == 'b')
                if (y > 150)
                    return 180;
                else return 90;
            else if (y > 150)
                return 170;
            else return 65;
        }
    }
}
