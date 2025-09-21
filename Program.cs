namespace laba3
{

   internal class Program
    {

       static void Main(string[] args)
       {
//            var times = enum.getvalues(typeof(timeofday));
//            var heroes = enum.getvalues(typeof(hero));
//            for (int i = 0; i<times.length; i++)
//                {
//                timeofday time = (timeofday)times.getvalue(i);
//                console.writeline($"\nвремя сейчас: {time}");
//                    for (int j = 0; j<heroes.length; j++)
//                    {
//                        hero h = (hero)heroes.getvalue(j);
//                        console.writeline($"{h} - ");
//                        switch (times)
//                        {
//                            case timeofday.утро:
//                                console.writeline(h switch
//                                {
//                                    hero.воин => "делает зарядку с мечом",
//                                    hero.маг => "заваривает зелья",
//                                    hero.вор => "крадётся по базару",
//                                    _ => "ничего не делает"
//                                });
//                                break;
//                        }


//                                    }
//                                }
//                            dayofweek today = dayofweek.friday;
//                            console.writeline(today);

//                TaskPriority priority = TaskPriority.High;
//Console.WriteLine((int)priority);
//DayOfWeek day = DayOfWeek.Saturday;
//switch (day)
//{
//    case DayOfWeek.Saturday:
//    case DayOfWeek.Sunday:
//        Console.WriteLine("Выходной! ");
//                break;
//            default:
//                Console.WriteLine("Будний день.");
//                break;

//        }
//        for (int i = 1; i < 10; i++)
//        {
//            Console.WriteLine(i);
//        }
//        int i = 1;
//        for (; ;)
//        {
//            Console.WriteLine($"i = {i}");
//            i++;
//        }

//        for (int i = 1, j =1; i < 10;i++, j++)
//        {
//            Console.WriteLine($"{i * j}");
//        }

//        int sum = 0;
//        for (int i = 1; i <= 10; i++)
//        {
//            sum += i;
//        }
//        Console.WriteLine($"Сумма: {sum}");

//        int i = 10;
//        do
//        {
//            Console.WriteLine(i);
//            i--;
//        }
//        while (i > 0);
//        int i = 10;
//        while (i > 0)
//        {
//            Console.WriteLine(i);
//            i--;
//        }

//        foreach (char i in "Hello World")
//        {
//            Console.WriteLine(i);
//        }
//        for (int i =0; i < 9; i++)
//        {
//            if (i == 5)
//                break;
//            Console.WriteLine(i);
//        }

//        for (int i = 1; i < 10; i++)
//        {
//            for (int j = 1; j < 10; j++)
//            {
//                Console.WriteLine($"{i * j} \t");


//        //    }
//        Console.WriteLine();
//}
            //string? input;
            //Console.WriteLine("Добро пожаловатьт в Эхо-чат! Напиши что нибудь (или 'выход' для завершения): ");
            //while (true)
            //{
            //    Console.WriteLine("> ");
            //    input = Console.ReadLine();
            //    if (input == null)
            //        continue;
            //    if (input.ToLower() == "выход")
            //    {
            //        Console.WriteLine("До встречи!");
            //        break;
            //    }
            //    Console.WriteLine($"Вы сказали: {input}");

            //}

            //Задание 1
            //                var TrafficLights = Enum.GetValues(typeof(TrafficLight));
            //foreach (int lights in TrafficLights)
            //{
            //    Console.Write("Введите цифру от 0 до 2 где (0 - Red), (1 - Yellow), (2 - Green) ");
            //    int light = int.Parse(Console.ReadLine());
            //    if (light == 0)
            //    {
            //        Console.WriteLine($"Следующий цвет: {TrafficLight.Yellow}");
            //    }
            //    if (light == 1)
            //    {
            //        Console.WriteLine($"Следующий цвет: {TrafficLight.Green}");
            //    }
            //    if (light == 2)
            //    {
            //        Console.WriteLine($"Следующий цвет: {TrafficLight.Red}");
            //    }
            //    у


            //                }

            //Задание 2
            //                var order = Enum.GetValues(typeof(OrderStatus));
            //for (int i = 0; i < order.Length; i++)
            //{
            //    {
            //        OrderStatus status = (OrderStatus)order.GetValue(i);

            //        string? orderNow = Console.ReadLine();
            //        switch (orderNow)
            //        {
            //            case "New" or "Processing":
            //                Console.WriteLine("Вы можете сейчас отменить заказ");
            //                continue;
            //            default:
            //                Console.WriteLine("Вы не можете вернуть заказ");
            //                break;
            //        }

            //    }


            //}
            //Задание 3
            //                for (int i = 10; i > 0; i--)
            //                {
            //    Console.WriteLine(i);
            //}

            //Задание 4
            //                for(int i = 1; i <= 10; i++)
            //                {
            //    Console.WriteLine($"5 * {i} = {5 * i}");
            //}

            //Задание 5
            //                for(int i = 0; i < 10; i++)
            //                {
            //    Console.WriteLine("Запомни: всего одна ошибка и ты ошибся");
            //}

            //Задание 6
            //                int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine($"Квадрат числа {i} равен {i * i}");
            //}

            //Задание 7
            //                string? str = Console.ReadLine();
            //int? number = int.Parse(Console.ReadLine());
            //for (int i = 0; i < number; i++) { Console.WriteLine($"{str}"); }

            //Задание 8
            //                string answer = "Yes";
            //for (int i = 1; i <= 10; i++)
            //{
            //    int k = int.Parse(Console.ReadLine());
            //    if (k % 2 != 0)
            //    {
            //        answer = "No";
            //    }

            //}
            //Console.WriteLine(answer);

            //Задание 9
            //                string shoot = "";
            //Console.WriteLine("Доброе пожаловать на стрельбище!");
            //Console.WriteLine("Введите 'Стоп', что бы завершить стрельбу.");
            //Console.WriteLine("Нажмите Enter для выстрела: ");
            //for (; ; )
            //{

            //    string s = Console.ReadLine();

            //    if (s == "Стоп")
            //    {
            //        break;
            //    }
            //    else if (s == shoot)
            //    {
            //        Console.WriteLine("Выстрел совершен.");
            //        Console.WriteLine("Нажмите Enter для выстрела: ");

            //    }
            //    else
            //    {
            //        continue;
            //    }
            //}
            }
        }
    }
//enum OrderStatus
//{
//    New,
//    Processing,
//    Shipped,
//    Delivered
//}


//enum TrafficLight
//{
//    Red,
//    Yellow,
//    Green
//}
//enum DayOfWeek
//{
//    Monday,
//    Tuesday,
//    Wednesday,
//    Thursday,
//    Friday,
//    Saturday,
//    Sunday
//}

//enum TaskPriority
//{
//    Low = 1,
//    Medium = 2,
//    High = 3
//}

//enum Hero
//{
//    воин, маг, вор
//}
//enum TimeOfDay
//{
//    Утро, День, Вечер, Ночь
//}