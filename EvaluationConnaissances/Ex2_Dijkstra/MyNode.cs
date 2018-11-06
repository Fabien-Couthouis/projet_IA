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
        public int nbNodes;
        public char firstNode;
        public char lastNode;
        public string graphName;
        private int[,] matrix;

        public void InitialiseGraph()
        {
            System.IO.StreamReader file = new System.IO.StreamReader("..//..//graph//" + graphName + ".txt");
            int lineNb = 0;
            string line;
            matrix = new int[nbNodes,nbNodes];

            //L1
            line = file.ReadLine();
            lineNb++;
            nbNodes = line[10];

            //L2
            line = file.ReadLine();
            lineNb++;
            firstNode = line[13];

            //L3
            line = file.ReadLine();
            lineNb++;
            lastNode = line[12];

            //L4
            line = file.ReadLine();
            lineNb++;
            //L5
            line = file.ReadLine();
            lineNb++;
            //L6
            line = file.ReadLine();
            lineNb++;

            for (int i=0; i < nbNodes; i++)
            {
                line = file.ReadLine();
                for (int j = 0; j < nbNodes; j++)
                {
                    matrix[i, j] = Convert.ToInt32(line[j + 1]);
                }
                lineNb++;
            }

        }

        // Méthodes abstrates, donc à surcharger obligatoirement avec override dans une classe fille
        public override bool IsEqual(GenericNode N2)
        {
            MyNode N2bis = (MyNode)N2;

            return number == N2bis.number;
        }

        public override double GetArcCost(GenericNode N2)
        {
            MyNode N2bis = (MyNode)N2;
            return matrix[number, N2bis.number];
        }

        public override bool EndState()
        {
            return (number == nbNodes - 1);
        }

        public override List<GenericNode> GetListSucc()
        {
            List<GenericNode> lsucc = new List<GenericNode>();

            for (int i = 0; i < nbNodes; i++)
            {
                if (matrix[number, i] != -1)
                {
                    MyNode newnode2 = new MyNode();
                    newnode2.number = i;
                    lsucc.Add(newnode2);
                }
            }
            return lsucc;
        }


        //a modifier
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
