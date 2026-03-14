
class Carrito
{
    private int tamanio;
    private Producto[] prod;

    public Carrito()
    {
        tamanio = 0;
        prod = null;

    }

    public void agregarProducto(Producto p)
    {
     if (p.stock > 0)
        {   
        Producto[] aux = new Producto[tamanio + 1];

        for (int i = 0; i < tamanio; i++)
        {
            aux[i] = prod[i];
        }
        aux[tamanio] = p;
        prod = aux;
        tamanio++;   
        p.stock--;         
        } else
        {
            Console.WriteLine("Producto no disponible");
        }
    }

    public double mostrarTotal()
    {
        double total = 0;
        for (int i = 0; i < tamanio; i++)
        {
            total += prod[i].obtenerPrecio();
        }
        return total;
    }
    public int cantidadProductos()
    {
        return tamanio;
    }

    public void mostrarCarrito()
    {
        if (tamanio == 0)
        {
            Console.WriteLine("Carrito vacio");
            return;
            }

        for (int i = 0; i < tamanio; i++)
        {
            Console.WriteLine("Nombre Producto: " + prod[i].obtenerNombre + " - Precio: " + prod[i].obtenerPrecio);
        }
        }
    };