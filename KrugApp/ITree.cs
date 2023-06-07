using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrugApp
{
    internal interface ITree
    {
        public interface ITreeNode<T> where T : ITreeNode<T>
        {
            T? parentNode { get; set; }
            T value { get; set; }
            ICollection<T> childNodes { get; set; }
        }
    }
}
