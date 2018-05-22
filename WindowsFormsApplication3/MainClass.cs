using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class MainClass
    {
        List<Questions> q = null;
        public MainClass()
        {
            q = new List<Questions>()
            {
                new Questions("How many legs do u have?",1, "2", "10", "4", "-1"),
                new Questions("2 + 2*2 = ?", 2, "8", "6", "12", "4"),
                new Questions("С какой скоростью полетит маркер если не ответить Чумаку на вопрос о С# ?", 2, "300 000 km/h", "7 m/s", "15 m/s", "1 m/s"),
                new Questions("sin(30)?", 3 , "1/2", "5.44444", "3/4", "no answer"),
                new Questions("Сколько занимает памяти int?"),
                new Questions("Speed of light?"),
                new Questions("How old is Dima?"),
            };
        }
    }
}
