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
    
    
    public partial class RFIDDiagnostics
    {
		
		void RFID_Opened(System.Object sender, System.EventArgs e)
		{
			Globals.Tags.GetTrunkValue.Value = 0;
			Globals.Tags.SetTrunkValue.Value = 0;

		}
		
		void RFID_Closed(System.Object sender, System.EventArgs e)
		{
			Globals.Tags.GetTrunkValue.Value = 0;
			Globals.Tags.SetTrunkValue.Value = 0;
			
		}

    }
}
