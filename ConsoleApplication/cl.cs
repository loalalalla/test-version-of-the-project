using System.Collections;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class cl
    {
        private IList<object> _objects = new List<object>();

        public void AddObjectTocl(object item)
        {
            _objects.Add(item);
        }

        public void clearcl()
        {
            _objects = new List<object>();
        }
    }
}
