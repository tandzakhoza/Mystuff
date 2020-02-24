using System;

namespace Problems
{
    class Program
    {
        public void Main(string[] args)
        {    Programs p=new Programs();
            Console.WriteLine(p.prefix("Hello World!"));
        
        }
        
       public class Programs
        {

             public string prefix(string s)
             {
                 int length= s.Length;
                 string[] words =s.Split(' ');
                 int numwords =0;
                 foreach(string ss in words)
                 {
                      numwords++;
                 }

                 return length+","+numwords+":"+s;

             }


        }







    }
}
