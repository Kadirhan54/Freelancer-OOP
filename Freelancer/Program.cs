using Freelancer.Entities;
using Freelancer.Services;
using Freelancer.Common;
using Freelancer.Abstract;
using Freelancer.Constants;

Console.WriteLine("Hello, World!");



ICsvConvertable freelancerInstance = new Freelancer.Entities.Freelancer()
{
    Id = Guid.NewGuid(),          // Replace with a valid GUID
    CreatedOn = DateTime.Now,    // Replace with the creation date
    FirstName = "John",
    LastName = "Doe",
    WorkExperience = "5 years of experience in web development",
    Reviews = new List<Review>
    {
        new Review { Text = "Excellent freelancer!", Rating = 5 },
        new Review { Text = "Great work!", Rating = 4 }
    }
};

var CustomerInstance = new Customer
{
    Id = Guid.NewGuid(),          // Replace with a valid GUID
    CreatedOn = DateTime.Now,    // Replace with the creation date
    FirstName = "Bob",
    LastName = "Smith",
    PhoneNumber = "555-123-4567" // Replace with an actual phone number
};



NotepadService notepadService = new();
notepadService.SaveToNotepad(CustomerInstance);
notepadService.SaveToNotepad(freelancerInstance);

string path = $"{FileLocation.ProjectFolder}\\Database";
string customerPath = $"{FileLocation.ProjectFolder}\\Database\\Customers.txt";
string freelancerPath = $"{FileLocation.ProjectFolder}\\Database\\Freelancers.txt";

string customerData = notepadService.GetOnNotepad(customerPath);
string freelancerData = notepadService.GetOnNotepad(freelancerPath);

string[] splittedLinesCustomer = customerData.Split("\n", StringSplitOptions.RemoveEmptyEntries);
string[] splittedLinesFreelancer = customerData.Split("\n", StringSplitOptions.RemoveEmptyEntries);

List<Customer> customers = new();
List<Freelancer.Entities.Freelancer> freelancers = new();

foreach (var line in splittedLinesCustomer)
{
    Customer customer = new();
    customer.SetValuesCSV(line);
    customers.Add(customer);
}

foreach (var line in splittedLinesFreelancer)
{
    Freelancer.Entities.Freelancer freelancer = new();
    freelancer.SetValuesCSV(line);
    freelancers.Add(freelancer);
}