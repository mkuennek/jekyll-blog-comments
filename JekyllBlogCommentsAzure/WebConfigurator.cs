using System;

namespace JekyllBlogCommentsAzure
{
    public class WebConfigurator
    {
        public string CommentWebsiteUrl => Environment.GetEnvironmentVariable("CommentWebsiteUrl");

        public string GitHubToken => Environment.GetEnvironmentVariable("GitHubToken");

        public string PullRequestRepository => Environment.GetEnvironmentVariable("PullRequestRepository");

        public string CommentFallbackCommitEmail => Environment.GetEnvironmentVariable("CommentFallbackCommitEmail");

        public string SentimentAnalysisSubscriptionKey => Environment.GetEnvironmentVariable("SentimentAnalysis.SubscriptionKey");

        public string SentimentAnalysisRegion => Environment.GetEnvironmentVariable("SentimentAnalysis.Region");

        public string SentimentAnalysisLang => Environment.GetEnvironmentVariable("SentimentAnalysis.Lang");
    }
}
