using _Stack;
using System.Security.Cryptography.X509Certificates;
namespace Homework_7
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack(); //Объектная переменная для класса Stack

            st.Show();
            st.Pop();
            Console.WriteLine("Удаленное значение: " + st.lastRemovedMember);
            st.Show();
        }

    }
}
          
