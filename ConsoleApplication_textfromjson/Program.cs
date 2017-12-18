using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_textfromjson
{
    class Program
    {

        static object[] ToObjectArray(List<float> a)
        {
            object[] b = new object[a.Count];
            for (int i = 0; i < (a.Count); i++)
                b[i] = (object)a[i];
            return b;
        }
        static void Main(string[] args)
        {
            var header = "Article";




            //    [{
            //"Article": "1711291301",
            //"Color": "15",
            //"SizeValues": [{
            //    "SizeName": "170-88-96\/S",
            //    "CountInWarehouse": 2,
            //    "CountInHall": 0
            //}, {
            //    "SizeName": "170-92-100\/M",
            //    "CountInWarehouse": 0,
            //    "CountInHall": 2
            //}, {
            //    "SizeName": "170-96-104\/L",
            //    "CountInWarehouse": 0,
            //    "CountInHall": 0
            //}, {
            //    "SizeName": "170-100-108\/XL",
            //    "CountInWarehouse": 1,
            //    "CountInHall": 0
            //}]
            string[] sizesnames = new string[] { "70/180", "xs", "xxs" };
            int[] qountinhall = { 4, 5, 6 };
            int[] qountinwarh = { 1, 2, 3 };
            var delim = "-----------------------------------------------------";
            string strngsizes = String.Join("|", sizesnames);
            string strngquant = String.Join("|", qountinhall);
            string path3 = @"C:\Projects\Melon\MyTest3.txt";
            var art = "Артикул: 17310224800";
            var devid = "ID устройства: ADF233-12414G-12THF";
            var date = "Дата операции: " + DateTime.Now.ToString();
            int[] years = { 2013, 2014, 2015 };
            int[] population = { 1025632, 1105967, 1148203 };
            string[] arr3 = new string[years.Length];
            String s2 = String.Format("{0,-10} {1,-10} {2,-10}\n\n", "SizeType", "Кол-во зал", "Кол-во склад");
            String s = String.Format("{0,-10} {1,-10} {2,-10}\n\n", "SizeType2", "Кол-во зал", "Кол-во склад");
            for (int index = 0; index < sizesnames.Length; index++)
            {
                s = String.Format("{0,-10} {1,-10:N0} {2,-10:N0}\n",
                    sizesnames[index], qountinhall[index], qountinwarh[index]);
                arr3[index] = s;

            }
            var sumszal = qountinhall.Sum();
            var sumsklad = qountinwarh.Sum();
            String s3 = String.Format("{0,-10} {1,-10} {2,-10}  \n\n", "Итого:", sumszal, sumsklad);
            using (StreamWriter sw = File.AppendText(path3))
            {
                //  sw.WriteLine(txt);
                sw.WriteLine(date);
                sw.WriteLine(devid);
                sw.WriteLine(art);
                sw.WriteLine(s2);

                for (int i = 0; i < arr3.Length; i++)
                {
                    sw.WriteLine(arr3[i]);
                }
                sw.WriteLine(s3);

                sw.WriteLine(delim);
            }

            List<float> a = new List<float>();
            a.Add(1.0f);
            a.Add(2.0f);
            a.Add(3.0f);

            string fmt = "{0} ft. {1} in.";
            Console.WriteLine(String.Format(fmt, ToObjectArray(a)));
            var ss = String.Format(fmt, ToObjectArray(a));
            string path4 = @"C:\Projects\Melon\MyTest8.txt";
            using (StreamWriter sw = File.AppendText(path4))
            {
                sw.WriteLine(ss);
            }

            object[] args2 = new object[] { "Alice", 2, 5 };
            var str2 = String.Format("Her name is {0} and she's {1} years old", args2);

            string path5 = @"C:\Projects\Melon\MyTest9.txt";
            using (StreamWriter sw = File.AppendText(path5))
            {
                sw.WriteLine(str2);
            }

            int[] arr1 = { 1, 2 };
            int[] arr2 = { 6, 7 };
            var filename = @"D:\test\test.txt";
            //        File.WriteAllLines(filename,
            //Enumerable.Range(0, arr1.Length)
            //          .Select(i => string.Format("Кол-во зал: {0}\t", arr1[i])));

            string[] sizesnames2 = new string[] { "70/180", "xs", "xxs" };
            int[] qountinhall2 = { 4, 5, 6 };
            int[] qountinwarh2 = { 1, 2, 3 };
            var delim7 = "-----------------------------------------------------";


            string path6 = @"C:\Projects\Melon\MyTest13.txt";
            var nms = Enumerable.Range(0, sizesnames2.Length)
                .Select(i => string.Format(" {0,10}\t", sizesnames2[i])).ToList();
            var ssnms = "Типы размеров\t" + String.Join("", nms.ToArray());

            var qh = Enumerable.Range(0, qountinhall2.Length)
                .Select(i => string.Format(" {0,10}\t", qountinhall2[i])).ToList();
            var ss2 = "Кол-во склад\t" + String.Join("", qh.ToArray());

            var wh = Enumerable.Range(0, qountinwarh2.Length)
               .Select(i => string.Format(" {0,10}\t", qountinwarh2[i])).ToList();
            var wh2 = "Кол-во склад\t" + String.Join("", wh.ToArray());

            using (StreamWriter sw = File.AppendText(path6))
            {
                sw.WriteLine(ssnms);
                sw.WriteLine(ss2);
                sw.WriteLine(wh2);
                sw.WriteLine(delim7);
            }

        }
    }
}
