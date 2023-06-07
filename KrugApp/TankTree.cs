using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrugApp
{
    internal class TankTree : ITree
    {
        public TankTree? parentNode { get; set; }
        public List<TankTree> childNodes { get; set; }

        // tank0 => (tank1, tank2) => tank3
        // if tank0 is null
        // this means that (tank1, tank2) were poured into tank3
        // if tank3 is null
        // this means that tank0 was split into (tank1, tank2)
        Tuple<int?, Tuple<int, int>, int?> step { get; set; }
        public Tank[] value { get; set; }

        private bool isValid()
        {
            /*
             * Pruning conditions:
             *      Node is getting farther from the result formula
             *      Child too similar to any parent
             *      Child too similar to other child
             */
            return true;
        }

        public TankTree(Tank[] value)
        {
            this.parentNode = null;
            this.value = value;
            this.childNodes = new List<TankTree>();
            this.step = new Tuple<int?, Tuple<int, int>, int?>(null, new Tuple<int, int>(0, 0), null);
        }

        public List<Tank[]> getPossibleChilds()
        {
            List<Tank[]> tanks = new List<Tank[]>();

            foreach (var t in this.value)
                foreach(var step in t.Steps)
                {
                    var splitStep = new Tuple<int?, Tuple<int, int>, int?>    (t.Index, step, null);
                    var mergeStep = new Tuple<int?, Tuple<int, int>, int?>    (null, step, t.Index);
                    tanks.Prepend(Tank.getStateAfterStep(this.value, splitStep));
                    tanks.Prepend(Tank.getStateAfterStep(this.value, mergeStep));
                }
            return tanks;
        }


        public void GenerateChilds(int depth)
        {
            if (depth > 0)
            {
                var possibleChilds = this.getPossibleChilds();
                foreach (var child in possibleChilds)
                {
                    TankTree childNode = new TankTree(child);
                    childNode.parentNode = this;
                    this.childNodes.Prepend(childNode);
                }
            }
        }
    }
}
