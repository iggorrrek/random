using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> students = new List<string>
        {
            "Берсенев Семён",
            "Мингалев Андрей",
            "Джумакулыев Алиджан",
            "Новоселова Ульяна",
            "Балобанова Арина",
            "Прокофьева Софья",
            "Спиридонова Весна",
            "Габов Алексей",
            "Хисматуллин Адель",
            "Минушина Алия",
            "Тырышкин Александр",
            "Рахматуллина Алия",
            "Каштанов Радмир",
            "Муллагалиев Амир",
            "Пушкина Анжела",
            "Шакиров Эмиль",
            "Шамкина Карина",
            "Халикова Дана",
            "Назарова Дарья",
            "Шайхутдинова Алина",
            "Гараева Диляра",
            "Харламова Анна",
            "Новикова Анастасия",
            "Сабирова Далия",
            "Фазылов Раис",
            "Меркулова Софья",
            "Доражан Андрей",
            "Верхотурова Арина",
            "Парышева Анна",
            "Пигуляк Роман",
            "Валетдинов Данис",
            "Целоусов Игорь",
            "Осипов Семён",
            "Валеев Сергей",
            "Хубайбуллина Зарина",
            "Лисюткина Руслана",
            "Гафуров Камиль",
            "Калимуллин Алмаз",
            "Кузьмина Анастасия",
            "Гиндуллин Марат",
            "Маркелов Михаил",
            "Гуро Руслан",
            "Юмагулова Анна",
            "Закиров Айназ",
            "Шамсутдинов Нурсултан",
            "Квятковский Всеволод",
            "Гомза Арина",
            "Садриев Салават",
            "Боронин Никита"
        };
        HashSet<int> randomNumbers = new HashSet<int>();
        Random rnd = new Random();
        while (randomNumbers.Count < students.Count)
        {
            int number = rnd.Next(1, 50); 
            if (!randomNumbers.Contains(number))
                randomNumbers.Add(number);
        }
        var sortedRandomNumbers = randomNumbers.ToList();
        string filePath = "randonSpisok.txt";
        using (StreamWriter writer = File.CreateText(filePath))
        {
            for (int i = 0; i < students.Count; i++)
            {
                writer.WriteLine($" {students[i]} - {sortedRandomNumbers[i]}");
            }
        }
        
    }
}
