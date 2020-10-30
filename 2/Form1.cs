using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibMas;
using Lib_7;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Кнопка "Справка"
        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Практическая работа №2. Бороненкова Дария, гр.ИСП - 31.\n" +
                "Задание:  Ввести  n  целых чисел. Вычислить для чисел < 0 функцию x^2.\n" +
                "Результат обработки каждого числа вывести на экран.", "О программе");
        }

        //Кнопка "Выход"
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Начальные значения таблицы при первом запуске
        private void Form1_Load(object sender, EventArgs e)
        {
            //table - таблица DataGridView
            table.ColumnCount = 5;//Количество столбцов
            table.RowCount = 1;//Количество строк
            tableResult.ColumnCount = 5;//Количество столбцов
            tableResult.RowCount = 1;//Количество строк
        }

        //Изменение количество колонок
        private void kolvo_ValueChanged(object sender, EventArgs e)
        {
            table.ColumnCount = Convert.ToInt32(columns.Value);
        }

        //Кнопка "Заполнить"
        private void button1_Click(object sender, EventArgs e)
        {
            int min = Convert.ToInt32(diapazonMinus.Value);
            int max = Convert.ToInt32(diapazonPlus.Value);
            LibMas.Class2.InitMas(table, min, max);
        }

        //Кнопка "Сохранить"
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LibMas.Class2.SaveFile(table);
        }

        //Кнопка "Открыть"
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LibMas.Class2.OpenFile(table);
        }

        //Кнопка "Рассчитать"
        private void button2_Click(object sender, EventArgs e)
        {
            Lib_7.Class2.FuncMas(table, tableResult);
        }

        //Кнопка "Очистить"
        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LibMas.Class2.DelMas(table);
            LibMas.Class2.DelMas(tableResult);
        }

    }
}
