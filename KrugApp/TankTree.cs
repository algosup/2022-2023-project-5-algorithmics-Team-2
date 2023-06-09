﻿namespace KrugApp
{
    internal class TankTree : ITree
    {
        public TankTree? ParentNode { get; set; }
        public List<TankTree> ChildNodes { get; set; }

        // tank0 => (tank1, tank2) => tank3
        // if tank0 is null
        // this means that (tank1, tank2) were poured into tank3
        // if tank3 is null
        // this means that tank0 was split into (tank1, tank2)
        public Tuple<int?, Tuple<int, int>, int?> Step { get; set; }
        public Tank[] value { get; }
        private bool IsValid()
        {
            /*
             * Pruning conditions:
             *      Node is getting farther from the result formula
             *      Child too similar to any parent
             *      Child too similar to other child
             */
            if (this == null)
                return false;

            // Check if the node is too similar to any parent
            var node = this.ParentNode;
            while (node != null)
            {
                if (DifferenceScore(this, node) < 50) // too low = too similar
                    return false;
                node = node.ParentNode;
            }

            // Check if the node is too similar to any sister node
            if (this.ParentNode != null)
                for(int i = 0; i < this.ParentNode.ChildNodes.Count; i++) // Very slow, but still faster than adding every node
                    if (DifferenceScore(this, this.ParentNode.ChildNodes[i]) < 50) // too low = too similar
                        return false;

            return true;
        }

        /// <summary>
        /// Given two tanks <paramref name="a"/> and <paramref name="b"/>, return the "difference" score between them
        /// </summary>
        /// <param name="a">First tank to compare</param>
        /// <param name="b">Second tank to compare</param>
        /// <returns></returns>
        private static int DifferenceScore(Tank a, Tank b)
        {
            float score = 0;
            if(a.IsEmpty && b.IsEmpty)
                return 0;
            for (int i = 0; i < a.Wine.Length; i++)
                score += Math.Abs(a.Wine[i].Quantity - b.Wine[i].Quantity);            
            
            return (int)score;
        }

        /// <summary>
        /// Given two nodes <paramref name="a"/> and <paramref name="b"/>, return the "difference" score between them
        /// </summary>
        /// <param name="a">First node to compare</param>
        /// <param name="b">Second node to compare</param>
        /// <returns></returns>
        private static int DifferenceScore(TankTree a, TankTree b)
        {
            int score = 0;

            for (int i = 0; i < a.value.Length; i++)
                score += DifferenceScore(a.value[i], b.value[i]);

            return score;
        }


        public TankTree(TankTree tanktree)
        {
            this.ParentNode = tanktree.ParentNode;
            this.ChildNodes = tanktree.ChildNodes;
            this.Step = tanktree.Step;
            this.value = (Tank[])tanktree.value.Clone();
        }

        public TankTree(Tank[] Value, Tuple<int?, Tuple<int, int>, int?>? step = null)
        {
            this.ParentNode = null;

            this.value = (Tank[])Value.Clone();
            this.ChildNodes = new();
            this.Step = step;
        }

        public List<TankTree> GetPossibleChilds(List<Tuple<int, int>>[] combinaison)
        {
            List<TankTree> possibleChilds = new();

            for (int tankIndex = 0; tankIndex < this.value.Length; tankIndex++)
            {
                int duplicate = -1;
                foreach (var step in combinaison[tankIndex])
                {
                    // check if the input tank emptyness is different from the tank in the step emptyness, if they are the same, skip the step
                    if (this.value[tankIndex].IsEmpty == this.value[step.Item1].IsEmpty || this.value[tankIndex].IsEmpty == this.value[step.Item2].IsEmpty)
                        continue;
                    
                    // Skip the step if we already used the tank in the step once, other generated state would be the same
                    if (step.Item1 == duplicate)
                        continue;
                    else
                        duplicate = step.Item1;

                    // Create the step tuple
                    var Step = new Tuple<int?, Tuple<int, int>, int?>(null, new Tuple<int, int>(0,0), null);
                    if (this.value[tankIndex].IsEmpty)
                        Step = new (null, step, tankIndex);
                    else
                        Step = new (tankIndex, step, null);

                    // Get the new state after the step
                    var nextState = Tank.getStateAfterStep(this.value, Step);
                    var childNode = new TankTree(nextState, Step);

                    // Keep track of the step that generated the child
                    childNode.Step = Step;


                    // Add the new state to the possible childs if it is valid (pruning)                    
                    //if (childNode.IsValid())
                    possibleChilds.Add(childNode);
                }
            }
            return possibleChilds;
        }

        public int CountNodes()
        {
            // count every node of the tree
            int count = 1;
            foreach (var child in this.ChildNodes)
                count += child.CountNodes();
            return count;
        }

        public void GenerateChilds(int depth, List<Tuple<int, int>>[] combinaison)
        {
            if (depth > 0)
            {
                var possibleChilds = this.GetPossibleChilds(combinaison);
                foreach (var childNode in possibleChilds)
                {
                    childNode.ParentNode = this;
                    this.ChildNodes.Add(childNode);
                    childNode.GenerateChilds(depth - 1, combinaison);
                }
            }
        }

        // todo FINISH THE BREADTH SEARCH

        private static float DiffFormula(Tank[] tanks, Wine[] formula)
        {
            float lowest = float.MaxValue;
            foreach (var tank in tanks)
            {
                if (tank.IsEmpty)
                    continue;
                float diff = 0;
                for (int i = 0; i < tank.Wine.Length; i++)
                {
                    diff += Math.Abs(tank.Wine[i].Quantity - formula[i].Quantity);
                }
                if (diff < lowest)
                    lowest = diff;
            }
            return lowest;
        }

        public static TankTree Search(TankTree tree, Wine[] formula)
        {
            // Look at all the leafs of the tree and return the best solution
            TankTree bestSolution = tree;
            float bestScore = float.MaxValue;

            foreach (var node in tree.ChildNodes)
            {
                if (node.ChildNodes.Count == 0)
                {
                    float score = DiffFormula(node.value, formula);
                    if (score < bestScore)
                    {
                        bestScore = score;
                        bestSolution = node;
                    }
                }
                else
                {
                    var solution = Search(node, formula);
                    if (solution != null)
                    {
                        float score = DiffFormula(solution.value, formula);
                        if (score < bestScore)
                        {
                            bestScore = score;
                            bestSolution = solution;
                        }
                    }
                }
            }
            // return the best solution
            return bestSolution;
        }

        public static Tank bestTank(TankTree node, Wine[] formula)
        {
            var bestTank = node.value[0];
            float bestScore = float.MaxValue;
            foreach (var tank in node.value) 
            {
                if (tank.IsEmpty)
                    continue;
                float score = 0;
                for (int i = 0; i < tank.Wine.Length; i++)
                {
                    score += Math.Abs(tank.Wine[i].Quantity - formula[i].Quantity);
                }
                if (score < bestScore)
                {
                    bestScore = score;
                    bestTank = tank;
                }
            }
            return bestTank;
        }
    }
}
