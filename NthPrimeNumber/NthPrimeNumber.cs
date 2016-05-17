using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NthPrimeNumber
{
    public class PrimeNumber
    {
        private List<int> _primes { get; set; }

        public List<int> Primes => _primes;

        public PrimeNumber()
        {
            _primes = new List<int>() { 2 };
        }

        public int GetNthPrimeNumber(int n)
        {
            if (n == 1)
            {
                return _primes[0];
            }

            for (int valueCheck = 3; valueCheck <= int.MaxValue - 1; valueCheck += 2)
            {
                if (IsPrime(valueCheck))
                {
                    _primes.Add(valueCheck);
                }
                if (_primes.Count == n)
                {
                    return _primes[n - 1];
                }
            }
            return _primes[n - 1];

        }

        public bool IsPrime(int valueCheck)
        {
            return _primes.All(prime => (valueCheck%prime) != 0 || !(prime <= Math.Sqrt(valueCheck)));
        }
    }
}
