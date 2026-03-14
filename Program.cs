Producto i = new Producto("1", "Sal", 18, 90);
Producto i2 = new Producto("2", "Salero", 40, 30);
Inventario inv1 = new Inventario();
inv1.agregarProducto(i);
inv1.agregarProducto(i2);
accesoUser user1 = new accesoUser();

accesoUser Admin1 = new accesoUser();

PresentacionTienda pres = new PresentacionTienda(inv1, Admin1); 
pres.preguntarOpcion();
