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
    
    
    public partial class SideShiftParameters
    {
		
		void Modify_MouseUp(System.Object sender, System.Windows.Forms.MouseEventArgs e)
		{
			// load old values
			Scale1Old.Text = Globals.Tags.EncScaleFork1.Value.ToString();
			Scale2Old.Text = Globals.Tags.EncScaleFork2.Value.ToString();
			Scale3Old.Text = Globals.Tags.EncScaleFork3.Value.ToString();
			MaxOld.Text = Globals.Tags.MaxForkSpeed.Value.ToString();
		}
    }
}
