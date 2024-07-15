using System;

public class ListaVaciaException : ApplicationException
{
	public ListaVaciaException(string nombre)
		:base("La cola de nombre "+ nombre+" está vacía.")
	{

	}
}
