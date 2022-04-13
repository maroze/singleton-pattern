using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocolate
{
    public class ChocolateBoiler
    {
        // Какие-либо хранимые данные.
        private bool empty;
        private bool boiled;

        //Основной объект, в котором будет храниться уникальный экземпляр класса. 
        private static ChocolateBoiler uniqueInstance;

        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }
        
        public static ChocolateBoiler getInstance()
        {
            if (uniqueInstance == null)
            {
                //Создание уникального экземпляра шоколадного котла
                uniqueInstance = new ChocolateBoiler();
            }
            return uniqueInstance;
        }
        
        public void Fill()
        {
            if (IsEmpty())
            {
                empty = false;
                boiled = false;
            }
        }
        
        public void Drain()
        {
            if (!IsEmpty() && IsBoiled())
            {
                // Слить нагретое молоко и шоколад
                empty = true;
            }
        }
        
        public void Boil()
        {
            if (!IsEmpty() && !IsBoiled())
            {
                // Довести содержимое до кипения
                boiled = true;
            }
        }

        //Значение по умолчанию для типа bool — false.
        public bool IsEmpty()
        {
            return empty;
        }
        
        public bool IsBoiled()
        {
            return boiled;
        }
    }
}
