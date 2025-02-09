using EjercicioPolimorfismo;

List<Guerrero> gerrero=new List<Guerrero>();
Guerrero guerrero2 = new Guerrero();
Triangulo triangulo = new Triangulo();

string opcion; 

do
{
    Console.Write("Ingrese el rango del guerrero ");
    guerrero2.categoria = Console.ReadLine();

    Console.Write("Ingrese la estrella del guerrero ");
    guerrero2.estrella= Console.ReadLine();

    gerrero.Add(guerrero2);


    Console.Write("Desea Continuar (S/N) o (s/n) ");
    opcion = Console.ReadLine();



} while (opcion.ToUpper() != "N");

foreach (Guerrero egerrero in gerrero)
{
    egerrero.Imprimir();
}

triangulo.imprimir();