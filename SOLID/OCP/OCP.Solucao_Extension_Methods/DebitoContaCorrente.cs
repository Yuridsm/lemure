﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LeanringWithMosh.SOLID.OCP.OCP.Solucao_Extension_Methods
{
    public static class DebitoContaCorrente
    {
        // Extensions Methods
        public static string DebitarContaCorrente(this DebitoConta debitoConta)
        {
            // Lógica de negócio para debito em Conta Corrente
            return debitoConta.FormatarTransacao();
        }
    }
}
