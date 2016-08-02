using OpenQA.Selenium;
using Core.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

/*2.	Предусмотреть следующие части:
a.	Базовые страницы и элементы
b.	Иерархия элементов
c.	Чтение конфигурации
d.	Инициализация и получение драйвера
e.	Хранение и чтение тестовых данных
f.	Логгер
g.	Обработка исключений
h.	Утилиты
i.	Ожидания и таймауты
j.	И т д
*/

namespace Core.Driver
{
    public class Driver
    {

        private static IWebDriver driverInstance = CreationOfDriver.CreateDriver();

        private Driver()
        {
        }

        public static IWebDriver DriverInstance()
        {
                return driverInstance;
        }


        

        //public static void Close()
        //{
        //    if (driverInstance != null)
        //    {
        //        driverInstance.Quit();
        //        driverInstance = null;
        //    }
        //}
    }
}
