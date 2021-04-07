using System.ComponentModel;
using System;
using System.Runtime.CompilerServices;
// This is a simple customer class that 
// implements the IPropertyChange interface.
namespace CSharp
{
public class DemoCustomer : INotifyPropertyChanged
{
    // These fields hold the values for the public properties.
    private Guid idValue = Guid.NewGuid();
    private string customerNameValue = string.Empty;
    private string phoneNumberValue = string.Empty;

    public event PropertyChangedEventHandler PropertyChanged;

    // This method is called by the Set accessor of each property.
    // The CallerMemberName attribute that is applied to the optional propertyName
    // parameter causes the property name of the caller to be substituted as an argument.
    private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
    {
         Console.WriteLine($" property name {propertyName}");
        if (PropertyChanged != null)
        {           
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    // The constructor is private to enforce the factory pattern.
    private DemoCustomer()
    {
        customerNameValue = "Customer";
        phoneNumberValue = "(312)555-0100";
        //sConsole.WriteLine($" property name {customerNameValue}");
    }
    public static void AddEvent(DemoCustomer d)
    {
        d.AddEvent();
    }
    public  void AddEvent()
    {
        PropertyChanged+= (object a, PropertyChangedEventArgs c)=>{Console.WriteLine($"type {a.GetType().ToString()} property name changed{c.PropertyName}");};
    }

    // This is the public factory method.
    public static DemoCustomer CreateNewCustomer()
    {
        return new DemoCustomer();
    }

    // This property represents an ID, suitable
    // for use as a primary key in a database.
    public Guid ID
    {
        get
        {
            return this.idValue;
        }
    }

    public string CustomerName
    {
        get
        {
            return this.customerNameValue;
        }

        set
        {
            if (value != this.customerNameValue)
            {
                this.customerNameValue = value;
                NotifyPropertyChanged();
            }
        }
    }

    public string PhoneNumber
    {
        get
        {
            return this.phoneNumberValue;
        }

        set
        {
            if (value != this.phoneNumberValue)
            {
                this.phoneNumberValue = value;
                NotifyPropertyChanged();
            }
        }
    }
}
}