namespace SextaClaseTarea.Models;

public class LIbro8
{
    private string? PTitulo {get; set;}
    public string? Titulo 
    {
        get{return PTitulo;}
        set{PTitulo = value.ToUpper();}
    }
    public string? Autor {get; set; }

    public LIbro8(string? Titulo, string? Autor)
    {
        this.Titulo = Titulo;
        this.Autor = Autor;
    }
}

