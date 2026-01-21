using LibraryApp.Models;
using LibraryApp.Services;
using LibraryApp.Data;
using LibraryApp.People;
using LibraryApp.Utils;

LibraryService library = new LibraryService();

if (library.Items.Count == 0)
{
    int id = 1;

    library.Items.Add(new Book(id++, "Wonder of Life", "J. Pan", 2000, 320));
    library.Items.Add(new Book(id++, "Silent River", "A. Moore", 1998, 280));
    library.Items.Add(new Book(id++, "Beyond the Stars", "L. Carter", 2005, 410));
    library.Items.Add(new Book(id++, "Hidden Truth", "M. Collins", 2002, 350));
    library.Items.Add(new Book(id++, "Path of Wisdom", "R. Stone", 1995, 290));
    library.Items.Add(new Book(id++, "Echoes of Time", "S. Turner", 2008, 360));
    library.Items.Add(new Book(id++, "Winds of Change", "C. Adams", 2003, 330));
    library.Items.Add(new Book(id++, "The Last Horizon", "E. Brown", 2010, 470));
    library.Items.Add(new Book(id++, "Mind and Matter", "D. Harris", 1999, 300));
    library.Items.Add(new Book(id++, "The Golden Era", "F. Nelson", 2001, 390));

    library.Items.Add(new Book(id++, "Shadows of the Past", "K. Miller", 1997, 340));
    library.Items.Add(new Book(id++, "Rise of Empires", "T. Walker", 2006, 520));
    library.Items.Add(new Book(id++, "Fragments of Hope", "J. Scott", 2004, 310));
    library.Items.Add(new Book(id++, "Broken Silence", "A. Reed", 2011, 360));
    library.Items.Add(new Book(id++, "Secrets of the Mind", "P. Young", 1996, 280));
    library.Items.Add(new Book(id++, "Light in the Dark", "H. King", 2009, 400));
    library.Items.Add(new Book(id++, "Road to Destiny", "B. Allen", 2013, 450));
    library.Items.Add(new Book(id++, "Whispers of Nature", "L. Green", 2007, 295));
    library.Items.Add(new Book(id++, "The Final Chapter", "R. Baker", 2015, 480));
    library.Items.Add(new Book(id++, "Dreams Unfolded", "M. Perez", 2012, 330));

    library.Items.Add(new Book(id++, "Power of Thought", "N. Evans", 1994, 260));
    library.Items.Add(new Book(id++, "Edge of Reality", "S. Cox", 2008, 390));
    library.Items.Add(new Book(id++, "The Forgotten Path", "D. Rogers", 2001, 310));
    library.Items.Add(new Book(id++, "Voices Within", "K. Stewart", 2005, 350));
    library.Items.Add(new Book(id++, "Chains of Time", "W. Morris", 1999, 300));
    library.Items.Add(new Book(id++, "The Silent War", "A. Cook", 2014, 470));
    library.Items.Add(new Book(id++, "Seeds of Change", "G. Bell", 2003, 320));
    library.Items.Add(new Book(id++, "Infinite Journey", "T. Murphy", 2016, 510));
    library.Items.Add(new Book(id++, "Reflections", "J. Bailey", 1998, 280));
    library.Items.Add(new Book(id++, "Awakening the Soul", "E. Rivera", 2007, 340));

    library.Items.Add(new Book(id++, "Crossing Borders", "L. Cooper", 2011, 420));
    library.Items.Add(new Book(id++, "The Human Code", "M. Richardson", 2018, 460));
    library.Items.Add(new Book(id++, "Fading Memories", "C. Howard", 2000, 310));
    library.Items.Add(new Book(id++, "Circle of Life", "R. Ward", 1993, 270));
    library.Items.Add(new Book(id++, "Truth and Illusion", "S. Torres", 2006, 360));
    library.Items.Add(new Book(id++, "The Long Road Home", "P. Peterson", 2010, 400));
    library.Items.Add(new Book(id++, "Moments in Time", "D. Gray", 2002, 290));
    library.Items.Add(new Book(id++, "Beyond Reason", "A. Ramirez", 2017, 450));
    library.Items.Add(new Book(id++, "Lost and Found", "J. James", 2004, 320));
    library.Items.Add(new Book(id++, "The Inner Voice", "K. Watson", 1996, 280));

    library.Items.Add(new Book(id++, "Legacy of Fire", "M. Brooks", 2019, 520));
    library.Items.Add(new Book(id++, "Between Two Worlds", "L. Kelly", 2008, 370));
    library.Items.Add(new Book(id++, "Breaking Barriers", "C. Sanders", 2015, 430));
    library.Items.Add(new Book(id++, "The Thinking Mind", "R. Price", 1997, 260));
    library.Items.Add(new Book(id++, "Steps to Freedom", "T. Bennett", 2003, 310));
    library.Items.Add(new Book(id++, "Mirror of Truth", "E. Wood", 2009, 350));
    library.Items.Add(new Book(id++, "Unseen Forces", "H. Barnes", 2012, 390));
    library.Items.Add(new Book(id++, "The Open Sky", "D. Ross", 2001, 300));
    library.Items.Add(new Book(id++, "Power and Purpose", "J. Henderson", 2016, 470));
    library.Items.Add(new Book(id++, "Lessons of History", "F. Coleman", 1995, 280));

    library.Items.Add(new Book(id++, "The Living Earth", "S. Jenkins", 2010, 420));
    library.Items.Add(new Book(id++, "Mind Over Matter", "B. Perry", 2004, 330));
    library.Items.Add(new Book(id++, "Journey to the Core", "A. Powell", 2018, 490));
    library.Items.Add(new Book(id++, "Threads of Destiny", "K. Long", 2007, 360));
    library.Items.Add(new Book(id++, "The Great Divide", "R. Patterson", 2011, 440));
    library.Items.Add(new Book(id++, "Wisdom of Ages", "M. Hughes", 1992, 260));
    library.Items.Add(new Book(id++, "Beyond the Surface", "C. Flores", 2005, 320));
    library.Items.Add(new Book(id++, "Shaping the Future", "T. Washington", 2019, 510));
    library.Items.Add(new Book(id++, "The Silent Mind", "L. Butler", 1999, 290));
    library.Items.Add(new Book(id++, "Purpose Driven Life", "D. Simmons", 2008, 380));

    DataStore.Save(library.Items);
}

