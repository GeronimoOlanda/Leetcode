using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Iniciante
{
    public class listaExercicios
    {
        private readonly int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
        private readonly int target = 9;
        //construtor vazio.
        public listaExercicios() { }

        public void ExecuteMethods()
        {
            Console.WriteLine(TwoSum(nums, target));
        }

        #region Exercicio: 1 - TwoSum
        public int[] TwoSum(int[] nums, int target)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {
                    var soma = nums[i] + nums[j];
                    if (soma == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[0];
        }
        #endregion
    }
}
