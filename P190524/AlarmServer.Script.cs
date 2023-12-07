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
	using Neo.ApplicationFramework.Interfaces.Events;
	using System.Collections.Generic;
	
    
	public partial class AlarmServer
	{					
		
		Dictionary<string,string> AlarmTextFromName;
		
		void AlarmServer_AlarmEventInfoRequested(System.Object sender, Neo.ApplicationFramework.Interfaces.Events.AlarmEventEventArgs e)
		{
			int alarmId;
			
			string name = e.AlarmEvent.AlarmItemDisplayName;
			
			// don't change length without changing in InfoBox as well
			if(name.Length == 5) 
			{
				try 
				{
					alarmId = Int32.Parse(name);
					Globals.Tags.RequestInfo.Value = alarmId;
					Globals.Tags.AlarmTitle.Value = getAlarmText(name).ToUpper();
				}	
				catch 
				{
					Globals.Tags.RequestInfo.Value = 0;
					Globals.Tags.AlarmTitle.Value = "TITLE ERROR 1";
				}
			}
			else 
			{
				Globals.Tags.RequestInfo.Value = 0;
				Globals.Tags.AlarmTitle.Value = "TITLE ERROR 2";
			}
			Globals.InfoBox.Show();
		}

		public string getAlarmText(string alarmDisplayName)
		{
			try
			{
				return AlarmTextFromName[alarmDisplayName];		
			}
			catch 
			{
				return "**MISSING TITLE IN ALARMSERVER**";
			}
		}
		
		public void createTextsFromAlarmName()
		{
			AlarmTextFromName = new Dictionary<string,string>();
			
			foreach (IAlarmGroup ag in Globals.AlarmServer.AlarmGroups)
			{
				foreach (IAlarmItem ai in ag.AlarmItems)
				{
					AlarmTextFromName.Add(ai.DisplayName,ai.Text);
				}
			}
		}
		
	}
}

