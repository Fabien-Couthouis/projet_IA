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

        public MyNode() : base()
        {
        }

        public MyNode(int number, Graph graph):base()
        {
            Number = number;
            Graph = graph;
        }

        // Méthodes abstraites, donc à surcharger obligatoirement avec override dans une classe fille
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
            return (Number == Graph.LastNodeId );
        }

        public override List<GenericNode> GetListSucc()
        {
            List<GenericNode> lsucc = new List<GenericNode>();

            for (int i = 0; i < Graph.NbNodes; i++)
            {
                if (Graph.Matrix[Number, i] != -1)
                {
                    //lsucc.Add(this.Copy());
                    MyNode newnode2 = new MyNode();
                    newnode2.Number = i;
                    newnode2.Graph = Graph;
                    lsucc.Add(newnode2);
                }
            }
            return lsucc;
        }

        public override double CalculeHCost()
        {
            return (0);
        }

        /// <summary>
        /// Retourne une copie du noeud.
        /// </summary>
        public MyNode Copy()
        {
            return new MyNode(this.Number, this.Graph);
        }

        //Renvoie la lettre correspondant au numéro du noeud (A=0 ; B=1 ; ...)
        public override string ToString()
        {
            return ((char)(Number + (int)'A')).ToString();
        }
    }
}
