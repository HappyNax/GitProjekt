using program;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;
using Newtonsoft.Json;

namespace Test
{
    public class DbServiceTest
    {
        [Fact]
        public void ServiceShouldReadFromFile()
        {
            // arrange
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\db.json";

            Database db = new Database();
            db.Projects.Add(new ProjectDto());
            db.Projects.Add(new ProjectDto());

            var dbAsText = JsonConvert.SerializeObject(db);

            System.IO.File.WriteAllText(path, dbAsText);

            // act
            DbService dbService = new DbService(path);

            Database dbFromFile = dbService.Get();

            // assert
            Assert.Equal(db.Projects.Count, dbFromFile.Projects.Count);




        }
    }
}
