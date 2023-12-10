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
    
    
    public partial class Tags
    {	
		
		void ToggleScreenSaver_ValueChange(System.Object sender, Core.Api.DataSource.ValueChangedEventArgs e)
		{
			if(Globals.Tags.ToggleScreenSaver.Value == 1 &&
				Globals.Tags.ConnectionBroken.Value == 0){
				Globals.ScreenSaver.Show();	
			}
		}
		
		void PLC_RequestScreenSaver_ValueChange(System.Object sender, Core.Api.DataSource.ValueChangedEventArgs e)
		{
			if(Globals.Tags.DisableLockscreen.Value == 0 && 
				Globals.Tags.PLC_RequestScreenSaver.Value) {
				Globals.Tags.ToggleScreenSaver.Value = 1;
			}
			Globals.Tags.MenusAccesible.Value = Globals.Tags.DisableLockscreen.Value ||
				!Globals.Tags.PLC_RequestScreenSaver.Value;
		}
		
		void DisableLockscreen_ValueChange(System.Object sender, Core.Api.DataSource.ValueChangedEventArgs e)
		{
			if(Globals.Tags.DisableLockscreen.Value == 0 && 
				Globals.Tags.PLC_RequestScreenSaver.Value) {
				Globals.Tags.ToggleScreenSaver.Value = 1;
			}
			Globals.Tags.MenusAccesible.Value = Globals.Tags.DisableLockscreen.Value ||
				!Globals.Tags.PLC_RequestScreenSaver.Value;
		}
		
		
		void CurrentOrderMode_ValueChange(System.Object sender, Core.Api.DataSource.ValueChangedEventArgs e)
		{
			if(Globals.Tags.CurrentOrderMode.Value == 2 ||
				Globals.Tags.CurrentOrderMode.Value == 3) {
				Globals.Tags.LocalOrderSettingsVisible.Value = 1;
			} else Globals.Tags.LocalOrderSettingsVisible.Value = 0;
			
		}
		
		void SystemTagCommunicationErrors_ValueChange(System.Object sender, Core.Api.DataSource.ValueChangedEventArgs e)
		{
			if(Globals.Tags.SystemTagCommunicationErrors.Value > 0)
			{
				Globals.Tags.ConnectionBroken.Value = 1;
				Globals.ConnectionLost.Show();
			}
			else // no active communication errors
			{
				Globals.Tags.ConnectionBroken.Value = 0;
				Globals.ScreenSaver.Show();
			}
		}
		
		void SystemTagCurrentUser_ValueChange(System.Object sender, Core.Api.DataSource.ValueChangedEventArgs e)
		{
			// Is called whenever there is a change in user
			if(Globals.Tags.ConnectionBroken.Value == 1) 
				Globals.ConnectionLost.Show();
			else {
				if(Globals.Tags.SystemTagCurrentUser.Value == String.Empty && Globals.Tags.ToggleScreenSaver.Value == 0) 
					Globals.Home.Show();
	
				Globals.Tags.IOForceMode.Value = 0;
			}
		}
		
		void Hr1_ValueChange(System.Object sender, Core.Api.DataSource.ValueChangedEventArgs e)
		{
			Globals.Tags.Hr1Internal.Value = (Globals.Tags.Hr1.Value/1000.0);
		}
		
		void Hr2_ValueChange(System.Object sender, Core.Api.DataSource.ValueChangedEventArgs e)
		{
			Globals.Tags.Hr2Internal.Value = (Globals.Tags.Hr2.Value/1000.0);
		}
		
		void Hr3_ValueChange(System.Object sender, Core.Api.DataSource.ValueChangedEventArgs e)
		{
			Globals.Tags.Hr3Internal.Value = (Globals.Tags.Hr3.Value/1000.0);
		}
		
		void Hr4_ValueChange(System.Object sender, Core.Api.DataSource.ValueChangedEventArgs e)
		{
			Globals.Tags.Hr4Internal.Value = (Globals.Tags.Hr4.Value/1000.0);
		}
		
		void Shift1_ValueChange(System.Object sender, Core.Api.DataSource.ValueChangedEventArgs e)
		{
			Globals.Tags.Shift1Internal.Value = (Globals.Tags.Shift1.Value/1000.0);
		}
		
		void Shift2_ValueChange(System.Object sender, Core.Api.DataSource.ValueChangedEventArgs e)
		{
			Globals.Tags.Shift2Internal.Value = (Globals.Tags.Shift2.Value/1000.0);
		}
		
		void Shift3_ValueChange(System.Object sender, Core.Api.DataSource.ValueChangedEventArgs e)
		{
			Globals.Tags.Shift3Internal.Value = (Globals.Tags.Shift3.Value/1000.0);
		}
		
		void Shift4_ValueChange(System.Object sender, Core.Api.DataSource.ValueChangedEventArgs e)
		{
			Globals.Tags.Shift4Internal.Value = (Globals.Tags.Shift4.Value/1000.0);
		}
		
		void I_Instant_ValueChange(System.Object sender, Core.Api.DataSource.ValueChangedEventArgs e)
		{
			Globals.Tags.Inst_I_Internal.Value = (Globals.Tags.I_Instant.Value/1000.0);
		}
		
		void RunningAvg_ValueChange(System.Object sender, Core.Api.DataSource.ValueChangedEventArgs e)
		{
			Globals.Tags.InstAvgInternal.Value = (Globals.Tags.RunningAvg.Value/1000.0);
		}
		
		
	
		//void DigitalInput30_ValueOn(System.Object sender, System.EventArgs e)
		//{
		//	Globals.RFID.Show();							
		//}
		
		void DigitalInput30_ValueOff(System.Object sender, System.EventArgs e)
		{
			if (Globals.Tags.GetTrunkValue.Value)
			{
				Globals.Home.Show();
			}
		}
		

			
	
    }
}
