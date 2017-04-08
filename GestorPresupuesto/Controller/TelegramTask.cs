using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace GestorPresupuesto.Controller
{
    public class TelegramTask
    {
        private readonly Timer timer;
        private readonly TelegramController controller;

        public TelegramTask(ISettingsController controller)
        {
            controller = new TelegramController(controller);

            timer = new Timer(10000);
            timer.Elapsed += Task;
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }

        private async void Task(object sender, ElapsedEventArgs e)
        {
            await controller.FetchUpdates();
        }
    }
}
