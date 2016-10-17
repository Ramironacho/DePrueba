using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeros_Ejercicios
{
    class EjerciciosSimples
    {
        public void Ejercicio1()
        {
            //1 Escriba un programa que pida al usuario que escriba su nombre, y lo salude llamándolo por su nombre.
            Console.WriteLine("Ejercicio 1");
            string nombre;
            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Hola, {0}", nombre);
            Console.ReadKey();
        }
        public void Ejercicio2()
        {
            //Escriba un programa que reciba como entrada el radio de un círculo y entregue como salida su perímetro y su área
            int radio;
            float perimetro;
            float area;
            const float pi = 3.14f;
            Console.WriteLine("Ingrese el radio del circulo: ");
            radio = Convert.ToInt32(Console.ReadLine());

            perimetro = radio *2* pi;
            area = radio * radio * pi;

            Console.WriteLine("Perimetro: {0}", perimetro);
            Console.WriteLine("Area: {0}", area);
            Console.ReadKey();
        }
        public void Ejercicio3()
        {
            //Escriba un programa que calcule el promedio de 4 notas ingresadas por el usuario:
            double nota1, nota2, nota3, nota4;
            double promedio;

            Console.WriteLine("Ingrese la primera nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la tercera nota: ");
            nota3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la cuarta nota: ");
            nota4 = Convert.ToDouble(Console.ReadLine());

            promedio = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.WriteLine("El promedio es: {0}", promedio);
            Console.ReadKey();

        }
        public void Ejercicio4()
        {
            //Escriba un programa que convierta de centímetros a pulgadas. Una pulgada es igual a 2.54 centímetros.
            float medidaCm, medidaPulgadas;
            Console.WriteLine("Ingrese la medida en centimetros: ");
            medidaCm = Convert.ToSingle(Console.ReadLine());
            medidaPulgadas = medidaCm / 2.54f;
            Console.WriteLine("{0} cm = {1} pulgadas", medidaCm, medidaPulgadas);
            Console.ReadKey();

        }
        public void Ejercicio5()
        {
            //Escriba un programa que pida al usuario un entero de tres dígitos, y entregue el número con los dígitos en orden inverso.
            int numero, centena, decena, unidad;
            
            Console.WriteLine("Ingrese un numero de tres digitos: ");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero > 999)
                Console.WriteLine("Numero Invalido");
            else
            {
                Console.WriteLine("Numero ingresado: {0}", numero);
                centena = numero / 100;
                numero = numero % 100;
                decena = numero / 10;
                numero = numero % 10;
                unidad = numero;

                Console.WriteLine("Numero Invertido; {0}{1}{2}", unidad, decena, centena);
                 
            }
            Console.ReadKey();
        }
        public void Ejercicio6()
        {
            //Escriba un programa que reciba como entrada las longitudes de los dos catetos aa y bb de un triángulo rectángulo, 
            //y que entregue como salida el largo de la hipotenusa cc del triangulo, dado por el teorema de Pitágoras: c2 = a2 + b2
            double primerLado, segundoLado;
            Console.WriteLine("Ingrese el primer lado del triangulo: ");
            primerLado = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo lado del triangulo: ");
            segundoLado = Convert.ToDouble(Console.ReadLine());
            double hipotenusa = Math.Sqrt((primerLado * primerLado) + (segundoLado * segundoLado));
            Console.WriteLine("El valor de la hipotenusa es: {0}", hipotenusa);
            Console.ReadKey();
        }
    }
}
