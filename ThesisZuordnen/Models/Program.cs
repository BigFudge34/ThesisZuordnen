using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ThesisZuordnen.Data;
namespace ThesisZuordnen.Models
{
    public class Program
    {
        public int ID { get; set; }
        public EnumerationOptions Name { get; set; }
    }
}
