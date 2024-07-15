using System;

public class Nodo
{
	private object dato;
	private Nodo siguiente;

	public Nodo(object vDato)
	{
		this.dato = vDato;
		this.siguiente = null;
	}

	public Nodo (object vDato,Nodo siguienteNodo)
    {
		this.dato = vDato;
		this.siguiente = siguienteNodo;
    }

	public Nodo Siguiente
    {
        get
        {
			return this.siguiente;
        }
        set
        {
			this.siguiente = value;
        }
    }

    public object Dato
    {
        get
        {
            return this.dato;
        }
        set
        {
            this.dato = value;
        }
    }
}
