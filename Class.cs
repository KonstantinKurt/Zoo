using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;
using static System.Math;
using System.Runtime.InteropServices;
using System.Drawing;


namespace Class
{
    class Methods
    {
        public int check_enter_int(int _n) // Метод проверки на интовость (исключает символы);
        {
            while (!int.TryParse(ReadLine(), out _n) || _n < 0)
            {
                WriteLine("Введите положительное число!(Без букв и любых других символов)");
            }
            return _n;
        }
        public double check_enter_double() // Метод проверки на положительный дабл (исключает символы);
        {
            double n;
            while (!double.TryParse(ReadLine().Replace('.', ','), out n) || n < 0)
            {
                Console.WriteLine("Введите положительное число!(Без букв и любых других символов)");
            }
            return n;
        }
        public double Get_double_random(int _a, int _b, int _fractional_part) // Генерация числа с плавающей запятой (fractional_part коллисество знков после запятой);
        {
            double n;
            double a = _a * Pow(10, _fractional_part);
            int c = (int)a;
            double b = _b * Pow(10, _fractional_part);
            int _c = (int)b;
            Random rand = new Random();
            n = rand.Next(c, _c) / Pow(10, _fractional_part);
            return n;
        }
        public int Get_int_random(int _a, int _b) // Генерация интового числа;
        {
            int n;
            Random rand = new Random();
            n = rand.Next(_a, _b);
            return n;
        }
        public int Get_number_from_string(string _str) // Метод проверки данных в строке на возможность считывания интового числа;
        {
            int x;
            bool rez = int.TryParse(_str, out x);
            if (rez)
                return x;
            else
                WriteLine("Невозможно считать данные!! (в строке нет интовых чисел, соблюдайте формат!)");
            return 0;
        }

    }


    abstract class Animal : Methods 
    {

        public string name;
        public int happiness;
        public Animal(string _name)
        {
            name = _name;
            happiness = 100;
        }


        public virtual void Print()
        {
            ForegroundColor =Green; Write(" Животное : "); 
        }
        public virtual void Draw() { }
        public virtual void Clean_the_cage(Zoo _obj) { }
        public virtual void Feed_the_animal(Zoo _obj) { }
        public virtual void Have_fun(Zoo _obj) { }
        public virtual double Get_cost(Zoo _obj) { return 0; }
        public virtual void Day_happinnes() { }

    }
    interface IZoo
    {
        List<Animal> List_of_animals { get; set; }
        void Show_collection();
        void Clear_the_list(bool[] _arr);
    }
    class Free : Animal
    {
        public int cage { get; set; }
        public Free(string _name , int _cage) : base(_name)
        {
            cage = _cage;
            
        }
        public override void Print()
        {
            ForegroundColor = Red; Write("Клетка :  "); ForegroundColor = White; Write(cage);
            base.Print(); ForegroundColor = White; Write(name+"\n");
        }

        public override void Draw()
        {
            int x = 0; int y = 0;
            if (cage == 0) { x = 7; y = 8; }
            if (cage == 1) { x = 22; y = 8; }
            if (cage == 2) { x = 37; y = 8; }
            if (cage == 3) { x = 7; y = 15; }
            if (cage == 4) { x = 22; y = 15; }
            if (cage == 5) { x = 37; y = 15; }
            if (cage == 6) { x = 7; y = 22; }
            if (cage == 7) { x = 22; y = 22; }
            if (cage == 8) { x = 37; y = 22; }
            SetCursorPosition(x, y);
            ForegroundColor = Green; Write(name);
            ForegroundColor = White;
        }
    }


    class Bear : Animal
    {
        public double  cost { get; set; }
        public int cage { get; set; }
        public double popularity = 10;
        public Bear(string _name , int _cage) : base(_name)
        {
            cage = _cage;
            cost = 5000;
        }
        public override void Print()
        {
            
            WriteLine("------------------------------------------------------------------------------------------------------------");
            ForegroundColor = Red; Write("Клетка :  "); ForegroundColor = White; Write(cage );
            base.Print(); ForegroundColor = White; Write(name);
            ForegroundColor = Green; Write(" Счастье  :  "); ForegroundColor = White; Write(happiness+"\n");
            WriteLine("------------------------------------------------------------------------------------------------------------");
        }
        public override void Day_happinnes()
        {
            happiness -= 10;
            if (happiness < 70 && happiness > 40) { happiness -= 20; }
            if (happiness < 40) { happiness -= 25; }
        }

