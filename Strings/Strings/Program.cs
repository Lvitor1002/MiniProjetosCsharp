
using System;
using System.Text;


namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //**************************************//
            //                  GUID                //
            //**************************************//

            //Identificador globalmente único.
            //Um Guid é um número de 128 bits que é quase impossível de ser duplicado.
            var id = Guid.NewGuid();
            Console.WriteLine($"Chave: {id.ToString()}\n");
            Console.WriteLine("-----------------------------------------");

            /* 
                Usado como:
                    primárias de banco de dados: Para garantir que cada registro tenha um identificador único, mesmo em sistemas distribuídos.
                    Identificadores de sessão: Para rastrear sessões de usuários de forma segura em aplicações web.
                    Nomes de arquivos: Para garantir que arquivos com o mesmo nome não se sobreponham.
                    Identificação de objetos: Para dar a objetos ou entidades uma identidade única no seu sistema. 
            */






            //////////////////////////////////////////////////////////////////////////////////////////









            //**************************************//
            //             Interpolador             //
            //**************************************//

            string nome = "Maria";
            int idade = 30;

            // Interpolação de string
            string mensagemInterpolacao = $"Olá, meu nome é {nome} e eu tenho {idade} anos.";
            Console.WriteLine(mensagemInterpolacao);

            // Interpolação de string com Format
            string mensagemInterpolacaoFormat = string.Format("Olá, meu nome é {0} e eu tenho {1} anos.", nome, idade);
            Console.WriteLine(mensagemInterpolacaoFormat);

            // Concatenação de string
            string mensagemConcatenacao = "Olá, meu nome é " + nome + " e eu tenho " + idade + " anos.";
            Console.WriteLine($"{mensagemConcatenacao}\n");
            Console.WriteLine("-----------------------------------------");





            //////////////////////////////////////////////////////////////////////////////////////////









            //**************************************//
            //        Comparação de Strings         //
            //**************************************//

            string texto2 = "Testando";
            Console.WriteLine($"{texto2.Contains("Testando")}");
            

            //Retorna int
            //Sendo [1]\[-1] para afirmar a diferença das strings ou [0] para afirmar a igualdade das strings
            string texto = "Testando";
            Console.WriteLine($"{texto.CompareTo("Testando")}");
            Console.WriteLine("-----------------------------------------");

            string texto3 = "Testando este texto";
            Console.WriteLine($"{texto3.StartsWith("este")}");


            string texto4 = "Testando este outro texto";
            Console.WriteLine($"{texto4.EndsWith("texto")}");
            Console.WriteLine("-----------------------------------------");

            string texto5 = "Testando este novo texto";
            Console.WriteLine($"{texto5.Equals("Testando este texto")}"); // Os tipos devem ser sempre iguais quando é usado o [Equals]
            Console.WriteLine("-----------------------------------------");

            string texto6 = "Posicao letra A";
            Console.WriteLine($"{texto6.IndexOf("A")}");


            string texto7 = "Posicao letra A";
            Console.WriteLine($"{texto7.LastIndexOf("A")}"); // Ultima ocorrência da letra encontrada
            Console.WriteLine("-----------------------------------------");

            string texto8 = "TUDO EM MINÚSCULO";
            Console.WriteLine($"{texto8.ToLower()}");

            string texto9 = "Tudo em maiúsculo";
            Console.WriteLine($"{texto9.ToUpper()}");
            Console.WriteLine("-----------------------------------------");

            string texto10 = "Espaços em branco";
            Console.WriteLine(texto10.Insert(17," aqui:")); //Na posição 5, insere a palavra "Aqui"

            string texto11 = "Espaços em branco aqui";
            Console.WriteLine(texto11.Remove(18, 4)); //Na posição 18, remova 4 caracteres"
            Console.WriteLine("-----------------------------------------");

            string texto12 = "Espaços em branco";
            string textoSemEspaco = texto12.Replace(" ", "");
            Console.WriteLine(textoSemEspaco.Length);
            Console.WriteLine("-----------------------------------------");


            string teste = "Testando este outro texto dividido";
            var dividido = teste.Split(' '); // Divide a string em um array de strings, usando o espaço como delimitador
            Console.WriteLine(string.Join("\n",dividido));
            Console.WriteLine("-----------------------------------------");


            string teste2 = "Testando este outro texto substring";
            Console.WriteLine(teste2.Substring(9, 5)); // Extrai uma substring começando na posição 9 com comprimento 5 caracteres
            Console.WriteLine("-----------------------------------------");


            string teste3 = ("   Testando este outro texto com espaços em branco no início e no fim ").Trim();
            Console.WriteLine(teste3); //Trim() remove os espaços em branco do início e do fim da string
            Console.WriteLine("-----------------------------------------");


            /*Usado para construir e manipular strings de forma eficiente e performática,
                principalmente em cenários onde há muitas concatenações ou modificações*/
            var sb = new StringBuilder();
            sb.Append("Usando StringBuilder");
            sb.AppendLine(" para construir strings");
            Console.WriteLine(sb.ToString());
        }
    }
}
