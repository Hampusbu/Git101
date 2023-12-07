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
	using System.IO;
    using System.Drawing;
    using Neo.ApplicationFramework.Tools;
    using Neo.ApplicationFramework.Common.Graphics.Logic;
    using Neo.ApplicationFramework.Controls;
    using Neo.ApplicationFramework.Interfaces;
    
    
    public partial class HTML_Viewer
    {		
		private static Timer m_timer;
		
		FileInfo[] currentFiles;
		
		void FTP_Reciever_Opened(System.Object sender, System.EventArgs e)
		{
			m_timer = new Timer();
			m_timer.Tick += TimerTick;
			m_timer.Enabled = true;
			LoadHtmlFiles();
		}
				
		private void TimerTick(System.Object sender, System.EventArgs e)
		{
			DirectoryInfo d = new DirectoryInfo(@"/FlashDrive/Project/Project Files/html_files/");
			FileInfo[] Files = d.GetFiles("*.html"); //Getting Text files
			
			bool found;
			
			if(Files.Length != currentFiles.Length){
				LoadHtmlFiles();
				return;
			}
				
			
			foreach(FileInfo file1 in Files){
				found = false;
				foreach(FileInfo file2 in currentFiles){
					if(file1.FullName == file2.FullName && file1.CreationTime == file2.CreationTime) {
						found = true;
						break;	
					}
				}
				if(!found) {
					LoadHtmlFiles();
					return;
				}
			}
		}	
			
		void LoadHtmlFiles()
		{	

			HTMLFileList.Items.Clear();
			DirectoryInfo d = new DirectoryInfo(@"/FlashDrive/Project/Project Files/html_files/");
			currentFiles = d.GetFiles("*.html"); //Getting Text files
			int index = 0;
			string fileName;
			string alarmTitle;
			foreach(FileInfo file in currentFiles)
			{
				fileName = file.Name;
				alarmTitle = Globals.AlarmServer.getAlarmText(fileName.Substring(0,4));
				
				HTMLFileList.Items.Add(fileName +" ("+alarmTitle+")");
				index++;
			}
			InfoText.Text = "found "+currentFiles.Length +" files";
			
			// if(index>0) HTMLFileList.SelectedIndex = 0;
		}	
	
		void PreviewBtn_Click(System.Object sender, System.EventArgs e)
		{
			if(HTMLFileList.Items.Count>0 && HTMLFileList.SelectedIndex>=0){
				string stID = HTMLFileList.SelectedItem.ToString().Substring(0,4);
				int id;
				try {
					id = Int32.Parse(stID);
					Globals.Tags.RequestInfo.Value = id;
					Globals.Tags.AlarmTitle.Value = Globals.AlarmServer.getAlarmText(stID).ToUpper();
				}	
				catch {
					Globals.Tags.RequestInfo.Value = 0;
					Globals.Tags.AlarmTitle.Value = "NO TITLE";
				}
				Globals.InfoBox.Show();
			}
		}
		
		void HTML_Viewer_Closed(System.Object sender, System.EventArgs e)
		{
			m_timer.Tick -= TimerTick;
			m_timer.Enabled = false;	
		}
    }
}
