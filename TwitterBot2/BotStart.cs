using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Net.Http;
using System.Reflection;
using Tweetinvi;
using Tweetinvi.Core;
using Tweetinvi.Core.Credentials;
using Tweetinvi.Core.Enum;
using Tweetinvi.Core.Extensions;
using Tweetinvi.Core.Interfaces;
using Tweetinvi.Core.Interfaces.Controllers;
using Tweetinvi.Core.Interfaces.DTO;
using Tweetinvi.Core.Interfaces.Models;
using Tweetinvi.Core.Interfaces.Streaminvi;
using Tweetinvi.Core.Parameters;
using Tweetinvi.Json;
using SavedSearch = Tweetinvi.SavedSearch;
using Stream = Tweetinvi.Stream;

namespace TwitterBot2
{
   public class BotStart
    {
        public void runBot()
        {
            tweetPublish publishTweet = new tweetPublish();
            FollowerManager followerManager = new FollowerManager();
            Random rand = new Random();
            int roll = 5;//rand.Next(0,5);
            #region ifStatement
            //if (roll == 1)
            //{
            //    publishTweet.searchForTweets();
            //    //timer
            //    runBot();
            //}
            //else if (roll == 2)
            //{
            //    publishTweet.replyToUser();
            //    //timer
            //    runBot();
            //}
            //else if (roll == 3)
            //{
            //    publishTweet.tweetWithMedia();
            //    //timer
            //    runBot();
            //}
            //else if(roll == 4)
            //{
            //    publishTweet.tweetTrending();
            //    runBot();
            //}
            #endregion
            switch (roll)
            {
                case 1:
                    publishTweet.searchForTweets();
                    Console.WriteLine("sleeping two minutes");
                    Thread.Sleep(120000); // 2 minues
                    runBot();
                    break;
                case 2:
                    publishTweet.replyToUser();
                    Console.WriteLine("sleeping two minutes");
                    Thread.Sleep(120000); // 2 minues
                    runBot();
                    break;
                case 3:
                    publishTweet.tweetWithMedia();
                    Console.WriteLine("sleeping two minutes");
                    Thread.Sleep(120000); // 2 minues
                    runBot();
                    break;
                case 4:
                    publishTweet.tweetTrending();
                    Console.WriteLine("sleeping two minutes");
                    Thread.Sleep(120000); // 2 minues
                    runBot();
                    break;
                case 5:
                    followerManager.followUser();
                    Console.WriteLine("sleeping two minutes");
                    Thread.Sleep(120000); // 2 minues
                    break;
                
            }

        }

    }
}
