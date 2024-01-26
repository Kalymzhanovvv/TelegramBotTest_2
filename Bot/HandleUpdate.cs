using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using TelegramBotTest_2.Data;

namespace TelegramBotTest_2.Bot
{
    public class HandleUpdate
    {
        ApplicationContext db = new ApplicationContext();

        public async Task Update(ITelegramBotClient client, Update update, CancellationToken token)
        {
            var message = update.Message;

            if (message.Text != null)
            {
                await Console.Out.WriteLineAsync(
                    $"UserName - {message.Chat.FirstName} | Text - {message.Text}"
                    );

                if (message.Text.ToLower().Contains("/start"))
                {
                    await client.SendTextMessageAsync(message.Chat.Id, "Ассаляму алейкум уа рахматулла!");
                    return;
                }
                else if
                (
                    message.Text.ToLower().Contains("ассаляму алейкум") ||
                    message.Text.ToLower().Contains("ассалаумағалейкүм")

                )
                {
                    await client.SendTextMessageAsync(message.Chat.Id, "Уа алейкум ассалям уа рахматулла!");
                    return;
                }
                else
                {
                    await client.SendTextMessageAsync(message.Chat.Id, "Такого варианта ответа нет.");
                    return;
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
