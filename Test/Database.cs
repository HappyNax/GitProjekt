using program;
using System.Collections.Generic;

namespace Test
{
    internal class Database
    {
        public Database()
        {
            Projects = new List<ProjectDto>();
        }

        public List<ProjectDto> Projects { get; internal set; }
    }
}