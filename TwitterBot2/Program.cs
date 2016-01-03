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
    class Program
    {
        static void Main(string[] args)
        {
            
            tweetPublish publishTweet = new tweetPublish();
            FollowerManager followerManager = new FollowerManager();
            BotStart startBot = new BotStart();
            startBot.runBot();
            
            
          
           
            Console.ReadLine();
        }
       
        
    }
}
