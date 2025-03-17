using lab1._2;

Console.WriteLine("Task2");

AmericanTime americanTime = new AmericanTime();
EuropeanTime europeanTime = new EuropeanTime();
americanTime.Print();
europeanTime.Print();
ConcreteDecorator d1 = new ConcreteDecorator(americanTime, " ~Alice~");
ConcreteDecorator d2 = new ConcreteDecorator(d1, " ~Alice~");
ConcreteDecorator d3 = new ConcreteDecorator(europeanTime, " ~Alice~");
d1.Print();
d2.Print();
d3.Print();