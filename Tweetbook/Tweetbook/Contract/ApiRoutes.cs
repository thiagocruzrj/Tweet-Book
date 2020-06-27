namespace Tweetbook.Contract
{
    public static class ApiRoutes
    {
        public const string Root = "api";
        public const string Version = "v1";
        public static readonly string Base = $"{Root}/{Version}";

        public static class Posts
        {
            public static readonly string GetAll = $"{Base}/posts";
        }
    }
}