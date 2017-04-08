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

            String apiKey = this.settingsController.Settings.TelegramApiKey;

            // TODO, Excepciones si la api key está mal o vacía. Avisar al Task para que no se ejecute.
            if (!String.IsNullOrEmpty(apiKey))
                this.bot = new TelegramBotClient(apiKey);
        }

        /// <summary>
        /// This will get the new Updates from telegram and add it to the given MonthModelController.
        /// It will use the TelegramUserAlias settings without caching the Settings object. 
        /// </summary>
        /// <returns></returns>
        public async Task FetchUpdates()
        {
            /* Settings */
            String userAlias = settingsController.Settings.TelegramUserAlias;

            /* Getting and preparing updates */
            Update[] updates = await bot.GetUpdatesAsync().ConfigureAwait(false);
            String[] commands = updates.Where(u => String.Equals(u?.Message.From.Username, userAlias))
                .Select(u => u?.Message.Text).Where(CommandValid).ToArray();

            /* Processing updates */
            Array.ForEach(commands, ProcessCommand);
        }

        /// <summary>
        /// We need at least an action and a number. So +1 is the least the commmand must have.
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        private Boolean CommandValid(String command)
        {
            return !String.IsNullOrWhiteSpace(command)
                && command.Length > 2;
        }

        private void ProcessCommand(String command)
        {
            //(\+|-)\d+ (\D+) (no|si)? Mejor Split... Después de comprobar el primer caracter



        }
    }
}
