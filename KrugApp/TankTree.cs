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
            if (this.ParentNode == null || this.ParentNode.ChildNodes.Count < 60)
                return true;
            return false;
        }

        public TankTree(Tank[] value)
        {
            this.ParentNode = null;
            this.value = value;
            this.ChildNodes = new();
            this.Step = null;
        }

        public List<TankTree> GetPossibleChilds()
        {
            List<TankTree> possibleChilds = new();

            foreach (var tank in this.value)
                foreach(var step in tank.Steps)
                {
                    if (tank.IsEmpty)
                    {
                        var stepTuple = new Tuple<int?, Tuple<int, int>, int?>(null, step, tank.Index);
                        var stepTree = new TankTree(Tank.getStateAfterStep(this.value, stepTuple));
                        stepTree.Step = stepTuple;
                        possibleChilds.Add(stepTree);
                    }
                    else
                    {
                        var stepTuple = new Tuple<int?, Tuple<int, int>, int?>(tank.Index, step, null);
                        var stepTree = new TankTree(Tank.getStateAfterStep(this.value, stepTuple));
                        stepTree.Step = stepTuple;
                        possibleChilds.Add(stepTree);
                    }
                }
            return possibleChilds;
        }


        public void GenerateChilds(int depth)
        {
            if (depth > 0)
            {
                var possibleChilds = this.GetPossibleChilds();
                foreach (var childNode in possibleChilds)
                {
                    if (!childNode.IsValid())
                        continue;
                    childNode.ParentNode = this;
                    this.ChildNodes.Prepend(childNode);
                    childNode.GenerateChilds(depth - 1);
                }
            }
        }
    }
}
