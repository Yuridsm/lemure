﻿
namespace lemure.OOP
{
    abstract class Eletrodomestico
    {
        private readonly string _nome;
        private readonly int _voltagem;
        protected Eletrodomestico(string nome, int voltagem)
        {
            _nome = nome;
            _voltagem = voltagem;
        }

        public abstract void Ligar();
        public abstract void Desligar();
        public virtual void Testar()
        {
            //Testa o equipamento...
        }
    }
}