        public  override void Clean_the_cage(Zoo _obj)
        {
            _obj.money -= 100;
            happiness += 10;
        }
        public override double Get_cost(Zoo _obj)
        {
            return cost / 2;
        }
        public override void Have_fun(Zoo _obj)
        {
            _obj.money -= 50;
            happiness += 5;
        }
        public override void Feed_the_animal(Zoo _obj)
        {
            _obj.money -= 200;
            happiness += 30;
        }
        public void Buy_a_bear(Zoo _obj)
        {
            _obj.money = _obj.money - cost;
            _obj.popularity = _obj.popularity + popularity;
        }

        public override void Draw()
        {
            int x = 0; int y = 0;
            if (cage == 0) { x = 1;  y = 8; }
            if (cage == 1) { x = 18; y = 8; }
            if (cage == 2) { x = 34; y = 8; }
            if (cage == 3) { x = 1; y = 15; }
            if (cage == 4) { x = 18; y = 15; }
            if (cage == 5) { x = 34; y = 15; }
            if (cage == 6) { x = 1; y = 22; }
            if (cage == 7) { x = 18; y = 22; }
            if (cage == 8) { x = 34; y = 22; }
            SetCursorPosition(x, y);
            ForegroundColor = Green; Write(name);
            ForegroundColor = White;
        }
    }
    class Squirrel : Animal
    {
        public double cost { get; set; }
        public int cage { get; set; }
        public double popularity = 5;
        public Squirrel(string _name, int _cage) : base(_name)
        {
            cage = _cage;
            cost = 3000;
        }
        public override void Print()
        {

            WriteLine("------------------------------------------------------------------------------------------------------------");
            ForegroundColor = Red; Write("Клетка :  "); ForegroundColor = White; Write(cage);
            base.Print(); ForegroundColor = White; Write(name);
            ForegroundColor = Green; Write(" Счастье  :  "); ForegroundColor = White; Write(happiness + "\n");
            WriteLine("------------------------------------------------------------------------------------------------------------");
        }
        public override void Day_happinnes()
        {
            happiness -= 5;
            if (happiness < 70 && happiness > 40) { happiness -= 20; }
            if (happiness < 40) { happiness -= 25; }
        }

        public override void Clean_the_cage(Zoo _obj)
        {
            _obj.money -= 50;
            happiness += 10;
        }
        public override double Get_cost(Zoo _obj)
        {
            return cost / 2;
        }
        public override void Have_fun(Zoo _obj)
        {
            _obj.money -= 100;
            happiness += 5;
        }
        public override void Feed_the_animal(Zoo _obj)
        {
            _obj.money -= 50;
            happiness += 30;
        }
        public void Buy_a_squirrel(Zoo _obj)
        {
            _obj.money = _obj.money - cost;
            _obj.popularity = _obj.popularity + popularity;
        }

        public override void Draw()
        {
            int x = 0; int y = 0;
            if (cage == 0) { x = 1; y = 8; }
            if (cage == 1) { x = 18; y = 8; }
            if (cage == 2) { x = 34; y = 8; }
            if (cage == 3) { x = 1; y = 15; }
            if (cage == 4) { x = 18; y = 15; }
            if (cage == 5) { x = 34; y = 15; }
            if (cage == 6) { x = 1; y = 22; }
            if (cage == 7) { x = 18; y = 22; }
            if (cage == 8) { x = 34; y = 22; }
            SetCursorPosition(x, y);
            ForegroundColor = Green; Write(name);
            ForegroundColor = White;
        }
    }
    class Ram : Animal
    {
        public double cost { get; set; }
        public int cage { get; set; }
        public double popularity = 5;
        public Ram(string _name, int _cage) : base(_name)
        {
            cage = _cage;
            cost = 6000;
        }
        public override void Print()
        {

            WriteLine("------------------------------------------------------------------------------------------------------------");
            ForegroundColor = Red; Write("Клетка :  "); ForegroundColor = White; Write(cage);
            base.Print(); ForegroundColor = White; Write(name);
            ForegroundColor = Green; Write(" Счастье  :  "); ForegroundColor = White; Write(happiness + "\n");
            WriteLine("------------------------------------------------------------------------------------------------------------");
        }
        public override void Day_happinnes()
        {
            happiness -= 1;
            if (happiness < 70 && happiness > 40) { happiness -= 3; }
            if (happiness < 40) { happiness -= 5; }
        }

