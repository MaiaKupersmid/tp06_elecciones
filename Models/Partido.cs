namespace TP06_Elecciones.Models;
public class Partido
{
    public int idPartido {get; set;}
    public string Nombre {get; set;}
    public string Logo {get; set;}
    public string SitioWeb {get; set;}
    public DateTime FechaFundacion {get; set;}
    public int CantidadDiputados {get; set;}
    public int CantidadSenadores {get; set;}

    public Partido(int IdPartido, string nombre, string logo, string sitioWeb, DateTime fechaFundacion, int cantidadDiputados, int cantidadSenadores){
        idPartido = IdPartido;
        Nombre = nombre;
        Logo = logo;
        SitioWeb = sitioWeb;
        FechaFundacion = fechaFundacion; 
        CantidadDiputados = cantidadDiputados;
        CantidadSenadores = cantidadSenadores;
    }  
    public Partido(string nombre, string logo, string sitioWeb, DateTime fechaFundacion, int cantidadDiputados, int cantidadSenadores){
        Nombre = nombre;
        Logo = logo;
        SitioWeb = sitioWeb;
        FechaFundacion = fechaFundacion; 
        CantidadDiputados = cantidadDiputados;
        CantidadSenadores = cantidadSenadores;
    }

}
