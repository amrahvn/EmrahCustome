

using EmrahCustome;

class MyClass
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class Program
{
    public void Main(string[] args)
    {
        CustomList<MyClass> myList = new CustomList<MyClass>();

        myList.Add(new MyClass { Id = 1, Name = "Emrah" });
        myList.Add(new MyClass { Id = 2, Name = "Emir" });
        myList.Add(new MyClass { Id = 3, Name = "RAh" });

        MyClass result = myList.Find(x => x.Id == 1);

        if (result != null)
        {
            Console.WriteLine("Name:" + result.Name);
        }
        else
        {
            Console.WriteLine("Object not found");
        }
    }


}