        public override void Clean_the_cage(Zoo _obj)
        {
            _obj.money -= 300;
            happiness += 25;
        }
        public override double Get_cost(Zoo _obj)
        {
            return cost / 2;
        }
        public override void Have_fun(Zoo _obj)
        {
            _obj.money -= 150;
            happiness += 25;
        }
        public override void Feed_the_animal(Zoo _obj)
        {
            _obj.money -= 200;
            happiness += 50;
        }
        public void Buy_a_ram(Zoo _obj)
        {
            _obj.money = _obj.money - cost;
            _obj.popularity = _obj.popularity + popularity;
        }

        public override void Draw()
        {
            int x = 0; int y = 0;
            if (cage == 0) { x = 3; y = 8; }
            if (cage == 1) { x = 20; y = 8; }
            if (cage == 2) { x = 36; y = 8; }
            if (cage == 3) { x = 3; y = 15; }
            if (cage == 4) { x = 20; y = 15; }
            if (cage == 5) { x = 36; y = 15; }
            if (cage == 6) { x = 3; y = 22; }
            if (cage == 7) { x = 20; y = 22; }
            if (cage == 8) { x = 36; y = 22; }
            SetCursorPosition(x, y);
            ForegroundColor = Green; Write(name);
            ForegroundColor = White;
        }
    }
    class Raccoon : Animal
    {
        public double cost { get; set; }
        public int cage { get; set; }
        public double popularity = 40;
        public Raccoon(string _name, int _cage) : base(_name)
        {
            cage = _cage;
            cost = 15000;
        }
        public override void Print()
        {

            WriteLine("------------------------------------------------------------------------------------------------------------");
            ForegroundColor = Red; Write("Клетка :  "); ForegroundColor = White; Write(cage);
            base.Print(); ForegroundColor = White; Write(name);
            ForegroundColor = Green; Write(" Счастье  :  "); ForegroundColor = White; Write(happiness + "\n");
            WriteLine("------------------------------------------------------------------------------------------------------------");
        }
        public override void Day_happinnes()
        {
            happiness -= 15;
            if (happiness < 70 && happiness > 40) { happiness -= 20; }
            if (happiness < 40) { happiness -= 25; }
        }

        public override void Clean_the_cage(Zoo _obj)
        {
            _obj.money -= 100;
            happiness += 25;
        }
        public override double Get_cost(Zoo _obj)
        {
            return cost / 2;
        }
        public override void Have_fun(Zoo _obj)
        {
            _obj.money -= 200;
            happiness += 25;
        }
        public override void Feed_the_animal(Zoo _obj)
        {
            _obj.money -= 100;
            happiness += 50;
        }
        public void Buy_a_raccoon(Zoo _obj)
        {
            _obj.money = _obj.money - cost;
            _obj.popularity = _obj.popularity + popularity;
        }

