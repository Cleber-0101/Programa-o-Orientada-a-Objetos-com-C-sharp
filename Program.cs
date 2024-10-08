﻿using System;
using System.Collections.Generic;
using CursoCSharp.fundamentos;
using CursoCSharp.EstruturaDeControle;

namespace CursoCSharp
{
    class Program
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"Variaveis - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferencia - Fundamentos",inferencia.Excecutar},
                {"Notação com Ponto - Fundamentos",NotacaoPonto.Excecutar},
                {"Lendo informações do console - Fundamentos",Lendoinformacoes.Excecutar},
                {"Formatando numeros - Fundamentos",FormatandoNumeros.Excecutar},
                {"Conversoes de Tipos - Fundamentos",ConversoesDeTipos.Excecutar},
                {"Operadores Aritmeticos - Fundamentos", Operadores.Excecutar},
                {"operadores Relacionais - Fundamentos" , OperadoresRelacionais.Excecutar},
                {"operadores Logicos - Fundamentos" , OperadoresLogicos2.Excecutar},
                {"operadores ternarios - Fundamentos" , OperadorTernario.Excecutar},

                //estrutura de controle
                {"Estrutura de controle if - condicionais" , EstruturaIf.Excecutar}
            });

            central.SelecionarEExecutar();
        }
    }
}