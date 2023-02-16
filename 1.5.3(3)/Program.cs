namespace _1._5._3_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Используя материалы юнита, создайте программу, которая будет общаться 
            с пользователем и спрашивать его 2-3 вопроса, выводя ответы на экран. 
            Вопросы могут быть любыми (имя, фамилия, возраст, увлечения, город проживания, и прочее).

            Обратите внимание на строку Console.WriteLine("Здравствуйте, {0}", name);. 
            Попробуйте использовать аналогичную конструкцию в своей программе. 
            А если это не получается — можете открыть подсказку.
             */

            Console.WriteLine("кто?");
            string who = Console.ReadLine();
            Console.WriteLine("где?");
            string where = Console.ReadLine();
            Console.WriteLine("почему?");
            string why = Console.ReadLine();
            Console.WriteLine("Привет {0}, который {1} и ответ {2}", who, where, why);

        }
    }
}