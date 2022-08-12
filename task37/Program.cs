//



int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRang)
{
Random rand = new Random();
int[] arr = new int [size];

for ( int i = 0; i< arr.Length; i++)
{
    arr [i] = rand.Next(leftRange,rightRang + 1);
}
return arr;
}
int[] array = FillArrayWithRandomNumbers(5,-5,8);

int newLength = array.Length % 2 + array.Length / 2; // прибавили целую часть от деления на 2 и процент от деления на 2 если он есть.

int[] newArray = new int [newLength] //выделяем пямать под переменную newLength

for (int i=0; i < array.Length /2; i++)

for (int i=0; i<array.Length; i++)

{

newArray[i] = array[i]* array[array.Length -1 -i];
}
if ()
