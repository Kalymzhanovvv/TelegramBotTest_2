using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using TelegramBotTest_2.Data;
using TelegramBotTest_2.Game;

namespace TelegramBotTest_2.Bot
{
    public class HandleUpdate
    {
        ApplicationContext db = new ApplicationContext();
        Moves moves = new Moves();

        public async Task Update(ITelegramBotClient client, Update update, CancellationToken token)
        {
            var message = update.Message;

            if (message.Text != null)
            {
                await Console.Out.WriteLineAsync(
                    $"UserName - {message.Chat.FirstName} | Text - {message.Text}"
                    );

                if (message.Text == "/игра")
                {
                    await client.SendTextMessageAsync(
                        message.Chat.Id,
                        "Добро пожаловать в игру!"
                        );
                }
            }


            await AddToDb(message.Chat.Id);
        }

        async Task AddToDb(long id)
        {
            var currentAppUser = await db.appUsers.FirstOrDefaultAsync(x => x.TelegramUserId == id);

            if (currentAppUser == null)
            {
                AppUser newAppUser = new AppUser()
                {
                    TelegramUserId = id
                };

                db.appUsers.Add(newAppUser);
                await db.SaveChangesAsync();
                await Console.Out.WriteLineAsync("Добавлено в базу данных");
            }
        }
    }
}
