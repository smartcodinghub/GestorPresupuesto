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
        private Action<Timer> StartTimer;

        public Action<int> OnFetchComplete { get; set; }

        public TelegramTask(TelegramController controller)
        {
            this.controller = controller;

            /* Only if controller is connected and token tried */
            if (controller.IsConnected)
            {
                this.timer = new Timer(2000);
                this.timer.Elapsed += DoTaskAsync;
                this.StartTimer = (t) => t.Start();

                Task.WaitAll(this.controller.FetchUpdatesAsync());
            }
            else
            {
                this.StartTimer = (t) => { };
            }
        }

        public void Start()
        {
            this.StartTimer(timer);
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
