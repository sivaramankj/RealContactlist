using System;
using System.Data.Entity.Validation;
using Data.Domain;

namespace DAL.Migrations
{
    using System.Data.Entity.Migrations;
    using WebMatrix.WebData;
    public class Configuration : DbMigrationsConfiguration<DAL.ContactListContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }


        protected override void Seed(DAL.ContactListContext context)
        {

            try
            {
                WebSecurity.InitializeDatabaseConnection("DefaultConnection", "UserProfile", "UserId", "UserName",
                    autoCreateTables: true);

                context.Contacts.AddOrUpdate(x => x.ContactId,
                    new Contact()
                    {
                        ContactId = 1,
                        FirstName = "Sh. N. Krishnamoorty",
                        LastName = "RajaRam",
                        Email = "roc.hyderabad@mca.gov.in",
                        Phone = "9776545768"
                        ,
                        Address = new Address()
                        {
                            Street = "2ND Floor, Corporate Bhawan,GSI Post"
                            ,
                            City = "Hyderabad "
                            ,
                            State = "ANDHRA PRADESH",
                            Zip = "500068"
                        }
                    }
                );
                context.Contacts.AddOrUpdate(x => x.ContactId,
                    new Contact()
                    {
                        ContactId = 2,
                        FirstName = "Sh. Lakshmi Prasad K",
                        LastName = "Sukla",
                        Email = "roc.hyderabad@mca.gov.in",
                        Phone = "9663576645",
                        Address = new Address()
                        {
                            Street = "Morello Building,Ground Floor"
                            ,
                            City = "Shillong",
                            State = "ASSAM"
                            ,
                            Zip = "793001"
                        }
                    }
                );
                context.Contacts.AddOrUpdate(x => x.ContactId,
                    new Contact()
                    {
                        ContactId = 3,
                        FirstName = "Mr.S.Sivaraman",
                        LastName = "Soundararajan",
                        Email = "sivaramankj@gmail.com",
                        Phone = "9976302702"
                        ,
                        Address = new Address()
                        {
                            Street = "E7,Giri Apartments"
                            ,
                            City = "Chennai "
                            ,
                            State = "TAMIL NADU"
                            ,
                            Zip = "500068"
                        }
                    }
                );
                context.Contacts.AddOrUpdate(x => x.ContactId,
                    new Contact()
                    {
                        ContactId = 4,
                        FirstName = "Mr.G.Balaji",
                        LastName = "Govindaraj",
                        Email = "leninbalaji@yahoo.com",
                        Phone = "9443474426"
                        ,
                        Address = new Address()
                        {
                            Street = "1/455,MGR Apartments,Porur"
                            ,
                            City = "Chennai "
                            ,
                            State = "TAMIL NADU"
                            ,
                            Zip = "600092"
                        }
                    }
                );
                context.Contacts.AddOrUpdate(x => x.ContactId,
                    new Contact()
                    {
                        ContactId = 5,
                        FirstName = "Mr.M.Kannan",
                        LastName = "Subramanian",
                        Email = "kannan@yahoo.com",
                        Phone = "9886756380"
                        ,
                        Address = new Address()
                        {
                            Street = "566,Vallalar Nagar, Arasu Apartments"
                            ,
                            City = "Coimbatore"
                            ,
                            State = "TAMIL NADU"
                            ,
                            Zip = "600022"
                        }
                    }
                );
                context.SaveChanges();
            }
           
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            // context.SaveChanges();
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
