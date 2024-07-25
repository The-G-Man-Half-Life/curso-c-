namespace NovenaClase.Models;

public class BasicClass
{
    public string CellphoneName {get; set;}
    public string ProcessorName {get; set;}

    public BasicClass(string CellphoneName, string ProcessorName) 
    {
        this.CellphoneName = CellphoneName;
        this.ProcessorName = ProcessorName;
    }
}

