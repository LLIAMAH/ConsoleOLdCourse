using System.Collections;

namespace ConsoleAppCore.Classes
{
    public class ExtendedArray<T> : IEnumerable<T>
    {
        private T[]? _array;
        private int? value1;

        public int Length1 => _array?.Length ?? 0;

        public int Length
        {
            get
            {
                return _array?.Length ?? 0;

                /*
                 // Логическая ТЕРНАРНАЯ операция, идентичная if/else что внизу
                return _array == null ? 0 : _array.Length;
                 */

                /*
                if (_array == null)
                    return 0;
                else
                    return _array.Length;
                */
            }
        }

        public T this[int index]
        {
            get
            {
                try
                {
                    if (_array == null)
                        throw new ArgumentNullException("array is null");

                    return _array[index];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new ArgumentOutOfRangeException("index");
                }
                catch (ArgumentNullException)
                {
                    throw;
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (_array != null)
                        _array[index] = value;
                }
                catch (IndexOutOfRangeException)
                {
                    throw new IndexOutOfRangeException($"Element with index {index} does not exist. Out of range.");
                }
            }
        }

        public ExtendedArray()
        {
            _array = default;
        }

        // var result = a + b;
        //                  result                                   a            b
        public static ExtendedArray<T> operator +(ExtendedArray<T> counter1, T counter2)
        {
            counter1.Add(counter2);
            return counter1;
        }

        public void Add(T? item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            if (_array != null)
            {
                // увеличиваем размер массива
                // в последний пустой - присваиваем наш входящий элемент
                _array = IncreaseArraySize(_array);
                _array[_array.Length - 1] = item;
            }
            else
            {
                // создать массив из одного элемента
                // присвоить в 0 индекс - наш входящий item
                _array = new T[1];
                _array[0] = item;
            }
        }

        private static TI[] IncreaseArraySize<TI>(TI[] array)
        {
            var length = array.Length;
            var tempArray = new TI[length + 1];
            for (int i = 0; i < length; i++)
            {
                tempArray[i] = array[i];
            }

            return tempArray;
        }

        public IEnumerator<T> GetEnumerator()
        {
            //return (IEnumerator <T>)this._array.GetEnumerator();
            if (this._array != null)
            {
                foreach (var item in this._array)
                {
                    yield return item;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
