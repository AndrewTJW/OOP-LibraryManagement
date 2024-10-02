using System.Linq.Expressions;

namespace OOP_Revise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person CreatedPerson = new Person();
            Author CreatedBookAuthor = new Author();
            Book CreatedBook = new Book();
            Library CreatedLibrary = new Library();
            Member CreatedMember = new Member();
            ListMember CreatedListMember = new ListMember();

            char user_input;
            string book_title;
            int book_id;
            string author_name;
            string author_country;

            int age;
            string gender;
            int student_id;
            string student_name;
            string member_id;


            Console.WriteLine("==========================");
            Console.WriteLine("LIBRARY MANAGEMENT SYSTEM");
            Console.WriteLine("==========================\n");

            while (true)
            {
                Console.WriteLine("\n1. Add book");
                Console.WriteLine("2. Remove Book");
                Console.WriteLine("3. Display Book Info");
                Console.WriteLine("4. Add Member");
                Console.WriteLine("5. View Member List");
                Console.WriteLine("6. Remove Member");
                Console.WriteLine("7. Quit\n");

                Console.WriteLine("Choose your option: ");

                user_input = Convert.ToChar(Console.ReadLine());
                Option User_Option = new Option(user_input);

                switch(User_Option.getUserOption())
                {
                    case '1':
                        Console.WriteLine("Please enter the book title: ");
                        book_title = Console.ReadLine();
                        Console.WriteLine("Please enter the book ID: ");
                        book_id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter the book author: ");
                        author_name = Console.ReadLine();
                        Console.WriteLine("Please enter the book author's country: ");
                        author_country = Console.ReadLine();

                        Author newCreatedBookAuthor = new Author(author_name, author_country);
                        Book newCreatedBook = new Book(book_id, book_title, newCreatedBookAuthor);

                        CreatedLibrary.AddBooks(newCreatedBook);

                        Console.WriteLine("The book you added is {0} {1} and it is written by {2} from {3}", newCreatedBook.book_title, newCreatedBook.book_id, newCreatedBook.book_author.author_name, newCreatedBook.book_author.author_country);
                        break;
                    case '2':
                        Console.WriteLine("Please enter the ID of the book that you want to remove: ");
                        book_id = Convert.ToInt32(Console.ReadLine());
                        Book BookToRemove = CreatedLibrary.findBookID(book_id);
                        if (BookToRemove != null)
                        {
                            CreatedLibrary.RemoveBook(BookToRemove);
                            Console.WriteLine("{0} has been removed", BookToRemove.book_title);
                        }
                        else
                        {
                            Console.WriteLine("No such book");
                        }
                        break;
                    case '3':
                        CreatedLibrary.DisplayBookTitle();
                        break;
                    case '4':
                        Console.WriteLine("Member age: ");
                        age = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Member gender: ");
                        gender = Console.ReadLine();
                        Console.WriteLine("Member name: ");
                        student_name = Console.ReadLine();
                        Console.WriteLine("Member Student ID: ");
                        student_id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Member ID: ");
                        member_id = Console.ReadLine();

                        Member newMember = new Member(member_id, student_name, student_id, age, gender);
                        CreatedListMember.AddMemberToList(newMember);
                        Console.WriteLine("{0} is added to member list.", newMember.student_name);
                        break;
                    case '5':
                        CreatedListMember.DisplayMemberList();
                        break;
                    case '6':
                        Console.WriteLine("Enter the member ID of the member you want to remove: ");
                        member_id = Console.ReadLine();
                        Member MemberToBeRemoved = CreatedListMember.findMemberById(member_id);
                        if (MemberToBeRemoved == null)
                        {
                            Console.WriteLine("No such member");
                        }
                        else
                        {
                            CreatedListMember.RemoveMemberFromList(MemberToBeRemoved);
                            Console.WriteLine("{0} has been removed from the member list.", MemberToBeRemoved.student_name);
                        }
                        break;
                    case '7':
                        Console.WriteLine("Quitting Application...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter a valid option!");
                        break;
                }
            }
        }
    }
}
