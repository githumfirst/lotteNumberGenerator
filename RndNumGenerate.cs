using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoNumberGenerator
{
    class RndNumGenerate
    {
        int[] rndNumArray = new int[46];
        Random rndNumGen = new Random();

        public int[] GetNumArray()
        {
            for (int i = 0; i < 46; i++)
            {
                rndNumArray[i] = rndNumGen.Next(1, 46);                
            }                      
            return rndNumArray;
        }
                 

    }
}
