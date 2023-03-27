/*5) PI=3.14159,
Pedir un ángulo en grados y calcular el sen y cos
*/

//Declaro variables
double angulo=0, radianes=0, sen=0, cos=0;
string valor= "";

//Pide el ángulo
Console.WriteLine("Ingresar el ángulo: ");
valor= Console.ReadLine();
angulo= Convert.ToDouble(valor);

//Convierto a radianes
radianes= angulo*(Math.PI/180);

//Calculo el seno
sen= Math.Sin(radianes);

//Calculo el cos
cos= Math.Cos(radianes);

Console.WriteLine("El seno de {0} es {1}",angulo, sen);
Console.WriteLine("El coseno de {0} es {1}",angulo, cos);