using GestorPresupuesto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorPresupuesto.Controller
{
    public interface IPersistenceController
    {
        PersistenceEntity Get();

        Boolean Save(PersistenceEntity toSave);
    }
}
