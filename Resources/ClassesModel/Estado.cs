﻿using System;

namespace Automobile
{
    public class Estado
    {

        //componente da classe
        public enum Tipo
        {
            //estrutura de dados usada para declarar um tipo numérico com um conjunto de valores constantes nomeados. Esses valores constantes representam os membros do enum e são conhecidos como enumerações.
            Disponivel,
            Reservado,
            Alugado,
            EmManutencao
        }
        public Tipo Nome { get; set; }

        private DateTime _dataInicio;
        private DateTime? _dataFim;
        public DateTime DataInicio
        {
            get
            {
                return _dataInicio;
            }
            set
            {
                if (value < DateTime.Today)
                {
                    throw new ArgumentException("A data de início não pode ser no passado.");
                }
                _dataInicio = value;
            }
        }
        public DateTime? DataFim
        {
            get
            {
                return _dataFim;
            }
            set
            {

                _dataFim = value;
            }
        }

        //construtor default para quando criar o veiculo
        public Estado()
        {
            Nome = Tipo.Disponivel; // Definir o estado padrão como Disponível
            DataInicio = DateTime.Now; // Definir a data de fim como o momento atual
            DataFim = null;
        }
        public Estado(Tipo nome, DateTime inicio, DateTime fim)
        {
            Nome = nome;
            DataInicio = inicio;
            DataFim = fim;
        }


    }
}
