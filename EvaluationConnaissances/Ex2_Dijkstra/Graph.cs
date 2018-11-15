using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex2_Dijkstra
{
    class Graph
    {

        /// <summary>
        /// Emplacement du fichier texte et de l'image du graph.
        /// </summary>
        private static string filesLocation = "..//..//graph//";
        public int Id { get; private set; }
        public string GraphFileLocation { get; private set; }
        public string PictureFileLocation { get; private set; }
        /// <summary>
        /// Matrice d'adjacence des noeuds du graph.
        /// </summary>
        public double[,] Matrix { get; private set; }
        public int NbNodes { get; private set; }
        public int FirstNode { get; private set; }
        public int LastNode { get; private set; }
        public SearchTree SolutionTree { get; private set; }
        public TreeView TreeView { get; private set; }
        public List<GenericNode> SearchList { get; private set; }


        public Graph(int id)
        {
            this.Id = id;
            this.GraphFileLocation = filesLocation + "graph" + id + ".txt";
            this.PictureFileLocation = filesLocation + "graph" + id + ".jpg";
            InitialiseGraph();

        }

        ///<summary>Transcrit les informations du fichier texte contenant le graph</summary>
        public void InitialiseGraph()
        {
            System.IO.StreamReader streamReader = new System.IO.StreamReader(GraphFileLocation);

            // Lecture du fichier
            // 1ère ligne : "nombre de noeuds du graphe
            string line = streamReader.ReadLine();
            int i = 0;

            //On va jusqu'au chiffre
            while (line[i] != ':') i++;
            i++; // On dépasse le ":"
            while (line[i] == ' ') i++; // on saute les blancs éventuels

            string nbNodes_str = "";

            while (i < line.Length)
            {
                nbNodes_str += line[i];
                i++;
            }
            NbNodes = Convert.ToInt32(nbNodes_str);

            // 2eme ligne : noeud de départ
            line = streamReader.ReadLine();
            i = 0;

            //On va jusqu'au chiffre
            while (line[i] != ':') i++;
            i++; // On dépasse le ":"
            while (line[i] == ' ') i++; // on saute les blancs éventuels

            string firstNode_str = "";

            while (i < line.Length)
            {
                firstNode_str += line[i];
                i++;
            }
            FirstNode = Convert.ToInt32(firstNode_str);

            // 3eme ligne : noeud d'arrivée
            line = streamReader.ReadLine();
            i = 0;

            //On va jusqu'au chiffre
            while (line[i] != ':') i++;
            i++; // On dépasse le ":"
            while (line[i] == ' ') i++; // on saute les blancs éventuels

            string lastNode_str = "";

            while (i < line.Length)
            {
                lastNode_str += line[i];
                i++;
            }
            LastNode = Convert.ToInt32(lastNode_str);


            //Initialisation de la matrice
            Matrix = new double[NbNodes, NbNodes];
            for (i = 0; i < NbNodes; i++)
                for (int j = 0; j < NbNodes; j++)
                    Matrix[i, j] = -1;

            // Ensuite on a la structure suivante : 
            //  arc : n°noeud départ    n°noeud arrivée  valeur
            //  exemple 4 : 
            line = streamReader.ReadLine();
            while (line != null)
            {
                i = 0;
                while (line[i] != ':') i++;
                i++; // on passe le :


                //Noeud 1
                while (line[i] == ' ') i++; // on saute les blancs éventuels
                string N1_str = "";
                while (line[i] != ' ')
                {
                    N1_str += line[i];
                    i++;
                }
                int N1 = Convert.ToInt32(N1_str);

                //Noeud 2
                while (line[i] == ' ') i++;
                string N2_str = "";
                while (line[i] != ' ')
                {
                    N2_str += line[i];
                    i++;
                }
                int N2 = Convert.ToInt32(N2_str);

                //Valeur
                while (line[i] == ' ') i++;
                string val_str = "";
                while ((i < line.Length) && (line[i] != ' '))
                {
                    val_str += line[i];
                    i++;
                }
                double val = Convert.ToDouble(val_str);

                //On rempli la matrice
                Matrix[N1, N2] = val;
                Matrix[N2, N1] = val;

                line = streamReader.ReadLine();
            }
            // Fermeture du StreamReader (obligatoire) 
            streamReader.Close();
        }

        ///<summary>Calcule la solution (application de A*) et met à jour les variables SearchList et TreeView.</summary>
        public void computeSolution()
        {
            SolutionTree = new SearchTree();
            MyNode N0 = new MyNode(FirstNode, this);
            List<GenericNode> Solution = SolutionTree.RechercheSolutionAEtoile(N0);

            SearchList = SolutionTree.GetSearchList();
            TreeView  = SolutionTree.GetSearchTree();
        }



    }
}
