﻿using System;
using System.Collections.Generic;

namespace Alura.Loja.Testes.ConsoleApp
{
    internal class Promocao
    {
        
        public int Id { get; internal set; }
        public string Descricao { get; internal set; }
        public DateTime DataInicio { get; internal set; }
        public DateTime DataTermino { get; internal set; }
        public IList<Produto> Produtos { get; internal set; }

        public override string ToString()
        {
            return $"Promoção {this.Descricao}\n" +
                $"Data de Inicio: {this.DataInicio:t}\n" +
                $"Data de termino: {this.DataTermino:t}\n" +                
                $"\n"; ;
        }
    }
}