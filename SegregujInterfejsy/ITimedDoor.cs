/*
 * Użytkownik: Kamil
 * Data: 2014-12-07
 * Godzina: 11:01
 */
using System;

namespace SegregujInterfejsy
{
	/// <summary>
	/// Description of ITimedDoor.
	/// </summary>
	public interface ITimedDoor : IDoor
	{
		void DoorTimeOut(int _timeOutId);
	}
}
