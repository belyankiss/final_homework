// Ввод исходного массива строк с клавиатуры
Console.WriteLine("Введите элементы массива, каждый с новой строки (для завершения введите пустую строку):");
string input;
string[] originalArray = new string[100]; // Предполагаем, что введется не более 100 строк
int count = 0;
while (!string.IsNullOrWhiteSpace(input = Console.ReadLine() !))
{
    originalArray[count++] = input;
}

// Формирование нового массива из строк длиной не более 3 символов
string[] newArray = new string[count]; // Создаем новый массив с размером, соответствующим количеству введенных строк
int newIndex = 0;
for (int i = 0; i < count; i++)
{
    if (originalArray[i].Length <= 3)
    {
        newArray[newIndex++] = originalArray[i];
    }
}

// Вывод нового массива
Console.WriteLine("Новый массив строк, длина которых не более 3 символов:");
for (int i = 0; i < newIndex; i++)
{
    Console.WriteLine(newArray[i]);
}