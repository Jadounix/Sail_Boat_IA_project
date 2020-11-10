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

        public override double GetArcCost(GenericNode noeudDestination)
        {
            NodeSailBoat noeudSuivant = (NodeSailBoat)noeudDestination;
            return time_estimation(this.coorX, this.coorY, noeudSuivant.coorX, noeudSuivant.coorY);
        }



        //adapter avec des valeurs dynamiques
        public override bool EndState()
        {
            bool fini = false;
            //cas 1 : point d'arrivée (5,5)
            if(this.coorX == 5 && this.coorY == 5)
            {
                fini = true;
            }
            //cas 2 : point d'arrivée (200,100)
            //cas 3 : point d'arrivée (100,200)
            return fini;
        }

        public override List<GenericNode> GetListSucc()
        {
            List<GenericNode> lsucc = new List<GenericNode>();

            //Pour l'instant pas de déplacement en diagonale
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
            return lsucc;
        }


        //a adapter avec val dynamiques
        public bool TestEnDehorsMap(double X, double Y)
        {
            bool dehors = false;
            if(X>300 || X<0 || Y > 300 || Y < 0)
            {
                //je suis en dehors de la map
                dehors = true;
            }
            return dehors;
        }

        public override double CalculeHCost() //Calcul de l'heuristique. Pour l'instant c'est toujours 0
        {
            return (0);
        }

        //fonction qui calcule le temps de navigation entre 2 points proches (x1,y1) et (x2,y2)
        public double time_estimation(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            if (distance > 10) return 1000000;
            double windspeed = get_wind_speed((x1 + x2) / 2.0, (y1 + y2) / 2.0);
            double winddirection = get_wind_direction((x1 + x2) / 2.0, (y1 + y2) / 2.0);
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
        public char cas = 'a'; // à modifier en ‘b’ ou ‘c’ selon le choix de l’utilisateur
        //faudra le mettre en paramètre
        public double get_wind_speed(double x, double y)
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

        public double get_wind_direction(double x, double y)
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


        public override string ToString()
        {
            string txt = "("+coorX+","+coorY+")";
            return txt;
        }
    }
}