        public override void Draw()
        {
            int x = 0; int y = 0;
            if (cage == 0) { x = 3; y = 8; }
            if (cage == 1) { x = 20; y = 8; }
            if (cage == 2) { x = 36; y = 8; }
            if (cage == 3) { x = 3; y = 15; }
            if (cage == 4) { x = 20; y = 15; }
            if (cage == 5) { x = 36; y = 15; }
            if (cage == 6) { x = 3; y = 22; }
            if (cage == 7) { x = 20; y = 22; }
            if (cage == 8) { x = 36; y = 22; }
            SetCursorPosition(x, y);
            ForegroundColor = Green; Write(name);
            ForegroundColor = White;
        }
    }
    class Snake : Animal
    {
        public double cost { get; set; }
        public int cage { get; set; }
        public double popularity = 20;
        public Snake(string _name, int _cage) : base(_name)
        {
            cage = _cage;
            cost = 8000;
        }
        public override void Print()
        {

            WriteLine("------------------------------------------------------------------------------------------------------------");
            ForegroundColor = Red; Write("Клетка :  "); ForegroundColor = White; Write(cage);
            base.Print(); ForegroundColor = White; Write(name);
            ForegroundColor = Green; Write(" Счастье  :  "); ForegroundColor = White; Write(happiness + "\n");
            WriteLine("------------------------------------------------------------------------------------------------------------");
        }
        public override void Day_happinnes()
        {
            happiness -= 10;
            if (happiness < 70 && happiness > 40) { happiness -= 20; }
            if (happiness < 40) { happiness -= 25; }
        }

        public override void Clean_the_cage(Zoo _obj)
        {
            _obj.money -= 100;
            happiness += 25;
        }
        public override double Get_cost(Zoo _obj)
        {
            return cost / 2;
        }
        public override void Have_fun(Zoo _obj)
        {
            _obj.money -= 300;
            happiness += 25;
        }
        public override void Feed_the_animal(Zoo _obj)
        {
            _obj.money -= 50;
            happiness += 50;
        }
        public void Buy_a_snake(Zoo _obj)
        {
            _obj.money = _obj.money - cost;
            _obj.popularity = _obj.popularity + popularity;
        }

        public override void Draw()
        {
            int x = 0; int y = 0;
            if (cage == 0) { x = 3; y = 8; }
            if (cage == 1) { x = 20; y = 8; }
            if (cage == 2) { x = 36; y = 8; }
            if (cage == 3) { x = 3; y = 15; }
            if (cage == 4) { x = 20; y = 15; }
            if (cage == 5) { x = 36; y = 15; }
            if (cage == 6) { x = 3; y = 22; }
            if (cage == 7) { x = 20; y = 22; }
            if (cage == 8) { x = 36; y = 22; }
            SetCursorPosition(x, y);
            ForegroundColor = Green; Write(name);
            ForegroundColor = White;
        }
    }
    class Baboon : Animal
    {
        public double cost { get; set; }
        public int cage { get; set; }
        public double popularity = 15;
        public Baboon(string _name, int _cage) : base(_name)
        {
            cage = _cage;
            cost = 7500;
        }
        public override void Print()
        {

            WriteLine("------------------------------------------------------------------------------------------------------------");
            ForegroundColor = Red; Write("Клетка :  "); ForegroundColor = White; Write(cage);
            base.Print(); ForegroundColor = White; Write(name);
            ForegroundColor = Green; Write(" Счастье  :  "); ForegroundColor = White; Write(happiness + "\n");
            WriteLine("------------------------------------------------------------------------------------------------------------");
        }
        public override void Day_happinnes()
        {
            happiness -= 10;
            if (happiness < 70 && happiness > 40) { happiness -= 20; }
            if (happiness < 40) { happiness -= 25; }
        }

        public override void Clean_the_cage(Zoo _obj)
        {
            _obj.money -= 200;
            happiness += 25;
        }
        public override double Get_cost(Zoo _obj)
        {
            return cost / 2;
        }
        public override void Have_fun(Zoo _obj)
        {
            _obj.money -= 150;
            happiness += 25;
        }
        public override void Feed_the_animal(Zoo _obj)
        {
            _obj.money -= 150;
            happiness += 50;
        }
        public void Buy_a_baboon(Zoo _obj)
        {
            _obj.money = _obj.money - cost;
            _obj.popularity = _obj.popularity + popularity;
        }

