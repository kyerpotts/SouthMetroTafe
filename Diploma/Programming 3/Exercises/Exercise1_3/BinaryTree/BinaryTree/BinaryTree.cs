using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class BinaryTree
    {
        private Node root;

        public BinaryTree()
        {
            root = null;
        }

        #region Public Methods
        public virtual void Clear()
        {
            root = null;
        }
        #endregion

        #region Public Properties
        public Node Root
        {
            get { return root; }
            set { root = value; }
        }
        #endregion
    }
}
