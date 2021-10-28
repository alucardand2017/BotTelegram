using System;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot.Extensions.Polling;

namespace ExemploBotCSharp
{
    
    class Program
    {
        private static TelegramBotClient botCliente = new TelegramBotClient("2097654419:AAEY95yL3T8RoQ-utxEDPAp0N0ERWHI3iEs");
     

        static void Main(string[] args)
        {
                botCliente.OnMessage += BotCliente_OnMessage;
                botCliente.StartReceiving();
                Thread.Sleep(Timeout.Infinite); //em milissegundos
                botCliente.StopReceiving();


        }

        private static void BotCliente_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            if (e.Message.Text == "1" || e.Message.Text == "2" || e.Message.Text == "3" || e.Message.Text == "4" || e.Message.Text == "5" || e.Message.Text == "6")
            {
                switch (e.Message.Text)
                {
                    case "1":
                        botCliente.SendTextMessageAsync(e.Message.Chat.Id, $" o endereço do chat dessa conversa: {e.Message.Chat.Id}; \n o seu Id do telegram: {e.Message.From.Id}; \n O seu primeiro nome: {e.Message.From.FirstName}; \n o seu ultimo nome: {e.Message.From.LastName}");
                        break;

                    case "2":
                        botCliente.SendTextMessageAsync(e.Message.Chat.Id, "Anderson é um ex-estudante de física e automação industrial que irá iniciar seus estudos em programção C# e Engenharia de Software. Possuir 36 anos e é casado há 13. Tem um garoto muito tranquilo como filho de nome L* * * * ");
                        break;

                    case "3":
                        botCliente.SendTextMessageAsync(e.Message.Chat.Id, "De acorcom com o devmedia, a linguagem C# (lê-se “cêsharp”) foi criada juntamente com a arquitetura da plataforma .NET da Microsoft. Construída do zero, sem se preocupar com compatibilidade de código legado, e a maioria das classes do framework .NET foram escritas com essa linguagem. Vários desenvolvedores participaram do projeto de criação da linguagem, mas o principal envolvido no projeto foi o engenheiro Anders Hejlsberg, que além do C# foi criador do Turbo Pascal e do Delphi.");
                        break;

                    case "4":
                        botCliente.SendTextMessageAsync(e.Message.Chat.Id, "Porque eu pretendo aprender as mais sobre programção para ficar rico o mais rápido possível (brincadeira... sou socialista, viva lá Revolucion!)");
                        break;
                    case "5":
                        botCliente.SendTextMessageAsync(e.Message.Chat.Id, "Passou a ser permitido oficialmente a partir do Código Eleitoral de 1932. Foda né?!");
                        break;
                    case "6":
                        botCliente.SendTextMessageAsync(e.Message.Chat.Id, $"Safadinho você hein {e.Message.From.FirstName}!!!");
                        break;  
                }
            }
            else
            {
                botCliente.SendTextMessageAsync(e.Message.Chat.Id, "digite uma opção:\n 1 - seus dados \n 2 - quem sou eu \n 3 - o que é C# \n 4 - por que esse bot existe \n 5 - quando mulheres no brasil começaram a votar \n 6 - foto do meu _ _ _ !");
            }
        }
    }
}
