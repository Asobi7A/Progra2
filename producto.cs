class Producto
{
    private string codigo;
    private string nombre;
    private double precio;

    public int stock;

    public Producto()
    {
        codigo = "";
        nombre = "";
        precio = 0;
        stock = 0;
    }
    public Producto(string codigo, string nombre, double precio, int stock)
    {
        this.codigo = codigo;
        this.nombre = nombre;
        this.precio = precio;
        this.stock = stock;
    }
    public void ajustarCodigo()
    {
        codigo = Console.ReadLine();
        
    }
    public string obtenerCodigo()
    {
        return codigo;
    }
        public void ajustarNombre()
    {
        nombre = Console.ReadLine();
        
    }
    public string obtenerNombre()
    {
        return nombre;
    }

    public void ajustarPrecio()
    {
        precio = Convert.ToDouble(Console.ReadLine());
        
    }
    public double obtenerPrecio()
    {
        return precio;
    }

        public void ajustarStock()
    {
        Console.WriteLine("Ingrese nro stock del producto:");
        stock = Convert.ToInt32(Console.ReadLine());
        
    }
    public double obtenerStock()
    {
        return stock;
    }





};

