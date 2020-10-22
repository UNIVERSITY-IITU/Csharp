using System.Linq;
using System;
using Telegram.Bot;
using Telegram.Bot.Args;
using System.Collections.Generic;



namespace telegram_bot
{
    class Program
    {
        class User{
            public String FirstName{ get; set; }
            public String LastName{ get; set; }
            public String Username{ get; set; }
            public String registered{ get; set; }

            public User(String FirstName, String LastName, String Username, String registered){
                this.FirstName = FirstName;
                this.LastName = LastName;
                this.Username = Username;
                this.registered = registered;
            }

            public override string ToString()
            {
                return "Person: " + FirstName + " " + LastName + " " + Username + " registered on " + registered;
            }
        }
        static ITelegramBotClient botClient;
        static Dictionary<String, User> people = new Dictionary<String, User>();

        public delegate String getInfoUser(String key);

        public static String Info(String username){
            return people[username].ToString();
        }

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
            Random rand = new Random();

            if(e.Message.Text == "/start"){
                
                
                people.Add(e.Message.Chat.Username, new User(
                    e.Message.Chat.FirstName,
                    e.Message.Chat.LastName,
                    e.Message.Chat.Username,
                    Convert.ToString(e.Message.Date)
                ));

                await botClient.SendStickerAsync(
                chatId: e.Message.Chat,
                sticker: "https://github.com/TelegramBots/book/raw/master/src/docs/sticker-fred.webp"
                );
                
                await botClient.SendTextMessageAsync(
                    chatId : e.Message.Chat,
                    text:   $"Hello {e.Message.Chat.FirstName}🖐\nMy names is @aqzholskybot created while 8's laboratory work"
                );
            }

            else if(e.Message.Text == "/me"){
                getInfoUser func = new getInfoUser(Info);
                await botClient.SendTextMessageAsync(
                    chatId : e.Message.Chat,
                    text:   func(e.Message.Chat.Username)
                );
            }
            else if(e.Message.Text == "/random"){
                getInfoUser get_ = (username) => people[username].ToString(); 
                String username = people.Keys.ToList()[rand.Next(people.Count)];

                await botClient.SendTextMessageAsync(
                    chatId : e.Message.Chat,
                    text:   get_(username)
                ); 
            }
        }
    }
}
