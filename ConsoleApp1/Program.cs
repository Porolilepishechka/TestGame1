using System;

namespace ConsoleApp1
{

    class Program
    {

        static void Main()
        {
            int Player = 100;
            int Enemy = 100;
            int Agrry = 0;
            int Damage = 0;
            string Inventory = "i";
            int HealPoint = 0;
            int Heals = 30;

            Console.WriteLine("у тебе є персонаж i ворог пиши цифри щоб убити ворога пиши (1) щоб атакувати");
            Console.WriteLine("введи (0) i ти активуєш щит");
            Console.WriteLine("введи (2) i ти приймеш лiкующий препарат");
            Console.WriteLine("введи (3) i ти очистеш консоль");



            do
            {
                Random Rdm = new Random();
                int DamageRdm = Rdm.Next(1, 10);
                //рандомний урон
                int DamageEnm = Rdm.Next(1, 3);
                // рандомний урон противника
                int RandomPrep = Rdm.Next(1, 2);
                //рондомна кількість препаратів
                try
                {
                    if (Inventory == "i")
                    {
                        Console.WriteLine("твiй iнвентар:");
                        Console.WriteLine("у вас " + HealPoint + " лiкувальних препаратiв");
                    }

                    Damage = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("ви завдали " + DamageRdm + " шкоди");

                    if (Damage >= 4)
                    {
                        Console.WriteLine("Чел ти не вмiєш читати? введи доступнi тобі числа");
                    }

                    switch (Damage)
                    {
                        case 2:

                            if (HealPoint >= 1)
                            {
                                Player = Player + Heals;
                                HealPoint = HealPoint - 1;
                                Console.WriteLine("ти застосував препарат i тепер у тебе на 30 Hp більше ніж було ;) ");
                            }
                            break;

                        default:
                            {
                                Console.WriteLine("У тебе не має лiкувальних препаратів");
                            }
                            break;
                            //коли застосував препарат
                    }
                    switch (Damage)
                    {
                        case 0:
                            Agrry = Agrry - 4;
                            Player = Player - 2;
                            Console.WriteLine("ви активували щит тепер у мас -2 Hp and -4 сили у противника");
                            break;
                        //активація щита
                        case 1:
                            Agrry = Agrry + DamageRdm + DamageEnm;
                            Enemy = Enemy - DamageRdm;
                            break;
                        //логіка завдаваня шкоди гравцю та поповнення сили противника
                        case 3:
                            Console.Clear();
                            break;
                    }

                    if (Player <= 10)
                    {
                        Console.WriteLine("ти пробудив у собi Берсерка i тепер ти наносеш " + 8 + " шкоди");
                        Player = Player + 5;
                        Enemy = Enemy - 8;
                    }
                    //пасівка

                    if (Agrry >= 21)
                    {
                        Console.WriteLine("Ворог вам завдає " + Agrry + " шкоди");
                        Player = Player - Agrry;
                        Agrry = 0;
                    }
                    //механіка завдавання шкоди ігроку

                    Console.WriteLine("ти: " + Player + " Hp");
                    Console.WriteLine("ворог: " + Enemy + " Hp");
                    Console.WriteLine("Сила ворога: " + Agrry);

                    if (Player <= 0)
                    {
                        Console.WriteLine("ти програв");
                        Console.WriteLine("Alt + F4 закрити гру або нажми на любу клавiшу щоб почати заново");
                        Console.ReadKey();
                        Console.Clear();
                        Enemy = 100;
                        Player = 100;
                        Agrry = 0;
                        Console.WriteLine("у тебе є персонаж і ворог пиши цифри щоб убити ворога пиши числа від 1 до 10");
                        Console.WriteLine("введи (0) і ти активуєш щит");
                        Console.WriteLine("Убий вже цього клятого ворога");

                    }
                    //якщо програв то перезапускає рівень

                    if (Enemy <= 0)
                    {
                        Console.WriteLine("ти виграв");
                        Console.WriteLine("Alt + F4 закрити гру");
                        Console.WriteLine("Або нажми на любу клавішу щоб перейти на новий рівень");
                        Console.ReadKey();
                        Enemy = 100 + 25;
                        Player = 100;
                        Agrry = 0;
                        HealPoint = HealPoint + RandomPrep;
                        Console.WriteLine("у тебе є персонаж і ворог пиши цифри щоб убити ворога пиши числа від 1 до 10");
                        Console.WriteLine("введи (0) i ти активуєш щит");
                        Console.WriteLine("Молодець далi монстри сильнiшi но не переживай у тебе є препарати вони облекшать тобi гру Удачі");

                    }
                    //якщо гравець виграв
                }
                catch (FormatException) 
                {
                    Console.WriteLine("щось пiшло не так");
                }

            } while (Enemy >= -1100);
            // логіка типу гри

        }
        
    }

}