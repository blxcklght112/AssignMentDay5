using System.Data;
using AssignmentDay5.Data;
using AssignmentDay5.Enum;
using AssignmentDay5.Models;

namespace AssignmentDay5.Services
{
    public class RookiesService : IRookiesService
    {
        public List<Person> GetMaleRookies()
        {
            return RookiesData.People.Where(person => person.Gender == Gender.Male).ToList();
        }

        public string OldestRookie()
        {
            var result = RookiesData.People.Where(person => person.Age == RookiesData.People.Max(x => x.Age)).FirstOrDefault();
            if (result == null)
            {
                return "Khong co thanh vien nao thoa man, hay kiem tra lai.";
            }
            else return result.PersonInfo;
        }

        public Tuple<List<Person>, List<Person>, List<Person>> GetRookiesByYear(int year)
        {
            var lessThan2k = RookiesData.People.Where(person => person.DateOfBirth.Year < year).ToList();
            var equals2k = RookiesData.People.Where(person => person.DateOfBirth.Year == year).ToList();
            var greaterThan2k = RookiesData.People.Where(person => person.DateOfBirth.Year > year).ToList();
            return Tuple.Create(lessThan2k, equals2k, greaterThan2k);
        }

        public List<string> FullNameRookies()
        {
            return RookiesData.People.Select(person => person.FullName).ToList();
        }

        public DataTable GetDataTable()
        {
            DataTable table = new DataTable();
            table.Columns.AddRange(new DataColumn[8] {
                new DataColumn("FirstName"),
                new DataColumn("LastName"),
                new DataColumn("Gender"),
                new DataColumn("DateOfBirth"),
                new DataColumn("Age"),
                new DataColumn("PhoneNumber"),
                new DataColumn("BirthPlace"),
                new DataColumn("IsGraduated")});

            foreach (var person in RookiesData.People)
            {
                table.Rows.Add(person.FirstName, person.LastName, person.Gender.ToString(), person.DateOfBirth, person.Age, person.PhoneNumber, person.BirthPlace, person.IsGrad);
            }

            return table;
        }
    }
}
