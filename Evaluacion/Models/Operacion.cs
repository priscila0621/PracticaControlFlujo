using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion.Models
{
    public class Operacion
    {
        private int[] numbers = new int[100]; // Array para almacenar los números
        private int currentPosition = 0; // Para llevar control de la posición actual

        // Método para agregar un número al array
        public void AddElements(int number)
        {
            if (number < 0)
            {
                // Si el número es negativo, no se agrega al array y el método se detiene.
                throw new ArgumentException("No se pueden agregar números negativos. El proceso se ha detenido.");
            }

            if (currentPosition < numbers.Length)
            {
                numbers[currentPosition] = number;
                currentPosition++;
            }
            else
            {
                throw new InvalidOperationException("El array está lleno, no se pueden agregar más números.");
            }
        }

        // Método para obtener los elementos ingresados
        public int[] GetElements()
        {
            int[] result = new int[currentPosition];
            Array.Copy(numbers, result, currentPosition); // Copia solo los elementos válidos
            return result;
        }

        // Método para encontrar el número mayor
        public int ObtenerMayor()
        {
            if (currentPosition == 0)
            {
                throw new InvalidOperationException("No hay elementos para evaluar.");
            }

            int max = numbers[0];
            for (int i = 1; i < currentPosition; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }

        // Método para encontrar el número menor
        public int ObtenerMenor()
        {
            if (currentPosition == 0)
            {
                throw new InvalidOperationException("No hay elementos para evaluar.");
            }

            int min = numbers[0];
            for (int i = 1; i < currentPosition; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            return min;
        }

        // Método para solicitar la entrada del usuario y agregar números hasta que se ingrese un número negativo
        public void IngresarNumeros(Func<int> obtenerNumero)
        {
            while (true)
            {
                int numero = obtenerNumero();
                if (numero < 0)
                {
                    // Si el número es negativo, el proceso se detiene.
                    break;
                }
                try
                {
                    AddElements(numero);
                }
                catch (Exception)
                {
                    
                    break;
                }
            }
        }
    }
}

