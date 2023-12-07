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
    
    
    public partial class InfoBox
    {
		
		void InfoBox_Opened(System.Object sender, System.EventArgs e)
		{
			updateAdress();
			//Globals.Tags.RequestInfo.ValueChange += RequestInfoValueChange;
		
		}
		
		void RequestInfoValueChange(System.Object sender, System.EventArgs e)
		{
			
			updateAdress();	
		}
	
		void InfoBox_Closed(System.Object sender, System.EventArgs e)
		{
			Globals.Tags.RequestInfo.ValueChange -= RequestInfoValueChange;
		}
	
		void updateAdress()
		{
			int textId = (int)Globals.Tags.RequestInfo.Value;

			string title = Globals.AlarmServer.getAlarmText(textId.ToString("0000"));
			if (title=="0007")
			{
				title = title+Globals.Tags.AutoLoadFail.Value.ToString();
			}
			
			string htmlFileName = textId.ToString("0000")+".html";
			
			string filePath = "/FlashDrive/Project/Project Files/html_files/"+htmlFileName;

			if(System.IO.File.Exists(filePath))
			{	
				WebBrowser.Visible = true;
				WebBrowser.Height = 421;
				if(textId == 1) // shows a bar below HTML-window, containing error messages
					WebBrowser.Height = 381;
				
				WebBrowser.Address = "file://"+filePath;
			}
			else {
				WebBrowser.Visible = false;
				if(textId>0)
					ErrorText.Text = "Could not open "+filePath;
				else
					ErrorText.Text = "Invalid alarm id";
			}
			TitleText.Text = title.ToUpper();
		}
    }
}
