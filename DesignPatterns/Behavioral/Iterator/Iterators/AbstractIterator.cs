using System.Collections;

namespace DesignPatterns.Behavioral.Iterator.Iterators
{
    public abstract class AbstractIterator : IEnumerator
    {
        public virtual bool MoveNext()
        {
            throw new System.NotImplementedException();
        }

        public virtual void Reset()
        {
            throw new System.NotImplementedException();
        }

        public virtual object Current { get; }
    }
}