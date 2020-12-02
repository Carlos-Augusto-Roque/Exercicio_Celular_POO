namespace Exercicio_Celular_POO.classes
{
    public class Celular
    {
        //atributos
        public string cor;
        public string modelo;
        public string tamanho;
        public bool ligado;

        //métodos
        public string Ligar()
        {
            ligado = true;//quando quiser ligar o celular
            return "Inicializando - Por favor aguarde...";//retornar a mensagem
        }
        
        public string Desligar()//quando quiser desligar o celular
        {
            ligado = false;
            return "Encerrando o dispositivo.....";//retornar a mensagem
        }
 
        public string FazerLigacao()//quando quiser fazer uma ligação
        {
            return "Ligando.....";//retornar a mensagem
        }

        public string EnviarMensagem()//quando quiser enviar uma mensagem
        {
            return "Enviando.....";//retornar a mensagem
        }

        
    }
}
// Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
// Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.