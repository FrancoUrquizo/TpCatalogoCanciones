public class Disco
{

    public string Nombre { get; private set; }
    public string Foto { get; private set; }
    public string Artista { get; private set; }
    public string Genero { get; private set; }
    public string Productor { get; private set; }
    public int Id { get; private set; }
    public List<Canciones> CancionesD1 = new List<Canciones>();


    public Disco(string Nombre, string Foto, string Artista, string Genero, string Productor, int Id ,List<Canciones> CancionesD1 )
    {
        this.Nombre = Nombre;
        this.Foto = Foto;
        this.Artista = Artista;
        this.Genero = Genero;
        this.Productor = Productor;
        this.Id= Id;
       this.CancionesD1 = CancionesD1;
    }
}