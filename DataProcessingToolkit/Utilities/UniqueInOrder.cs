namespace Utilities
{
    public static class UniqueInOrderUtility
    {

        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            // Результирующий список для хранения уникальных элементов
            List<T> result = new List<T>();
            // Переменная для хранения предыдущего элемента
            T? previous = default;

            // Флаг для обработки первого элемента
            bool firstElement = true;
            foreach (T element in iterable)
            {
                // Если элемент первый или отличается от предыдущего, добавляем его в результат
                if (firstElement || !EqualityComparer<T>.Default.Equals(previous, element))
                {
                    result.Add(element);
                    previous = element;
                    firstElement = false;
                }
            }

            return result;
        }
    }
}
