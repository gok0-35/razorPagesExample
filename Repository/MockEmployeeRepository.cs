using razorpagesExample.Models;

namespace razorpagesExample.Repository;

public class MockEmployeeRepository : IEmployeeRepository
{
    private List<Employee> _employeeList;
    public MockEmployeeRepository()
    {
        _employeeList = new List<Employee>()
        {
            new Employee { Id = 1, Name="Gökmen Soysal", Email = "gokmensoysal@gmail.com", Photo = "1.jpg", Deparment = "Yönetim"},
            new Employee { Id = 2, Name="Elis Aydın", Email = "elisaydin@gmail.com", Photo = "2.jpg", Deparment = "Halkla İlişkiler"},
            new Employee { Id = 3, Name="Cenker Gezer", Email = "cenkergezer@gmail.com", Photo = "3.jpg", Deparment = "Hukuk"},
            new Employee { Id = 4, Name="Yalım Yasan", Email = "yalimyasan@gmail.com", Photo = "4.jpg", Deparment = "Muhasebe"},
        };
    }
    public IEnumerable<Employee> GetAll()
    {
        return _employeeList;
    }

    public Employee GetById(int id)
    {
        return _employeeList.FirstOrDefault(i => i.Id == id);
    }

    public Employee Update(Employee entity)
    {
        Employee employee = _employeeList.FirstOrDefault(i => i.Id == entity.Id);

        if (employee != null)
        {
            employee.Name = entity.Name;
            employee.Email = entity.Email;
            employee.Photo = entity.Photo;
            employee.Deparment = entity.Deparment;
        }
        return employee;
    }
}

