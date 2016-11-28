using contactsManager.Domain;

namespace contactsManager.Web.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<contactsManager.Web.Infrastructure.ContactDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(contactsManager.Web.Infrastructure.ContactDb context)
        {
            context.Contacts.AddOrUpdate( c => c.FirstName,
                new Contact() { FirstName = "Andrea", LastName = "Schisani", PhoneNumber = "085 2343 088", PhotoUrl = "~/Images/photo.jpg" }
                );
        }
    }
}
