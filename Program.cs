using System;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using TelegramBotTest_2.Bot;

namespace TelegramBotTest_2
{
    public class Program
    {

        static void Main(string[] args)
        {
            HandleUpdate update = new HandleUpdate();
            HandleError error = new HandleError();

            var client = new TelegramBotClient("6914793900:AAF9XSV8veiM4EwexY-kevxydqZFZ8lKRxg");

            client.StartReceiving(update.Update, error.Error);

            Console.ReadLine();
        }


    }
}
