using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KartSkills
{
    public partial class template : Form
    {
        public template()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer_event_Tick(object sender, EventArgs e)
        {
            //Создаём новый экземпляр типа DateTime для хранения время начала события
            DateTime finishdate = new DateTime(2020, 10, 1, 9, 0, 0);
            //вычисляем текущее время и время начала события
            TimeSpan result = finishdate - DateTime.Now;
            /*
             Проверяем услоие, если finishdate (вреям начало события) меньше или равно текущей дате и времени (берется с компьютера),
             то выводится сообщение,что "событие уже началось" если нет, то отображаем счётчик
             */
            if (finishdate <= System.DateTime.Now)
            {
                //В элемент Label (с индетификатором l_timer)  в свойство Text добавляем сообщение Событе уже началось
                l_timer.Text = "Событие уже началось";
            }
            else
            {
                //В элемент label (c индетификатором l_timer) в свойство Text добавляем сообщение которое так же принимается переменную для отображения даты и времени
                l_timer.Text = "До события осталось: " + result.Days + " Дней " + result.Hours + " часов " + result.Minutes + " минуты " + result.Seconds + " секунд ";
            }
        }
    }
}