        public override void Draw()
        {
            int x = 0; int y = 0;
            if (cage == 0) { x = 3; y = 8; }
            if (cage == 1) { x = 20; y = 8; }
            if (cage == 2) { x = 36; y = 8; }
            if (cage == 3) { x = 3; y = 15; }
            if (cage == 4) { x = 20; y = 15; }
            if (cage == 5) { x = 36; y = 15; }
            if (cage == 6) { x = 3; y = 22; }
            if (cage == 7) { x = 20; y = 22; }
            if (cage == 8) { x = 36; y = 22; }
            SetCursorPosition(x, y);
            ForegroundColor = Green; Write(name);
            ForegroundColor = White;
        }
    }
    class Zoo : IZoo
    {
        public List<Animal> List_of_animals { get; set; }
        public double money = 10000;
        public double popularity = 0;
        public void Show_stats()
        {
            SetCursorPosition(50, 7); ForegroundColor = Red; Write(" Деньги :  "); ForegroundColor = White; Write(money);
            SetCursorPosition(50, 8); ForegroundColor = Blue; Write(" Рейтинг : "); ForegroundColor = White; Write(popularity);
        }

        public void Clear_the_list(bool[] _arr)
        {
            List_of_animals.Clear();
            for (int i = 0; i < _arr.Length; i++)
            {
                _arr[i] = false;
            }
            WriteLine("Коллекция очищена\n");
        }
        public void see_assistant()
        {
            for (int i = 0; i < 9; i++)
            {
                if (List_of_animals[i].name != "Свободно") { List_of_animals[i].Print(); }
            }
        }
        public void Show_collection()
        {
            Show_stats();
            foreach (Animal item in List_of_animals)
            {
                item.Draw();
            }
            SetCursorPosition(7, 7); Write("Клетка 0"); SetCursorPosition(22, 7); Write("Клетка 1"); SetCursorPosition(37, 7); Write("Клетка 2");
            SetCursorPosition(7, 14); Write("Клетка 3"); SetCursorPosition(22, 14); Write("Клетка 4"); SetCursorPosition(37, 14); Write("Клетка 5");
            SetCursorPosition(7, 21); Write("Клетка 6"); SetCursorPosition(22, 21); Write("Клетка 7"); SetCursorPosition(37, 21); Write("Клетка 8");
            Write("\n\n\n\n\n");
            WriteLine("------------------------------------------------------------------------------------------------------------");
        }
          public void Day_result_animals()
        {
            int n; 
            Random rand = new Random();
            n = rand.Next(1, 100);
            if (List_of_animals.Any(Animal=>Animal.name == " Мишка Винни-Пух")&& List_of_animals.Any(Animal => Animal.name == " Бельчонок Штофф")&& n>=70)
            {
                Write("Бельчонок Штофф посетил мишку Винни - пуха...Ремонт клетки "); ForegroundColor = Red; Write("  -" + 200 + "\n"); ForegroundColor = White; money -= 200;
                Write("Мишка Винни-Пух слегка расстроен утром "); ForegroundColor = Red; Write("  -" + 10 + " счастье\n"); ForegroundColor = White;
                WriteLine("------------------------------------------------------------------------------------------------------------");
                for (int i = 0; i < 9; i++)
                {
                    if(List_of_animals[i].name == " Мишка Винни-Пух")
                    {
                        
                        List_of_animals[i].happiness -= 10;
                    }
                }
            }
            if (List_of_animals.Any(Animal => Animal.name == " Баран Витек") && List_of_animals.Any(Animal => Animal.name == " Бельчонок Штофф") && n>=60 && n<=95)
            {
                Write("Бельчонок Штофф посетил Барана Витька ...Ремонт клетки "); ForegroundColor = Red; Write("  -" + 300 + "\n"); ForegroundColor = White; money -= 200;
                Write(" Баран Витек слегка расстроен утром "); ForegroundColor = Red; Write("  -" + 5 + " счастье\n"); ForegroundColor = White;
                WriteLine("------------------------------------------------------------------------------------------------------------");
                for (int i = 0; i < 9; i++)
                {
                   
                    if (List_of_animals[i].name == " Баран Витек") { List_of_animals[i].happiness -= 5; }
                }
            }
            if (List_of_animals.Any(Animal => Animal.name == " Баран Витек") && List_of_animals.Any(Animal => Animal.name == " Бельчонок Штофф") &&  n <= 40 && n>10)
            {
                Write("Баран Витек наехал на Бельчонка Штоффа.... Не поймал, но слегка обидел))"); ForegroundColor = Red; Write("  -" + 5 + " счастье\n"); ForegroundColor = White;
                WriteLine("------------------------------------------------------------------------------------------------------------");
                for (int i = 0; i < 9; i++)
                {
                    if (List_of_animals[i].name == " Бельчонок Штофф")
                    {
                        List_of_animals[i].happiness -= 5;
                    }
                }
            }
            if (List_of_animals.Any(Animal => Animal.name == " Енот Путин")&& n > 32 && n <= 68)
            {
                Write("Енот Владимир опять всех кошмарит!"); ForegroundColor = Red; Write("  -" + 15 + " счастье у всех зверей, кроме его друзей\n"); ForegroundColor = White;
                WriteLine("------------------------------------------------------------------------------------------------------------");
                for (int i = 0; i < 9; i++)
                {
                    if (List_of_animals[i].name != " Баран Витек" && List_of_animals[i].name != " Гадюка Юля")
                    {
                        List_of_animals[i].happiness -= 15;
                    }
                }
            }
            if (List_of_animals.Any(Animal => Animal.name == " Гадюка Юля") && List_of_animals.Any(Animal => Animal.name == " Баран Витек") && n > 81 && n <= 100)
            {
                Write("Гадюка Юля укусила Барана Витька! Больно!! "); ForegroundColor = Red; Write("  -" + 50 + " счастье у Барана Витька \n"); ForegroundColor = White;
                WriteLine("------------------------------------------------------------------------------------------------------------");
                for (int i = 0; i < 9; i++)
                {
                    if (List_of_animals[i].name != " Баран Витек")
                    {
                        List_of_animals[i].happiness -= 50;
                    }
                }
            }
            if (List_of_animals.Any(Animal => Animal.name == " Гадюка Юля") && List_of_animals.Any(Animal => Animal.name == " Баран Витек") && n > 79 && n <= 92)
            {
                Write("Баран Витек наехал на Гадюку Юлю.... Ох уж эта вечная вражда!!"); ForegroundColor = Red; Write("  -" + 15 + " счастье у Гадюки Юли\n"); ForegroundColor = White;
                WriteLine("------------------------------------------------------------------------------------------------------------");
                for (int i = 0; i < 9; i++)
                {
                    if (List_of_animals[i].name == " Гадюка Юля")
                    {
                        List_of_animals[i].happiness -= 15;
                    }
                }
            }
            if (List_of_animals.Any(Animal => Animal.name == " Павиан Олежка") && List_of_animals.Any(Animal => Animal.name == " Баран Витек") && n > 25 && n <= 45)
            {
                Write("Баран Витек наехал на Павиана Олежку!!...Весьма отчаянный ход!"); ForegroundColor = Red; Write("  -" + 15 + " счастье у Павиана Олежки\n"); ForegroundColor = White;
                WriteLine("------------------------------------------------------------------------------------------------------------");
                for (int i = 0; i < 9; i++)
                {
                    if (List_of_animals[i].name == " Павиан Олежка")
                    {
                        List_of_animals[i].happiness -= 15;
                    }
                }
            }
            if (List_of_animals.Any(Animal => Animal.name == " Павиан Олежка") && n > 5 && n <= 39)
            {
                Write("Павиан Олежка провел рейд по зоопарку!! Все особи мужского пола очень насторожены..."); ForegroundColor = Red; Write("  -" + 15 + " счастье у всех зверей, кроме особей женского пола\n"); ForegroundColor = White;
                WriteLine("------------------------------------------------------------------------------------------------------------");
                for (int i = 0; i < 9; i++)
                {
                    if ( List_of_animals[i].name != " Гадюка Юля")
                    {
                        List_of_animals[i].happiness -= 15;
                    }
                }
            }
        }





        
        public void Get_money()
        {
            int n; int weather;
            Random rand = new Random();
            Random rand1 = new Random();
            weather = rand.Next(1, 11);
            if(weather>=1 && weather <= 5)
            {
                SetCursorPosition(12, 0);Write("Погода :  "); ForegroundColor = Yellow;Write("Солнечно" + "\n"); ForegroundColor = White;
                n = rand.Next(30, 301);
                Write("Зоопарк посетило :  "); ForegroundColor = Green; Write(n); ForegroundColor = White; Write("  людей" + "\n");
                Write("Дневной заработок :  "); ForegroundColor = Green; Write(n * popularity + "\n"); ForegroundColor = White;
                money = money + n * popularity;
                WriteLine("------------------------------------------------------------------------------------------------------------");
                Write("\n\n");
           }
            if (weather > 5 && weather <= 8)
            {
                SetCursorPosition(12, 0); Write("Погода :  "); ForegroundColor = Blue; Write("Пасмурно" + "\n"); ForegroundColor = White;
                n = rand.Next(20, 121);
                Write("Зоопарк посетило :  "); ForegroundColor = Green; Write(n); ForegroundColor = White; Write("  людей" + "\n");
                Write("Дневной заработок :  "); ForegroundColor = Green; Write(n * popularity + "\n"); ForegroundColor = White;
                money = money + n * popularity;
                WriteLine("------------------------------------------------------------------------------------------------------------");
                Write("\n\n");
            }
            if (weather > 8 && weather <= 10)
            {
                SetCursorPosition(12, 0); Write("Погода :  "); ForegroundColor = DarkMagenta; Write("Ливень" + "\n"); ForegroundColor = White;
                n = rand.Next(10, 50);
                Write("Зоопарк посетило :  "); ForegroundColor = Green; Write(n); ForegroundColor = White; Write("  людей" + "\n");
                Write("Дневной заработок :  "); ForegroundColor = Green; Write(n * popularity + "\n"); ForegroundColor = White;
                money = money + n * popularity;
                WriteLine("------------------------------------------------------------------------------------------------------------");
                Write("\n\n");
            }
        }
        public void Day_result_other()
        {
            int n;
            Random rand = new Random();
            n = rand.Next(0, 101);
            if (n <= 10) { Write("Студенты академии 'Шаг' праздновали окончание курса С++. Снятие стресса с животных  "); ForegroundColor = Red; Write("  -" + 1000+"\n"); ForegroundColor = White; money -= 1000; }
            if(n>10 && n <= 15) { Write("У директора местной налоговой День рождения  "); ForegroundColor = Red; Write("  -" + 3000 + "\n"); ForegroundColor = White; money -= 3000; }
            if (n > 15 && n <= 16) { Write("Беда!! Депутатам требуются деньги на новую предвыборную кампанию..." +"\n" );  money = 0; }
            if (n > 16 && n <= 25) { Write("Туристы из Европы прослезились, осматривая Ваш зоопарк..  "); ForegroundColor = Red; Write("  +" + 5000 + "\n"); ForegroundColor = White; money += 5000; }
            if (n > 25 && n <= 35) { Write("У сторожа Феди в коморке нашли склад пустых бутылок  "); ForegroundColor = Red; Write("  +" + 500 + "\n"); ForegroundColor = White; money += 500; }
            if (n > 35 && n <= 45) { Write("По случаю гей-прада зоопарк был закрыт (на всякий случай). Финансовое положение без изменений. \n"); }
            if (n > 45 && n <= 60) { Write("Дети-мажоры бросались в зверей бананами. Предприимчивая уборщица тетя Люся отнесла бананы на рынок  "); ForegroundColor = Red; Write("  +" + 1000 + "\n"); ForegroundColor = White; money += 1000; }
            if (n > 60 && n <= 75) { Write("Охранник Василий торгует наркотиками!! Но штраф выписан Вам. Почему-то... "); ForegroundColor = Red; Write("  -" + 3500 + "\n"); ForegroundColor = White; money -= 3500; }
            if (n > 75 && n <= 90) { Write("Зоозащитники устроили дебош. Охранник Василий вел себя не корректно! Услуги стоматолога любителям животных  "); ForegroundColor = Red; Write("  -" + 1500 + "\n"); ForegroundColor = White; money -= 1500; }
            if (n > 90 && n <= 100) { Write("День прошел спокойно... Аж странно!!" + "\n"); }
            WriteLine("------------------------------------------------------------------------------------------------------------");
            Write("\n\n");
        }

    }

}


























