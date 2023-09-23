// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
string[] arr = {"Hello", "2", "world", ":-)"};

//string[] arr = {"1234", "1567", "-2", "computer scienc"};


//string[] arr = {"Russia", "Denmark", "Kazan"};


int count = 0;
int FillMatrixWhitNumbers(string [] arr)
{

   

      for (int i = 0; i < arr.Length; i++)

        {

          if (arr[i].Length<=3) count++;
          
          
        }
       
        return (count);

        
}

FillMatrixWhitNumbers(arr);


string [] Arr = new string[count]; 

 void PrintResultMatrix(string [] Arr,string [] arr)
{
Console.Write("[");

     count = 0;

      for (int i = 0; i <= 3; i++)

        {

          if (arr[i].Length<=3)

          {    

          Arr[count] = arr[i];

          Console.Write($"{Arr[count]},"); 
          
          
          count++;
          
          }
        }

Console.Write("]");

}

if (count > 0)

PrintResultMatrix(Arr,arr);

else 

 Console.WriteLine("[]"); 