using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;
using static System.ConsoleColor;
using Class;
namespace Hw7
{

    class Program
    {


        static void Main(string[] args)
        {

            Zoo Coll = new Zoo();
            Coll.List_of_animals = new List<Animal>();
            for (int i = 0; i < 9; i++)
            {
                Free free = new Free("Свободно", i);
                Coll.List_of_animals.Add(free);

            }
            bool[] arr_check = new bool[9];
            bool ex = false;
            do
            {
                start:
                int choice = 0;
                string str1 = "                                   Hw_8 Зоопарк";
                switch (ShowMenu(new string[] { "Магазин ", "Состояние животных", "Уход за животными", "Продать животное","Новый день" ,"Ввести пароль","Выход" }, ref choice, str1, Coll))
                {

                    case 0:
                        {
                            string str2 = "                                 Магазин";
                            switch (ShowMenu1(new string[] { "Мишка Винни - Пух ", "Бельчонок Штофф", "Баран Витек", "Енот Владимир","Гадюка Юля","Павиан Олежка", "Выход" }, ref choice, str2))
                            {

                                case 0:
                                    {
                                        Clear();
                                        Bear bear = new Bear(" Мишка Винни-Пух", 0);
                                        ForegroundColor = Red; Write("Имя:  "); ForegroundColor = White; Write(bear.name+"\n");
                                        ForegroundColor = Red; Write("Стоимость:  "); ForegroundColor = White; Write(bear.cost + "\n");
                                        ForegroundColor = Red; Write("Рейтинг:  "); ForegroundColor = White; Write(bear.popularity + "\n");
                                        ForegroundColor = Red; Write("Стоимость уборки:  "); ForegroundColor = White; Write(100 + "\n");
                                        ForegroundColor = Red; Write("Стоимость кормежки:  "); ForegroundColor = White; Write(200 + "\n");
                                        ForegroundColor = Red; Write("Стоимость веселья:  "); ForegroundColor = White; Write(50 + "\n");
                                        ForegroundColor = Blue; WriteLine("Добрый мишка из детской сказки. Правда, в голове одни опилки\n"); ForegroundColor = White;
                                        WriteLine("---------------------------------------------------------------------------------------------");
                                        int occupancy = check_arr_occupancy(arr_check);
                                        if (occupancy == 0) { goto start; }
                                        int position = 0;
                                        WriteLine("Выберите клетку\n");
                                        position = check_enter_int(position);
                                        while (arr_check[position] == true)
                                        {
                                            WriteLine("Клетка занята, выберите другую\n");
                                            position = check_enter_int(position);
                                        }
                                        arr_check[position] = true;
                                        if (Coll.money >= bear.cost)
                                        {
                                            Bear bear1 = new Bear(" Мишка Винни-Пух", position);
                                            Coll.List_of_animals[position] = bear1;
                                            bear1.Buy_a_bear(Coll);
                                        }
                                        else
                                        {
                                            WriteLine("У Вас недостаточно денег для покупки данного зверя \n ");
                                            WriteLine("Для продолжения нажмите любую клавишу");
                                            ReadKey();
                                        }
                                    }
                                    break;
                                case 1:
                                    {
                                        Clear();
                                        Squirrel squirrel = new Squirrel(" Бельчонок Штофф", 0);
                                        ForegroundColor = Red; Write("Имя:  "); ForegroundColor = White; Write(squirrel.name + "\n");
                                        ForegroundColor = Red; Write("Стоимость:  "); ForegroundColor = White; Write(squirrel.cost + "\n");
                                        ForegroundColor = Red; Write("Рейтинг:  "); ForegroundColor = White; Write(squirrel.popularity + "\n");
                                        ForegroundColor = Red; Write("Стоимость уборки:  "); ForegroundColor = White; Write(50 + "\n");
                                        ForegroundColor = Red; Write("Стоимость кормежки:  "); ForegroundColor = White; Write(100 + "\n");
                                        ForegroundColor = Red; Write("Стоимость веселья:  "); ForegroundColor = White; Write(50 + "\n");
                                        ForegroundColor = Blue; WriteLine("Хитрая и опасная белка! Любит посещать не слишком 'интеллектуальных' зверей\n"); ForegroundColor = White;
                                        WriteLine("---------------------------------------------------------------------------------------------");
                                        int occupancy = check_arr_occupancy(arr_check);
                                        if (occupancy == 0) { goto start; }
                                        int position = 0;
                                        WriteLine("Выберите клетку\n");
                                        position = check_enter_int(position);
                                        while (arr_check[position] == true)
                                        {
                                            WriteLine("Клетка занята, выберите другую\n");
                                            position = check_enter_int(position);
                                        }
                                        arr_check[position] = true;
                                        if (Coll.money >= squirrel.cost)
                                        {
                                            Squirrel squirrel1 = new Squirrel(" Бельчонок Штофф", position);
                                            Coll.List_of_animals[position] = squirrel1;
                                            squirrel1.Buy_a_squirrel(Coll);
                                        }
                                        else
                                        {
                                            WriteLine("У Вас недостаточно денег для покупки данного зверя \n ");
                                            WriteLine("Для продолжения нажмите любую клавишу");
                                            ReadKey();
                                        }
                                    }
                                    break;
                                case 2:
                                    {
                                        Clear();
                                        Ram ram = new Ram(" Баран Витек", 0);
                                        ForegroundColor = Red; Write("Имя:  "); ForegroundColor = White; Write(ram.name + "\n");
                                        ForegroundColor = Red; Write("Стоимость:  "); ForegroundColor = White; Write(ram.cost + "\n");
                                        ForegroundColor = Red; Write("Рейтинг:  "); ForegroundColor = White; Write(ram.popularity + "\n");
                                        ForegroundColor = Red; Write("Стоимость уборки:  "); ForegroundColor = White; Write(300 + "\n");
                                        ForegroundColor = Red; Write("Стоимость кормежки:  "); ForegroundColor = White; Write(200 + "\n");
                                        ForegroundColor = Red; Write("Стоимость веселья:  "); ForegroundColor = White; Write(150 + "\n");
                                        ForegroundColor = Blue; WriteLine("Крайне недалекий зверь. Был неоднократно судим, чувствует себя в клетке как дома.\nСчитает себя авторитетом и может обидеть более слабых животных.\nДруг Енота Владимира."); ForegroundColor = White;
                                        WriteLine("---------------------------------------------------------------------------------------------");
                                        int occupancy = check_arr_occupancy(arr_check);
                                        if (occupancy == 0) { goto start; }
                                        int position = 0;
                                        WriteLine("Выберите клетку\n");
                                        position = check_enter_int(position);
                                        while (arr_check[position] == true)
                                        {
                                            WriteLine("Клетка занята, выберите другую\n");
                                            position = check_enter_int(position);
                                        }
                                        arr_check[position] = true;
                                        if (Coll.money >= ram.cost)
                                        {
                                            Ram ram1 = new Ram(" Баран Витек", position);
                                            Coll.List_of_animals[position] = ram1;
                                            ram1.Buy_a_ram(Coll);
                                        }
                                        else
                                        {
                                            WriteLine("У Вас недостаточно денег для покупки данного зверя \n ");
                                            WriteLine("Для продолжения нажмите любую клавишу");
                                            ReadKey();
                                        }

                                    }
                                    break;

                                case 3:
                                    {
                                        Clear();
                                        Raccoon racoon = new Raccoon(" Енот Владимир", 0);
                                        ForegroundColor = Red; Write("Имя:  "); ForegroundColor = White; Write(racoon.name + "\n");
                                        ForegroundColor = Red; Write("Стоимость:  "); ForegroundColor = White; Write(racoon.cost + "\n");
                                        ForegroundColor = Red; Write("Рейтинг:  "); ForegroundColor = White; Write(racoon.popularity + "\n");
                                        ForegroundColor = Red; Write("Стоимость уборки:  "); ForegroundColor = White; Write(100 + "\n");
                                        ForegroundColor = Red; Write("Стоимость кормежки:  "); ForegroundColor = White; Write(100 + "\n");
                                        ForegroundColor = Red; Write("Стоимость веселья:  "); ForegroundColor = White; Write(200 + "\n");
                                        ForegroundColor = Blue; WriteLine("Второе имя данного зверя считается неприличным произносить в культурном обществе.\nИмеет большой рейтинг, так как крайне многие желают видеть его в клетке\nРаздражает практически всех животных"); ForegroundColor = White;
                                        WriteLine("---------------------------------------------------------------------------------------------");
                                        int occupancy = check_arr_occupancy(arr_check);
                                        if (occupancy == 0) { goto start; }
                                        int position = 0;
                                        WriteLine("Выберите клетку\n");
                                        position = check_enter_int(position);
                                        while (arr_check[position] == true)
                                        {
                                            WriteLine("Клетка занята, выберите другую\n");
                                            position = check_enter_int(position);
                                        }
                                        arr_check[position] = true;
                                        if (Coll.money >= racoon.cost)
                                        {
                                            Raccoon racoon1 = new Raccoon(" Енот Владимир", position);
                                            Coll.List_of_animals[position] = racoon1;
                                            racoon1.Buy_a_raccoon(Coll);
                                        }
                                        else
                                        {
                                            WriteLine("У Вас недостаточно денег для покупки данного зверя \n ");
                                            WriteLine("Для продолжения нажмите любую клавишу");
                                            ReadKey();
                                        }

                                    }
                                    break;
                                case 4:
                                    {
                                        Clear();
                                        Snake snake = new Snake(" Гадюка Юля", 0);
                                        ForegroundColor = Red; Write("Имя:  "); ForegroundColor = White; Write(snake.name + "\n");
                                        ForegroundColor = Red; Write("Стоимость:  "); ForegroundColor = White; Write(snake.cost + "\n");
                                        ForegroundColor = Red; Write("Рейтинг:  "); ForegroundColor = White; Write(snake.popularity + "\n");
                                        ForegroundColor = Red; Write("Стоимость уборки:  "); ForegroundColor = White; Write(100 + "\n");
                                        ForegroundColor = Red; Write("Стоимость кормежки:  "); ForegroundColor = White; Write(50 + "\n");
                                        ForegroundColor = Red; Write("Стоимость веселья:  "); ForegroundColor = White; Write(300 + "\n");
                                        ForegroundColor = Blue; WriteLine("Очень хитрая дама\nИмеет иммунитет к еноту Владимиру и особую неприязнь к Барану Витьку"); ForegroundColor = White;
                                        WriteLine("---------------------------------------------------------------------------------------------");
                                        int occupancy = check_arr_occupancy(arr_check);
                                        if (occupancy == 0) { goto start; }
                                        int position = 0;
                                        WriteLine("Выберите клетку\n");
                                        position = check_enter_int(position);
                                        while (arr_check[position] == true)
                                        {
                                            WriteLine("Клетка занята, выберите другую\n");
                                            position = check_enter_int(position);
                                        }
                                        arr_check[position] = true;
                                        if (Coll.money >= snake.cost)
                                        {
                                            Snake snake1 = new Snake(" Гадюка Юля", position);
                                            Coll.List_of_animals[position] = snake1;
                                            snake1.Buy_a_snake(Coll);
                                        }
                                        else
                                        {
                                            WriteLine("У Вас недостаточно денег для покупки данного зверя \n ");
                                            WriteLine("Для продолжения нажмите любую клавишу");
                                            ReadKey();
                                        }

                                    }
                                    break;
                                case 5:
                                    {
                                        Clear();
                                        Baboon baboon = new Baboon(" Павиан Олежка", 0);
                                        ForegroundColor = Red; Write("Имя:  "); ForegroundColor = White; Write(baboon.name + "\n");
                                        ForegroundColor = Red; Write("Стоимость:  "); ForegroundColor = White; Write(baboon.cost + "\n");
                                        ForegroundColor = Red; Write("Рейтинг:  "); ForegroundColor = White; Write(baboon.popularity + "\n");
                                        ForegroundColor = Red; Write("Стоимость уборки:  "); ForegroundColor = White; Write(200 + "\n");
                                        ForegroundColor = Red; Write("Стоимость кормежки:  "); ForegroundColor = White; Write(150 + "\n");
                                        ForegroundColor = Red; Write("Стоимость веселья:  "); ForegroundColor = White; Write(150 + "\n");
                                        ForegroundColor = Blue; WriteLine("Вызывает сильные опасения у всех особей мужского пола...."); ForegroundColor = White;
                                        WriteLine("---------------------------------------------------------------------------------------------");
                                        int occupancy = check_arr_occupancy(arr_check);
                                        if (occupancy == 0) { goto start; }
                                        int position = 0;
                                        WriteLine("Выберите клетку\n");
                                        position = check_enter_int(position);
                                        while (arr_check[position] == true)
                                        {
                                            WriteLine("Клетка занята, выберите другую\n");
                                            position = check_enter_int(position);
                                        }
                                        arr_check[position] = true;
                                        if (Coll.money >= baboon.cost)
                                        {
                                            Baboon baboon1 = new Baboon(" Павиан Олежка", position);
                                            Coll.List_of_animals[position] = baboon1;
                                            baboon1.Buy_a_baboon(Coll);
                                        }
                                        else
                                        {
                                            WriteLine("У Вас недостаточно денег для покупки данного зверя \n ");
                                            WriteLine("Для продолжения нажмите любую клавишу");
                                            ReadKey();
                                        }

                                    }
                                    break;
                                case 6:
                                    {
                                        goto start;

                                    }
                                    
                            }
                            break;
                        }
                    case 1:
                        {
                            ConsoleKey key1;
                            do
                            {
                                Clear();
                                Coll.see_assistant();
                                WriteLine("Для выхода нажмите Esc");
                                key1 = ReadKey().Key;
                            } while (key1 != ConsoleKey.Escape);
                        }
                        break;
                    case 2:
                        {
                            string str3 = "                               Уход за животными";
                            switch (ShowMenu1(new string[] { "Убрать клетку", "Покормить зверя", "Развеселить зверя", "Выход" }, ref choice, str3))
                            {

                                case 0:
                                    {
                                            Clear();
                                            ForegroundColor = Red; Write("\t\tУборка  \n"); ForegroundColor = White;
                                            WriteLine("---------------------------------------------------------------------------------------------");
                                           string str4 = "                                 Выберите клетку";
                                        switch (ShowMenu1(new string[] { "Клетка 0 ", "Клетка 1 ", "Клетка 2 ", "Клетка 3 ", "Клетка 4 ", "Клетка 5 ", "Клетка 6 ", "Клетка 7 ", "Клетка 8 ", "Выход" }, ref choice, str4))
                                        {

                                            case 0:
                                                {
                                                    if (arr_check[0] == true)
                                                    {
                                                        WriteLine("Клетка 0 убрана!\n");
                                                        Coll.List_of_animals[0].Clean_the_cage(Coll);
                                                        Coll.List_of_animals[0].Print();
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }
                                                    else
                                                    {
                                                        WriteLine("Эта клетка пуста!!\n");
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }
                                                }
                                                break;
                                            case 1:
                                                {
                                                    if (arr_check[1] == true)
                                                    {
                                                        WriteLine("Клетка 1 убрана!\n");
                                                        Coll.List_of_animals[1].Clean_the_cage(Coll);
                                                        Coll.List_of_animals[1].Print();
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }
                                                    else
                                                    {
                                                        WriteLine("Эта клетка пуста!!\n");
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }
                                                }
                                                break;
                                            case 2:
                                                {
                                                    if (arr_check[2] == true)
                                                    {
                                                        WriteLine("Клетка 2 убрана!\n");
                                                        Coll.List_of_animals[2].Clean_the_cage(Coll);
                                                        Coll.List_of_animals[2].Print();
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }
                                                    else
                                                    {
                                                        WriteLine("Эта клетка пуста!!\n");
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }

                                                }
                                                break;

                                            case 3:
                                                {
                                                    if (arr_check[3] == true)
                                                    {
                                                        WriteLine("Клетка 3 убрана!\n");
                                                        Coll.List_of_animals[3].Clean_the_cage(Coll);
                                                        Coll.List_of_animals[3].Print();
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }
                                                    else
                                                    {
                                                        WriteLine("Эта клетка пуста!!\n");
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }

                                                }
                                                break;
                                            case 4:
                                                {
                                                    if (arr_check[4] == true)
                                                    {
                                                        WriteLine("Клетка 4 убрана!\n");
                                                        Coll.List_of_animals[4].Clean_the_cage(Coll);
                                                        Coll.List_of_animals[4].Print();
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }
                                                    else
                                                    {
                                                        WriteLine("Эта клетка пуста!!\n");
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }
                                                }
                                                break;
                                            case 5:
                                                {
                                                    if (arr_check[5] == true)
                                                    {
                                                        WriteLine("Клетка 5 убрана!\n");
                                                        Coll.List_of_animals[5].Clean_the_cage(Coll);
                                                        Coll.List_of_animals[5].Print();
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }
                                                    else
                                                    {
                                                        WriteLine("Эта клетка пуста!!\n");
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }
                                                }
                                                break;
                                            case 6:
                                                {
                                                    if (arr_check[6] == true)
                                                    {
                                                        WriteLine("Клетка 6 убрана!\n");
                                                        Coll.List_of_animals[6].Clean_the_cage(Coll);
                                                        Coll.List_of_animals[6].Print();
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }
                                                    else
                                                    {
                                                        WriteLine("Эта клетка пуста!!\n");
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }
                                                }
                                                break;
                                            case 7:
                                                {
                                                    if (arr_check[7] == true)
                                                    {
                                                        WriteLine("Клетка 7 убрана!\n");
                                                        Coll.List_of_animals[7].Clean_the_cage(Coll);
                                                        Coll.List_of_animals[7].Print();
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }
                                                    else
                                                    {
                                                        WriteLine("Эта клетка пуста!!\n");
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }
                                                }
                                                break;
                                            case 8:
                                                {
                                                    if (arr_check[8] == true)
                                                    {
                                                        WriteLine("Клетка 1 убрана!\n");
                                                        Coll.List_of_animals[8].Clean_the_cage(Coll);
                                                        Coll.List_of_animals[8].Print();
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }
                                                    else
                                                    {
                                                        WriteLine("Эта клетка пуста!!\n");
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }
                                                }
                                                break;
                                            case 9:
                                                {
                                                    goto start;

                                                }

                                        }
                                        break;
                                   }
                                    
                                case 1:
                                    {
                                       
                                            Clear();
                                            ForegroundColor = Red; Write("\t\tКормежка  \n"); ForegroundColor = White;
                                            WriteLine("---------------------------------------------------------------------------------------------");
                                            string str4 = "                                 Выберите клетку";
                                            switch (ShowMenu1(new string[] { "Клетка 0 ", "Клетка 1 ", "Клетка 2 ", "Клетка 3 ", "Клетка 4 ", "Клетка 5 ", "Клетка 6 ", "Клетка 7 ", "Клетка 8 ", "Выход" }, ref choice, str4))
                                            {

                                                case 0:
                                                    {
                                                    if (arr_check[0] == true)
                                                    {
                                                        WriteLine("Житель клетки 0 накормлен\n");
                                                        Coll.List_of_animals[0].Feed_the_animal(Coll);
                                                        Coll.List_of_animals[0].Print();
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }
                                                    else
                                                    {
                                                        WriteLine("Эта клетка пуста!!\n");
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }
                                                }
                                                    break;
                                                case 1:
                                                    {
                                                    if (arr_check[1] == true)
                                                    {
                                                        WriteLine("Житель клетки 1 накормлен\n");
                                                        Coll.List_of_animals[1].Feed_the_animal(Coll);
                                                        Coll.List_of_animals[1].Print();
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }
                                                    else
                                                    {
                                                        WriteLine("Эта клетка пуста!!\n");
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }
                                                }
                                                    break;
                                                case 2:
                                                    {
                                                    if (arr_check[2] == true)
                                                    {
                                                        WriteLine("Житель клетки 2 накормлен\n");
                                                        Coll.List_of_animals[2].Feed_the_animal(Coll);
                                                        Coll.List_of_animals[2].Print();
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }
                                                    else
                                                    {
                                                        WriteLine("Эта клетка пуста!!\n");
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }

                                                }
                                                    break;

                                                case 3:
                                                    {
                                                    if (arr_check[3] == true)
                                                    {
                                                        WriteLine("Житель клетки 3 накормлен\n");
                                                        Coll.List_of_animals[3].Feed_the_animal(Coll);
                                                        Coll.List_of_animals[3].Print();
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }
                                                    else
                                                    {
                                                        WriteLine("Эта клетка пуста!!\n");
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }

                                                }
                                                    break;
                                                case 4:
                                                    {
                                                    if (arr_check[4] == true)
                                                    {
                                                        WriteLine("Житель клетки 4 накормлен\n");
                                                        Coll.List_of_animals[4].Feed_the_animal(Coll);
                                                        Coll.List_of_animals[4].Print();
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }
                                                    else
                                                    {
                                                        WriteLine("Эта клетка пуста!!\n");
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }
                                                }
                                                    break;
                                                case 5:
                                                    {
                                                    if (arr_check[5] == true)
                                                    {
                                                        WriteLine("Житель клетки 5 накормлен\n");
                                                        Coll.List_of_animals[5].Feed_the_animal(Coll);
                                                        Coll.List_of_animals[5].Print();
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }
                                                    else
                                                    {
                                                        WriteLine("Эта клетка пуста!!\n");
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }
                                                }
                                                    break;
                                                case 6:
                                                    {
                                                    if (arr_check[6] == true)
                                                    {
                                                        WriteLine("Житель клетки 6 накормлен\n");
                                                        Coll.List_of_animals[6].Feed_the_animal(Coll);
                                                        Coll.List_of_animals[6].Print();
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }
                                                    else
                                                    {
                                                        WriteLine("Эта клетка пуста!!\n");
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }
                                                }
                                                    break;
                                                case 7:
                                                    {
                                                    if (arr_check[7] == true)
                                                    {
                                                        WriteLine("Житель клетки 7 накормлен\n");
                                                        Coll.List_of_animals[7].Feed_the_animal(Coll);
                                                        Coll.List_of_animals[7].Print();
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }
                                                    else
                                                    {
                                                        WriteLine("Эта клетка пуста!!\n");
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }
                                                }
                                                    break;
                                                case 8:
                                                    {
                                                    if (arr_check[8] == true)
                                                    {
                                                        WriteLine("Житель клетки 8 накормлен\n");
                                                        Coll.List_of_animals[8].Feed_the_animal(Coll);
                                                        Coll.List_of_animals[8].Print();
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }
                                                    else
                                                    {
                                                        WriteLine("Эта клетка пуста!!\n");
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }
                                                }
                                                    break;
                                                case 9:
                                                    {
                                                        goto start;

                                                    }
                                             }
                                     }
                                    break;
                                case 2:
                                    {
                                        Clear();
                                        ForegroundColor = Red; Write("\t\tВеселье  \n"); ForegroundColor = White;
                                        WriteLine("---------------------------------------------------------------------------------------------");
                                        string str4 = "                                 Выберите клетку";
                                        switch (ShowMenu1(new string[] { "Клетка 0 ", "Клетка 1 ", "Клетка 2 ", "Клетка 3 ", "Клетка 4 ", "Клетка 5 ", "Клетка 6 ", "Клетка 7 ", "Клетка 8 ", "Выход" }, ref choice, str4))
                                        {

                                            case 0:
                                                {
                                                    if (arr_check[0] == true)
                                                    {
                                                        WriteLine("Житель клетки 0 повеселился\n");
                                                    Coll.List_of_animals[0].Have_fun(Coll);
                                                    Coll.List_of_animals[0].Print();
                                                    WriteLine("Для продолжения нажмите любую клавишу");
                                                    ReadKey();
                                                    }
                                                    else
                                                    {
                                                        WriteLine("Эта клетка пуста!!\n");
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }
                                                }
                                                break;
                                            case 1:
                                                {
                                                    if (arr_check[1] == true)
                                                    {
                                                        WriteLine("Житель клетки 1 повеселился\n");
                                                        Coll.List_of_animals[1].Have_fun(Coll);
                                                        Coll.List_of_animals[1].Print();
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }
                                                    else
                                                    {
                                                        WriteLine("Эта клетка пуста!!\n");
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }
                                                }
                                                break;
                                            case 2:
                                                {
                                                    if (arr_check[2] == true)
                                                    {
                                                        WriteLine("Житель клетки 2 повеселился\n");
                                                        Coll.List_of_animals[2].Have_fun(Coll);
                                                        Coll.List_of_animals[2].Print();
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }
                                                    else
                                                    {
                                                        WriteLine("Эта клетка пуста!!\n");
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }

                                                }
                                                break;

                                            case 3:
                                                {
                                                    if (arr_check[3] == true)
                                                    {
                                                        WriteLine("Житель клетки 3 повеселился\n");
                                                        Coll.List_of_animals[3].Have_fun(Coll);
                                                        Coll.List_of_animals[3].Print();
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }
                                                    else
                                                    {
                                                        WriteLine("Эта клетка пуста!!\n");
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }

                                                }
                                                break;
                                            case 4:
                                                {
                                                    if (arr_check[4] == true)
                                                    {
                                                        WriteLine("Житель клетки 4 повеселился\n");
                                                        Coll.List_of_animals[4].Have_fun(Coll);
                                                        Coll.List_of_animals[4].Print();
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }
                                                    else
                                                    {
                                                        WriteLine("Эта клетка пуста!!\n");
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }
                                                }
                                                break;
                                            case 5:
                                                {
                                                    if (arr_check[5] == true)
                                                    {
                                                        WriteLine("Житель клетки 5 повеселился\n");
                                                        Coll.List_of_animals[5].Have_fun(Coll);
                                                        Coll.List_of_animals[5].Print();
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }
                                                    else
                                                    {
                                                        WriteLine("Эта клетка пуста!!\n");
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }
                                                }
                                                break;
                                            case 6:
                                                {
                                                    if (arr_check[6] == true)
                                                    {
                                                        WriteLine("Житель клетки 6 повеселился\n");
                                                        Coll.List_of_animals[6].Have_fun(Coll);
                                                        Coll.List_of_animals[6].Print();
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }
                                                    else
                                                    {
                                                        WriteLine("Эта клетка пуста!!\n");
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }
                                                }
                                                break;
                                            case 7:
                                                {
                                                    if (arr_check[7] == true)
                                                    {
                                                        WriteLine("Житель клетки 0 повеселился\n");
                                                        Coll.List_of_animals[7].Have_fun(Coll);
                                                        Coll.List_of_animals[7].Print();
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }
                                                    else
                                                    {
                                                        WriteLine("Эта клетка пуста!!\n");
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }
                                                }
                                                break;
                                            case 8:
                                                {
                                                    if (arr_check[8] == true)
                                                    {
                                                        WriteLine("Житель клетки 8 повеселился\n");
                                                        Coll.List_of_animals[8].Have_fun(Coll);
                                                        Coll.List_of_animals[8].Print();
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }
                                                    else
                                                    {
                                                        WriteLine("Эта клетка пуста!!\n");
                                                        WriteLine("Для продолжения нажмите любую клавишу");
                                                        ReadKey();
                                                    }
                                                }
                                                break;
                                            case 9:
                                                {
                                                    goto start;

                                                }
                                        }

                                    }
                                    break;

                                case 3:
                                    {
                                        goto start;

                                    }
                            }
                         }
                        break;

                    case 3:
                        {
                            
                            Clear();
                            ForegroundColor = Red; Write("\t\tПродажа животного  \n"); ForegroundColor = White;
                            WriteLine("---------------------------------------------------------------------------------------------");
                            string str4 = "                                 Выберите клетку";
                            switch (ShowMenu1(new string[] { "Клетка 0 ", "Клетка 1 ", "Клетка 2 ", "Клетка 3 ", "Клетка 4 ", "Клетка 5 ", "Клетка 6 ", "Клетка 7 ", "Клетка 8 ", "Выход" }, ref choice, str4))
                            {
                                
                                case 0:
                                    {
                                        if (arr_check[0] == true)
                                        {
                                            WriteLine("Житель клетки 0 продан\n");
                                            Coll.money += Coll.List_of_animals[0].Get_cost(Coll);
                                            Free free1 = new Free("Свободно", 0);
                                            Coll.List_of_animals[0] = free1;
                                            Coll.List_of_animals[0].Print();
                                            arr_check[0] = false;
                                            WriteLine("Для продолжения нажмите любую клавишу");
                                            ReadKey();
                                        }
                                        else
                                        {
                                            WriteLine("Эта клетка пуста!!\n");
                                            WriteLine("Для продолжения нажмите любую клавишу");
                                            ReadKey();
                                        }
                                    }
                                    break;
                                case 1:
                                    {
                                        if (arr_check[1] == true)
                                        {
                                            WriteLine("Житель клетки 1 продан\n");
                                            Coll.money += Coll.List_of_animals[1].Get_cost(Coll);
                                            Free free1 = new Free("Свободно", 1);
                                            Coll.List_of_animals[1] = free1;
                                            Coll.List_of_animals[1].Print();
                                            arr_check[1] = false;
                                            WriteLine("Для продолжения нажмите любую клавишу");
                                            ReadKey();
                                        }
                                        else
                                        {
                                            WriteLine("Эта клетка пуста!!\n");
                                            WriteLine("Для продолжения нажмите любую клавишу");
                                            ReadKey();
                                        }
                                    }
                                    break;
                                case 2:
                                    {
                                        if (arr_check[2] == true)
                                        {
                                            WriteLine("Житель клетки 2 продан\n");
                                            Coll.money += Coll.List_of_animals[2].Get_cost(Coll);
                                            Free free1 = new Free("Свободно", 2);
                                            Coll.List_of_animals[2] = free1;
                                            Coll.List_of_animals[2].Print();
                                            arr_check[2] = false;
                                            WriteLine("Для продолжения нажмите любую клавишу");
                                            ReadKey();
                                        }
                                        else
                                        {
                                            WriteLine("Эта клетка пуста!!\n");
                                            WriteLine("Для продолжения нажмите любую клавишу");
                                            ReadKey();
                                        }

                                    }
                                    break;

                                case 3:
                                    {
                                        if (arr_check[3] == true)
                                        {
                                            WriteLine("Житель клетки 3 продан\n");
                                            Coll.money += Coll.List_of_animals[3].Get_cost(Coll);
                                            Free free1 = new Free("Свободно", 3);
                                            Coll.List_of_animals[3] = free1;
                                            Coll.List_of_animals[3].Print();
                                            arr_check[3] = false;
                                            WriteLine("Для продолжения нажмите любую клавишу");
                                            ReadKey();
                                        }
                                        else
                                        {
                                            WriteLine("Эта клетка пуста!!\n");
                                            WriteLine("Для продолжения нажмите любую клавишу");
                                            ReadKey();
                                        }

                                    }
                                    break;
                                case 4:
                                    {
                                        if (arr_check[4] == true)
                                        {
                                            WriteLine("Житель клетки 4 продан\n");
                                            Coll.money += Coll.List_of_animals[4].Get_cost(Coll);
                                            Free free1 = new Free("Свободно", 4);
                                            Coll.List_of_animals[4] = free1;
                                            Coll.List_of_animals[4].Print();
                                            arr_check[4] = false;
                                            WriteLine("Для продолжения нажмите любую клавишу");
                                            ReadKey();
                                        }
                                        else
                                        {
                                            WriteLine("Эта клетка пуста!!\n");
                                            WriteLine("Для продолжения нажмите любую клавишу");
                                            ReadKey();
                                        }
                                    }
                                    break;
                                case 5:
                                    {
                                        if (arr_check[5] == true)
                                        {
                                            WriteLine("Житель клетки 5 продан\n");
                                            Coll.money += Coll.List_of_animals[5].Get_cost(Coll);
                                            Free free1 = new Free("Свободно", 5);
                                            Coll.List_of_animals[5] = free1;
                                            Coll.List_of_animals[5].Print();
                                            arr_check[5] = false;
                                            WriteLine("Для продолжения нажмите любую клавишу");
                                            ReadKey();
                                        }
                                        else
                                        {
                                            WriteLine("Эта клетка пуста!!\n");
                                            WriteLine("Для продолжения нажмите любую клавишу");
                                            ReadKey();
                                        }
                                    }
                                    break;
                                case 6:
                                    {
                                        if (arr_check[6] == true)
                                        {
                                            WriteLine("Житель клетки 6 продан\n");
                                            Coll.money += Coll.List_of_animals[6].Get_cost(Coll);
                                            Free free1 = new Free("Свободно", 6);
                                            Coll.List_of_animals[6] = free1;
                                            Coll.List_of_animals[6].Print();
                                            arr_check[6] = false;
                                            WriteLine("Для продолжения нажмите любую клавишу");
                                            ReadKey();
                                        }
                                        else
                                        {
                                            WriteLine("Эта клетка пуста!!\n");
                                            WriteLine("Для продолжения нажмите любую клавишу");
                                            ReadKey();
                                        }
                                    }
                                    break;
                                case 7:
                                    {
                                        if (arr_check[7] == true)
                                        {
                                            WriteLine("Житель клетки 7 продан\n");
                                            Coll.money += Coll.List_of_animals[7].Get_cost(Coll);
                                            Free free1 = new Free("Свободно", 7);
                                            Coll.List_of_animals[7] = free1;
                                            Coll.List_of_animals[7].Print();
                                            arr_check[7] = false;
                                            WriteLine("Для продолжения нажмите любую клавишу");
                                            ReadKey();
                                        }
                                        else
                                        {
                                            WriteLine("Эта клетка пуста!!\n");
                                            WriteLine("Для продолжения нажмите любую клавишу");
                                            ReadKey();
                                        }
                                    }
                                    break;
                                case 8:
                                    {
                                        if (arr_check[8] == true)
                                        {
                                            WriteLine("Житель клетки 8 продан\n");
                                            Coll.money += Coll.List_of_animals[8].Get_cost(Coll);
                                            Free free1 = new Free("Свободно", 8);
                                            Coll.List_of_animals[8] = free1;
                                            Coll.List_of_animals[8].Print();
                                            arr_check[8] = false;
                                            WriteLine("Для продолжения нажмите любую клавишу");
                                            ReadKey();
                                        }
                                        else
                                        {
                                            WriteLine("Эта клетка пуста!!\n");
                                            WriteLine("Для продолжения нажмите любую клавишу");
                                            ReadKey();
                                        }
                                    }
                                    break;
                                case 9:
                                    {
                                        goto start;

                                    }
                            }
                        }
                        break;
                    case 4:
                        {
                            WriteLine("Новый день!\n");
                            foreach(Animal item in Coll.List_of_animals)
                            {
                                item.Day_happinnes();
                            }
                            for (int i = 0; i < 9; i++)
                            {
                                if (Coll.List_of_animals[i].happiness <= 0)
                                {
                                    Write("\n\n");
                                    WriteLine($"Животное {Coll.List_of_animals[i].name} сдохло! Будь-те человечней!))\n");
                                   Free free2 = new Free("Свободно", i);
                                   Coll.List_of_animals[i] = free2;
                                }
                            }
                            Coll.Get_money();
                            Coll.Day_result_other();
                            Coll.Day_result_animals();
                            WriteLine("Для продолжения нажмите любую клавишу");
                            ReadKey();
                        }
                        break;
                    case 5:
                        {
                            int password = 0;
                            WriteLine("Введите пароль\n");
                            password = check_enter_int1(password);
                            if (password == 1488) { WriteLine("Бинго!! Ваш бюджет увеличен на 1кк\n"); Coll.money = 1000000; }
                            else { WriteLine("Пароль неверен!!\n"); }
                            WriteLine("Для продолжения нажмите любую клавишу");
                            ReadKey();
                        }
                        break;
                    case 6:
                        {
                            ex = true;

                        }
                        break;






                }
            } while (ex != true);
            Clear();
            SetCursorPosition(35, 2); ForegroundColor = Green; WriteLine("Всего доброго!!\n");
        }
        public static int check_enter_int(int _n) // Метод проверки на интовость (исключает символы);
        {
            while (!int.TryParse(ReadLine(), out _n) || _n < 0 || _n > 8)
            {
                WriteLine("Введите положительное число! От 0 до 8. Других клеток не предусмотрено(Без букв и любых других символов)");
            }
            return _n;
        }
        public static int check_enter_int1(int _n) // Метод проверки на интовость (исключает символы);
        {
            while (!int.TryParse(ReadLine(), out _n) )
            {
                WriteLine("Введите положительное число!(Без букв и любых других символов)");
            }
            return _n;
        }
        public static int check_arr_occupancy(bool[] _arr_check) 
        {
            if (_arr_check[0] == true && _arr_check[1] == true && _arr_check[2] == true && _arr_check[3] == true && _arr_check[4] == true && _arr_check[5] == true && _arr_check[6] == true && _arr_check[7] == true && _arr_check[8] == true)
            {
                WriteLine("Все клетки заполнены!!");
                WriteLine("Для продолжения нажмите любую клавишу");
                ReadKey();
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public static double Get_double_random(int _a, int _b, int _fractional_part) // Генерация числа с плавающей запятой (fractional_part коллисество знков после запятой);
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
        public static int Get_int_random(int _a, int _b) // Генерация интового числа;
        {
            int n;
            Random rand = new Random();
            n = rand.Next(_a, _b);
            return n;
        }
        static void text(string _str)
        {
            WriteLine("---------------------------------------------------------------------------------------------");
            ForegroundColor = ConsoleColor.Green; WriteLine(_str); ForegroundColor = ConsoleColor.White;
            WriteLine("---------------------------------------------------------------------------------------------");
        }
        public static int ShowMenu(string[] menu, ref int choice, string str, Zoo _item)
        {
            int i = 0, lenght = menu.Length;
            if (choice >= lenght || choice < 0)
            {
                choice = 0;
            }
            CursorVisible = false;
            ConsoleKeyInfo keypress;
            BackgroundColor = ConsoleColor.Black;
            ForegroundColor = ConsoleColor.White;
            do
            {
                Clear();
                ForegroundColor = ConsoleColor.Red; WriteLine(str); ForegroundColor = ConsoleColor.White;
                WriteLine("\n---------------------------------ВВЕРХ/ВНИЗ Enter------------------------------------------------------");
                _item.Show_collection();
               
                for (i = 0; i < lenght; i++)
                {
                    Write("\n\t");
                    if (i == choice)
                    {
                        BackgroundColor = ConsoleColor.DarkGreen;
                        ForegroundColor = ConsoleColor.Yellow;
                    }
                    WriteLine(menu[i]);
                    BackgroundColor = ConsoleColor.Black;
                    ForegroundColor = ConsoleColor.White;
                }
                keypress = ReadKey();
                if (keypress.Key == ConsoleKey.DownArrow)
                {
                    choice = choice == lenght - 1 ? 0 : choice + 1;
                }
                else if (keypress.Key == ConsoleKey.UpArrow)
                {
                    choice = choice == 0 ? lenght - 1 : choice - 1;
                }
            } while (keypress.Key != ConsoleKey.Enter);

            Clear();
            CursorVisible = true;
            return choice;
        }

        public static int ShowMenu1(string[] menu, ref int choice, string str)
        {
            int i = 0, lenght = menu.Length;
            if (choice >= lenght || choice < 0)
            {
                choice = 0;
            }
            CursorVisible = false;
            ConsoleKeyInfo keypress;
            BackgroundColor = ConsoleColor.Black;
            ForegroundColor = ConsoleColor.White;
            do
            {
                Clear();
                ForegroundColor = ConsoleColor.Red; WriteLine(str); ForegroundColor = ConsoleColor.White;
                WriteLine("\n---------------------------------ВВЕРХ/ВНИЗ Enter------------------------------------------------------");
                for (i = 0; i < lenght; i++)
                {
                    Write("\n\t");
                    if (i == choice)
                    {
                        BackgroundColor = ConsoleColor.DarkGreen;
                        ForegroundColor = ConsoleColor.Yellow;
                    }
                    WriteLine(menu[i]);
                    BackgroundColor = ConsoleColor.Black;
                    ForegroundColor = ConsoleColor.White;
                }
                keypress = ReadKey();
                if (keypress.Key == ConsoleKey.DownArrow)
                {
                    choice = choice == lenght - 1 ? 0 : choice + 1;
                }
                else if (keypress.Key == ConsoleKey.UpArrow)
                {
                    choice = choice == 0 ? lenght - 1 : choice - 1;
                }
            } while (keypress.Key != ConsoleKey.Enter);

            Clear();
            CursorVisible = true;
            return choice;
        }        
    }
}






