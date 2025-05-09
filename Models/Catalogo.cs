public static class Catalogo
{
    public static Dictionary<int, Disco> DicDiscos ;

    public static string Nombre { get; private set; }


    public static void inicializarCatalogo()
    {

        DicDiscos = new Dictionary<int, Disco>();

        Canciones D1C1 = new Canciones("Hells Bells");
        Canciones D1C2 = new Canciones("Shoot to Thrill");
        Canciones D1C3 = new Canciones("Back in Black");
        Canciones D1C4 = new Canciones("You Shook Me All Night Long");
        List<Canciones> CancionesD1 = new List<Canciones>{D1C1, D1C2, D1C3, D1C4};
        Disco disco1 = new Disco("Back in Black", "/imagenes/backinblack.jpg", "AC/DC", "Hard Rock", "Robert John 'Mutt' Lange", 1, CancionesD1);


// Disco 2
        Canciones D2C1 = new Canciones("Wanna Be Startin' Somethin'");
        Canciones D2C2 = new Canciones("Thriller");
        Canciones D2C3 = new Canciones("Beat It");
        Canciones D2C4 = new Canciones("Billie Jean");
        List<Canciones> CancionesD2 = new List<Canciones> { D2C1, D2C2, D2C3, D2C4 };
        Disco disco2 = new Disco("Thriller", "/imagenes/thriller.jpg", "Michael Jackson", "Pop", "Quincy Jones", 2, CancionesD2);

        // Disco 3
        Canciones D3C1 = new Canciones("Smells Like Teen Spirit");
        Canciones D3C2 = new Canciones("Come as You Are");
        Canciones D3C3 = new Canciones("Lithium");
        Canciones D3C4 = new Canciones("In Bloom");
        List<Canciones> CancionesD3 = new List<Canciones> { D3C1, D3C2, D3C3, D3C4 };
        Disco disco3 = new Disco("Nevermind", "/imagenes/nevermind.jpg", "Nirvana", "Grunge", "Butch Vig", 3, CancionesD3);

        // Disco 4
        Canciones D4C1 = new Canciones("Speak to Me");
        Canciones D4C2 = new Canciones("Breathe");
        Canciones D4C3 = new Canciones("Time");
        Canciones D4C4 = new Canciones("Money");
        List<Canciones> CancionesD4 = new List<Canciones> { D4C1, D4C2, D4C3, D4C4 };
        Disco disco4 = new Disco("The Dark Side of the Moon", "/imagenes/darkside.jpg", "Pink Floyd", "Progressive Rock", "Alan Parsons", 4, CancionesD4);

        // Disco 5
        Canciones D5C1 = new Canciones("Taxman");
        Canciones D5C2 = new Canciones("Eleanor Rigby");
        Canciones D5C3 = new Canciones("I'm Only Sleeping");
        Canciones D5C4 = new Canciones("Here, There and Everywhere");
        List<Canciones> CancionesD5 = new List<Canciones> { D5C1, D5C2, D5C3, D5C4 };
        Disco disco5 = new Disco("Revolver", "/imagenes/revolver.jpg", "The Beatles", "Rock", "George Martin", 5, CancionesD5);

        // Disco 6
        Canciones D6C1 = new Canciones("Like a Rolling Stone");
        Canciones D6C2 = new Canciones("Tombstone Blues");
        Canciones D6C3 = new Canciones("It Takes a Lot to Laugh, It Takes a Train to Cry");
        Canciones D6C4 = new Canciones("Highway 61 Revisited");
        List<Canciones> CancionesD6 = new List<Canciones> { D6C1, D6C2, D6C3, D6C4 };
        Disco disco6 = new Disco("Highway 61 Revisited", "/imagenes/highway61.jpg", "Bob Dylan", "Folk Rock", "Bob Johnston", 6, CancionesD6);

        // Disco 7
        Canciones D7C1 = new Canciones("Good Times Bad Times");
        Canciones D7C2 = new Canciones("Babe I'm Gonna Leave You");
        Canciones D7C3 = new Canciones("Dazed and Confused");
        Canciones D7C4 = new Canciones("Communication Breakdown");
        List<Canciones> CancionesD7 = new List<Canciones> { D7C1, D7C2, D7C3, D7C4 };
        Disco disco7 = new Disco("Led Zeppelin II", "/imagenes/ledzeppelin2.jpg", "Led Zeppelin", "Hard Rock", "Jimmy Page", 7, CancionesD7);

        // Disco 8
        Canciones D8C1 = new Canciones("Imagine");
        Canciones D8C2 = new Canciones("Crippled Inside");
        Canciones D8C3 = new Canciones("Jealous Guy");
        Canciones D8C4 = new Canciones("It's So Hard");
        List<Canciones> CancionesD8 = new List<Canciones> { D8C1, D8C2, D8C3, D8C4 };
        Disco disco8 = new Disco("Imagine", "/imagenes/imagine.jpg", "John Lennon", "Rock", "Phil Spector", 8, CancionesD8);


       

       DicDiscos.Add(disco1.Id, disco1);
       DicDiscos.Add(disco2.Id, disco2);
       DicDiscos.Add(disco3.Id, disco3);
       DicDiscos.Add(disco4.Id, disco4);
       DicDiscos.Add(disco5.Id, disco5);
       DicDiscos.Add(disco6.Id, disco6);
       DicDiscos.Add(disco7.Id, disco7);
       DicDiscos.Add(disco8.Id, disco8);



    }










}


