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
    
    
    public partial class Layout
    {
		private static Timer m_timer;
			

		private void TimerTick(System.Object sender, System.EventArgs e)
		{
			string NewString;
			Globals.Tags.GlobalX.Read();
			Globals.Tags.GlobalY.Read();
			NewString = Globals.Tags.GlobalX.Value.ToString()+" X, "+ Globals.Tags.GlobalY.Value.ToString()+" Y";
			GlobalPosition.Text = NewString;
		}
		
		void Layout_Closed(System.Object sender, System.EventArgs e)
		{
			m_timer.Enabled = false;
			m_timer.Tick -= TimerTick;
		}
		
		void Layout_Opened(System.Object sender, System.EventArgs e)
		{
			m_timer = new Timer();
			m_timer.Interval = 500;
			m_timer.Tick += TimerTick;
			m_timer.Enabled = true;
		}
    }
}
