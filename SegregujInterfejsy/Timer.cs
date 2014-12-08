/*
 * Użytkownik: Kamil
 * Data: 2014-12-06
 * Godzina: 22:11
 */
using System;
using System.Collections;
using System.Collections.Generic;

namespace SegregujInterfejsy
{
	/// <summary>
	/// Description of Timer.
	/// </summary>
	public class Timer
	{
		
		private List<ITimerClient> Clients;
		
		public Timer()
		{
			Clients = new List<ITimerClient>();
		}
		
		public void RegisterClient(ITimerClient client)
		{
			Clients.Add(client);
			System.Threading.Thread.Sleep(client.TimeLimit);
			client.TimeOut(1);
		}
		
		
	}
}
