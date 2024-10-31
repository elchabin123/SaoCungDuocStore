using SaoCungDuocStore.Models;

namespace SaoCungDuocStore.Data
{
    public class SaoCungDuocDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<SaoCungDuocStoreDbContext>();

                context.Database.EnsureCreated();

                //BooksBranches
                if (!context.BookBranches.Any()) {
                    context.BookBranches.AddRange(new List<BookBranch>()
                    {
                        new BookBranch()
                        {
                            Name = "Cinema 1",
                           
                            Description = "This is the description of the first cinema"
                        },
                        new BookBranch()
                        {
                            Name = "Cinema 2",
                            
                            Description = "This is the description of the first cinema"
                        },
                        new BookBranch()
                        {
                            Name = "Cinema 3",
                           
                            Description = "This is the description of the first cinema"
                        },
                        new BookBranch()
                        {
                            Name = "Cinema 4",
                            
                            Description = "This is the description of the first cinema"
                        },
                        new BookBranch()
                        {
                            Name = "Cinema 5",
                            
                            Description = "This is the description of the first cinema"
                        },
                    }
                    );
                    context.SaveChanges();
                }
                //Authors
                if (!context.Author.Any())
                {
                    context.Author.AddRange(new List<Author>()
                    {
                        new Author()
                        {
                            FullName = "Actor 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg"

                        },
                        new Author()
                        {
                            FullName = "Actor 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Author()
                        {
                            FullName = "Actor 3",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new Author()
                        {
                            FullName = "Actor 4",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new Author()
                        {
                            FullName = "Actor 5",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        }
                    }
                    );
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Producer 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"

                        },
                        new Producer()
                        {
                            FullName = "Producer 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 3",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 4",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 5",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-5.jpeg"
                        }
                    }
                    );
                    context.SaveChanges();
                }
                //Books
                if (!context.Books.Any())
                {
                    context.Books.AddRange(new List<Books>()
                    {
                      new Books()
                        {
                            Name = "Life",
                            Description = "This is the Life movie description",
                            Price = 39.50,
                            Image = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            BookBranchId = 3,
                            ProducerId = 3,
                            BookCatagory = Enums.BookCatagory.Documentary
                        },
                        new Books()
                        {
                            Name = "The Shawshank Redemption",
                            Description = "This is the Shawshank Redemption description",
                            Price = 29.50,
                            Image = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            BookBranchId = 1,
                            ProducerId = 1,
                            BookCatagory = Enums.BookCatagory.Horror
                        },
                        new Books()
                        {
                            Name = "Ghost",
                            Description = "This is the Ghost movie description",
                            Price = 39.50,
                            Image = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            BookBranchId = 4,
                            ProducerId = 4,
                            BookCatagory = Enums.BookCatagory.Horror
                        },
                        new Books()
                        {
                            Name = "Race",
                            Description = "This is the Race movie description",
                            Price = 39.50,
                            Image = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            BookBranchId = 1,
                            ProducerId = 2,
                            BookCatagory = Enums.BookCatagory.Documentary
                        },
                        new Books()
                        {
                            Name = "Scoob",
                            Description = "This is the Scoob movie description",
                            Price = 39.50,
                            Image = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            BookBranchId = 1,
                            ProducerId = 3,
                           BookCatagory = Enums.BookCatagory.Cartoon
                        },
                        new Books()
                        {
                            Name = "Cold Soles",
                            Description = "This is the Cold Soles movie description",
                            Price = 39.50,
                            Image = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            BookBranchId = 1,
                            ProducerId = 5,
                            BookCatagory = Enums.BookCatagory.Drama
                        }

                    }
                    );
                    context.SaveChanges();
                }
                //Authors & Boooks
                if (!context.Authors_Books.Any())
                {
                    context.Authors_Books.AddRange(new List<Author_Book>()
                    {
                        new Author_Book()
                        {
                            AuthorId = 1,
                            BookId = 1
                        },
                        new Author_Book()
                        {
                            AuthorId = 3,
                            BookId = 1
                        },

                         new Author_Book()
                        {
                            AuthorId = 1,
                            BookId = 2
                        },
                         new Author_Book()
                        {
                            AuthorId = 4,
                            BookId = 2
                        },

                        new Author_Book()
                        {
                            AuthorId = 1,
                            BookId = 3
                        },
                        new Author_Book()
                        {
                            AuthorId = 2,
                            BookId = 3
                        },
                        new Author_Book()
                        {
                            AuthorId = 5,
                            BookId = 3
                        },


                        new Author_Book()
                        {
                            AuthorId = 2,
                            BookId = 4
                        },
                        new Author_Book()
                        {
                            AuthorId = 3,
                            BookId = 4
                        },
                        new Author_Book()
                        {
                            AuthorId = 4,
                            BookId = 4
                        },


                        new Author_Book()
                        {
                            AuthorId = 2,
                            BookId = 5
                        },
                        new Author_Book()
                        {
                            AuthorId = 3,
                            BookId = 5
                        },
                        new Author_Book()
                        {
                            AuthorId = 4,
                            BookId = 5
                        },
                        new Author_Book()
                        {
                            AuthorId = 5,
                            BookId = 5
                        },


                        new Author_Book()
                        {
                            AuthorId = 3,
                            BookId = 6
                        },
                        new Author_Book()
                        {
                            AuthorId = 4,
                            BookId = 6
                        },
                        new Author_Book()
                        {
                            AuthorId = 5,
                            BookId = 6
                        },
                    }
                    );
                    context.SaveChanges();
                }
            }
        }
    }
}
