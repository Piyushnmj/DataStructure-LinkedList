namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkedList");

            LinkedList objLinkedList = new LinkedList();
            objLinkedList.Add(56);
            objLinkedList.Add(36);
            objLinkedList.Add(40);
            objLinkedList.Add(70);
            objLinkedList.Display();
            objLinkedList.sortList();
            objLinkedList.Display();


            Console.ReadLine();
        }
    }
}