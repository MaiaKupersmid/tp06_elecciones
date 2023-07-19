using System.Data.SqlClient;
using Dapper;
namespace TP06_Jules.Models;
public static class BD
{
    public static string _connectionString = @"Server=COMPUTADORALULI\SQLEXPRESS01;
    Database=Elecciones2023;Trusted_Connection=True;";

    public static void AgregarCandidato(Candidato can)
    {
        string sql = "INSERT INTO Candidato(Apellido, Nombre, FechaNacimiento) VALUES(@cApellido, @cNombre, @cFechaNacimiento)";
        using (SqlConnection BD = new SqlConnection(_connectionString))
        {
            BD.Execute(sql, new { cNombre = can.Nombre, cApellido = can.Apellido, cFechaNacimiento = can.FechaNacimiento });
        }
    }

    public static void EliminarCandidato(int idCandidato)
    {
        string sql = "DELETE FROM Candidato WHERE IdCandidato = @candi";
        using (SqlConnection BD = new SqlConnection(_connectionString))
        {
            BD.Execute(sql, new { candi = idCandidato });
        }
    }
    public static Partido VerInfoPartido(int idPartido)
    {
        Partido MiPartido = null;
        using (SqlConnection BD = new SqlConnection(_connectionString))
        {
            string sql = "SELECT * FROM Partido WHERE idPartido = @ID";
            MiPartido = BD.QueryFirstOrDefault<Partido>(sql, new { ID = idPartido });
        }
        return MiPartido;
    }
    public static Candidato VerInfoCandidato(int idCandidato)
    {
        Candidato MiCandidato = null;
        using (SqlConnection BD = new SqlConnection(_connectionString))
        {
            string sql = "SELECT * FROM Candidato WHERE idCandidato = @ID";
            MiCandidato = BD.QueryFirstOrDefault<Candidato>(sql, new { ID = idCandidato });
        }
        return MiCandidato;
    }

    public static List<Partido> ListarPartidos()
    {
        List<Partido> ListadoPartidos = new List<Partido>();
        using (SqlConnection BD = new SqlConnection(_connectionString))
        {
            string sql = "SELECT * FROM Partido";
            ListadoPartidos = BD.Query<Partido>(sql).ToList();
        }
        return ListadoPartidos;
    }

    public static List<Candidato> ListarCandidatos(int idPartido)
    {
        List<Candidato> ListadoCandidatos = new List<Candidato>();
        using (SqlConnection BD = new SqlConnection(_connectionString))
        {
            string sql = "SELECT * FROM Candidato WHERE idPartido = @ID";
            ListadoCandidatos = BD.Query<Candidato>(sql).ToList();
        }
        return ListadoCandidatos;
    }

}
