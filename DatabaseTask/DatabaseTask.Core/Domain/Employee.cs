﻿using System.ComponentModel.DataAnnotations;


namespace DatabaseTask.Data.Domain
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int SocialSecurityNumber { get; set; }
        public string Address { get; set; }
        public int ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string? Comment { get; set; }

        // Foreign key properties to reference with email
        public Email Email { get; set; }
        public Guid EmailId { get; set; }

        // Navigation property to represent the relationship with Emails
        public ICollection<Email> Emails { get; set; } = new List<Email>();

        // Navigation property to represent the relationship with SalesOrders
        //public ICollection<SalesOrder> SalesOrders{ get; set; } = new List<SalesOrder>();

        // Navigation property to represent the relationship with Campaigns
        public ICollection<Campain> Campains { get; set; } = new List<Campain>();

        // Navigation property to represent the relationship with Orders
        public ICollection<Order> Orders { get; set; } = new List<Order>();


        /// TEINE HINDELINE HARJUTUS
        ///
        /// 1. Teha Teie meeskonna poolt esitletud FirmaDB-st objektide struktuur.
        /// 2. Kui see on valmis, siis teha code first migration. Vajadusel võib mitu migrationit teha.
        /// 3. NB! Kasutate enda meeskonna poolt esitatud FirmaDB ERD-d, aga igaüks teeb individuaalselt.
        /// 4. Järgida hea programmeerimise tava.
        /// 5. Kogu solution laadida GitHubi ja link valmis tööst saata mulle.
        /// 6. Järgmisena teha print screen MS SQL-s database diagrams all olevast auto-genereeritud ERD-st pilt. See lisada readMe.md failina sama projekti alla GitHubis.

        /// Mõned muutujad võivad olla ka NULL väärtusega ja need tuleb ära märkida

        /// kui peate tõmbama mingeid packagesi alla, siis kasutage eelistatult microsofti omasid ning latest stabel versiooni

        /// <summary>
        /// Kui kasutate enumit, siis peate olema kindel, et on tegemist valikutega, mis jäävad kogu rakenduse eluajaks samaks.
        /// </summary>
        //public Gender Gender { get; set; }

        /// <summary>
        /// 
        /// Siin on info ja analüüs, et mis varianti kasutada
        /// https://stackoverflow.com/questions/10113244/why-use-icollection-and-not-ienumerable-or-listt-on-many-many-one-many-relatio/10113331
        /// https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerable?redirectedfrom=MSDN&view=net-5.0
        /// https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1?redirectedfrom=MSDN&view=net-5.0
        /// https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?redirectedfrom=MSDN&view=net-5.0
        /// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers#:~:text=Object%20initializers%20let%20you%20assign,by%20lines%20of%20assignment%20statements.
        /// </summary>
        /// Kas peaks objekti initsialiseerima või mitte
        //public IEnumerable<Children> Childrens { get; set; } = new List<Children>();
        //public ICollection<Children> Childrens { get; set; }
        //public List<Children> Childrens { get; set; }
    }


    //public enum Gender
    //{
    //    Female, 
    //    Male,
    //    Unknown
    //}

    //public class Children
    //{
    //    [Key]
    //    public Guid Id { get; set; }

    //    public string FirstName { get; set; }
    //}
}

