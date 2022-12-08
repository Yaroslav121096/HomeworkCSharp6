Console.Clear();
Console.WriteLine("Какое количество чисел Вы введёте? ");
int numbers = Convert.ToInt32(Console.ReadLine());
int[] numberStorage = new int[numbers];
for (int i = 0; i < numberStorage.Length; i++)
{
    Console.WriteLine($"Введите {i + 1} число: ");
    numberStorage[i] = Convert.ToInt32(Console.ReadLine());
}
int count = 0;
for (int i = 0; i < numberStorage.Length; i++)
{
    if (numberStorage[i] > 0)
        count++;
}
Console.Clear();
Console.WriteLine($"Заданные числа: {string.Join(", ", numberStorage)}");
Console.WriteLine($"Количество чисел больше нуля, введенных вами: {count}.");