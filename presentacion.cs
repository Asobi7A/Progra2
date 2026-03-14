class PresentacionTienda
{
private Inventario i;

private accesoUser user;

public PresentacionTienda(Inventario i, accesoUser user)
    {
        this.i = i;
        this.user = user;
    }

    public void ajustarInventario(Inventario x)
    {
        i = x;
    }

    public void presentarInv()
    {
        if (i.obtenerTam() == 0)
        {
            Console.WriteLine("Inventario vacio");
            return;
        }

        Console.WriteLine("Inventario:");
        for (int j = 0; j < i.obtenerTam(); j++)
        {
            Console.WriteLine("Nombre Producto: " + i.obtenerProducto(j).obtenerNombre()+ " - Stock: " + i.obtenerProducto(j).obtenerStock());
        }
    }
    public void preguntarOpcion()
    {
        user.setAdmin();
        int op = -1;
        while (op != 2)
        {
            if (user.getNivelAcceso()){
            Console.WriteLine("Ingrese opcion: \n1: Mostrar Inventario \n2: Salir \n3: Agregar Producto");
            op = Convert.ToInt32(Console.ReadLine());
            if(op == 1)
            {
                presentarInv();
            } else if (op == 2)
            {
                Console.WriteLine("Gracias por usar la app");
                return;
            } else if (op == 3)
            {        
                Console.WriteLine("Ingrese codigo:");
        string codigo = Console.ReadLine();
        Console.WriteLine("Ingrese nombre:");
        string nombre = Console.ReadLine();
        Console.WriteLine("Ingrese precio:");
        double precio = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese nro stock:");
        int stock = Convert.ToInt32(Console.ReadLine());

        Producto nuevo = new Producto(codigo, nombre, precio, stock);

                i.agregarProducto(nuevo);
            }
            else
            {
                Console.WriteLine("No existe esa opcion");
            }
            } else
            {
                Console.WriteLine("Ingrese opcion: \n1: Mostrar Inventario \n2: Salir");
            op = Convert.ToInt32(Console.ReadLine());
            if(op == 1)
            {
                presentarInv();
            } else if (op == 2)
            {
                Console.WriteLine("Gracias por usar la app");
                return;
            }else
            {
                Console.WriteLine("No existe esa opcion");
            }
                
            }
        }
    }

};

