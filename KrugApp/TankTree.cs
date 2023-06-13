using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrugApp
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
        public Tank[] value { get; set; }

        private bool IsValid()
        {
            /*
             * Pruning conditions:
             *      Node is getting farther from the result formula
             *      Child too similar to any parent
             *      Child too similar to other child
             */
            return true;
        }

        public TankTree(Tank[] value, Tuple<int?, Tuple<int, int>, int?>? step = null)
        {
            this.ParentNode = null;
            this.value = value;
            this.ChildNodes = new();
            this.Step = step;
        }

        public List<TankTree> GetPossibleChilds(List<Tuple<int, int>>[] combinaison)
        {
            List<TankTree> possibleChilds = new();

            for (int tankIndex = 0; tankIndex < this.value.Length; tankIndex++)
            {
                if (possibleChilds.Count > 30)
                    break;

                foreach (var step in combinaison[tankIndex])
                {
                    // Create the step tuple
                    var Step = new Tuple<int?, Tuple<int, int>, int?>(null, new Tuple<int, int>(0,0), null);
                    if (this.value[tankIndex].IsEmpty)
                        Step = new (null, step, tankIndex);
                    else
                        Step = new (tankIndex, step, null);

                    // Get the new state after the step
                    var nextState = Tank.getStateAfterStep(value, Step);
                    var childNode = new TankTree(nextState, Step);

                    // Keep track of the step that generated the child
                    childNode.Step = Step;
                    // Add the new state to the possible childs
                    possibleChilds.Add(childNode);
                }
            }
            return possibleChilds;
        }


        public void GenerateChilds(int depth, List<Tuple<int, int>>[] combinaison)
        {
            if (depth > 0)
            {
                var possibleChilds = this.GetPossibleChilds(combinaison);
                foreach (var childNode in possibleChilds)
                {
                    if (!childNode.IsValid())
                    {
                        continue;
                    }
                    else
                    {
                        childNode.ParentNode = this;
                        this.ChildNodes.Add(childNode);
                        childNode.GenerateChilds(depth - 1, combinaison);
                    }
                }
            }
        }
    }
}
