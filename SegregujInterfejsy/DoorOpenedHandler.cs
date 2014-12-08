/*
 * Użytkownik: Kamil
 * Data: 2014-12-08
 * Godzina: 21:52
 */
using System;

namespace SegregujInterfejsy
{
	/// <summary>
	/// Description of DoorOpenedHandler.
	/// </summary>
	public class DoorOpenedHandler
	{
		public delegate void EventHandler(object sender, EventArgs args) ;
		public event EventHandler ThrowDoorOpen = delegate{};

		public void SomethingHappened()
		{
			ThrowDoorOpen(this, new EventArgs());
		}
	}
	
}
