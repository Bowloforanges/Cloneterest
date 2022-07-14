using System.Collections.Generic;


namespace Users.Mongo.Configurations
{
    public class MongoOptions
    {
        public const string MongoSettings = "MongoSettings";
        public Dictionary<string, string> Collections { get; set; }
    }
}
