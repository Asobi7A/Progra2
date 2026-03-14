

class Inventario
{
    private int tam;
    public Producto[] inv;
    public Inventario()
    {
        tam = 0;
        inv = null;
    }

    public void agregarProducto( Producto p){
        Producto[] temp = new Producto [tam + 1];
        for (int i = 0; i < tam; i++)
        {
            temp[i] = inv[i];
        }
        temp [tam] = p;
        inv = temp;
        tam++;

    }

/*   public void mostrarInventario()
    {
        if (tam == 0)
        {
            Console.WriteLine("Inventario vacio");
            return;
        }

        Console.WriteLine("Inventario:");
        for (int i = 0; i < tam; i++)
        {
            Console.WriteLine("Nombre Producto: " + inv[i].obtenerNombre()+ " - Stock: " + inv[i].obtenerStock());
        }

    }
*/

        public Producto obtenerProducto(int pos)
    {

        return inv[pos];
    }


    public int obtenerTam()
    {
        return tam;
    }
};

