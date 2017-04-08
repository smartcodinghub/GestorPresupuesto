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

        public TelegramTask(TelegramController controller)
        {
            this.controller = controller;

            this.timer = new Timer(10000);
            this.timer.Elapsed += DoTask;

            Task.WaitAll(this.controller.FetchUpdates());
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }

        private async void DoTask(object sender, ElapsedEventArgs e)
        {
            await controller.FetchUpdates();
        }
    }
}
