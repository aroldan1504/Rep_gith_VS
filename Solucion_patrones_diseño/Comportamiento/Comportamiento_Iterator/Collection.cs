using System.Collections;


namespace Comportamiento_Iterator
{
    class Collection : IAbstractCollection

    {
        private ArrayList _items = new ArrayList();

        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

        // Gets item count

        public int Count
        {
            get { return _items.Count; }
        }

        // Indexer

        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Add(value); }
        }
    }
    interface IAbstractIterator

    {
        Item First();
        Item Next();
        bool IsDone { get; }
        Item CurrentItem { get; }
    }
}
