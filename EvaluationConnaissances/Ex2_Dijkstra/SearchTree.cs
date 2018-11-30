using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex2_Dijkstra
{
    class SearchTree
    {
        private List<GenericNode> L_Ouverts;
        private List<GenericNode> L_Fermes;
        /// <summary>
        /// Liste de tous les noeuds ayant été placés dans les ouverts.
        /// </summary>
        public List<List<GenericNode>> L_Ouverts_Historic { get; private set; }
        /// <summary>
        /// Liste de tous les noeuds ayant été placés dans les fermés.
        /// </summary>
        public List<List<GenericNode>> L_Fermes_Historic { get; private set; }


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
                if (L_Fermes[i].IsEqual (N2))
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
            L_Ouverts = new List<GenericNode>();
            L_Fermes = new List<GenericNode>();

            L_Ouverts_Historic = new List<List<GenericNode>>();
            L_Fermes_Historic = new List<List<GenericNode>>();

            // Le noeud passé en paramètre est supposé être le noeud initial
            GenericNode N = N0;
            L_Ouverts.Add(N0);

            UpdateHistoricLists();
            // tant que le noeud n'est pas terminal et que ouverts n'est pas vide
            while (L_Ouverts.Count != 0 && N.EndState() == false)
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
                UpdateHistoricLists();
            }
            // A* terminé
            AddLastFermesInHistoric();

            // On retourne le chemin qui va du noeud initial au noeud final sous forme de liste
            // Le chemin est retrouvé en partant du noeud final et en accédant aux parents de manière
            // itérative jusqu'à ce qu'on tombe sur le noeud initial
            List<GenericNode> SolutionNodes = new List<GenericNode>();
            if (N != null)
            {
                SolutionNodes.Add(N);

                while (N != N0)
                {
                    N = N.GetNoeud_Parent();
                    SolutionNodes.Insert(0, N);  // On insère en position 1
                }
            }
            return SolutionNodes;
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
                        if (N.GetGCost() + N.GetArcCost(N2) < N2bis.GetGCost())
                        {
                            // Mise à jour de N2bis
                            N2bis.SetGCost(N.GetGCost() + N.GetArcCost(N2));
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
                        N2.SetGCost(N.GetGCost() + N.GetArcCost(N2));
                        N2.SetNoeud_Parent(N);
                        N2.calculCoutTotal(); // somme de GCost et HCost
                        this.InsertNewNodeInOpenList(N2);
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

        // Si on veut obtenir les 2 arbres de recherche (entier et vide) , il suffit de passer 2 treeviews en paramètres
        // Ils sont mis à jour avec les noeuds de la liste des fermés (on ne tient pas compte des ouverts)
        public TreeView GetSearchTrees(TreeView fullTV, TreeView emptyTv)
        {
            if (L_Fermes == null || L_Fermes.Count == 0) return null;

            // On suppose les TreeViews préexistants
            fullTV.Nodes.Clear();
            emptyTv.Nodes.Clear();

            TreeNode TNfull = new TreeNode ( L_Fermes[0].ToString() );
            TreeNode TNempty = new TreeNode(L_Fermes[0].ToString() + ":" + 0);
            fullTV.Nodes.Add(TNfull);
            emptyTv.Nodes.Add(TNempty);


            AjouteBranche ( L_Fermes[0], TNfull, TNempty);

            return fullTV;
        }


        // AjouteBranche est exclusivement appelée par GetSearchTree; les noeuds sont ajoutés de manière récursive
        private void AjouteBranche(GenericNode GN, TreeNode TNfull, TreeNode TNempty)
        {
            foreach (GenericNode GNfils in GN.GetEnfants())
            {
                TreeNode TNfilsFull = new TreeNode(GNfils.ToString());
                TreeNode TNfilsEmpty = new TreeNode("noeud:distance"); //Texte du TreeNode permettant à l'utilisateur de savoir dans quel format rentrer la solution

                TNfull.Nodes.Add(TNfilsFull);
                TNempty.Nodes.Add(TNfilsEmpty);

                //Appel récursif de la méthode si le noeud étudié GNfils a des enfants
                if (GNfils.GetEnfants().Count > 0) AjouteBranche(GNfils, TNfilsFull, TNfilsEmpty);
            }
        }


        /// <summary>
        /// Ajoute les listes des fermés et des ouverts actuelles dans l'historique.
        /// </summary>
        private void UpdateHistoricLists()
        {
            if (!L_Ouverts_Historic.Contains(L_Ouverts))
                L_Ouverts_Historic.Add(new List<GenericNode>(L_Ouverts));

            if (!L_Fermes_Historic.Contains(L_Fermes))
                L_Fermes_Historic.Add(new List<GenericNode>(L_Fermes));
        }

        /// <summary>
        /// Ajoute la dernière étape dans l'historique des fermés.
        /// </summary>
        private void AddLastFermesInHistoric()
        {
            L_Fermes_Historic.Add(new List<GenericNode>(L_Fermes));
            int lastStep = L_Fermes_Historic.Count - 1;
            L_Fermes_Historic[lastStep].Add(L_Ouverts_Historic[lastStep - 1][0]);
        }

        ///<summary>Renvoie le noeud present dans la liste des ouverts à l'étape et l'index indiqué, sous forme
        ///d'une chaîne de caractères. Si aucun noeud n'est présent, renvoie un null.</summary>
        public String GetOuvertNodeFromHistoric(int step, int index)
        {
            if (L_Ouverts_Historic.Count > step && L_Ouverts_Historic[step].Count > index)
                return L_Ouverts_Historic[step][index].ToString();
            else return null;
        }

        ///<summary>Renvoie le noeud present dans la liste des fermes à l'étape et l'index indiqué, sous forme
        ///d'une chaîne de caractères. Si aucun noeud n'est présent, renvoie un null.</summary>
        public String GetFermeNodeFromHistoric(int step, int index)
        {
            if (L_Fermes_Historic.Count > step && L_Fermes_Historic[step].Count > index)
                return L_Fermes_Historic[step][index].ToString();
            else return null;
        }


    }
}
