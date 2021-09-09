
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace StarWarsWF.Connection
{
    public abstract class ConnectionClass : IDisposable
    {
        protected readonly SqlConnection con;

        protected ConnectionClass()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-GH;Initial Catalog=EstrelaDaMorte;Integrated Security=True;Connect Timeout=30");
        }

        protected async Task Insert(string comando)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(comando, con);
            await cmd.ExecuteNonQueryAsync();
            con.Close();
        }

        protected async Task Select(string comando, Action<SqlDataReader> tratamentoLeitura)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(comando, con);
            SqlDataReader dr = await cmd.ExecuteReaderAsync();
            tratamentoLeitura(dr);
            con.Close();
        }

        public void Dispose()
        {
            con?.Close();
            con?.Dispose();
        }

    }
}
