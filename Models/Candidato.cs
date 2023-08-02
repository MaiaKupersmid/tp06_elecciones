namespace TP06_Elecciones.Models;
public class Candidato
{
    public int IdCandidato {get; set;}
    public int IdPartido {get; set;}
    public string Apellido {get; set;}
    public string Nombre {get; set;}
    public DateTime FechaNacimiento {get; set;}
    public string Foto {get; set;}
    public string Postulacion {get; set;}


  public Candidato(int idCandidato,int idPartido, string apellido, string nombre, DateTime fechanacimiento, string foto, string postulacion){
        IdCandidato = idCandidato;
        IdPartido = idPartido;
        Apellido = apellido;
        Nombre = nombre;
        FechaNacimiento = fechanacimiento; 
        Foto = foto;
        Postulacion = postulacion;
    }

   public Candidato(int idPartido, string apellido, string nombre, DateTime fechanacimiento, string foto, string postulacion){
        IdPartido = idPartido;
        Apellido = apellido;
        Nombre = nombre;
        FechaNacimiento = fechanacimiento; 
        Foto = foto;
        Postulacion = postulacion;
    }
}
