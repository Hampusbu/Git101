//--------------------------------------------------------------
// Press F1 to get help about using script.
// To access an object that is not located in the current class, start the call with Globals.
// When using events and timers be cautious not to generate memoryleaks,
// please see the help for more information.
//---------------------------------------------------------------

// This file updates the status and stop texts when
// they have been updated in the CVC

// This file uses StringTable/StringTable.xml as the 
// StringTable - database. This file can be Created, 
// Edited and transferred using OPTX2 Utilities.

// StringID 0 will always be displayed as "< none >"

namespace Neo.ApplicationFramework.Generated
{
    using System.Windows.Forms;
    using System;
    using System.Drawing;
    using Neo.ApplicationFramework.Tools;
    using Neo.ApplicationFramework.Common.Graphics.Logic;
    using Neo.ApplicationFramework.Controls;
    using Neo.ApplicationFramework.Interfaces;
	using System.IO;
	using System.Collections.Generic;
	using System.Xml;

    public partial class UpdateStrings
    {			
		int statusVal;
		int stopVal;
		bool displayStrings;
		
		string xmlPath;
		
		Dictionary<int, string> CurrentStringTable;
		
		void UpdateStrings_Created(System.Object sender, System.EventArgs e)
		{
			xmlPath = @"/FlashDrive/Project/Project Files/StringTable/StringTable.xml";
			displayStrings = true;
			CurrentStringTable = new Dictionary<int, string>();
			
			Globals.Tags.StatusString.ValueChange += StatusStringChange;
			Globals.Tags.StatusValue.ValueChange += StatusValueChange;
			Globals.Tags.StopString.ValueChange += StopStringChange;
			Globals.Tags.StopValue.ValueChange += StopValueChange;
			
			InsertStringsFromFile();
		}
		
		void StatusStringChange(System.Object sender, System.EventArgs e){
			if(displayStrings){
				int stringID = (int)Globals.Tags.StatusString.Value;
				Globals.Tags.StatusStringInternal.Value = getString(stringID, statusVal);
			}	
		}
		
		void StopStringChange(System.Object sender, System.EventArgs e){
			if(displayStrings){
				int stringID = (int)Globals.Tags.StopString.Value;
				Globals.Tags.StopStringInternal.Value = getString(stringID, stopVal);
			}
		}
		
		void StatusValueChange(System.Object sender, System.EventArgs e){
			statusVal = (int) Globals.Tags.StatusValue.Value;	
		}
		
		void StopValueChange(System.Object sender, System.EventArgs e){
			stopVal = (int)	Globals.Tags.StopValue.Value;
		}
		
		string getString(int stringID, int val){
			
			if(stringID==0) return "< none >";
			else if(CurrentStringTable.ContainsKey(stringID)){
				string text = CurrentStringTable[stringID];
				if(text.Contains("%d")){
					return text.Replace("%d", val.ToString());
				} else if(text.Contains("%x")){
					return text.Replace("%x", val.ToString("X"));
				} else {
					return text;
				}
			} else{
				return "Missing StringID "+stringID.ToString();
			}
		}
		
		public void InsertStringsFromFile(){
			// Reads from StringTable.xml and inserts content in CurrentStringTable

			displayStrings = false;
			Globals.Tags.StatusStringInternal.Value = String.Empty;
			Globals.Tags.StopStringInternal.Value = String.Empty;
			try
			{
				CurrentStringTable.Clear();

				XmlDocument stringFile = new XmlDocument();
				stringFile.Load(xmlPath);
			
				int id;
				string text;
				
				if(stringFile.DocumentElement.HasChildNodes){
					foreach(XmlNode x in stringFile.DocumentElement.ChildNodes){
						try{
							id = Int32.Parse(x.Attributes["Id"].Value);
							text = x.Attributes["Text"].Value;
							
							text = text.Replace("%D", "%d");
							text = text.Replace("%X", "%x");
							
							CurrentStringTable.Add(id, text);
						} catch {}						
					}
					displayStrings = CurrentStringTable.Count>0;
					if(displayStrings){
						int stringID = (int)Globals.Tags.StatusString.Value;
						Globals.Tags.StatusStringInternal.Value = getString(stringID, statusVal);
						stringID = (int)Globals.Tags.StopString.Value;
						Globals.Tags.StopStringInternal.Value = getString(stringID, stopVal);
					} else{
						Globals.Tags.StatusStringInternal.Value = "NO STRINGS";
						Globals.Tags.StopStringInternal.Value = "NO STRINGS";
					}
				} else {
					Globals.Tags.StatusStringInternal.Value = "NO STRINGTABLE";
					Globals.Tags.StopStringInternal.Value = "NO STRINGTABLE";
				}
			}
			catch {
				Globals.Tags.StatusStringInternal.Value = "ERROR READING STRINGTABLE.XML";
				Globals.Tags.StopStringInternal.Value = "ERROR READING STRINGTABLE.XML";
			}
		}
	}
}
