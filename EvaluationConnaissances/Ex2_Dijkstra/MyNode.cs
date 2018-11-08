using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_Dijkstra
{
    class MyNode:GenericNode
    {
        public Graph Graph { get; set; }
        public int Number { get; set; }

        // Méthodes abstrates, donc à surcharger obligatoirement avec override dans une classe fille
        public override bool IsEqual(GenericNode N2)
        {
            MyNode N2bis = (MyNode)N2;

            return Number == N2bis.Number;
        }

        public override double GetArcCost(GenericNode N2)
        {
            MyNode N2bis = (MyNode)N2;
            return Graph.Matrix[Number, N2bis.Number];
        }

        public override bool EndState()
        {
            return (Number == Graph.LastNode);
        }

        public override List<GenericNode> GetListSucc()
        {
            List<GenericNode> lsucc = new List<GenericNode>();

            for (int i = 0; i < Graph.NbNodes; i++)
            {
                if (Graph.Matrix[Number, i] != -1)
                {
                    MyNode newnode2 = new MyNode();
                    newnode2.Number = i;
                    lsucc.Add(newnode2);
                }
            }
            return lsucc;
        }

        public override double CalculeHCost()
        {
            return (0);
        }

        //Renvoie la lettre correspondant au numéro du noeud (A=0 ; B=1 ; ...)
        public override string ToString()
        {
            //return Convert.ToString(Number);
            return ((char)(Number + (int)'A')).ToString();
        }
    }
}
