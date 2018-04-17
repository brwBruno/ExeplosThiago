using System;
using System.Collections.Generic;
using Tweetinvi.Models;

namespace NDDTwitter.Infra.Twitter.Base
{
    public interface ITwitterService
    {
        ITweet GetTweet(long id);

        IEnumerable<ITweet> ListTweetsOnHomeTimeline();

        ITweet SendTweet(string message);

        bool DeleteTweet(long id);
    }
}
