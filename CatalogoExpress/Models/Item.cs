namespace CatalogoExpress;

public class Producto
{
    private string nombre;
    private string categoria;
    private int anio;
    private double precio;
    private string descripcion;

    public Producto(string nombre, string categoria, int anio, double precio, string descripcion){
        this.nombre = nombre;
        this.categoria = categoria;
        this.anio = anio;
        this.precio = precio;
        this.descripcion = descripcion;
    }

    public string ObtenerNombre(){
        return nombre;
    }

    public string ObtenerCategoria(){
        return categoria;
    }

    public int ObtenerAnio(){
        return anio;
    }

    public double ObtenerPrecio(){
        return precio;
    }

    public string ObtenerDescripcion(){
        return descripcion;
    }

}