
    List<string> todoList = new List<string>();
    bool isRunning = true;

    do
    {
        Console.WriteLine("Hello!");
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("[V]iew list");
        Console.WriteLine("[A]dd a task");
        Console.WriteLine("[R]emove task");
        Console.WriteLine("[E]xit");
    
        string userInput = Console.ReadLine().Trim().ToLower();
    

        switch (userInput)
        {
            case "v" :
                viewList(todoList);
                break;
            case "a" :
                addTask(todoList);
                break;
            case "r" :
                Console.WriteLine("Item removed");
                break;
            case "e" :
                Console.WriteLine("Goodbye");
                isRunning = false;
                break;
            default: Console.WriteLine("invalid input");
                break;
        }
    }while(isRunning);

    void viewList(List<string> list)
    {
        Console.WriteLine("Todo List tasks: ");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }

    void addTask(List<string> list)
    {
        Console.Write("Add task to list: ");
        string task = Console.ReadLine().Trim().ToLower();
        list.Add(task);
        Console.WriteLine($"{task} added to list");
    }