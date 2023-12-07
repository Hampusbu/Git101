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
    
    
    public partial class ConfirmationScreen
    {
		
		void OK_Click(System.Object sender, System.EventArgs e)
		{
			if (Globals.Tags.Rear.Value == 1)
			{
				Globals.Tags.RearWheelDistance.Value=0;
				Globals.Tags.Rear.Value=0;
			}
			if (Globals.Tags.Front.Value==1)
			{
				Globals.Tags.FrontWheelDistance.Value=0;
				Globals.Tags.Front.Value=0;
		
			}
			
			if (Globals.Tags.STDCalcSequence.Value == 1)
			{
				Globals.Tags.StartSTDCalc.Value=1;
			}
			else if (Globals.Tags.STDCalcSequence.Value == 2)
			{
				Globals.Tags.StartSTDCalc.Value=2;
			}
			else
			{
				Globals.Tags.StartSTDCalc.Value=3;
			}
			
			Globals.Tags.STDCalcSequence.Value=0;
			Globals.ConfirmationScreen.Close();
		}
		
		void Cancel_Click(System.Object sender, System.EventArgs e)
		{
			Globals.Tags.Rear.Value=0;
			Globals.Tags.Front.Value=0;
			Globals.Tags.STDCalcSequence.Value=0;
			Globals.ConfirmationScreen.Close();
		}
		
		void ConfirmationScreen_Opened(System.Object sender, System.EventArgs e)
		{
			if (Globals.Tags.STDCalcSequence.Value != 0)
			{
				LoadedMsg.Visible=true;
			}
			else
			{
				LoadedMsg.Visible=false;
			}
		}
    }
}
