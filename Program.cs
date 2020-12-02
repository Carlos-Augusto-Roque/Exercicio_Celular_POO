using System;
using Exercicio_Celular_POO.classes;

namespace Exercicio_Celular_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular iphone = new Celular();//instânciamento da classe - objeto Celular Iphone 
            Console.ForegroundColor = ConsoleColor.Blue;//alteração da cor do texto
            Console.WriteLine(iphone.cor = "Cor : Black");//Exibição da mensagem
            Console.WriteLine(iphone.modelo = "Modelo: Iphone 12 Pro Max 128GB");//Exibição da mensagem
            Console.WriteLine(iphone.tamanho = "Dimensões: 78.1 mm X 160.8 mm X 7.4 mm");//Exibição da mensagem
            Console.ResetColor();//fim da alteração da cor do texto
            
            Console.WriteLine("Ligar ? true or false ");//exibição da mensagem
            iphone.ligado = bool.Parse(Console.ReadLine());//atribuição para verdadeiro ou falso,entrada e armazenamento da resposta

            if(iphone.ligado == true)//caso opte por ligar o celular 
            {

                Console.ForegroundColor =ConsoleColor.Green;//alteração da cor do texto
                Console.WriteLine(iphone.Ligar());//exibir o método ligar
                Console.ResetColor();//fim da alteração da cor do texto

                string funcao = "";//variável para escolher a função

                 //estrutura de repetição do-while
                do//ler em primeiro lugar o menu
                {   
                    Console.WriteLine("------------------");//exibição da mensagem
                    Console.WriteLine("---Menu inicial---");//exibição da mensagem
                    Console.WriteLine("Selecione a função desejada:");//exibição da mensagem
                    Console.WriteLine("[1] - Realizar chamada");//exibição da mensagem
                    Console.WriteLine("[2] - Enviar SMS");//exibição da mensagem
                    Console.WriteLine("[0] - Encerrar o dispositivo");//exibição da mensagem
                    funcao = Console.ReadLine();//entrada e armazenamento da opção escolhida

                    //estrutura de condicional  
                    switch (funcao)
                    {
                        case "1"://se a função escolhida for 1,então:
                            Console.ForegroundColor = ConsoleColor.Green;//alteração da cor do texto
                            Console.WriteLine(iphone.FazerLigacao());//exibição do método
                            Console.ResetColor();//fim da alteração da cor do texto
                        break;

                        case "2":
                            Console.ForegroundColor = ConsoleColor.Green;//alteração da cor do texto
                            Console.WriteLine(iphone.EnviarMensagem());//exibição do método
                            Console.ResetColor();//fim da alteração da cor do texto
                        break;

                        case "0":
                            Console.ForegroundColor = ConsoleColor.Green;//alteração da cor do texto
                            Console.WriteLine(iphone.Desligar());//exibição do método
                            Console.ResetColor();//fim da alteração da cor do texto
                        break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;//fim da alteração da cor do texto
                            Console.WriteLine("Função inexistente !");//exibição da mensagem
                            Console.ResetColor();//fim da alteração da cor do texto
                        break;
                    }
                

                } while (funcao != "0");//se a função escolhida for diferente de 0 , então entre com uma opção até que seja válida
            
            }else//fim da condicional 
            { 
                Console.WriteLine("-----------------");//exibição da mensagem
            }
        }
    }
}

//  Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
// - Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
// - Só será possível executar tais métodos se o celular estiver ligado.
// - Suba o projeto para um repositório no Github, com o título "AulaPOOCelular".
// - Envie o link do repositório como entrega desta atividade.
