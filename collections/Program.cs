using System;
using System.Collections.Generic;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
        // Three basic arrays
            int[] numArray = {0,1,2,3,4,5,6,7,8,9};
            string[] names = new string[4] {"Tim", "Martin", "Nikki", "Sara"};
            bool[] tandf = new bool[10] {true, false, true, false, true, false, true, false, true, false};
            Console.WriteLine(tandf[3]);
        // Multiplecation Table:
            int[] array = {1,2,3,4,5,6,7,8,9,10};
            int[,,] mult = new int [10,1,10];
            for (int row = 0; row < 10; row++){
                for (int idx = 0; idx < 10; idx++){
                    if (row == 0){
                        mult[row,0,idx] = array[idx];
                        Console.WriteLine(mult[row,0,idx]);
                    }
                    else{
                        mult[row,0,idx] = array[idx] * (row + 1);
                        Console.WriteLine(mult[row,0,idx]); 
                    }
                }
            }
        // List of Flavors:
            List<string> flavors = new List<string>();
            flavors.Add("Neopolitan");
            flavors.Add("Rocky Road");
            flavors.Add("Moosetracks");
            flavors.Add("Mint Chip");
            flavors.Add("Butterfinger");
            Console.WriteLine("There are {0} ice cream flavors", flavors.Count);
            Console.WriteLine("flavor idx[2]: " + flavors[2]);
            flavors.RemoveAt(2);
            Console.WriteLine("New amount of ice cream flavors is now {0}", flavors.Count);
        // User info Dictionary:
            Dictionary<string,string> users = new Dictionary<string,string>();
            for (int name = 0; name < names.Length; name++){
                users.Add(names[name], "null");
            }
            // add flavors to keys in users
            Random rand = new Random();
            int icecream = 0;
            var keys = new List<string>(users.Keys);
            foreach (string key in keys){
                icecream = rand.Next(1,4);
                if (icecream == 1){
                    users[key] = "Neopolitan";
                }
                if (icecream == 2){
                    users[key] = "Rocky Road";
                }
                if (icecream == 3){
                    users[key] = "Mint Chip";
                }
                if (icecream == 4){
                    users[key] = "Butterfinger";
                }
            }
            foreach (KeyValuePair<string,string> user in users){
                Console.WriteLine(user.Key + " " + user.Value);
            }
        }
    }
}
