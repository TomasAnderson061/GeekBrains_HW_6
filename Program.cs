/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
int [] CreateArray(int size) {
    int [] array=new int[size];
        for(int i=0; i<size; i++)
        {   Console.WriteLine($"Введите {i+1}-е числo: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
    return array;
}
int CountAboveZero(int [] array) {
    int cas=0;
        for(int i=0; i<array.Length; i++){
        if (array[i]>0)
        cas++;
    }    
    return cas;
}
 void ShowArray(int [] array){
    for (int i=0; i<array.Length; i++)
        Console.Write($"{array[i]}, ");
}
Console.WriteLine("Введите кол-во чисел: ");
int M = Convert.ToInt32(Console.ReadLine());
int [] array = CreateArray(M);
Console.Write($"В введенных числах: "); 
ShowArray(array);
Console.WriteLine($"больше нуля {CountAboveZero(array)} чис-ло(-ла/-ел).");


/*Задача 43: Напишите программу, которая найдёт точку пересечения
двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
Console.WriteLine("Нахождение точки пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2");
double k1, k2, b1, b2, x0, y0;
Console.WriteLine("Введите k1: ");
k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b1: ");
b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2: ");
k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2: ");
b2 = Convert.ToDouble(Console.ReadLine());
x0=(b2-b1)/(k1-k2);
y0=k1*x0+b1;
Console.WriteLine($"Точка пересечения двух прямых y={k1}*x+{b1}, y={k2}*x+{b2} есть ({x0};{y0})");


Console.WriteLine("Нахождение точки пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2");
double [,] array1 = new double [2,2];
string [,] arrayBK = new string [2,2];
arrayBK [0,0] = "b1"; arrayBK [0,1]= "k1"; arrayBK [1,0]="b2"; arrayBK [1,1]="k2";
for (int i = 0; i < 2; i++){
   for (int j = 0; j < 2; j++){
       Console.WriteLine($"Введите {arrayBK[i,j]}:"); 
       array1[i,j]=Convert.ToDouble(Console.ReadLine());
   }
}
double x00=(array1[1,0]-array1[0,0])/(array1[0,1]-array1[1,1]);
double y00=array1[0,1]*x0+array1[0,0];
Console.WriteLine($"Точка пересечения двух прямых y={arrayBK [0,1]}*x+{arrayBK [0,0]}, y={arrayBK [1,1]}*x+{arrayBK [1,0]} есть ({x00};{y00})");