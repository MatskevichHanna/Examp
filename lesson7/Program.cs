// // Задача: собрать строку с числами от a до b, a <= b
// string NumbersFor(int a, int b)
// {
//     string result = string.Empty;
//     for (int i = a; i <= b; i++)
//     {
//         result += $"{i} ";
//     }
//     return result;
// }
// string NumbersRec(int a, int b)
// {
//     if(a <= b) return $"{a} " + NumbersRec(a + 1, b);
//     else return String.Empty;
// }
// Console.WriteLine(NumbersFor(1, 10));
// Console.WriteLine(NumbersRec(1, 10));

// // Задача: сумма чисел от 1 до n
// int SumFor(int n)
// {
//     int result = 0;
//     for(int i = 1; i < n; i ++) result += i;
//     return result;
// }
// int SumRec(int n)
// {
//     if(n == 0) return 0;
//     else return n + SumRec(n - 1);
// }
// Console.WriteLine(SumFor(10));
// Console.WriteLine(SumRec(10));

// //Задача: факториал числа
// int FactorialFor(int n)
// {
//     int result = 1;
//     for(int i = 1; i <= n; i ++) result *= i;
//     return result;
// }
// int FactorialRec(int n)
// {
//     if(n == 1) return 1;
//     else return n * FactorialRec(n - 1);
// }
// Console.WriteLine(FactorialFor(10));
// Console.WriteLine(FactorialRec(10));

// //Задача: вычислить a в степени n
// int PowerFor(int a, int n)
// {
//     int result = 1;
//     for(int i = 1; i <= n; i ++) result *= a;
//     return result;
// }
// int PowerRec(int a, int n)
// {
//     //return n == 0 ? 1 : PowerRec(a, n - 1) * a;
//     if(n == 0) return 1;
//     else return PowerRec(a, n - 1) * a;
// }
// int PowerRecMath(int a, int n)
// {
//     if(n == 0) return 1;
//     else if(n % 2 == 0) return PowerRecMath(a * a, n / 2);
//     else return PowerRecMath(a, n - 1) * a;
// }
// Console.WriteLine(PowerFor(2, 10));
// Console.WriteLine(PowerRec(2, 10));
// Console.WriteLine(PowerRecMath(2, 10));

// //Задача: перебор слов. В некотором машинном алфавите имеются 4 буквы: а, и, с, в. 
// // Покажите все слова, состоящие из Т букв, которые можно построить из букв этого алфавита.
// int n = 0;
// void FindWords(string alphabet, char[] word, int length = 0)
// {
//     if(length == word.Length)
//     {
//         Console.WriteLine($"{n++} {new String(word)}"); return;
//     }
//     for (int i = 0; i < alphabet.Length; i++)
//     {
//         word[length] = alphabet[i];
//         FindWords(alphabet, word, length +1);
//     }
// }
// FindWords("аисв", new char[2]);

// // Задача: как посмотреть содержимое папки?
// string path = "C:\Users\Lenovo\Desktop\repo\Examples";
// DirectoryInfo di = new DirectoryInfo(path);
// System.Console.WriteLine(di.CreationTime);
// FileInfo fi = di.GetFiles();
// for (int i = 0; i < fi.Length; i++)
// {
//     System.Console.WriteLine(fi[i].Name);
// }

// // Задача: опишем рекурсию, которая будет ходить по папкам и рассматривать что там внутри
// void CatalogInfo(string path, string indent = "")
// {
//     DirectoryInfo catalog = new DirectoryInfo(path);
//     DirectoryInfo[] catalogs = catalog.GetDirectories();
//     for (int i = 0; i < catalogs.Length; i++)
//     {
//         Console.WriteLine($"{indent} {catalogs[i].Name} ");
//         CatalogInfo(catalogs[i].FullName, indent + " ");
//     }
//     FileInfo[] files = catalog.GetFiles();
//     for (int i = 0; i < files.Length; i++)
//     {
//         Console.WriteLine($"{indent} {files[i].Name} ");
//     }
// }
// string path = "C:\Users\Lenovo\Desktop\repo\Examples\008function";
// CatalogInfo(path);

// // Задача: игра в пирамидки
// void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
// {
//     if(count > 1) Towers(with, some, on, count - 1);
//     Console.WriteLine($"{with} >> {on}");
//     if(count > 1) Towers(some, on, with, count - 1);
// }
// Towers();

// // Задача: обход разных структур ((4 - 2) * (1 + 3)) / 10
// string emp = String.Empty;
// string[] tree = {emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3"};
// void InOrderTraversal(int pos = 1)
// {
//     if(pos < tree.Length)
//     {
//         int left = 2 * pos;
//         int rigth = 2 * pos + 1;
//         if(left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
//         Console.WriteLine(tree[pos]);
//         if(rigth < tree.Length && !String.IsNullOrEmpty(tree[rigth])) InOrderTraversal(rigth);
//     }
// }
// InOrderTraversal();

// // Задача: подсчет чисел Фибоначчи
// decimal fRec = 0;
// decimal fIte = 0;
// decimal FibonacciRecursion(int n)
// {
//     fRec++;
//     return n == 0 || n == 1 ? 1 : FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
// }
// decimal FibonacciIteration(int n)
// {
//     fIte++;
//     decimal result = 1;
//     decimal f0 = 1;
//     decimal f1 = 1;
//     for (int i = 2; i < n; i++)
//     {
//         result = f0 + f1;
//         f0 = f1;
//         f1 = result;
//         fIte ++;
//     }
//     return result;
// }
// // # 1 2 3 4 5 6
// // V 1 1 2 3 5 8
// Console.ReadLine();
// DateTime dt = DateTime.Now;

// for (int n = 10; n < 40; n++)
// {
//     Console.WriteLine($"FibonacciIteration({n}) = {FibonacciIteration(n)} fIte = {fIte}");
//     fIte = 0;
// }
// System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);
// Console.WriteLine();
// Console.ReadLine();
// for (int n = 10; n < 40; n++)
// {
//     Console.WriteLine($"FibonacciRecursion({n}) = {FibonacciRecursion(n)} fRec = {fRec}");
//     fRec = 0;
// }
// Console.ReadLine();

// Задача: показать почему плохо работает рекурсия, рисуем квадратик
int[,] pic = new int[10, 10];
for (int i = 0; i < 10; i++)
{
    pic[0, i] = 1;
    pic[i, 0] = 1;
    pic[i, 9] = 1;
    pic[9, i] = 1;
}
PrintImage(pic);
FillImage(1, 1);
Console.WriteLine();
PrintImage(pic);
void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            // Console.Write($"{image[i, j]}");
            if(image[i, j] == 0) Console.Write($" ");
            else Console.Write($"+");
        }
        Console.WriteLine();
    }
}
void FillImage(int row, int col)
{
    if(pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row - 1, col);
        FillImage(row, col - 1);
        FillImage(row + 1, col);
        FillImage(row, col + 1);
    }
}