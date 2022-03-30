using System;

namespace MoodAnalyserException
{
    internal class Program
    {
        public  int CheckMood (string mood,int e)
        {
            try
            {
                int i = 0;
                int j = 1;
                string check = "Happy";
                if (mood == check)
                {
                    Console.WriteLine("person is happy");
                }
                else
                {
                    return j / i;

                }
                return j / i;
            }catch (Exception e)
            {
                return e;   
            }
            }
            
        static void Main(string[] args)
        {
            Console.WriteLine("Person mood");
            string mood1 = Convert.ToString(10); 
            Program check=new Program();
            check.CheckMood(mood1);
        }
    }
}
