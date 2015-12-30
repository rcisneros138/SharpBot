using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
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
    class tweetPublish
    {
        public void replyToUser(string user,string tweetMessage)
        {
            //take in list of users?
            //take in randomly selected message from another function.
            string message = String.Format("@{0}{1}", user, tweetMessage);
            var tweet = Tweet.PublishTweet(message);
        }

        public List<string> searchForTweets()
        {
            var tweets = Search.SearchTweets("werewolf");
            List<string> users = new List<string>();
            foreach (var tweet in tweets)
            {
                try
                {
                    //add to list?
                    //replyToUser(tweet.InReplyToScreenName, "Definitely not a Werewolf. all good.");
                    //Thread.Sleep(300000);
                    //Console.WriteLine(tweet.InReplyToScreenName);
                    users.Add(tweet.InReplyToScreenName);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                }
            }
            return users;
        }
        public string getQuote()
        {
            string[] lines = File.ReadAllLines("Quotes.txt");
            Random rand = new Random();
            int randomLineNumber = rand.Next(0, lines.Length);
            string ChosenQuote = lines[randomLineNumber];
            return ChosenQuote;
        }

    }
}
