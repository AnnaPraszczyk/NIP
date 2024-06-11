using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

//namespace SimpleProjectManager.Module.BusinessObjects.Marketing
namespace NIP2.Module.BusinessObjects.PobieranieDanych
{

    [NavigationItem("Pobieranie Danych")]
    public class Customer : BaseObject
    {
        public Customer(Session session) : base(session) { }
        string nip;
        public string NIP
        {
            get { return nip; }
            set { SetPropertyValue(nameof(NIP), ref nip, value); }
        }
        string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { SetPropertyValue(nameof(FirstName), ref firstName, value); }
        }
        string lastName;
        public string LastName
        {
            get { return lastName; }
            set { SetPropertyValue(nameof(LastName), ref lastName, value); }
        }
        string email;
        public string Email
        {
            get { return email; }
            set { SetPropertyValue(nameof(Email), ref email, value); }
        }
        string company;
        public string Company
        {
            get { return company; }
            set { SetPropertyValue(nameof(Company), ref company, value); }
        }
        string street;
        public string Street
        {
            get { return street; }
            set { SetPropertyValue(nameof(Street), ref street, value); }
        }

    }
        /*[Association("Customer-Testimonials")]
        public XPCollection<Testimonial> Testimonials
        {
            get { return GetCollection<Testimonial>(nameof(Testimonials)); }
        }
        public string FullName
        {
            get
            {
                string namePart = string.Format("{0} {1}", FirstName, LastName);
                return Company != null ? string.Format("{0} ({1})", namePart, Company) : namePart;
            }
        }
    }*/
    [NavigationItem("Pobieranie Danych")]
    public class DaneGUS : BaseObject
    {
        public DaneGUS(Session session) : base(session) { }
        
        string nipGUS;
        public string NIPGUS
        {
            get { return nipGUS; }
            set { SetPropertyValue(nameof(NIPGUS), ref nipGUS, value); }
        }
        string firstNameGUS;
        public string FirstNameGUS
        {
            get { return firstNameGUS; }
            set { SetPropertyValue(nameof(FirstNameGUS), ref firstNameGUS, value); }
        }
        string lastNameGUS;
        public string LastNameGUS
        {
            get { return lastNameGUS; }
            set { SetPropertyValue(nameof(LastNameGUS), ref lastNameGUS, value); }
        }
        string emailGUS;
        public string EmailGUS
        {
            get { return emailGUS; }
            set { SetPropertyValue(nameof(EmailGUS), ref emailGUS, value); }
        }
        string companyGUS;
        public string CompanyGUS
        {
            get { return companyGUS; }
            set { SetPropertyValue(nameof(CompanyGUS), ref companyGUS, value); }
        }
        string streetGUS;
        public string StreetGUS
        {
            get { return streetGUS; }
            set { SetPropertyValue(nameof(StreetGUS), ref streetGUS, value); }
        }
    }
}