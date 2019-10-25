using System;
using System.Collections.Generic;

namespace EOLCricketSimulator
{
    public class WeightRandom
    {
        private List<int> _probability;
        private List<int> _runs;
        private int[] _prefix;
        private int _runsCount;
        public WeightRandom(List<int> runs, List<int> prob)
        {
            _probability = prob;
            _runs = runs;
            _runsCount = runs.Count;
            _prefix = new int[_runsCount];
            _prefix[0] = _probability[0];
            for (int i = 1; i < _runsCount; ++i)
                _prefix[i] = _prefix[i - 1] + _runs[i];
        }

        // To return an index
        private int findCeilValue(int randomNo, int l, int h)
        {
            int mid;
            while (l < h)
            {
                mid = l + ((h - l) >> 1); // Same as mid = (l+h)/2  
                if (randomNo > _prefix[mid])
                {
                    l = mid + 1;
                }
                else
                {
                    h = mid;
                }
            }

            return (_prefix[l] >= randomNo) ? l : -1;
        }

        // To calculate the score for a player
        public int Next()
        {
            int randomNo = (new Random().Next(0, _prefix[_runsCount - 1]) % _prefix[_runsCount - 1]) + 1;
            int indexc = findCeilValue(randomNo, 0, _runsCount - 1);
            return _runs[indexc];


        }
    }
}
