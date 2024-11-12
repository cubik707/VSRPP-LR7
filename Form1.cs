using System.Diagnostics;
using System.Threading;

namespace LR7
{
    public partial class Form1 : Form
    {
        private Thread thread1;
        private Thread thread2;
        private AutoResetEvent event1;
        private AutoResetEvent event2;
        private bool isRunning;
        private bool threadsStopped = false;

        public Form1()
        {
            InitializeComponent();

            event1 = new AutoResetEvent(false);
            event2 = new AutoResetEvent(false);
            isRunning = false;
            labelThreadStop.Text = "Потоки спят...😴";
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (isRunning)
                return;

            isRunning = true;
            labelThreadStop.Text = "Потоки работают...🐱‍👤";
            labelResult.Text = " ";

            // Сбрасываем события перед новым запуском
            event1.Reset();
            event2.Reset();

            thread1 = new Thread(Thread1Method);
            thread2 = new Thread(Thread2Method);

            thread1.Start();
            thread2.Start();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            // Вызовем метод для завершения потоков
            StopThreads();

            labelThreadStop.Text = "Потоки остановлены.☠";
        }


        private void Thread1Method()
        {
            string part1 = "Привет от потока 1!";
            // Симуляция работы
            Thread.Sleep(1000);

            // Уведомляем поток 2 о готовности части 1
            labelResult.Invoke((Action)(() => labelResult.Text = part1));
            event1.Set(); // Уведомляем поток 2
            event2.WaitOne(); // Ожидаем, пока поток 2 завершит свою работу
        }

        private void Thread2Method()
        {
            // Ожидаем готовности потока 1
            event1.WaitOne();

            string part2 = "А это поток 2.";
            // Симуляция работы
            Thread.Sleep(1000);

            // Обновляем метку с полной фразой
            labelResult.Invoke((Action)(() => labelResult.Text += " " + part2));

            event2.Set(); // Уведомляем поток 1, что работа завершена
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!threadsStopped)
            {
                // Вызовем метод для завершения потоков
                StopThreads();
            }

            // Вызов базового метода для корректного закрытия формы
            base.OnFormClosing(e);
        }

        private void StopThreads()
        {
            // Устанавливаем флаг, чтобы потоки завершились
            isRunning = false;

            // Сообщаем потокам, что нужно завершить их работу
            event1.Set();
            event2.Set();

            // Ожидаем завершения работы потоков
            thread1?.Join();
            thread2?.Join();

            threadsStopped = true;
        }

    }
}
