//--------------------------------------------------------------
// Press F1 to get help about using script.
// To access an object that is not located in the current class, start the call with Globals.
// When using events and timers be cautious not to generate memoryleaks,
// please see the help for more information.
//---------------------------------------------------------------

// Keeps track of incactivity, if #seconds of inactivity is larger
// than Incactivity Timeout, go to screen saver


namespace Neo.ApplicationFramework.Generated
{
    using System.Windows.Forms;
    using System;
    using System.Drawing;
    using Neo.ApplicationFramework.Tools;
    using Neo.ApplicationFramework.Common.Graphics.Logic;
    using Neo.ApplicationFramework.Controls;
    using Neo.ApplicationFramework.Interfaces;
    
    
    public partial class ScreenSaverTimer
    {
		private static Timer m_timer;
		private int MouseX = -1;
		private int MouseY = -1;
		private int MouseMoved = 0;
		private static int InactTime = 90;

		
		void ScreenSaverTimer_Created(System.Object sender, System.EventArgs e)
		{
			// Set up timer that monitors if the mouse has moved
			
			m_timer = new Timer();
			m_timer.Interval = 1000;
			m_timer.Tick += TimerTick;
			m_timer.Enabled = true;	
			Globals.Tags.InactivityTimeout.ValueChange += UpdateTimeout;
		}
		
		private void TimerTick(System.Object sender, System.EventArgs e)
		{
			int x = System.Windows.Forms.Control.MousePosition.X;
			int y = System.Windows.Forms.Control.MousePosition.Y;
						
			if( ( Math.Abs(MouseX-x) > 5 ) || ( Math.Abs(MouseY-y) > 5 ) )
			{
				MouseMoved=0;						
			}
			else
			{
				// Increment number of seconds since the mouse moved
				MouseMoved++;
				
				// Check if we want the inactivity function to be active and
				// if mouse hasn't been moved for a specific time
				if(MouseMoved > InactTime)
				{
					Globals.Tags.ToggleScreenSaver.Value = 1;			
				}
				else if(Globals.Tags.ToggleScreenSaver.Value == 1 &&
				Globals.Tags.ConnectionBroken.Value == 0){
					Globals.ScreenSaver.Show();	
				}
			}			
			MouseX = x;
			MouseY = y;	
		}
		
		void UpdateTimeout(System.Object sender, System.EventArgs e)
		{
			if(Globals.Tags.InactivityTimeout.Value > 60)
			{
				InactTime = (int) Globals.Tags.InactivityTimeout.Value;
			}
		}
	}
}
