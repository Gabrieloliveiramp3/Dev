// Define um método que imprime o tipo e a área de uma forma
using Conceito_de_Heranca;


void PrintArea(Shape shape)
{
    Console.WriteLine($"A Area do {shape.GetType().Name} e : {shape.Area()}");
    


}

// Cria objetos das classes derivadas
Rectangle rectangle = new Rectangle { Width = 5, Height = 4 };
Square square = new Square { SideLength = 5 };
Circle circle = new Circle { Radius = 3 };

// Imprime o tipo e a área de cada objeto
PrintArea(rectangle);
PrintArea(square);
PrintArea(circle);
