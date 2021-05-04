using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensajeroModel.DAL
{
    public class MensajesDALFactory
    {
      public static IMensajesDAL CreateDAL()
        {
            return MensajesDALArchivos.GetInstance();

        }
    }
}
