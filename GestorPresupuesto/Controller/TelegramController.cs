using GestorPresupuesto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        private Regex commandRegex = new Regex(@"^(\+|-)(\d+)\s+(?:(\d{2})\/(\d{2})?(\d{2})\s+)?(.+)$", RegexOptions.Compiled | RegexOptions.CultureInvariant | RegexOptions.IgnoreCase | RegexOptions.ECMAScript);

        public Boolean IsConnected { get; set; }

        public TelegramController(ISettingsController settingsController, MonthModelController monthController)
        {
            this.monthController = monthController;
            this.settingsController = settingsController;

            String apiKey = this.settingsController.Settings.TelegramApiKey;

            /* This checks and tries the given api key. If not valid, 
             * it won't call the api. */
            if (!String.IsNullOrEmpty(apiKey))
            {
                this.bot = new TelegramBotClient(apiKey);
                this.IsConnected = bot.TestApiAsync().Result;
            }
            else
            {
                this.IsConnected = false;
            }
        }

        /// <summary>
        /// This will get the new Updates from telegram and add it to the given MonthModelController.
        /// It will use the TelegramUserAlias settings without caching the Settings object. 
        /// </summary>
        /// <returns></returns>
        public async Task<int> FetchUpdatesAsync()
        {
            if (IsConnected)
            {
                /* Settings */
                String userAlias = settingsController.Settings.TelegramUserAlias;
                long lastProcessed = settingsController.Settings.TelegramLastProcessed;

                /* Getting and preparing updates */
                Update[] updates = await bot.GetUpdatesAsync().ConfigureAwait(false);
                String[] commands = updates.Where(u => u.Id > lastProcessed && String.Equals(u?.Message.From.Username, userAlias))
                    .Select(u => u?.Message.Text.ToLower()).Where(CommandValid).ToArray();

                /* Processing updates */
                Array.ForEach(commands, ProcessCommand);

                /* Setting the last processed item */
                settingsController.Settings.TelegramLastProcessed = updates.Select(u => u.Id).Max();

                return commands.Length;
            }

            return 0;
        }

        /// <summary>
        /// We need at least an action and a number. So +1 is the least the commmand must have.
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        private Boolean CommandValid(String command)
        {
            return !String.IsNullOrWhiteSpace(command)
                && commandRegex.IsMatch(command);
        }

        private void ProcessCommand(String command)
        {
            //^(\+|-)(\d+)\s+(?:(\d{2}\/\d{2}(\d{2})?)\s+)?(\D+)$ Mejor Split... Después de comprobar el primer caracter
            Match match = commandRegex.Match(command);

            String action = match.Groups[1].Value;
            String amount = match.Groups[2].Value;
            String month = match.Groups[3].Value;
            String year1 = match.Groups[4].Value;
            String year2 = match.Groups[5].Value;
            String text = match.Groups[6].Value;
            Boolean isFixed = text.EndsWith(" si");

            if (String.IsNullOrEmpty(year1)) year1 = "20";
            String year = year1 + year2;

            Expense exp = new Expense()
            {
                Cost = decimal.Parse(action + amount),
                Name = isFixed ? text.Remove(text.Length - 3) : text,
                IsFixed = isFixed
            };

            int id = String.IsNullOrEmpty(month)
                ? DateTime.Now.Year * 100 + DateTime.Now.Month
                : int.Parse(year) * 100 + int.Parse(month);

            monthController.AddExpense(id, exp);
        }
    }
}
