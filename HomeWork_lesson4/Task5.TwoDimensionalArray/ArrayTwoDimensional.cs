using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.TwoDimensionalArray
{
    public class ArrayTwoDimensional
    {
        int[,] array;
        int row;
        int column;
        Random random = new Random();

        public int Min
		{
            get { return MinElement(); }
		}

        public int Max
		{
            get { return MaxElement(); }
		}

        public ArrayTwoDimensional(int n, int m)
		{
            row = n;
            column = m;
            array = new int[n, m];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++) array[i, j] = random.Next(-100, 100);
		}

        public ArrayTwoDimensional(string filename)
        {
            if(File.Exists(filename))
			{
                string[] arr = File.ReadAllLines(filename);
                row = arr.Length;
                column = arr[0].Split().Length;
                array = new int[row, column];

                for(int i = 0; i < row; i++)
				{
                    string[] rowArr = arr[i].Split();
                    for (int j = 0; j < column; j++) array[i, j] = int.Parse(rowArr[j]);
				}
			}
            else Console.WriteLine("Error load file");
        }

        private int MinElement()
		{
            int min = array[0, 0];

            for (int i = 0; i < row; i++)
                for (int j = 0; j < column; j++)
                    if (array[i, j] < min) min = array[i, j];

            return min;
        }

        private int MaxElement()
		{
            int max = array[0, 0];

            for (int i = 0; i < row; i++)
                for (int j = 0; j < column; j++)
                    if (array[i, j] > max) max = array[i, j];

            return max;
        }

        public int SumArray()
		{
            int sum = 0;

            for (int i = 0; i < row; i++)
                for (int j = 0; j < column; j++) sum += array[i, j];

            return sum;
		}

        public int SumArray(int number)
		{
            int sum = 0;

            for (int i = 0; i < row; i++)
                for (int j = 0; j < column; j++)
                    if(array[i,j] > number) sum += array[i, j];

            return sum;
        }

        public void NumberMaxElement(out int r, out int c)
		{
            r = c = 0;

            int max = array[0, 0];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                        r = i + 1;
                        c = j + 1;
                    }
                }
            }
        }

        public void ReadArrayFromFile(string filename)
		{
            if (File.Exists(filename))
            {
                string[] arr = File.ReadAllLines(filename);
                row = arr.Length;
                column = arr[0].Split().Length;
                array = new int[row, column];

                for (int i = 0; i < row; i++)
                {
                    string[] rowArr = arr[i].Split();
                    for (int j = 0; j < column; j++) array[i, j] = int.Parse(rowArr[j]);
                }
            }
            else
			{
                Console.WriteLine("Error load file");
            }
        }

        public void WriteArrayFromFile(string filename)
        {
            if (File.Exists(filename))
            {
                string[] rows = new string[row];
                string[] columns = new string[column];

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++) columns[j] = array[i, j].ToString();
                    rows[i] = string.Join(" ", columns);
                }

                File.WriteAllLines(filename, rows);
            }
            else
            {
                Console.WriteLine("Error load file");
            }
        }

        public void Print()
		{
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++) Console.Write("{0,4}", array[i, j]);
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
