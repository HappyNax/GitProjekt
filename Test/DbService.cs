using System;
using System.IO;
using Newtonsoft.Json;

namespace Test
{
    internal class DbService
    {
        private string path;

        public DbService(string path)
        {
            this.path = path;
        }

        internal Database Get()
        {

            var text = File.ReadAllText(path);
            Database DbJason = JsonConvert.DeserializeObject<Database>(text);
            
            // read file : string
            // deserialize string to Database
            throw new NotImplementedException();
        }
    }
}