int page = 1;
 while (true)
{
    Console.Clear();
    Console.WriteLine("===== LIBRARY MANAGEMENT SYSTEM =====");
    Console.WriteLine("1. View Items");
    Console.WriteLine("2. Borrow Item");
    Console.WriteLine("3. Return Item");
    Console.WriteLine("4. Next Page");
    Console.WriteLine("5. Previous Page");
    Console.WriteLine("6. Exit");
    Console.Write("Choose an option: ");

    try
    {
        string? input = Console.ReadLine();

        if (!int.TryParse(input, out int choice))
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            Console.ReadKey();
            continue;
        }


        switch (choice)
        {
            case 1:
                Console.Clear();
                Pagination.ShowItems(library.Items, page);
                Console.WriteLine($"\n--- Page {page} ---");
                Console.ReadKey();
                break;

            case 2:
                Console.Write("Enter Item ID to borrow: ");
                int borrowId = int.Parse(Console.ReadLine());

                Member member = new StudentMember(1, "Default Student");
                library.BorrowItem(borrowId, member);

                DataStore.Save(library.Items);

                Console.WriteLine("Item borrowed successfully.");
                Console.ReadKey();
                break;

            case 3:
                Console.Write("Enter Item ID to return: ");
                int returnId = int.Parse(Console.ReadLine());

                library.ReturnItem(returnId);
                DataStore.Save(library.Items);

                Console.WriteLine("Item returned successfully.");
                Console.ReadKey();
                break;

            case 4:
                page++;
                break;

            case 5:
                if (page > 1)
                    page--;
                break;

            case 6:
                Console.WriteLine("Goodbye!");
                return;

            default:
                Console.WriteLine("Invalid option. Try again.");
                Console.ReadKey();
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
        Console.ReadKey();
    }
}