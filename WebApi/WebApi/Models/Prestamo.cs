using WebApi.Models.Base;

namespace WebApi.Models;

public class Prestamo: Model
{

    public int? bookid {get; set;}

    public int? Usuarioid {get;set;}

    public string? Devuelto {get;set;}

    public DateTime Loandate {get; set;}

    public DateTime FechaDevolucion {get;set;}

    public virtual Usuario? Usuario { get; set;} = default!;
    public virtual Book? Book { get; set;} = default!;
}