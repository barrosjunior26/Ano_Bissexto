namespace Excercico21
{
    class Ano_Bissexto
    {
        public static void Main(String[] args)
        {
            //Faça um algoritmo que leia um determinado ano e mostre se ele é ou não BISSEXTO.

            //Declaração de variáveis
            int opcao = 0;

            do
            {
                //Solicita ao usuário ano
                Console.Write("Informe o ano que você deseja verificar se é ou não bissexto: ");
                int ano = int.Parse(Console.ReadLine());

                //Processamento dos dados e condições que irão verificar se o ano é Bissexto
                if (ano % 4 == 0)
                {
                    Console.WriteLine("O ano informado é BISSEXTO!");
                }
                else if (ano % 100 == 0)
                {
                    Console.WriteLine("O ano informado é BISSEXTO!");
                }
                else if (ano % 400 == 0)
                {
                    Console.WriteLine("O ano informado é BISSEXTO!");
                }
                else
                {
                    Console.WriteLine("O ano informado não é BISSEXTO!");
                }
                Console.Write("Digite 1 para NOVA OPERAÇÃO ou 0 para SAIR: ");
                opcao = int.Parse(Console.ReadLine());
            }while(opcao != 0);
        }
    }
}