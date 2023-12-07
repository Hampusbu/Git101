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
    
    
    public partial class HomeScreenInfo
    {
		
		void HomeScreenInfo_Opened(System.Object sender, System.EventArgs e)
		{
			AlarmInfo.Text = string.Format("{0} alarms active. Press to show active alarms.", Globals.Tags.AlarmsActive.Value.ToString());
			Globals.Tags.AlarmsActive.ValueChange += AlarmChange;
		}
		
		void AlarmChange(System.Object sender, System.EventArgs e){
			AlarmInfo.Text = string.Format("{0} alarms active. Press to show active alarms.", Globals.Tags.AlarmsActive.Value.ToString());
		}
		
		void HomeScreenInfo_Closed(System.Object sender, System.EventArgs e)
		{
			Globals.Tags.AlarmsActive.ValueChange -= AlarmChange;
		}
		
		
    }
}
