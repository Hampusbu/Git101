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
    
    
    public partial class ScreenSaver
    {
		
		  void ScreenSaver_Opened(System.Object sender, System.EventArgs e)
		{
			Globals.Tags.ToggleScreenSaver.Value = 1;
			// Globals.Tags.UpdateValuesFromCVC.Value = 1;
			//Globals.Security.Logout();
			Globals.Tags.EncoderCalibrateOn.Value = 0;
			Globals.Tags.SpeedCalibrateOn.Value = 0;
			Globals.Tags.LaserCalibrateOn.Value = 0;
			Globals.Tags.BlockedStatus.ValueChange += UpdateBlockedText;
			Globals.Tags.BlockingID.ValueChange += UpdateBlockedText;
			if (Globals.Tags.BlockedStatus.Value == 0){BlockedID.Text = "Unknown";}
			else if (Globals.Tags.BlockedStatus.Value == 1){BlockedID.Text = "None";}
			else if (Globals.Tags.BlockedStatus.Value == 2){BlockedID.Text = "Blocked by SSIO";}
			
			else if (Globals.Tags.BlockedStatus.Value == 3)
		
			{	
				BlockedID.Text = "Blocked by AGV " + Globals.Tags.BlockingID.Value.ToString();
			}
		}
			void ScreenSaver_Closed(System.Object sender, System.EventArgs e)
		{
			Globals.Tags.ToggleScreenSaver.Value = 0;
			Globals.Tags.BlockedStatus.ValueChange -= UpdateBlockedText;
			Globals.Tags.BlockingID.ValueChange -= UpdateBlockedText;
		}
		
			void ScreenSaver_Closing(System.Object sender, System.ComponentModel.CancelEventArgs e)
			{
			}
		
			void UpdateBlockedText (System.Object sender, System.EventArgs e)
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
