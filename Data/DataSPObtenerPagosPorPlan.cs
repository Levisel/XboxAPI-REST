using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
namespace Data
{
    public class DataSPObtenerPagosPorPlan 
    {
        XboxGamePassEntities _context;
        public DataSPObtenerPagosPorPlan()
        {
            _context = new XboxGamePassEntities();
            _context.Configuration.ProxyCreationEnabled = false;
        }
       
        public SPObtenerPagosPorPlan_Result buscarPorId(string nombrePlan)
        {
            return _context.Database.SqlQuery<SPObtenerPagosPorPlan_Result>("exec SPObtenerPagosPorPlan @nombrePlan", new object[] { nombrePlan }).FirstOrDefault();
        }

    }
}
