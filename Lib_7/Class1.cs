using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Lib_7
{
    public class Class2
    {
        /*Параметры:
         Входные:
         DataGridView table – таблица c исходными данными
         DataGridView tableResult - таблица для вывода ответа 
         Выходные:
         x - значение функции
         */
        public static void FuncMas(DataGridView table, DataGridView tableResult)
        {
            double x;
            for (int i = 0; i < table.ColumnCount; i++)
            {
              x = Convert.ToInt32(table[i, 0].Value);
                if (x < 0)
                {
                    tableResult[i, 0].Value = Math.Pow(x, 2);
                }
                else
                {
                    tableResult[i, 0].Value = 0;
                }
            }
        }
    }
}
