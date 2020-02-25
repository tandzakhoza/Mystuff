using System;

namespace Problems
{
    public class Program
    {
        static void Main(string[] args)
        {    Program p=new Program();
            Console.WriteLine(p.prefix("Hello World!"));
        
        }
        
        public string prefix(string s)
             {
                 int length= s.Length;
                 string[] words =s.Split(' ');
                 int numwords =0;
                 foreach(string ss in words)
                 {
                      numwords++;
                 }

                // return length+","+numwords+":"+s;
               return "\""+length+","+numwords+":"+s+"\"";
               
               // Console.WriteLine("{0},{1}:{2}",length,numwords,s);

             }








    }
}
