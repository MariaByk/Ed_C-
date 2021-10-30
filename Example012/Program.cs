// Разложите натуральное число n на простые 
// множители и определите сколько раз встречается 
// множитель 2 в произведении
// наименьший множитель произведения
// сколько различных множителей в произведении

// 1. Натуральное число
// 2. Что такое разложение на множители
// 3. Как сделать подсчет нужного множителя

// Как ввести число n=12;
// Как получить разбиение на простые множители
// как сделать подсчет нужного множителя

int n = 288; // 1..2_147_000_000
// if (n < 1) Console.WriteLine ("Число не натуральное");

int[] simpleNumber = {2, 3, 5, 7, 11, 13, 17};
int index = 0;
int length = simpleNumber.Length;
int count = 0;     
   
 while (n > 1)
 {
     while (index < length)
     {
         if (n % simpleNumber[index] == 0)
         {
             //Console.WriteLine(simpleNumber[index]);
             if (simpleNumber[index] == 2)
             {
                 count++;
             }
             n = n / simpleNumber [index];

         }
         else
         {
             index++;
         }
     }

 }
 Console.WriteLine(count);
