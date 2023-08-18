using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DagoApp_.Clases
{
    internal class luis
    {
        public static DataTable LLENAGRIDVIEW(string SP_Lista)
        {
            SqlConnection conexion = new SqlConnection(@"data source=.;initial catalog=DBIR;persist security info=True;user id=sa;password=admin2022.;MultipleActiveResultSets=True;App=EntityFramework");

            string muestraDatosDGV = SP_Lista;
            SqlDataAdapter adaptador = new SqlDataAdapter(muestraDatosDGV, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            return dt;
        }
    }
}
