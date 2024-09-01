using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Iniciante
{
    public class listaExercicios
    {
        private readonly int[] nums  =  {1, 2, 3, 4, 5, 6, 7};
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
            // Inicializa o array nums (removi a linha que redefinia nums, pois nums já é passado como argumento)
            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                { // Começa o segundo loop a partir de i + 1 para evitar somar o mesmo índice
                    var soma = nums[i] + nums[j];
                    if (soma == target)
                    {
                        // Retorna um array contendo os índices i e j que satisfazem a condição
                        return new int[] { i, j };
                    }
                }
            }

            // Se nenhum par for encontrado, pode-se retornar um array vazio ou lançar uma exceção
            return new int[0]; // ou throw new ArgumentException("Nenhum par encontrado que some o valor target.");
        }
        #endregion
    }
}
