

namespace EmrahCustome
{
   public class CustomList<T>
    {
        private List<T> items;

        public CustomList()
        {
            items = new List<T>();
        }

        public void Add(T item)
        {
            items.Add(item);
        }

        public T Find(Predicate<T> predicate)
        {
            return items.Find(predicate);
        }
    }
}
