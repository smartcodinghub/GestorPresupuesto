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

        public Action<int> OnFetchComplete { get; set; }

        public TelegramTask(TelegramController controller)
        {
            this.controller = controller;

            this.timer = new Timer(2000);
            this.timer.Elapsed += DoTaskAsync;

            Task.WaitAll(this.controller.FetchUpdatesAsync());
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }

        private async void DoTaskAsync(object sender, ElapsedEventArgs e)
        {
            int updatesProcessed = await controller.FetchUpdatesAsync().ConfigureAwait(false);
            OnFetchComplete?.Invoke(updatesProcessed);
        }
    }
}
