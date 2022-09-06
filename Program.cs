// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

// int [] CreateRandomArray (int size, int min, int max)               
// {
//     int [] newArray = new int [size];
//     for (int i = 0; i < size; i++)
//     newArray [i] = new Random().Next (min, max +1 );
//     return newArray;
// }
// void ShowArray (int [] array)                                               

// {
//     for (int i = 0; i < array.Length; i++)
//         Console.Write (array [i] + " *  ");    
//     Console.WriteLine();    
// }
// int [] ReverseArray (int [] array)
// {

// for ( int i = 0, j = array.Length -1; i < j; i++, j--)
// {
//     int temp = array[i];
//     array [i] = array [j];
//    array [j] = temp; 
// }

// return array; 
// }

// Console.Write("введите размер массива" );  
// int size = Convert.ToInt32 ( Console.ReadLine());
// Console.Write("введите мин возможное значние " );  
// int min = Convert.ToInt32 ( Console.ReadLine());
// Console.Write("введите макс  возможное значние" );  
// int max = Convert.ToInt32 ( Console.ReadLine());

// int[] newArray = CreateRandomArray (size, min , max);
// ShowArray (newArray);
// newArray = ReverseArray (newArray);
// ShowArray (newArray);






                   // ЗАДАЧИ В ЗАЛЕ 

// ЗАДАЧА 1
// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины. a < b + c
// через bool решаеться 




// bool Metod (int a, int b,  int c)
// {



//     if (a < b + c)
//         if (b < a + c)
//             if (c < b + c)
//                 return true;

//     return false;
// }
//      void ShowBool (bool result)
//      {
//         if (result == false)
//         Console.Write("is no" );  
//          if (result == true)
//         Console.Write("is yes " );  
//         Console.WriteLine();


//      }
// Console.Write("enter a side " );  
// int a = Convert.ToInt32 ( Console.ReadLine());
// Console.Write("enter a side " );  
// int b = Convert.ToInt32 ( Console.ReadLine());
// Console.Write("enter a side " );  
// int c = Convert.ToInt32 ( Console.ReadLine());

// bool answ = Metod (a, b, c);
// ShowBool (answ);

    
        






//  ЗАДАЧА 2
//  Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.  F(n) = F(n-1) + F(n-2)
// на вход метод берет 3 числа ( сколько чисел и 2 аругумента) возвращает метод - массив ( массив инт)


int [] Fed (int n, int a, int b)
{
    int[] febResult = new int [n];
    febResult [0] = a;
    febResult [1] = b;
    

    for ( int i = 2; i<n; i++);
        {
            febResult [1] = febResult [i - 1] + febResult [i - 2];

        }

        return febResult;
}


void ShowArray (int [] array)     
{
Console.WriteLine ("answer");  
    for (int i = 0; i < array.Length; i++)

        Console.Write (array [i] + " *  ");    
    Console.WriteLine();    
}


Console.Write("enter n " );  
int n = Convert.ToInt32 ( Console.ReadLine());
Console.Write("enter n " );  
int b = Convert.ToInt32 ( Console.ReadLine());
Console.Write("enter n  " );  
int a = Convert.ToInt32 ( Console.ReadLine());

ShowArray(Fed (n, a , b));



// ЗАДАЧА 3 
// Напишите программу, которая будет преобразовывать десятичное число в двоичное. двоичное из 2 чисел обычное от 0 до 9 возвращаем string string = new string + string;
// принимать число возвращаем строку 

string Metod (int num)
{
    string answer = string.Empty;
    for ( int i = 0; i < num; i++)
    {
        answer = 
    }
}