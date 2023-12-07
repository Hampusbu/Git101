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
    
    
    public partial class VersionInformation
    {
		
		void VersionInformation_Opened(System.Object sender, System.EventArgs e)
		{
			Globals.Tags.CompilationID1.ValueChange += CompID1_Change;
			Globals.Tags.CompilationID2.ValueChange += CompID2_Change;
			Globals.Tags.TimeStamp.ValueChange += TimeStampChange;
			Globals.Tags.SoftwareVersion.ValueChange += SoftwareVersionChange;
			UpdateCompilationID();
		}
		
		void UpdateCompilationID()
		{
			if(Globals.Tags.CompilationID1.Value!=0 &&
				Globals.Tags.CompilationID2.Value!=0 &&
				Globals.Tags.TimeStamp.Value!=0 &&
				Globals.Tags.SoftwareVersion.Value!=0)
			{
				string st1 = Globals.Tags.CompilationID1.Value.ToString();
				string st2 = Globals.Tags.CompilationID2.Value.ToString();
				if(st2.Length == 6) st2 = "0"+st2;
				CompilationID.Text = st1+"_"+st2.Substring(0,6)+"_"+st2.Substring(6);
				ModDate.Text = st1.Substring(0,4)+"-"+st1.Substring(4,2)+
						"-"+st1.Substring(6,2)+", "+st2.Substring(0,2)+":"+
						st2.Substring(2,2);
				TimeStamp.Text = Globals.Tags.TimeStamp.Value.ToString();
				string Vers = Globals.Tags.SoftwareVersion.Value.ToString();
				Vers = Vers.Substring(0,1)+"."+Vers.Substring(1,1)+"."+Vers.Substring(2,1);
				SoftwareVersion.Text = Vers;
			} 
			else {
				CompilationID.Text = "-";
				ModDate.Text = "-";
				TimeStamp.Text = "-";
				SoftwareVersion.Text = "-";
			}
		}
		
		void CompID1_Change(System.Object sender, System.EventArgs e)
		{
			UpdateCompilationID();
		}
		
		void CompID2_Change(System.Object sender, System.EventArgs e)
		{
			UpdateCompilationID();
		}
		
		void TimeStampChange(System.Object sender, System.EventArgs e)
		{
			UpdateCompilationID();
		}
		
		void SoftwareVersionChange(System.Object sender, System.EventArgs e){
			UpdateCompilationID();	
		}
		
		void VersionInformation_Closed(System.Object sender, System.EventArgs e)
		{
			Globals.Tags.CompilationID1.ValueChange -= CompID1_Change;
			Globals.Tags.CompilationID1.ValueChange -= CompID2_Change;
			Globals.Tags.TimeStamp.ValueChange -= TimeStampChange;
			Globals.Tags.SoftwareVersion.ValueChange -= SoftwareVersionChange;
		}
    }
}
