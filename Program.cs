
// Creamos el objeto
Producto producto = new Producto();
Producto producto1 = new Producto();

producto.Id = 1;
producto.Nombre = "Laptop";
producto.Precio = 13500;
producto.Stock = 10;
producto.MostrarInformacion();
producto.DisminuirStock(15);
producto.MostrarInformacion();

producto1.Id = 2;
producto1.Nombre = "Mouse";
producto1.Precio = 250;
producto1.Stock = 100;
producto1.MostrarInformacion();
producto1.DisminuirStock(13);
producto1.MostrarInformacion();