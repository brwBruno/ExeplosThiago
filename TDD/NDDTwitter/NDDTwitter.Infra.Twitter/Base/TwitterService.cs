using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;
using Tweetinvi.Models;

namespace NDDTwitter.Infra.Twitter.Base
{
    public class TwitterService  : ITwitterService
    {
        private readonly string _consumerKey;
        private readonly string _consumerSecret;
        private readonly string _accessToken;
        private readonly string _accessTokenSecret;

        public TwitterService()
        {
            // Obtém as chaves do configuration
            _consumerKey = ConfigurationManager.AppSettings["ConsumerKey"];
            _consumerSecret = ConfigurationManager.AppSettings["ConsumerSecret"];
            _accessToken = ConfigurationManager.AppSettings["AccessToken"];
            _accessTokenSecret = ConfigurationManager.AppSettings["AccessTokenSecret"];
        }

        public bool DeleteTweet(long id)
        {
            return Tweet.DestroyTweet(id);
        }

        public ITweet GetTweet(long id)
        {
            return Tweet.GetTweet(id);
        }

        public IEnumerable<ITweet> ListTweetsOnHomeTimeline()
        {
            return Timeline.GetHomeTimeline();
        }

        public ITweet SendTweet(string message)
        {
            return Tweet.PublishTweet(message);
        }

        public void SetCredentials() {
            Auth.SetUserCredentials(_consumerKey, _consumerSecret, _accessToken, _accessTokenSecret);
        }
    }
}
