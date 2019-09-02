using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_task_6
{
    public class RangeOfArray
    {
        private int[] _array;
        public int _size { get; set; }
        private int _minIndex;
        private int _maxIndex;

        public RangeOfArray(int minIndex, int maxIndex)
        {
            _minIndex = minIndex;
            _maxIndex = maxIndex;
            _size = _maxIndex - _minIndex;
            _array = new int[_size];
        }

        public int MinIndex
        {
            get { return _minIndex; }
            set
            {
                if (value > MaxIndex)
                {
                    _minIndex = value;
                    int temp = MinIndex;
                    MinIndex = MaxIndex;
                    MaxIndex = temp;
                }
            }
        }
        public int MaxIndex
        {
            get { return _maxIndex; }
            set
            {
                if (value < MinIndex)
                {
                    _maxIndex = value;
                    int temp = MinIndex;
                    MinIndex = MaxIndex;
                    MaxIndex = temp;
                }
            }
        }
        public int this[int i]
        {
            get
            {
                return _array[Math.Abs(i) - Math.Abs(MinIndex)];
            }
            set
            {
                _array[Math.Abs(i) - Math.Abs(MinIndex)] = value;
            }
        }
    }
}
