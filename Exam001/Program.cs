Console.Write("Введите несколько чисел(через пробел): ");
string phrase = Console.ReadLine();
string[] words = phrase.Split(' ');
int[] numbers = new int[words.Length];
for (int i = 0; i < words.Length; i++)
{
    numbers[i] = int.Parse(words[i]);
}

int count = 0;
int size = numbers.Length;
for (int i = 0; i < size; i++)
{
    if (numbers[i] > 0)
    {
        count ++;
    }
}

Console.WriteLine("Количество чисел больше нуля: " + count);