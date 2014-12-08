/*
 * Użytkownik: Kamil
 * Data: 2014-12-07
 * Godzina: 10:55
 */
using System;

namespace SegregujInterfejsy
{
	/// <summary>
	/// Description of TimedDoorAdapter.
	/// </summary>
	public class TimedDoorAdapter : ITimerClient
	{
		public TimedDoorAdapter(ITimedDoor _door){
			timedDoor = _door;
			
			// podmienić jakoś TimedDoor, zeby nie było ścisłej zaleznosci.
			// ewentualnie wrzucic sygn zdarzenia do int ITimedDoor
			((TimedDoor)_door).OpenEvent += new TimedDoor.DoorOpenedHandler(startCountThread);
		}
		public virtual void TimeOut(int _timeOutId){
			timedDoor.DoorTimeOut(_timeOutId);
		}
		public int TimeLimit{
			get{return timedDoor.TimeLimit;}
		}
		
		private void startCountThread(ITimedDoor _door,EventArgs args){
			Console.WriteLine("door open. count elapsed time.");
		}
					
		private ITimedDoor timedDoor;
		private DoorOpenedHandler handler;		
		
		
		
		
	}
}
