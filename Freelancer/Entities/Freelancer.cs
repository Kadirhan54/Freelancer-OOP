using Freelancer.Abstract;
using Freelancer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelancer.Entities
{
    internal class Freelancer : Person<Guid> ,ICsvConvertable
    {
        public string? WorkExperience { get; set; }

        public List<Review>? Reviews { get; set; }
        public List<Job>? Jobs { get; set; }

        public string GetValuesCSV()
        {
            return $"{Id};{CreatedOn};{FirstName};{LastName};{WorkExperience}";
        }

        public void SetValuesCSV(string csv)
        {
            string[] data = csv.Split(';');
            Id = Guid.Parse(data[0]);
            CreatedOn = DateTimeOffset.Parse(data[1]);
            FirstName = data[2];
            LastName = data[3];
            WorkExperience = data[4];
        }
    }
}
