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
    
    
    public partial class ErrorWindow
    {
		
		void ErrorWindow_Opened(System.Object sender, System.EventArgs e)
		{
			Disc.Text = Globals.Tags.DisplayError.Value;
			Globals.Tags.DisplayError.ValueChange += ErrorChanged;
		}
			
		void ErrorChanged(System.Object sender, System.EventArgs e){
			Disc.Text = Globals.Tags.DisplayError.Value;
		}
		
		void ErrorWindow_Closed(System.Object sender, System.EventArgs e)
		{
			Globals.Tags.DisplayError.ValueChange -= ErrorChanged;
		}
	}
}
