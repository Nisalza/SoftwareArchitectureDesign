using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_Observer
{
    //Вариант 4.
    //Подписка на новости, журналы и т.д.Издатели хранят динамический список клиентов, которым нужно отправить определенный контент.
    //Клиенты могут добавляться в список и удаляться из него динамически.
    class Program
    {
        static void Main(string[] args)
        {
            //Наблюдатель
            NewsObservable newsProvider = new NewsObservable();

            //Пользователи
            NewsObserver user1 = new NewsObserver(1, "Студент1");
            NewsObserver user2 = new NewsObserver(2, "Студент2");
            NewsObserver user3 = new NewsObserver(3, "Студент3");

            //События
            newsProvider.AddObserver(user1);
            newsProvider.AddObserver(user2);
            newsProvider.AddObserver(user3);
            newsProvider.SendMessage($"Отчёт по практике необходимо сдать к 1 июня.");
            newsProvider.RemoveObserver(user3);
            newsProvider.SendMessage($"Первый экзамен состоится 10 июня по дисциплине [Введение в машинное обучение].");
            newsProvider.RemoveObserver(user2);

            Console.ReadKey();
        }
    }
}
