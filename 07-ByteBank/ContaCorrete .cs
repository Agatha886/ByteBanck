//using _05_ByteBank;

namespace _07_ByteBank
{

    class ContaCorrente
    {
        private Cliente _titular;
        private int _agencia;
        private int _numero;
        private double _saldo = 100;

        public static int TotalDeContasCriadas { get; private set; }


        public Cliente Titular
        {
            get
            {
                return _titular;
            }

            set
            {
                _titular = value;
            }
        }

        public int Agencia
        {
            get
            {
                return _agencia;
            }

            set
            {
                if (value <= 0)
                {
                    return;
                }

                _agencia = value;
            }
        }

        public int Numero
        {
            get
            {
                return _numero;
            }

            set
            {
                _numero = value;
            }
        }

        public double Saldo
        {
            get
            {
                return _saldo;
            }

            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        public ContaCorrente (int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
        }

        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
       
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                contaDestino.Depositar(valor);

                return true;
            }
        }
    }
}

