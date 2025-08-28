// See https://aka.ms/new-console-template for more informationpublic 
var Aseador = new Aseadores();
var Proporcion = new Proporciones();
var Propietario = new Propietarios();
var Terreno = new Terrenos();
Aseador.Cedula = "12345";
Aseador.Nombre = "rigoberto";
Aseador.Edad = 6;
Aseador.Horario = "6:00 AM - 6:00 PM";
Aseador.Salario = 23.55;
Console.WriteLine("compilo la el aseador");
Proporcion.Alto = 15;
Proporcion.Ancho = 20;
Proporcion.Capacidad = 60;
Proporcion.Id = "54321";
Console.WriteLine("compilo la proporcion");
Propietario.CantHijos = 5;
Propietario.Cedula = "09876";
Propietario.Direccion = "la paulina";
Propietario.Nombre = "octavio mesa";
Console.WriteLine("compilo el propietario");
Terreno.Ubicacion = "la paulina";
Terreno.TipoDeSuelo = "arena";
Console.WriteLine("compilo el terreno");



public class Aseadores
{
    public string Nombre = "pablo";
    public string Cedula = "";
    public int Edad = 0;
    public string Horario = "";
    public double Salario = 0.0;
    
}

public class Proporciones
{
    public string Id = "";
    public int Alto = 0;
    public int Ancho = 0;
    public int Capacidad = 0;
}

public class Propietarios
{
    public string Nombre = "";
    public string Cedula = "";
    public string Direccion = "";
    public int CantHijos = 0;
}

public class Terrenos
{
    public string Ubicacion = "";
    public string TipoDeSuelo = "";

}
