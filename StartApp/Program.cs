using System;

namespace StartApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool flag = false;
            while (flag == false)
            {
                Menu();
                Console.WriteLine("Do you want to exit or continue :\nEnter 1 to continue\n2 to exit ");
                if (Convert.ToInt32(Console.ReadLine()) == 2)
                {
                    flag = true;
                }
            }
        }
        public static string Encode(string data)
        {
            string a = data;
            string b = a.Substring(0, (a.Length)/2);
            string c = a.Substring((a.Length + 1 )/2, (a.Length)/2);
            char[] bchar = b.ToCharArray();
            char[] cchar = c.ToCharArray();
            string bs = "";
            string cs = "";
            for (int i = 0; i < bchar.Length; i++)
            {     
                if (i % 2 == 0)
                {
                    bs += bchar[i];
                    bs += cchar[i];  
                } 
                if(i % 2 != 0)
                {
                    cs += bchar[i];
                    cs += cchar[i];
                } 
            }
            string result = cs +""+ bs;
            return result;
         }

        public static char[] Decode(string encodedData)
        { 
           
            string a = encodedData.Substring(0,encodedData.Length/2);
            string b = encodedData.Substring((encodedData.Length/2), encodedData.Length/2);
            char[] achar = a.ToCharArray();
            char[] bchar = b.ToCharArray();
            string asc = "";
            string bsc = "";
            for (int i = 0; i < bchar.Length-1; i++)
            {     
                if (i % 2 == 0)
                {
                    bsc += Convert.ToChar(b.Substring(i,1));
                    b.Remove(i, 1);
                    bsc += Convert.ToChar(b.Substring(i,1));
                    b.Remove(i, 1); 
                } 
                if(i % 2 != 0)
                {
                    asc += Convert.ToChar(a.Substring(i,1));
                    a.Remove(i, 1);
                    bsc += Convert.ToChar(a.Substring(i,1));
                    a.Remove(i, 1); 
                } 
            }
             return bchar ;    
        }
        private static void Menu()
        {
            try
            {
                string ig = "";
                Console.WriteLine("Enter string to be encoded or decoded :");
                ig = Console.ReadLine();
                Console.WriteLine("Enter 1 to Encode, 2 to Decode");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                case 1 :
                 Console.WriteLine($"Encoded Data:{Encode(ig)}");
                break;
                case 2 :
                 Console.WriteLine($"Currently, Not available at the moment");
                break;
                default:
                 Console.WriteLine("Invalid Input");
                break; 
                }
            }
            catch (Exception ex )
            {
                 Console.WriteLine(ex.Message);
            }
        }
    }
}