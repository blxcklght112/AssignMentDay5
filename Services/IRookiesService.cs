using System.Data;
using AssignmentDay5.Models;

namespace AssignmentDay5.Services
{
    public interface IRookiesService
    {
        List<Person> GetMaleRookies();
        string OldestRookie();
        List<string> FullNameRookies();
        Tuple<List<Person>, List<Person>, List<Person>> GetRookiesByYear(int year);
        DataTable GetDataTable();
    }
}