using System;
using System.Collections.Generic;
using System.Text;

namespace _4
{
    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }
}
