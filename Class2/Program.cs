using System;

namespace Class2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 Задание:
            Person person1 = new Person();
            person1.Name = "Александр";
            person1.age = 26;
            person1.weight = 72;
            Person person2 = new Person();
            person2.Name = "Михаил";
            person2.age = 25;
            person2.weight = 64;
            string weightminimal = person1.weight < person2.weight ? person1.Name : person2.Name;
            Console.WriteLine(weightminimal);
            string ageminimal = person2.age < person1.age? person1.Name : person2.Name;
            Console.WriteLine(ageminimal);

            // 2 Задание:
            const int nul = 0;
            const int hour = 24;
            const int minute = 60;
            const int second = 60;
            Time time1 = new Time();
            time1.hour = 10;
            time1.minute = 68;
            time1.second = 38;
            bool answer = time1.hour > nul && time1.minute > nul && time1.second > nul && time1.hour < hour && time1.minute < minute && time1.second < second ? true : false;
            Console.WriteLine(answer);

            // 3 Задание:
            MessageStatus message0 = MessageStatus.отправлено;
            MessageStatus message1 = MessageStatus.доставлено;
            MessageStatus message2 = MessageStatus.прочитано;
            Console.WriteLine($"Сообщение {message0}");
            Console.WriteLine($"Сообщение {message1}");
            Console.WriteLine($"Сообщение {message2}");

            // 4 Задание:
            Song song1 = new Song();
            song1.executor = "11111";
            song1.title = "11111";
            song1.duration =192;
            const int minet1 = 60;
            int timesong0 = song1.duration / minet1;
            int newtimesong0 = song1.duration - timesong0 * minet1;
            Song song2 = new Song();
            song2.executor = "22222";
            song2.title = "22222";
            song2.duration = 320;
            int timesong1 = song2.duration / minet1;
            int newtimesong1 = song2.duration - timesong1 * minet1;
            string minimalduration = song1.duration < song2.duration ? $"{song1.executor} - {song1.title} {timesong0}:{newtimesong0}" : $"{song2.executor} - {song2.title} {timesong1}:{newtimesong1}";
            Console.WriteLine(minimalduration);

            //5 Задание
            Point point1 = new Point();
            point1.x =1;
            point1.y =6;
            Point point2 = point1;
            point2.x =8;
            point2.y =4;
            double length = Math.Sqrt(((point2.x- point1.x)*(point2.x - point1.x))+ ((point2.y - point1.y) * (point2.y - point1.y)));
            Console.WriteLine(length);

            //6 Задание
            AccessType available0 = AccessType.создание;
            AccessType available1 = AccessType.чтение;
            AccessType available2 = AccessType.обновление;
            AccessType available3 = AccessType.удаление;
            Console.WriteLine($"Доступно {available0}");
            Console.WriteLine($"Доступно {available1}");
            Console.WriteLine($"Доступно {available2}");
            Console.WriteLine($"Доступно {available3}");

            //7 Задание
            Post post1 = new Post();
            post1.author = "Липинский";
            post1.amount = 10;
            post1.text = "Обучающее пособие";
            Post post2 = new Post();
            post2.author = "Аркин";
            post2.amount = 8;
            post2.text = "Проектирование моделей";
            string amountLike = post1.amount> post2.amount? post1.author: post2.author;
            Console.WriteLine(amountLike);
            string textMinLike = post1.amount > post2.amount ? post2.text : post1.text;
            Console.WriteLine(textMinLike);

            // 8 Задание
            Date date1 = new Date();
            date1.day =28;
            date1.month =9;
            date1.year =2022;
            string month = "0";
            string month80 = date1.month < 10 ? $"{date1.day}.{month}{date1.month}.{date1.year}" : $"{date1.day}.{date1.month}.{date1.year}";
            Console.WriteLine(month80);

            //9 Задание
            UnitsType unitsType0 = UnitsType.килограммы;
            UnitsType unitsType1 = UnitsType.литры;
            UnitsType unitsType2 = UnitsType.количество;
            int meaning = 5;

            Console.WriteLine($"{meaning} {unitsType0}");
            Console.WriteLine($"{meaning} {unitsType1}");
            Console.WriteLine($"{meaning} {unitsType2}");
            // не разобрался, как можно явно преобразовать одну переменную из перечисления в другую, которой нет в самом перечислении
            // т.е. перечисление у нас ограничено "килограммы", "литры", "количество", а нужно получить "кг", "л", "шт".
            // при попытке явно преобразовать в string - ый тип переменных вылезает ошибка, что логично, ведь у них идут как бы числовые значения
        }
    }
}
