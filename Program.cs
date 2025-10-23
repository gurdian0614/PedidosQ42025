
// Creamos el objeto
Producto producto = new Producto();
Producto producto1 = new Producto();

producto.Id = 1;
producto.Nombre = "Laptop";
producto.Precio = 13500;
producto.Stock = 1500;
producto.MostrarInformacion();

producto1.Id = 2;
producto1.Nombre = "Mouse";
producto1.Precio = 250;
producto1.Stock = 100;
producto1.MostrarInformacion();

Pedido pedido = new Pedido(1);
pedido.AgregarItem(producto, 150);
pedido.AgregarItem(producto1, 45);
pedido.MostrarDetalles();

Console.WriteLine("********** Actualización de Productos **********");
producto.MostrarInformacion();
producto1.MostrarInformacion();

Electronico electronico = new Electronico();
electronico.Id = 3;
electronico.Nombre = "iPhone 17 Pro Max";
electronico.Precio = 52000;
electronico.Stock = 10;
electronico.GarantiaMeses = 12;
electronico.Voltaje = "110V";
electronico.MostrarInformacion();

Libro libro = new Libro();
libro.Id = 4;
libro.Nombre = "El Principito";
libro.Precio = 250;
libro.Stock = 1500;
libro.ISBN = "8536492365322";
libro.Autor = "Antoine de Saint-Exupéry";
libro.NumeroPaginas = 170;
libro.MostrarInformacion();