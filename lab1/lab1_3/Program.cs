using lab1_3;

Console.WriteLine("Task3");

Tree First = new Tree(1);
Tree Second = new Tree(2);
Tree sf = new Tree(21);         //Первый потомок Second
Tree ss = new Tree(22);         //Второй потомок Second
Tree Third = new Tree(3);

First.AddKid(Second);
First.AddKid(Third);
Second.AddKid(sf);
Second.AddKid(ss);
First.Print();
Console.WriteLine();
Second.Print();
Console.WriteLine();
Third.Print();

