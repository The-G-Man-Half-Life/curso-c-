namespace SextaClaseTarea.Models;

public class Libro9
{
    private  String? PTitulo {get; set;}
    public  String? Titulo 
    {
        get{return PTitulo;}
        set{PTitulo = value.ToUpper();}
    }
    public  String? Autor {get; set;}
    public  String? Texto {get; set;}
    public int CantidadDePalabras {get;}


    private int ContarPalabras()
    {
        char[] separador = {' ', ',','.',';',':'};
        var palabrasEnLista = this.Texto.Split(separador);
        int CantidadDePalabras = palabrasEnLista.Length;
        return CantidadDePalabras;
    }

    public Libro9(string? Titulo, string? Autor, string? Texto)
    {
        this.Titulo = Titulo;
        this.Autor = Autor;
        this.Texto = Texto;
        this.CantidadDePalabras = ContarPalabras();
    }
}