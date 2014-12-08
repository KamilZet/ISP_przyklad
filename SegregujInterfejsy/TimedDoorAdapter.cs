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
		private ITimedDoor timedDoor;
		
		public TimedDoorAdapter(ITimedDoor _door)
		{
			timedDoor = _door;
			handler = new DoorOpenedHandler();
			handler.ThrowDoorOpen += (sender,args)=>{respondToEvent();}
		}
		
		private void respondToEvent(){}
					
		private DoorOpenedHandler handler;
		
		public virtual void TimeOut(int _timeOutId){
			timedDoor.DoorTimeOut(_timeOutId);
		}
		public int TimeLimit{
			get{return 1;}
		}
		
		
		
		
		
	}
}
