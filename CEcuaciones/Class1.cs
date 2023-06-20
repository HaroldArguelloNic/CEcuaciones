using System;

namespace MisClases.ES
{
    public class Leer //Clase leer
    {
        public static short datoShort()
        {
			try
			{
				return Int16.Parse(Console.ReadLine());
			}
			catch (FormatException)
			{
				return Int16.MinValue;//valor mas pequeño
			}
        }
		public static int datoInt()
		{
			try
			{
                return Int32.Parse(Console.ReadLine());
            }
			catch (FormatException)
			{
				return Int32.MinValue;
			}
		}
		public static long datoLong()
		{
			try
			{
				return Int64.Parse(Console.ReadLine());
			}
			catch (FormatException)
			{
				return Int64.MinValue;
			}
		}
		public static float datoFloat()
		{
			try
			{
				return Single.Parse(Console.ReadLine());
			}
			catch (FormatException)
			{
				return Single.MinValue;
			}
		}
		public static double datoDouble()
		{
			try
			{
				return Double.Parse(Console.ReadLine());
			}
			catch (FormatException)
			{
				return Double.NaN;
			}
		}
    }
}