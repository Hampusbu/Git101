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
    
    
    public partial class DriveParameters1
    {

		
		void Modify_MouseUp(System.Object sender, System.Windows.Forms.MouseEventArgs e)
		{
			// load old values
			StopOld.Text = Globals.Tags.SpeedStopTolerance.Value.ToString();
			MaxSpeedOld.Text = Globals.Tags.MaxSpeed.Value.ToString();
			EncScaleOld.Text = Globals.Tags.EncoderScalingDrive1.Value.ToString();
		
		}
    }
}
