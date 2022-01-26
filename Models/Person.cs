using AssignmentDay5.Enum;

namespace AssignmentDay5.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string BirthPlace { get; set; }
        public bool IsGraduated { get; set; }
        public string IsGrad
        {
            get
            {
                if (IsGraduated)
                {
                    return "Yes";
                }
                else return "No";
            }
        }
        public int Age
        {
            get
            {
                return DateTime.Now.Year - DateOfBirth.Year;
            }
        }
        public string PersonInfo
        {
            get
            {
                return String.Format($"{FirstName,-5} {LastName,-12} {Gender.ToString(),-10} {DateOfBirth,-15} {BirthPlace,-15} {Age,-5} {IsGrad}\n");
            }
        }
        public string FullName
        {
            get
            {
                return String.Format($"{LastName} {FirstName}");
            }
        }
    }
}