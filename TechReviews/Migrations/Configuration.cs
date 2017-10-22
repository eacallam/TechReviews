namespace TechReviews.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TechReviews.Models.TechReviewsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "TechReviews.Models.TechReviewsContext";
        }

        protected override void Seed(TechReviews.Models.TechReviewsContext context)
        {
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
            context.Categories.AddOrUpdate(
            p => p.ID,
            new Category { ID = 1, Name = "Restaurants" },
            new Category { ID = 2, Name = "Entertainment" },
            new Category { ID = 3, Name = "Retail" }
            );

           context.Reviews.AddOrUpdate(
           p => p.ID,
           new Review { ID = 1, Author = "John Smith", Title = "Kat's Putt-Putt", CategoryID = 2, DateVisited = DateTime.Parse("2017-08-02"), DateCreated = DateTime.Parse("2017-10-22"), Rating = 5, Content = "Praesent sed malesuada magna, sed ultrices velit. Quisque elementum tellus id felis iaculis, non semper quam ultrices. Sed ipsum nulla, ultricies sit amet magna id, viverra ultricies ex. Fusce scelerisque, justo a dapibus ultricies, purus lacus posuere mauris, et molestie tellus felis ut leo. Nulla metus enim, blandit eu lacinia a, varius id quam. Cras ac mauris id lectus pharetra efficitur id id mauris. Ut venenatis, lacus vitae congue pellentesque, elit urna maximus velit, ut pretium sem sapien nec elit. Donec laoreet luctus libero. Integer ut libero at urna laoreet ornare. Proin sodales tellus vel metus vulputate maximus. Vivamus aliquam tincidunt rutrum. Aliquam a commodo ipsum." },
           new Review { ID = 2, Author = "Joyce Sample", Title = "Rick's Steakhouse", CategoryID = 1, DateVisited = DateTime.Parse("2016-02-01"), DateCreated = DateTime.Parse("2017-10-22"), Rating = 4, Content = "Praesent sed malesuada magna, sed ultrices velit. Quisque elementum tellus id felis iaculis, non semper quam ultrices. Sed ipsum nulla, ultricies sit amet magna id, viverra ultricies ex. Fusce scelerisque, justo a dapibus ultricies, purus lacus posuere mauris, et molestie tellus felis ut leo. Nulla metus enim, blandit eu lacinia a, varius id quam. Cras ac mauris id lectus pharetra efficitur id id mauris. Ut venenatis, lacus vitae congue pellentesque, elit urna maximus velit, ut pretium sem sapien nec elit. Donec laoreet luctus libero. Integer ut libero at urna laoreet ornare. Proin sodales tellus vel metus vulputate maximus. Vivamus aliquam tincidunt rutrum. Aliquam a commodo ipsum." },
           new Review { ID = 3, Author = "Melanie Thomas", Title = "The Toy Zone", CategoryID = 3, DateVisited = DateTime.Parse("2011-11-01"), DateCreated = DateTime.Parse("2017-10-22"), Rating = 1, Content = "Praesent sed malesuada magna, sed ultrices velit. Quisque elementum tellus id felis iaculis, non semper quam ultrices. Sed ipsum nulla, ultricies sit amet magna id, viverra ultricies ex. Fusce scelerisque, justo a dapibus ultricies, purus lacus posuere mauris, et molestie tellus felis ut leo. Nulla metus enim, blandit eu lacinia a, varius id quam. Cras ac mauris id lectus pharetra efficitur id id mauris. Ut venenatis, lacus vitae congue pellentesque, elit urna maximus velit, ut pretium sem sapien nec elit. Donec laoreet luctus libero. Integer ut libero at urna laoreet ornare. Proin sodales tellus vel metus vulputate maximus. Vivamus aliquam tincidunt rutrum. Aliquam a commodo ipsum." },
           new Review { ID = 4, Author = "Shayna Reilly", Title = "Bowling Supercenter", CategoryID = 2, DateVisited = DateTime.Parse("2000-08-23"), DateCreated = DateTime.Parse("2017-10-22"), Rating = 2, Content = "Praesent sed malesuada magna, sed ultrices velit. Quisque elementum tellus id felis iaculis, non semper quam ultrices. Sed ipsum nulla, ultricies sit amet magna id, viverra ultricies ex. Fusce scelerisque, justo a dapibus ultricies, purus lacus posuere mauris, et molestie tellus felis ut leo. Nulla metus enim, blandit eu lacinia a, varius id quam. Cras ac mauris id lectus pharetra efficitur id id mauris. Ut venenatis, lacus vitae congue pellentesque, elit urna maximus velit, ut pretium sem sapien nec elit. Donec laoreet luctus libero. Integer ut libero at urna laoreet ornare. Proin sodales tellus vel metus vulputate maximus. Vivamus aliquam tincidunt rutrum. Aliquam a commodo ipsum." },
           new Review { ID = 5, Author = "Kris Thompson", Title = "Crazy Hot Dogs", CategoryID = 1, DateVisited = DateTime.Parse("2012-08-30"), DateCreated = DateTime.Parse("2017-10-22"), Rating = 5, Content = "Praesent sed malesuada magna, sed ultrices velit. Quisque elementum tellus id felis iaculis, non semper quam ultrices. Sed ipsum nulla, ultricies sit amet magna id, viverra ultricies ex. Fusce scelerisque, justo a dapibus ultricies, purus lacus posuere mauris, et molestie tellus felis ut leo. Nulla metus enim, blandit eu lacinia a, varius id quam. Cras ac mauris id lectus pharetra efficitur id id mauris. Ut venenatis, lacus vitae congue pellentesque, elit urna maximus velit, ut pretium sem sapien nec elit. Donec laoreet luctus libero. Integer ut libero at urna laoreet ornare. Proin sodales tellus vel metus vulputate maximus. Vivamus aliquam tincidunt rutrum. Aliquam a commodo ipsum." }
             );
        }



        
    }
}
