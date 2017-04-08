using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorPresupuesto.Model
{
    public class Settings
    {
        public decimal MonthExpenseMax { get; set; }

        public decimal MonthContinuosExpenseMax { get; set; }

        public String TelegramUserAlias { get; set; }

        public String TelegramApiKey { get; set; }
    }
}
