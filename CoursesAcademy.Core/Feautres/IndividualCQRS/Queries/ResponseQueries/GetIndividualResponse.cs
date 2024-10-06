using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursesAcademy.Core.Feautres.IndividualCQRS.Queries.ResultHandlers
{
    public class GetIndividualResponse
    {
        public int Id { get; set; }

        public string University { get; set; } = null!;

        public int YearOfGraduation { get; set; }
        public  string? ParticpantName { get; set; }
    }
}
