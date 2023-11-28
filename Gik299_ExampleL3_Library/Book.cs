using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Gik299_ExampleL3_Library
{
    public class Book
    {
       
        //Properties
        public string Title { get; private set; }
        public Author TheAuthor { get;  set; }
        public BookFormat Format { get; private set; }
        public int Pages { get; private set; }
        public int Weight { get; private set; }
        public string Genre { get; private set; }
        public DateTime ReleaseDate { get; private set; }

        //Constructor
        public Book(string bookTitle, Author author, BookFormat bookFormat, int numOfPages, int weight, string genre, DateTime releaseDate)
        {
            Title = bookTitle;
            TheAuthor = author;
            Format = bookFormat;
            Pages = numOfPages;
            Weight = weight;
            Genre = genre;
            ReleaseDate = releaseDate;
        }



        //overriding ToString method "[...]converts an object to its string representation so that it is suitable for display (Microsoft n.d)"
        public override string ToString()
        {
            return $"Title: {Title}" +
                $"\nAuthor: {TheAuthor.FirstName} {TheAuthor.LastName}" +
                $"\nFormat: {Format}" +
                $"\nPages: {Pages}" +
                $"\nWeight: {Weight}" +
                $"\nGenre: {Genre}" +
                $"\nRelease Date: {ReleaseDate:yyyy/MM/dd}"; //formatting the date to only include year, month and day while removing trailing information about the time. What happens to the ouput if you only write ReleaseDate within the brackets? :)
        }
    }
}

//This was perhaps a bit much? Below you will find a clarification of the concepts used above. Don't hesitate to ask me during lab time if you have trouble wrapping your head around this. It is a lot to comprehend.

//What is a property? 
// In C#, a property is a member of a class or struct that provides a flexible way to read, write, or compute the value of a private field.
// It encapsulates a getter method (to retrieve the property value) and optionally a setter method (to modify the property value).
//Properties allow controlled access to fields by exposing them through accessors (getters and setters) while providing a level of abstraction and enabling validation,
//computation, or access control logic within these accessors. By using properties we are enabled to use ENCAPSULATION (when we keep certain fields private while allowing
//controlled access to them and hiding internal implementation details in the class or struct from the user.
//Properties also help us to improve readability by abstracting data access and modification of behavior or validaton without changing what the uses are interacting with.
//And finally, properties help us to restrict or control read and write access to field by implementing customized logic in the getter and setters (we are not doing that in 
//this example, we are only deciding that the user is not allowed to set data to the property other than when creating the object via the constructor).
//Properties are written in PascalCase in C#, in contrast to "common" variables that are written in camelCase. 

//what is a constructor?
//A constructor is a speical member method within a class (or a struct) with the responsibility for initializing instances of that particular class, so in this case
//the constructors job is to create an instance of the Book-class. The constructor is automatically called when we are creating a new object of a particular class or struct 
//by using the keyword "new" (you can see that we are using the new keyword in the Program class when we are creating the book on line 15 in Program.cs)
//If we do not explicitly create a constructor (like we are doing in this case) a default, empty, constructor is automatically created, however, it won't be visible to us
//but in this case it would look like this: public Book() {}
//We use constructors to initialize newly created objects bt setting initial values to its field, properties or performing any other necessary setup. In this case we are
//only using properties and hence, we are only initializing properties in this constructor. 
//The constructor is a special method that ALWAYS has the same name as the class. Constructors are special because they do not have a return type, not even void.
// A class can have multiple constructors if we want to allow the user to pass different parameters with it. In this case we only have one. If we have created 
//a constructor like we have in this class, the default constructor cease to exist, so if we want to have the default constructor as an option, we need to explicitly declare this with public Book() {}


//what about ToString() and why are we using the word override when creating this method?
//The ToString() method is a predefined method that exists in the System.Object class and it is overridden in any derived classes (all classes derive from System.Object, the Book class is not an exception)
//It is overridden in the derived classes because its purpose is to provide a string representation of an object's state.
// If you do not override the ToString method it exists by default and will return the object's type to the caller. You can read more about the ToString method in the link to the documentation below.


/*
REFERENCES
Microsoft (n.d.). Object.ToString Method. Retrieved November 27, 2022, from https://learn.microsoft.com/en-us/dotnet/api/system.object.tostring?view=net-7.0
 */