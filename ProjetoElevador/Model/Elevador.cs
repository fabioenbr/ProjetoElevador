using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Model
{
    internal class Elevador
    {
        static void Main(string[] args)
        {
            elevator obj = new elevator();
            obj.Escolha();


        }
    }

    public class elevator
    {

        int Andar;
        int PosicaoAtual = 0;
        int AndarMaximo = 10;
        int AndarMinimo = 0;

        int TotalPessoas = 0;
        int TotalPessoasMaximo = 5;



        public void Escolha()
        {
            //Inicio da aplicação o pressuposto é que o úsuário está no térreo e decidiu entrar e escolhe o andar de destino

            Console.WriteLine("Bem vindo ao Edifício Mathilde");



            //Console.WriteLine("Vc está no Piso Térreo");
            Console.WriteLine("Nosso Edifício possui {0} Andares", AndarMaximo);
            Console.WriteLine("Por favor escolha o andar de destino");



            if (int.TryParse(Console.ReadLine(), out Andar))
            {
                Opcao(Andar);
            }
            else
            {
                //Console.WriteLine("Por favor Digite um valor: (int value)");
                Escolha();
            }
            Console.Clear();

        }
        private void Subir(int AndarDestino)
        {
            //Nesta etapa é avaliado se a opção escolhida é valida considerando o número de andares do prédio
            // Caso a opção escolhida para subir seja invalida ele retornara mesagem de erro caso contrário fara as interações e mostrará no Display
            //Chegando ao andar informa que o usuário chegou ao seu destino

            if (Andar > AndarMaximo)
            {
                Console.WriteLine("Opção Invalida");
            }
            else

                for (int i = PosicaoAtual; i <= AndarDestino; i++)
                {

                    {

                        Console.WriteLine("Subindo... " + i + " Andar ");

                        if (i == AndarDestino)
                        {

                            Console.WriteLine("Você chegou ao Andar solicitado");
                            PosicaoAtual = AndarDestino;
                            AndarDestino = 0;
                            break;
                        }
                    }
                }
            Escolha();
        }
        private void Descer(int AndarDestino)
        {
            //Nesta etapa é avaliado se a opção escolhida é valida considerando o número de andares do prédio
            // Caso a opção escolhida para descer seja invalida ele retornara mesagem de erro caso contrário fara as interações e mostrará no Display
            //Chegando ao andar informa que o usuário chegou ao seu destino

            if (Andar < AndarMinimo)
            {
                Console.WriteLine("Opção Invalida");
            }
            else

                for (int i = PosicaoAtual; i >= AndarDestino; i--)
                {
                    Console.WriteLine("Descendo .... " + i + " Andar ");
                    if (i == AndarDestino)
                    {
                        Console.WriteLine("Você chegou ao Andar solicitado");
                        PosicaoAtual = AndarDestino;
                        AndarDestino = 0;
                        break;
                    }

                }
            Escolha();
        }
        private void Opcao(int AndarDestino)
        {
            //Este passo irá avaliar o andar onde o usuário se encotra atualmente e ira subir ou descer a partir da posição atual

            if (AndarDestino > PosicaoAtual)
            {
                Subir(AndarDestino);
            }
            else if (AndarDestino < PosicaoAtual)
            {
                Descer(AndarDestino);
            }
        }

    }
}
