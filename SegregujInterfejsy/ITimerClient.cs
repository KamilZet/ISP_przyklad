/*
 * Użytkownik: Kamil
 * Data: 2014-12-06
 * Godzina: 22:09
 */
using System;

namespace SegregujInterfejsy
{
	/// <summary>
	/// Description of TimerClient.
	/// </summary>
	public interface ITimerClient
	{
		void TimeOut(int _timeOutId);
		
		
	}
}
