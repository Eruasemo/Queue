using System;

public class Cola
{
	private Nodo primero;
	private Nodo ultimo;
	private string nombre;
	
	public Cola(string nombreCola)
	{
		nombre = nombreCola;
		primero = ultimo = null;
	}

	public Cola()
    {
		nombre = "Cola";
		primero = ultimo = null;
    }

	public bool estaVacia()
    {
		return primero == null;
    }

	public void Encolar(object articulo)
    {
		if (estaVacia())
			primero = ultimo = new Nodo(articulo);
        else
        {
			ultimo = ultimo.Siguiente = new Nodo(articulo);
			//ultimo.Siguiente = primero;
		}
			
	}

	public object Desencolar()
    {
        if (estaVacia())
        {
			throw new ListaVaciaException(nombre);
        }

		object objetoBorrado = primero.Dato;

		 /* if (primero == ultimo)
		  {
			  primero = ultimo = null;
		  }
		  else
		  {
			  primero = primero.Siguiente;
		  }*/
		primero = primero.Siguiente;

		return objetoBorrado;
    }

	
}
