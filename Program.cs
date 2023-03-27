namespace DatastructureProblems
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Day6 Datastructure PracticeProblem");
            Console.WriteLine("Select any one option for \n 1. Generic Custom Linklist");
            int operation = Convert.ToInt32(Console.ReadLine());
            switch (operation)
            {
                case 1:
                    GenericClassCustomLinkedlist<int> integerLinkList = new GenericClassCustomLinkedlist<int>();
                    integerLinkList.AddLast(10);
                    integerLinkList.AddLast(20);
                    integerLinkList.Addfirst(30);
                    integerLinkList.Addfirst(40);
                   // integerLinkList.DisplayList();

                    GenericClassCustomLinkedlist<string> stringLinkList = new GenericClassCustomLinkedlist<string>();
                    Console.WriteLine();
                    stringLinkList.AddLast("mahesh");
                    stringLinkList.Addfirst("Gangurde");
                    Console.WriteLine("Before Removing Elements");
                    stringLinkList.DisplayList();
                    Console.WriteLine("After removing Elements");
                    stringLinkList.Remove("Gangurde");
                    stringLinkList.DisplayList();
                    break;
                default:
                    Console.WriteLine("Please Enter Valid Option");
                    break;
            }
        }
    }

}