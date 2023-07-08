Console.WriteLine("Ingrese su nombre");
//No es un ERROR, si no, una advertencia
string nombre = Console.ReadLine();
Console.WriteLine("Su nombre es: " + nombre);

Console.WriteLine("La hora es:");
DateTime fecha = DateTime.Now;
int hora = fecha.Hour;
int min = fecha.Minute;
int sec = fecha.Second;
Console.WriteLine(hora + " : " + min + " : " + sec);