using System;

namespace Basic13
{
    class Program
    {
        public static void Array(int[] X){
            for (int idx = 0; idx < X.Length; idx++){
                Console.WriteLine(X[idx]);
            }
        }
        public static void FindMax(int[] X){
            int max = X[0];
            for (int idx = 0; idx < X.Length; idx++){
                if (X[idx] > max){
                    max = X[idx];
                }
            }
            Console.WriteLine("Find Max: " + max);
        }
        public static void FindAvg(int[] X){
            int sum = 0;
            for (int idx = 0; idx < X.Length; idx++){
                sum += X[idx];
            }
            float floatsum = sum;
            float avg = floatsum/X.Length;
            Console.WriteLine("Find Avg: " + avg);
        }
        public static int GTY(int[] arr, int Y){
            int GTYcount = 0;
            for (int idx = 0; idx < arr.Length; idx++){
                if (arr[idx] > Y){
                    GTYcount++;
                }
            }
            Console.WriteLine(GTYcount);
            return GTYcount;
        }
        public static void Squares(int[] x){
            for (int idx = 0; idx < x.Length; idx++){
                x[idx] = x[idx] * x[idx];
                Console.WriteLine(x[idx]);
            }
        }
        public static void NoNegs(int[] x){
            for (int idx = 0; idx < x.Length; idx++){
                if (x[idx] < 0){
                    x[idx] = 0;
                }
                Console.WriteLine(x[idx]);
            }
        }
        public static void MinMaxAvg(int[] x){
            int max = x[0];
            int min = x[0];
            int sum = 0;
            for (int idx = 0; idx < x.Length; idx++){
                if (x[idx] > max){
                    max = x[idx];
                }
                if (x[idx] < min){
                    min = x[idx];
                }
                sum += x[idx];
            }
            float floatsum = sum;
            float avg = floatsum/x.Length;
            // float MinMaxAvg = 
            Console.WriteLine("Min:" + min + ", Max:" + max + ", Avg:" + avg);
        }
        public static int[] ShiftVal(int[] x){
            for (int idx = 0; idx < x.Length; idx++){
                if (idx == x.Length-1){
                    x[idx] = 0;
                }
                else{
                    x[idx] = x[idx+1];
                }
                Console.WriteLine(x[idx]);
            }
            return x;
        }
        public static object[] NumToStr(object[] x){
            for(int idx = 0; idx < x.Length; idx++){
                if((int)x[idx] < 0){
                    x[idx] = "Dojo";
                }
                Console.WriteLine(x[idx]);
            }
            return x;
        }
        static void Main(string[] args)
        {
        // Print 1 - 255:
            for (int num = 1; num < 256; num++){
                // Console.WriteLine(num);
            }
        // Print odd numbers between 1 - 255:
            for (int num = 1; num < 256; num+=2){
                // Console.WriteLine(num);
            }
        // Print Sum:
            int sum = 0;
            for (int num = 0; num < 256; num++){
                sum += num;
                // Console.WriteLine("num: " + num + ", sum: " + sum);
            }
        // Iterating through an Array:
            Array(new int[] {1,3,5,7,9,13});
        // Find Max:
            FindMax(new int[] {-3,0,1,-10,6,0,8,-2});
        // Find Avg:
            FindAvg(new int[] {-1,2,-3,4,5});
        // Array with Odd Numbers:
            int count = 0;
            for (int num = 1; num < 256; num+=2){
                count++;
            }
            int[] Y = new int[count];
            int idx = 0;
            for (int num = 1; num < 256; num+=2){
                Y[idx] = num;
                idx++;
            }
            // Loop below can validate correct answer:
            for (int num = 0; num < Y.Length; num++){
                Console.WriteLine("Y idx: " + Y[num]); 
            }
        // Greater than Y:
            GTY(new int[] {1,3,5,7}, 3);
        // Square Values:
            Squares(new int[] {1,3,5,7});
        // Eliminate Negative Numbers:
            NoNegs(new int[] {1,5,10,-2});
        // Min, Max, Average:
            MinMaxAvg(new int[] {1,5,10,-2});
        // Shifting the values in an array:
            ShiftVal(new int[] {1,5,10,7,-2});
        // Number to String:
            NumToStr(new object[] {-1,-3,2});
        }
    }
}
