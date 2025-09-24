//int[] numbers;
////длина массива
//int[] nums = new int[4];
//int[] numbers = [1, 2, 3, 5];
//Console.WriteLine(numbers[3]);
//var n = numbers[1];
//Console.WriteLine(n);

//numbers[1] = 505;
//Console.WriteLine(numbers[6]);
//Console.WriteLine(numbers.Length);
//Console.WriteLine(numbers[numbers.Length - 1]);
//Console.WriteLine(numbers[^1]);

//foreach (int i in numbers)
//{
//    Console.WriteLine(i);
//}
//int[] nums1 = [0, 1, 2, 3, 4, 5];
//int[,] nums2 = { { 0, 1, 2 }, { 3, 4, 5 } };
//foreach (int i in nums2)
//{
//    Console.WriteLine(i);
//}

//int[] numbers = [-1, -2, -3, 4, 5, -6, 0, 43, 56, -34];
/*
 * ИЩЕМ ЧИСЛА БОЛЬШЕ НУЛЯ
 */
//int result = 0;
//foreach (int number in numbers)
//{
//    if (number >= 0)
//        result++;
//}
//Console.WriteLine($"Число элементов больше нуля: {result}");
/*
 *  ИНВЕРСИЯ
 */
//int n = numbers.Length;
//int k = n / 2;
//int temp;
//for (int i = 0; i < k; i++)
//{
//    temp = numbers[i];
//    numbers[i] = numbers[n - i - 1];
//    numbers[n - i - 1] = temp;
//}
//foreach (int i in numbers)
//{
//    Console.Write($"{i}\t");
//}

//int[] nums = [54, 7, -41, 2, 4, 2, 89, 33, -5, 12];
//int temp;
//for (int i = 0; i < nums.Length - 1; i++)
//{
//    for (int j = 0; j < nums.Length; j++)
//    {
//        if (nums[i] > nums[j])
//        {
//            temp = nums[i];
//            nums[i] = nums[j];
//            nums[j] = temp;
//        }
//    }
//}
//Console.WriteLine("Вывод отсортированного массива");
//for (int i = 0; i < nums.Length; i++)
//{
//    Console.WriteLine(nums[i]);
//}

//List<string> people = new List<string>();
//List<string> student = new List<string>()
//{"Иван","Игорь","Александр" };

//List<string> student = ["Билли", "Игорь", "Степан"];
//string firstStudent = student[0];
//Console.WriteLine(firstStudent);
//student[0] = "Богдан";
//Console.WriteLine(student[0]);

//Console.WriteLine(student.Count);

//foreach (var person in student)
//{
//    Console.WriteLine(person);
//}

//student.Add("Van");
//student.AddRange(["Антон", "Денис"]);
//student.Insert(1, "Кирилл");
//student.InsertRange(1, ["Mike", "Kate"]);

//student.Insert(7, "Михаил");
//foreach (var person in student)
//{
//    Console.WriteLine(person);
//}
/*
 * zad1
 */
//string[] mas = ["sword", "shield", "potion", "sword", "potion", "potion"];
//foreach (string i in mas)
//{
//    Console.WriteLine(i);
//}
/*
 * zad2
 */
//int[] mas = [10, 20, 25, 30, 15];
//int temp = 0;
//foreach (int i in mas)
//{
//    if (i > 0)
//    {
//        temp += i;  
//    }
//}
//Console.WriteLine(temp);
/*
 * zad3
 */
//int[] massiv = [ 1, 3, 7, 2, 5 ];
//int max = massiv[0];
//for (int i = 0; i < massiv.Length; i++)
//{
//    if (massiv[i] > max)
//    {
//        max = massiv[i];
//    }
//}
//Console.WriteLine($"Максимальный элемент: {max}");
/*
 * zad4
 */
//int[] massiv = [1, 2, 3, 4, 5];
//int res1 = 0;
//int res2 = 0;
//foreach (int number in massiv)
//{
//    if (number % 2 == 0)
//        res1++;
//    else
//        res2++;
//}
//Console.WriteLine($"Чётные числа: {res1}");
//Console.WriteLine($"Нечётные числа: {res2}");
/*
 * zad5
 */
//int[] mass = [120, 95, 110, 105, 100];
//int min = mass[0];
//for (int i = 0; i < mass.Length; i++)
//{
//    if (mass[i] < min)
//    {
//        min = mass[i];
//    }
//}
//Console.WriteLine($"Самое быстрое время: {min}");
/*
 * zad6
 */
//string[] mass = ["win", "loss", "win", "win", "loss"];
//int res1 = 0;
//int res2 = 0;
//foreach (string zet in mass)
//{
//    if (zet == "win")
//    {
//        res1++;
//    }
//    else
//    {
//        res2++;
//    }
//}
//Console.WriteLine($"Число побед: {res1}");
//Console.WriteLine($"Число поражений: {res2}");
/*
 * zad7
 */
//int[] mas = [15, 20, 25, 30, 10];
//int temp = 0;
//int res = 0;
//foreach(int num in mas)
//{
//    temp += num;
//    res = temp / mas.Length;
//}
//Console.WriteLine(res);
/*
 * zad8
 */
//List<string> inventar = ["Меч", "Ласточка", "Бомба", "Зелье Гром", "Ласточка"];
//for (int i = 0; i < inventar.Count; i++)
//{
//    if (inventar[i] == "Ласточка")
//    {
//        inventar[i] = "Кошка";
//    }
//}
//foreach (var res in inventar)
//{
//    Console.WriteLine(res);
//}
/*
 * zad9
 */
//List<string> person = ["Garrus", "Tali", "Mordin", "Grunt", "Jack"];
//List<string> rol = ["Лидер команды", "Техник", "Биотик", "Солдат",
//    "Поддержка"];
//for (int i = 0; i < person.Count && i < rol.Count; i++)
//{
//    Console.WriteLine($"{rol[i]}: {person[i]}");
//}

