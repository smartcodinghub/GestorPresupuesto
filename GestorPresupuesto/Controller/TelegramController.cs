using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace GestorPresupuesto.Controller
{
    public class TelegramController
    {
        private TelegramBotClient bot;
        private ISettingsController settingsController;
        private MonthModelController monthController;

        public TelegramController(ISettingsController settingsController, MonthModelController monthController)
        {
            this.settingsController = settingsController;
            this.bot = new TelegramBotClient("339054846:AAGct-35pCL_M6wF2aKk9oTEP_sdVuG4CCo");
        }

        public async Task FetchUpdates()
        {   //11447519 "Edwinem"
            String userAlias = settingsController.Settings.TelegramUserAlias;
            Update[] updates = await bot.GetUpdatesAsync().ConfigureAwait(false);
            String[] commands = updates.Where(u => String.Equals(u?.Message.From.Username, userAlias)).Select(u => u?.Message.Text).ToArray();

            ProcessCommands();
        }

        private void ProcessCommands()
        {
            //(\+|-)\d+ (\D+) (no|si)? Mejor Split... Después de comprobar el primer caracter
            throw new NotImplementedException();
        }
    }
}
