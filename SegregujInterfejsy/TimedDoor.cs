/*
 * Użytkownik: Kamil
 * Data: 2014-12-06
 * Godzina: 21:51
 */
using System;

namespace SegregujInterfejsy
{
	
	
	
	/// <summary>
	/// Description of TimedDoor.
	/// </summary>
	public class TimedDoor : IDoor,ITimedDoor
	{
		public event DoorOpenedHandler OpenEvent;
		
		private int openTimeLimit;
		public int TimeLimit{
			get{return openTimeLimit;}
		}
		
		public TimedDoor(int limit)
		{
			openTimeLimit = limit;
		}
		public void Lock(){
			isOpened = false;
			//resetuj licznik zarejestrowanej instancji klasy || usuń z rejestru obserwowanych drzwi
		
		}	
		private TimedDoorAdapter adapter;
			public TimedDoorAdapter	Adapter{
				get
				{
					if (adapter == null) adapter = new TimedDoorAdapter(this);
					return adapter;
						
				}
			}
		
			
		
		public void Open(){
			if(OpenEvent != null)OpenEvent();
			isOpened = true;
			
		}
		private bool isOpened;
		public bool IsOpened(){
			return isOpened;
		}
		
		public void DoorTimeOut(int _timeOutId){
			Lock();
		}
	}
}
