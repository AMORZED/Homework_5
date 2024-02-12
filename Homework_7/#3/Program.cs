using _Stack;
using System.Security.Cryptography.X509Certificates;
namespace Homework_7
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack(10);

            st.Show();
            st.Pop();
            st.Show();
            st.Push(666);
            st.Show();
        }

    }
}
          
