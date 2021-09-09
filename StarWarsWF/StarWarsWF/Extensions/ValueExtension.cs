using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace StarWarsWF.Extensions
{
    public static class ValueExtension
    {
        public static T GetValueOrDefault<T>(this SqlDataReader reader, string campo)
        {
            try
            {
                return (T)reader[campo];
            }
            catch
            {
                return default(T);
            }
        }
    }
}
