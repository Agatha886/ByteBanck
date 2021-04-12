using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    public class Cliente
    {
        private string _nome;
        private string _cpf;
        char[] arr;
        private string _profissao; 
        public string Nome { get; set; }
        public string Profissao { get; set; }

        public string CPF
        {

            get
            {
                    return _cpf;
                
            }

            set
            {
                // Escrevo Minha lógica de validação CPF
                _cpf = value;
            }
        }

    }
}
