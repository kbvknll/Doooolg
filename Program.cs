using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        DataTable table = new DataTable();

        table.Columns.Add("Ученик", typeof(string));

        for (int i = 1; i <= 5; i++)
        {
            table.Columns.Add("Оценка " + i, typeof(int));
        }

        table.Rows.Add("Анастасия", 4, 5, 3, 4, 5);
        table.Rows.Add("Андрей", 3, 2, 4, 3, 5);
        table.Rows.Add("Евгений", 5, 5, 5, 5, 4);

        foreach (DataRow row in table.Rows)
        {
            Console.Write(row["Ученик"] + ": ");
            for (int i = 1; i <= 5; i++)
            {
                Console.Write(row["Оценка " + i] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Вы хотите посчитать средний балл учеников?");
        string otvet = Console.ReadLine();
        if(otvet.ToLower() == "да")
        {
            foreach (DataRow row in table.Rows)
            {
                double sum = 0;
                for (int i = 1; i <= 5; i++)
                {
                    sum += Convert.ToDouble(row["Оценка " + i]);
                }
                double average = sum / 5;
                Console.WriteLine("Средний балл для " + row["Ученик"] + ": " + average);
            }
        }
    }
}