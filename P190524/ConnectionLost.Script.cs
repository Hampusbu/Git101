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
    
    
    public partial class ConnectionLost
    {
		Timer RedBlink;
		int incVal;
		
		
		void ConnectionLost_Opened(System.Object sender, System.EventArgs e)
		{
			RedBlink = new Timer();
			RedBlink.Interval = 100;
			RedBlink.Tick += TimerTick;
			RedBlink.Enabled = true;
			incVal = 10;
			Globals.Tags.SystemTagPowerLedRedIntensity.Value = 0;
			Globals.Tags.SystemTagPowerLedBlueIntensity.Value = 0;
			Advice.Visible = false;
		}
		
		void ConnectionLost_Closed(System.Object sender, System.EventArgs e)
		{
			RedBlink.Enabled = false;
			Globals.Tags.SystemTagPowerLedRedIntensity.Value = 0;
			Globals.Tags.SystemTagPowerLedBlueIntensity.Value = 100;
		}
		
		void TimerTick(System.Object sender, System.EventArgs e)
		{
			Globals.Tags.SystemTagPowerLedRedIntensity.Value = 
				(Globals.Tags.SystemTagPowerLedRedIntensity.Value + incVal);
			
			
			if(Globals.Tags.SystemTagPowerLedRedIntensity.Value>70)
			{
				incVal = -10;
			}
			else if(Globals.Tags.SystemTagPowerLedRedIntensity.Value<0)
			{
				incVal = 10;
			}
		}
		
		void Picture_MouseDown(System.Object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Advice.Visible = true;
		}
		
    }
}
