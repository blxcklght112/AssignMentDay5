using AssignmentDay5.Enum;
using AssignmentDay5.Models;

namespace AssignmentDay5.Data
{
    public static class RookiesData
    {
        public static List<Person> People = new List<Person>
        {
            new Person{
                FirstName = "Loc",
                LastName = "Pham Duc",
                Gender = Gender.Male,
                DateOfBirth = new DateTime(1999,01,12),
                PhoneNumber = "0343428821",
                BirthPlace = "Ha Noi",
                IsGraduated = false
                },
            new Person{
                FirstName = "Loc 2",
                LastName = "Pham Duc",
                Gender = Gender.Male,
                DateOfBirth = new DateTime(2000,01,12),
                PhoneNumber = "0343428821",
                BirthPlace = "Ha Noi",
                IsGraduated = false
            },
            new Person{
                FirstName = "An",
                LastName = "Nguyen Hai",
                Gender = Gender.Female,
                DateOfBirth = new DateTime(1989,12,03),
                PhoneNumber = "0343428821",
                BirthPlace = "Thai Nguyen",
                IsGraduated = false
            },
            new Person{
                FirstName = "An 2",
                LastName = "Nguyen Hai",
                Gender = Gender.Other,
                DateOfBirth = new DateTime(1989,12,03),
                PhoneNumber = "0343428821",
                BirthPlace = "Thai Nguyen",
                IsGraduated = false
            },
            new Person{
                FirstName = "Nhung",
                LastName = "Nguyen Hong",
                Gender = Gender.Female,
                DateOfBirth = new DateTime(2004,08,08),
                PhoneNumber = "0343428821",
                BirthPlace = "Thai Binh",
                IsGraduated = false
            },
        };
    }
}