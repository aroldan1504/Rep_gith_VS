

namespace Comportamiento_Iterator
{
    class Item

    {
        private string _name;

        // Constructor

        public Item(string name)
        {
            this._name = name;
        }

        // Gets name

        public string Name
        {
            get { return _name; }
        }
    }
    interface IAbstractCollection

    {
        Iterator CreateIterator();
    }
}
