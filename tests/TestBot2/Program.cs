using System;
using VkBotFramework;
using VkNet.Enums.Filters;

namespace TestBot2
{
    internal class Program
    {
        private static string AccessToken = "qpz06es4JjMqjb4kDi1cvNCQfVumHDL5IkJfpiNafD0X-PggDF3ZF6zl2EoTn4zs8bwhd629vyS31m1QNqrkM3Qiost9XFW3Y3D2nm1PsLCh32zVsTBe20NAMP8toWl2wjT6IDo-nqjMe4CCeRPgc4onRxBSM9CCuu-eAFneL0xcI9GcAQUbSfcuSbyYsyBRpS4SM_Dlwpk4uptEXchEqg";
        private static string GroupUrl = "https://vk.com/public219066759";
        static void Main(string[] args)
        {
            VkBot bot = new VkBot(AccessToken, GroupUrl);
            Console.WriteLine("Bot is started");
        }
    }
}
