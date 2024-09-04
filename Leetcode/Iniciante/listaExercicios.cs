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

        #region Exercicio: 2 - Palindromo Numero
        public bool IsPalindrome(int x)
        {
            var valor = 0;

            if (x < 0) return false; // valor negativo nao pode ser palintromo

            var s = x.ToString(); //convertemos para string para pega o tamanho dela
            var tamanho = s.Length;
            //O loop percorre a string comparando os caracteres da esquerda para a direita com os caracteres da direita para a esquerda
            for (var i = 0; i < tamanho / 2; i++)
            {
                //
                if (s[i] != s[tamanho - 1 - i])
                {
                    return false;
                }
            }
            return true;

        }

        #endregion

        #region xercicio: 3 - Convertendo ROmanos para Inteiro
        public int RomanToInt(string s)
        {
            var numeroRomano = 0;

            var valores = new Dictionary<char, int>{
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };
            for (int i = 0; i < s.Length; i++)
            {
                int valorAtual = valores[s[i]];


                if (i + 1 < s.Length && valores[s[i + 1]] > valorAtual)
                {
                    numeroRomano -= valorAtual;
                }
                else
                {
                    numeroRomano += valorAtual;
                }
            }
            return numeroRomano;
        }
        #endregion
    }
}
