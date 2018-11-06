using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_Dijkstra
{
    class MyNode:GenericNode
    {
        public int number;
        public int[,] matrix;

        // Méthodes abstrates, donc à surcharger obligatoirement avec override dans une classe fille
        public override bool IsEqual(GenericNode N2)
        {
            MyNode N2bis = (MyNode)N2;

            return number == N2bis.number;
        }

        public override double GetArcCost(GenericNode N2)
        {
            MyNode N2bis = (MyNode)N2;
            return Form1.matrice[number, N2bis.number];
        }

        public override bool EndState()
        {
            return (number == Form1.numfinal);
        }

        public override List<GenericNode> GetListSucc()
        {
            List<GenericNode> lsucc = new List<GenericNode>();

            for (int i = 0; i < Form1.nbnodes; i++)
            {
                if (Form1.matrice[number, i] != -1)
                {
                    MyNode newnode2 = new MyNode();
                    newnode2.number = i;
                    lsucc.Add(newnode2);
                }
            }
            return lsucc;
        }


        public override double CalculeHCost()
        {
            return (0);
        }

        public override string ToString()
        {
            return Convert.ToString(number);
        }
    }
}
