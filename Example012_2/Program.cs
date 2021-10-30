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

int MinCounter(int n)
{
int[] simpleNumber = {2, 3, 5, 7, 11, 13, 17};
int index = 0;
     
 while (n > 1)
 {
  if (n % simpleNumber[index] == 0)
        {
        break;
        }
         else
         {
             index++;
         }
     }
     return(simpleNumber[index]);
}



int DiffCounter(int n)
{
int[] simpleNumber = {2, 3, 5, 7, 11, 13, 17};
int index = 0;
int count = 0;
bool newcount = true;
     
 while (n > 1)
 {
  if (n % simpleNumber[index] == 0)
    {
    n = n / simpleNumber[index];
    if (newcount == true)
    {
        count++;
        newcount = false;
        
    }
    else
         {
          newcount = true;
          index++;
         }
     }
     
}
return count;
}
int result1 = MinCounter(333);
int result2 = DiffCounter(333);
Console.WriteLine(result1);
Console.WriteLine(result2);