using ClassLibrary;
using System;

namespace Testing2
{
    internal class clsSupplierCollection
    {
        public clsSupplierCollection()
        {
        }

        public List<clsSupplier> SupplierList { get; internal set; }
        public clsSupplier ThisSupplier { get; internal set; }
        public int Count { get; internal set; }

        internal int Add()
        {
            throw new NotImplementedException();
        }
    }
}