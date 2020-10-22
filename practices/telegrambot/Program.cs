using System;
using Telegram.Bot;
using Telegram.Bot.Args;



namespace telegram_bot
{
    class Program
    {
        static ITelegramBotClient botClient;

        static void Main(string[] args)
        {
            botClient = new TelegramBotClient("1251528088:AAECXGaHJx7J7PsDPKsot5rpWlThNN-hpuw");
            var me = botClient.GetMeAsync().Result;
            Console.WriteLine(me.Username);

            botClient.OnMessage += Bot_OnMessage;
            botClient.StartReceiving();

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

            botClient.StopReceiving();
        }

        static async void Bot_OnMessage(object sender, MessageEventArgs e){
            Console.WriteLine(e.Message.Text);
            if(e.Message.Text == "/start"){

                await botClient.SendStickerAsync(
                    chatId: e.Message.Chat,
                    sticker: "https://github.com/UNIVERSITY-IITU/Csharp/tree/main/practices/telegram%20bot/stickers/sticker.webp"
                    );

                await botClient.SendTextMessageAsync(
                    chatId : e.Message.Chat,
                    text:   e.Message.Text
                );
            }
        }
    }
}
