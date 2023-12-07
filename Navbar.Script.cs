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
    
    
    public partial class Navbar
    {			
		void Navbar_Opened(System.Object sender, System.EventArgs e)
		{	
			UpdateBlockedText(); // call when first opened
			Globals.Tags.BlockedStatus.ValueChange += PassThrough;
			Globals.Tags.BlockingID.ValueChange += PassThrough;
			Globals.Tags.TimeStamp.ValueChange += TimeStamp_ValueChange;
			CheckTimeStamp();
		}
		
		void CheckTimeStamp()
		{
			int temp = (int)Globals.Tags.TimeStamp.Value;
			if(temp != 0 && 
				temp != Globals.Tags.PreviousTimeStamp.Value)
			{
				Globals.Tags.PreviousTimeStamp.Value = temp;
				Globals.UpdateMessage.Show();
			}
		}
						
		void TimeStamp_ValueChange(System.Object sender, System.EventArgs e)
		{
			CheckTimeStamp();
		}
		
		void Navbar_Closed(System.Object sender, System.EventArgs e)
		{
			Globals.Tags.TimeStamp.ValueChange -= TimeStamp_ValueChange;
		}			
		
		void PassThrough(System.Object sender, System.EventArgs e){ UpdateBlockedText();}
		
		void UpdateBlockedText()
		{
			if (Globals.Tags.BlockedStatus.Value == 0){BlockedID.Text = "Unknown";}
			else if (Globals.Tags.BlockedStatus.Value == 1){BlockedID.Text = "None";}
			else if (Globals.Tags.BlockedStatus.Value == 2){BlockedID.Text = "Blocked by SSIO";}
			else if (Globals.Tags.BlockedStatus.Value == 3)
			{
				BlockedID.Text = "Blocked by AGV " + Globals.Tags.BlockingID.Value.ToString();
			}
		}				
		
		
	}
}
