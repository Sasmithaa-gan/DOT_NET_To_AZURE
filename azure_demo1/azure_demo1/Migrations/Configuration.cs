namespace azure_demo1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using azure_demo1.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<azure_demo1.Data.azure_demo1Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(azure_demo1.Data.azure_demo1Context context)
        {
            context.Contacts.AddOrUpdate(p => p.Name,
         new Contact
         {
             Name = "Debra Garcia",
             Address = "1234 Main St",
             City = "Redmond",
             State = "WA",
             Zip = "10999",
             Email = "debra@example.com",
         },
          new Contact
          {
              Name = "Thorsten Weinrich",
              Address = "5678 1st Ave W",
              City = "Redmond",
              State = "WA",
              Zip = "10999",
              Email = "thorsten@example.com",
          },
          new Contact
          {
              Name = "Yuhong Li",
              Address = "9012 State st",
              City = "Redmond",
              State = "WA",
              Zip = "10999",
              Email = "yuhong@example.com",
          },
          new Contact
          {
              Name = "Jon Orton",
              Address = "3456 Maple St",
              City = "Redmond",
              State = "WA",
              Zip = "10999",
              Email = "jon@example.com",
          },
          new Contact
          {
              Name = "Diliana Alexieva-Bosseva",
              Address = "7890 2nd Ave E",
              City = "Redmond",
              State = "WA",
              Zip = "10999",
              Email = "diliana@example.com",
          }
          );
        }
    }
}
