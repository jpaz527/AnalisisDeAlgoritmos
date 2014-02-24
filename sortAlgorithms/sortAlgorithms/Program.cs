using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortAlgorithms
{
    class Program
    {
        private Random RNG = new Random();
        private static int[] n10 = new int[11];
        private static int[] n100 = new int[101];
        private static int[] n1000 = new int[1001];
        private static int[] n10000 = new int[10001];
        private static int[] n100000 = new int[100001];
        private static int[] n1000000 = new int[1000001];

        private static int n;
        private static int left;
        private static int right;
        private static int largest;
        static void Main(string[] args)
        {
            Program p = new Program();
            Stopwatch stopwatch = new Stopwatch();
            p.populateNull();
            p.populate();
            stopwatch.Start();
            p.bubblesort(n100);
            //p.insertionSort(n10);
            //p.selectionSort(n100);
            //quickSort(n100, 0, n100.Length-1);
            //sort(n100);
            //p.MergeSort(n100, 0, n100.Length - 1);
            //p.RadixSort(n100);
            stopwatch.Stop();
            print(n100);
            Console.WriteLine("Time elapsed in milliseconds: " + stopwatch.Elapsed);
            string var = "0";
            while (var == "0")
            {
                Console.WriteLine("Terminar?\nNo: 1");
                var = Console.ReadLine();
            }
            
        }

        public int randomize(int min, int max)
        {
            return RNG.Next(min, max);
        }

        public void populateNull()
        {
            for (int i = 0; i < n1000000.Length; i++)
            {
                if (i < 11)
                    n10[i] = -1;

                if (i < 101)
                    n100[i] = -1;

                if (i < 1001)
                    n1000[i] = -1;

                if (i < 10001)
                    n10000[i] = -1;

                if (i < 100001)
                    n100000[i] = -1;

                if (i < 1000001)
                    n1000000[i] = -1;
            }
        }

        public void populate()
        {
            bool go = true;
            int value;
            for (int i = 0; i < 11; i++)
            {
                go = true;
                while (go == true)
                {
                    value = randomize(0, 11);
                    if (n10[value] == -1)
                    {
                        n10[value] = i;
                        go = false;
                    }
                }
            }

            go = true;
            for (int i = 0; i < 101; i++)
            {
                go = true;
                while (go == true)
                {
                    value = randomize(0, 101);
                    if (n100[value] == -1)
                    {
                        n100[value] = i;
                        go = false;
                    }
                }
            }

            go = true;
            for (int i = 0; i < 1001; i++)
            {
                go = true;
                while (go == true)
                {
                    value = randomize(0, 1001);
                    if (n1000[value] == -1)
                    {
                        n1000[value] = i;
                        go = false;
                    }
                }
            }

            go = true;
            for (int i = 0; i < 10001; i++)
            {
                go = true;
                while (go == true)
                {
                    value = randomize(0, 10001);
                    if (n10000[value] == -1)
                    {
                        n10000[value] = i;
                        go = false;
                    }
                }
            }

            go = true;
            for (int i = 0; i < 100001; i++)
            {
                go = true;
                while (go == true)
                {
                    value = randomize(0, 100001);
                    if (n100000[value] == -1)
                    {
                        n100000[value] = i;
                        go = false;
                    }
                }
            }

            go = true;
            for (int i = 0; i < 1000001; i++)
            {
                go = true;
                while (go == true)
                {
                    value = randomize(0, 1000001);
                    if (n1000000[value] == -1)
                    {
                        n1000000[value] = i;
                        go = false;
                    }
                }
            }

        }

        public void bubblesort(int[] a)
        { 
            int temp;
            bool cambio = false;
            while (cambio == false)
            {
                for (int i = 0; i < a.Length-1; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        cambio = true;
                        temp = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = temp;

                    }       
                }

                if (cambio == false)
                    cambio = true;

                else
                    cambio = false;
            }
        }

        public void insertionSort(int[] a)
        {
            int i;
            int j;
            int key;

            for (i = 1; i < a.Length; i++)
            {
                key = a[i];
                for (j = i - 1; (j >= 0) && (a[j] > key); j--)
                {
                    a[j + 1] = a[j];
                }
                a[j + 1] = key;
            }
        }

        public void selectionSort(int [] num)
        {
            int i, j, first, temp;

            for ( i = num.Length - 1; i > 0; i--)  
            {
              first = 0;   
              for(j = 1; j <= i; j ++)   
              {
                   if( num[ j ] < num[ first ] )         
                       first = j;
              }
              temp = num[ first ];   
              num[ first ] = num[ i ];
              num[ i ] = temp; 
            }  
        }

        public static void quickSort(int[] a, int p, int r)
        {
            if (p < r)
            {
                int q = partition(a, p, r);
                quickSort(a, p, q);
                quickSort(a, q + 1, r);
            }
        }

        private static int partition(int[] a, int p, int r)
        {

            int x = a[p];
            int i = p - 1;
            int j = r + 1;

            while (true)
            {
                i++;
                while (i < r && a[i] < x)
                    i++;
                j--;
                while (j > p && a[j] > x)
                    j--;

                if (i < j)
                    swap(a, i, j);
                else
                    return j;
            }
        }

        private static void swap(int[] a, int i, int j)
        {
            int temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }

        public static void buildheap(int[] arr)
        {
            n = arr.Length - 1;
            for (int i = n / 2; i >= 0; i--)
            {
                maxheap(arr, i);
            }
        }
 
        public static void maxheap(int[] arr, int i){ 
        left=2*i;
        right=2*i+1;
        if(left <= n && arr[left] > arr[i]){
            largest=left;
        }
        else{
            largest=i;
        }
        
        if(right <= n && arr[right] > arr[largest]){
            largest=right;
        }
        if(largest!=i){
            exchange(arr, i,largest);
            maxheap(arr, largest);
        }
    }

        public static void exchange(int[] arr, int i, int j)
        {
            int t = arr[i];
            arr[i] = arr[j];
            arr[j] = t;
        }

        public static void sort(int[] arr)
        {

            buildheap(arr);

            for (int i = n; i > 0; i--)
            {
                exchange(arr, 0, i);
                n = n - 1;
                maxheap(arr, 0);
            }
        }

        public void MergeSort(int[] input, int startIndex, int endIndex)
        {
            int mid;

            if (endIndex > startIndex)
            {
                mid = (endIndex + startIndex) / 2;
                MergeSort(input, startIndex, mid);
                MergeSort(input, (mid + 1), endIndex);
                Merge(input, startIndex, (mid + 1), endIndex);
            }
        }

        public void Merge(int[] input, int left, int mid, int right)
        {
            int[] temp = new int[input.Length];
            int i, leftEnd, lengthOfInput, tmpPos;
            leftEnd = mid - 1;
            tmpPos = left;
            lengthOfInput = right - left + 1;

            while ((left <= leftEnd) && (mid <= right))
            {
                if (input[left] <= input[mid])
                {
                    temp[tmpPos++] = input[left++];
                }
                else
                {
                    temp[tmpPos++] = input[mid++];
                }
            }
            while (left <= leftEnd)
            {
                temp[tmpPos++] = input[left++];
            }

            while (mid <= right)
            {
                temp[tmpPos++] = input[mid++];
            }

            for (i = 0; i < lengthOfInput; i++)
            {
                input[right] = temp[right];
                right--;
            }
        }

        public void RadixSort(int[] a)
        {
            int[] t = new int[a.Length];

            int r = 4;
 
            int b = 32;

            int[] count = new int[1 << r];
            int[] pref = new int[1 << r];

            int groups = (int)Math.Ceiling((double)b / (double)r);

            int mask = (1 << r) - 1;

            for (int c = 0, shift = 0; c < groups; c++, shift += r)
            {
                for (int j = 0; j < count.Length; j++)
                    count[j] = 0;

                for (int i = 0; i < a.Length; i++)
                    count[(a[i] >> shift) & mask]++;

                pref[0] = 0;
                for (int i = 1; i < count.Length; i++)
                    pref[i] = pref[i - 1] + count[i - 1];

                for (int i = 0; i < a.Length; i++)
                    t[pref[(a[i] >> shift) & mask]++] = a[i];

                t.CopyTo(a, 0);
            }
            
        }

        public static void print(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Valor x" + i + ": " + a[i]);
            }
        }


    }
}
