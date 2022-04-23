using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {
        public static void PrintRecipe(Recipe receta)
        {
            Console.WriteLine($"Receta de {receta.FinalProduct.Description}:");
            foreach (Step step in receta.pasos)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
    }
}
/* El patrón utilizado para encontrar esta solución es el de SRP. Debido a que en un comiendo la clase Recipe tenía 2 responsabilidades, 
la de generar la receta y tambien imprimirla. Lo que se hizo fue mover la responsabilidad de imprimir a la clase 
ConsolePrinter respetando el patrón SRP*/