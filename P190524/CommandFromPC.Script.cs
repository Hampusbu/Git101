//--------------------------------------------------------------
// Press F1 to get help about using script.
// To access an object that is not located in the current class, start the call with Globals.
// When using events and timers be cautious not to generate memoryleaks,
// please see the help for more information.
//---------------------------------------------------------------

// Used by OPTX2 Utilities to execute commands.
// This function looks for a file in the /Commands
// folder and get the command from the file name

namespace Neo.ApplicationFramework.Generated
{
    using System.Windows.Forms;
    using System;
    using System.Drawing;
	using System.IO;
    using Neo.ApplicationFramework.Tools;
    using Neo.ApplicationFramework.Common.Graphics.Logic;
    using Neo.ApplicationFramework.Controls;
    using Neo.ApplicationFramework.Interfaces;
    
    public partial class CommandFromPC
    {
		
		void CommandFromPC_Created(System.Object sender, System.EventArgs e)
		{
			Timer CheckTimer = new Timer();
			CheckTimer.Interval = 1000;
			CheckTimer.Tick += TimerTick;
			CheckTimer.Enabled = true;	
		}
		
		void TimerTick(System.Object sender, System.EventArgs e){
			// If a file can be found in a folder named "Commands", the name
			// of the file is what determines which command to execute

			try{
				string file = Directory.GetFiles(@"/FlashDrive/Project/Project Files/Commands/")[0];
				setCmd(Int32.Parse(Path.GetFileName(file)));	
				File.Delete(file);
			} catch{ };
		}
		
		void setCmd(int cmd){
			if(cmd == 1){
				// show Home
				Globals.Home.Show();	
			} else if(cmd == 2){
				// show HTML Viewer
				Globals.HTML_Viewer.Show();
			} else if(cmd == 3){
				// take screenshot - Note: copied from backend of Display Application Designer
				// saves a .png picture in Screenshots folder
				Core.Api.Service.ServiceContainerCF.GetService<Neo.ApplicationFramework.Interfaces.IPrintScreenService>().PrintCurrentScreen(Neo.ApplicationFramework.Interfaces.PrintScreenAction.SaveScreenShot, Neo.ApplicationFramework.Interfaces.FileDirectory.ProjectFiles, "");
			} else if(cmd == 4){
				Globals.UpdateStrings.InsertStringsFromFile();
			}
		}
    }
}
