//main
main();
static void main()
{
    menu();
    string userInput = Console.ReadLine();
    while(userInput!= "3"){
        if (userInput == "1")
        {
            triangleFull();
        }
        else if(userInput == "2")
        {
            trianglePartial();
        }
        else if(userInput =="3"){}
            else
            {
                System.Console.WriteLine("Invalid input");
            }
        menu();
        userInput = Console.ReadLine();
    }
}
static void triangleFull()
{
    Random rnd = new Random();
    int number = rnd.Next(3,10);
    for(int i = 1; i <= number; i++){
        for(int j = 1; j <= i; j++) {
            System.Console.Write("0");
        
        }
        System.Console.WriteLine("");
    }
}
static void trianglePartial()
{
    Random rnd = new Random();
    int number = rnd.Next(3,10);
    for(int i = 1; i <= number; i++){
        for(int j = 1; j <= i; j++) {
            int decomp = rnd.Next(4);
            if(decomp != 1){
                System.Console.Write("0");
            }
        }
        System.Console.WriteLine("");
    }
}
static void menu()
{
    System.Console.WriteLine("1. ");
    System.Console.WriteLine("2. ");
    System.Console.WriteLine("3. Exit");
}