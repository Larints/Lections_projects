Console.WriteLine("Задачка про двух друзей и собаку "); // Вывод текста самой задачки
Console. WriteLine("Введите скорость первого друга: "); // Просим пользователя ввести скорость первого друга
string firstFriendSpeed = Console.ReadLine(); // Пользователь вводит значение скорости первого друга
int firstFS = Convert.ToInt32(firstFriendSpeed); // Конвертируем строку в численное значение
Console. WriteLine("Введите скорость второго друга: "); // Просим пользователя ввести скорость второго друга
string secondFriendSpeed = Console.ReadLine(); // Пользователь вводит значение скорости второго друга
int secondFS = Convert.ToInt32(secondFriendSpeed); // Конвертируем строку в численное значение
Console. WriteLine("Введите скорость собаки: "); // Просим пользователя ввести скорость собаки
string dogSpeed = Console.ReadLine(); // Вводим значение скорости собаки
int dogS = Convert.ToInt32(dogSpeed); // Конвертируем скорость собаки в числовое значение
Console. WriteLine("Введите расстояние между друзьями (в метрах):"); 
string distance = Console.ReadLine();
int dc = Convert.ToInt32(distance);
int count = 0;
int time = 0;
int friend = 2;

while(dc > 10)
{
    if (friend == 1)
    {
        time = dc/(firstFS + dogS);
        friend = 2;
    }
    else
    {
        time = dc/(secondFS + dogS);
        friend = 1;
    }
    dc = dc - (firstFS + secondFS) * time;
    count++;
}
 Console.WriteLine(count);