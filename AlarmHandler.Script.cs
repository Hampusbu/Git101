//--------------------------------------------------------------
// Press F1 to get help about using script.
// To access an object that is not located in the current class, start the call with Globals.
// When using events and timers be cautious not to generate memoryleaks,
// please see the help for more information.
//---------------------------------------------------------------

namespace Neo.ApplicationFramework.Generated
{
    using System.Windows.Forms;
    using System;
    using System.Drawing;
    using Neo.ApplicationFramework.Tools;
    using Neo.ApplicationFramework.Common.Graphics.Logic;
    using Neo.ApplicationFramework.Controls;
    using Neo.ApplicationFramework.Interfaces;
	using System.IO;

	public partial class AlarmHandler
	{
		int TickCounter = 0;
		
		void AlarmHandler_Created(System.Object sender, System.EventArgs e)
		{	
			// update alarm icons each second
			// alarms changed event in alarm server does not seem to work
			Timer WaitingTimer = new Timer();
			WaitingTimer.Interval = 1000;
			WaitingTimer.Tick += TimerTick;
			WaitingTimer.Enabled = true;
		}
		
		void TimerTick(System.Object sender, System.EventArgs e)
		{
			if(TickCounter<5)TickCounter++; // WAIT FOR ALARM SERVER TO START 
			else if(TickCounter == 5){ // ALARM SERVER STARTED
				Globals.AlarmServer.createTextsFromAlarmName();
				TickCounter++;
			}else{
				// Alarm server started, update alarm tags which are used in nav-bar
				Globals.Tags.AnyAlarmActive.Value = Globals.AlarmServer.IsAnyActive;
				Globals.Tags.AlarmsActive.Value = Globals.AlarmServer.NumberOfAlarms;	
			}
		}
	}
}
