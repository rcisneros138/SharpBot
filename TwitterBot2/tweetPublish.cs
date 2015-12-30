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
        Random rand = new Random();
        List<string> tweetedUsers = new List<string>();
        public void replyToUser()
        {
            List<string> users = searchForTweets();
            string chosenUser = users[rand.Next(users.Count)];

            if (tweetedUsers.Contains(chosenUser))
            {
                return;
            }
            else
            {
                string message = String.Format("@" + "{0} {1}", chosenUser, FileMediaGetter.getFileItem("Quotes.txt"));
                Console.WriteLine(message);
                var tweet = Tweet.PublishTweet(message);
                tweetedUsers.Add(chosenUser);
            }
        }

        public void tweetWithMedia()
        {
            try
            {
                byte[] file = File.ReadAllBytes(FileMediaGetter.getMedia());
                var tweet = Tweet.PublishTweetWithImage(FileMediaGetter.getFileItem("Quotes.txt"), file);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            
        }

        public List<string> searchForTweets()
        {
            var tweets = Search.SearchTweets("WereWolf");
            List<string> users = new List<string>();
            foreach (var tweet in tweets)
            {
                try
                {
                    users.Add(tweet.InReplyToScreenName);
                    //Console.WriteLine(tweet);
                    
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    continue;
                }
            }
            users.RemoveAll(string.IsNullOrWhiteSpace);
            return users;
        }
       

    }
}
