string text;
double sal_b, ven, sal_t = 0, sal = 0;
int años;
Console.WriteLine("Ingresar su nombre: ");
text = Console.ReadLine();
Console.WriteLine("Ingresar su salario bruto: ");
sal_b = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese numero de ventas: ");
ven = double.Parse(Console.ReadLine());
Console.WriteLine("Ingresar años en la Empresa: ");
años = int.Parse(Console.ReadLine());

//proceso
if (ven <= 600)
{
    sal_t = sal_b + (ven * 0.05);
}
else if (ven > 600 && ven <= 3000)
{
    sal_t = sal_b + (ven * 0.07);
}
else if (ven > 3000)
{
    sal_t = sal_b + 300 + (ven * 0.06);
}

if (años <= 3)
{
    sal = sal_t - (sal_t * 0.065);
}
else if (años >= 4)
{
    sal = sal_t - (sal_t * 0.045);
}
Console.WriteLine("Nombre: " + text);
Console.WriteLine("Total Ganado: " + sal_t);
Console.WriteLine("Descuento " + ((sal - sal_t) * (-1)));
Console.WriteLine("Salario neto: " + sal);
