namespace H_2_2.Model;

public class VisitCard
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public string Description { get; set; }

    public VisitCard(string firstName, string lastName, DateTime birthDate, string description)
    {
        FirstName = firstName;
        LastName = lastName;
        BirthDate = birthDate;
        Description = description;
    }

    public int Age
    {
        get
        {
            var today = DateTime.Today;
            var age = today.Year - BirthDate.Year;
            if (BirthDate.Date > today.AddYears(-age))
            {
                age--;
            }
            return age;
        }
    }
}

