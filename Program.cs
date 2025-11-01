
// Creamos el objeto
Electronico electronico = new Electronico();
electronico.Id = 3;
electronico.Nombre = "iPhone 17 Pro Max";
electronico.Precio = 52000;
electronico.Stock = 10;
electronico.GarantiaMeses = 12;
electronico.Voltaje = "110V";
electronico.MostrarInformacion("San Pedro Sula");

Pedido pedido = new Pedido(1);
pedido.AgregarItem(electronico, 1);
pedido.AgregarItem(electronico, 5);

electronico.MostrarInformacion();

Libro libro = new Libro();
libro.Id = 4;
libro.Nombre = "El Principito";
libro.Precio = 250;
libro.Stock = 1500;
libro.ISBN = "8536492365322";
libro.Autor = "Antoine de Saint-Exupéry";
libro.NumeroPaginas = 170;
libro.MostrarInformacion("Tegucigalpa", "0801199900321");

Pedido pedido1 = new Pedido(1);
pedido1.AgregarItem(libro, 1);
pedido1.AgregarItem(libro, 5);

libro.MostrarInformacion();