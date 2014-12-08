/*
 * Użytkownik: Kamil
 * Data: 2014-12-06
 * Godzina: 21:48
 */
using System;

namespace SegregujInterfejsy
{
	class Program
	{
		public static void Main(string[] args)
		{
			TimedDoor door = new TimedDoor(1);
			Timer timer = new Timer();
			timer.RegisterClient(door.Adapter);
			door.Open();
		}
	}
}