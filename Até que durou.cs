using System;
using System.Threading;

class Program
{
    static void Main()
    {
        // Aqui você pode colar a letra da música (ou qualquer texto longo)
        string letra = @"
Tentei fazer valer a pena
Passei por cima dos problemas
Achei que eu era o bastante
Mas não fui pra você

Tentei ser um cara perfeito
Eu fiz as coisas do seu jeito
Queria ser mais importante
Mas não fui pra você

Até que durou
Me diz o porquê
Perdeu tanto tempo aqui
Te faço um favor
Melhor eu sumir

Fui mais um nas suas mãos
Não sei se por carência ou falta de opção
Só sei que eu senti amor
Que pena, só eu senti amor

O que faço com os planos
Dos próximos anos
Juro que não sei
Só sei que eu senti amor
Que pena, só eu senti amor
Só eu senti amor

Tentei ser um cara perfeito
Eu fiz as coisas do seu jeito
Queria ser mais importante
Mas não fui pra você

Até que durou
Me diz o porquê
Perdeu tanto tempo aqui
Te faço um favor
Melhor eu sumir

Fui mais um nas suas mãos
Não sei se por carência ou falta de opção
Só sei que eu senti amor
Que pena, só eu senti amor

O que faço com os planos
Dos próximos anos
Juro que não sei
Só sei que eu senti amor
Que pena, só eu senti amor

Fui mais um nas suas mãos
Não sei se por carência ou falta de opção
Só sei que eu senti amor
Que pena, só eu senti amor

O que faço com os planos
Dos próximos anos
Juro que não sei
Só sei que eu senti amor
Que pena, só eu senti amor
Só eu senti amor

Fui mais um nas suas mãos
Não sei se por carência ou falta de opção
Só sei que eu senti amor
Que pena, só eu senti amor

O que faço com os planos
Dos próximos anos
Juro que não sei
Só sei que eu senti amor
Que pena, só eu senti amor

Fui mais um nas suas mãos
Não sei se por carência ou falta de opção
Só sei que eu senti amor
Que pena, só eu senti amor

O que faço com os planos
Dos próximos anos
Juro que não sei
Só sei que eu senti amor
Que pena, só eu senti amor

Fui mais um nas suas mãos
Não sei se por carência ou falta de opção
Só sei que eu senti amor
Que pena, só eu senti amor

O que faço com os planos
Dos próximos anos
Juro que não sei
Só sei que eu senti amor
Que pena, só eu senti amo
Só eu senti amor";

        foreach (char c in letra)
        {
            Console.Write(c);
            Thread.Sleep(100); // Ajuste a velocidade (ms)
        }

        Console.WriteLine("\n\n[Fim da música]");
    }
}
