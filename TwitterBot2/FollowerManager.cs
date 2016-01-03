using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
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
    class FollowerManager
    {
        tweetPublish tweetPublisher = new tweetPublish();
        Random rand = new Random();
        public void FollowFollowers()
        {
            try
            {
                var followRequests = Account.GetUsersRequestingFriendship();
                var currentUser = User.GetLoggedUser();
                foreach (var user in followRequests)
                {
                    currentUser.FollowUser(user);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("no requests recieved!");
            }
        }
        public void followUser()
        {
            List<string> users = tweetPublisher.searchForTweets();
            var currentUser = User.GetLoggedUser();
            try
            {
                currentUser.FollowUser(users[rand.Next(0, users.Count)]);
            }
            catch (Exception e)
            { 
                Console.WriteLine(e);
            }
    
            
        }

        public static void LoggedUser_GetOutgoingRequests()
        {
            try
            {
                var RequestsToFollow = Account.GetUsersYouRequestedToFollow();
                foreach (var user in RequestsToFollow)
                {
                    Console.WriteLine("You sent a request to follow {0}!", user.Name);
                }
            }
            catch
            {
                Console.WriteLine("No requests sent!");
            }
          
        }
    }
}
