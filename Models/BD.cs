using System.Data.SqlClient;
using Dapper;
//namesapce
public static class BD
{
    public static string _connectionString = @"Server=localhost;
    Database=Elecciones2023;Trusted_Connection=True;";

    
    public static void AgregarCandidato(Candidato can)
    {
        using(SqlConnection BD = new SqlConnection(_connectionString))
        {
            string sql= "INSERT INTO Candidato(Apellido, Nombre, FechaNacimiento) VALUES(Kuper, Maiu, 08/06/2007)";
            =BD.Query<,>(sql).ToList();
        }
    }
    /*

    public static void EliminarCandidato(int idCandidato)
    {

    }
    public static Partido VerInfoPartido(int idPartido)
    {
        return ;
    }
    public static Candidato VerInfoCandidato(int idCandidato)
    {
        return ;
    }
    public static Partido ListarPartidos()
    {
        return a;
    }
    public static Candidato ListarCandidatos(int idPartido)
    {
        return ;
    }
*/
}