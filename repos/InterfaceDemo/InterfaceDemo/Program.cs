using InterfaceDemo;

internal class Program
{
    private static void Main(string[] args)
    {
        Company c = new Company();
        c.Name = "ChangePond Technologies";
        c.addressline1 = "SIPCOT,Siruseri";
        c.city = "Chennai";
        c.state = "Tamil Nadu";
        c.postcode = "603103";
        c.Email = "contact@changepond.com";
       
        c.addressDetails();
        c.ContactDetails();
       
                
        Employee e = new Employee();
        e.Name = "Eswaran Arumugam";
        e.addressline1 = "SIPCOT,Siruseri";
        e.city = "Chennai";
        e.state = "Tamil Nadu";
        e.postcode = "8925708431";
        e.Email = "eswaran.codepro@gmail.com";
      
        e.addressDetails();
        e.ContactDetails();

    }
}
