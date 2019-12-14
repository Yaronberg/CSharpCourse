using System;
using System.Collections.Generic;
using System.Text;

namespace _4
{
    class DocumentWorker
    {
        public virtual void OpenDocumet()
        {
            Console.WriteLine("Документ открыт");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Про");
        }
    }
}
