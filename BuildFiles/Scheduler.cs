//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Neo.ApplicationFramework.Generated
{
	using Neo.ApplicationFramework.Tools.Actions;
	
	
	public partial class Scheduler : Neo.ApplicationFramework.Tools.Scheduler.Scheduler, Neo.ApplicationFramework.Interfaces.ISupportMultiLanguage
	{
		
		private Neo.ApplicationFramework.Tools.Scheduler.SchedulerJob m_SchedulerJob1;
		
		public Scheduler()
		{
			this.InitializeComponent();
			this.SchedulerJob1.Activated += new System.EventHandler(this.SchedulerJob1_Action_Activated);
			this.ApplyLanguageInternal();
		}
		
		public Neo.ApplicationFramework.Tools.Scheduler.SchedulerJob SchedulerJob1
		{
			get
			{
				return this.m_SchedulerJob1;
			}
			set
			{
				this.m_SchedulerJob1 = value;
			}
		}
		
		private void InitializeComponent()
		{
			this.InitializeObjectCreations();
			// 
			// Scheduler
			// 
			// 
			// SchedulerJob1
			// 
			this.SchedulerJob1.Duration = System.TimeSpan.Parse("00:00:05");
			this.SchedulerJob1.Name = "SchedulerJob1";
			this.SchedulerJob1.Period = Neo.ApplicationFramework.Interfaces.SchedulerJobPeriods.Once;
			this.SchedulerJob1.Start = new System.DateTime(2018, 8, 28, 16, 0, 0, 0);
			this.SchedulerJob1.Stop = new System.DateTime(2018, 8, 28, 15, 3, 12, 0);
			this.SchedulerJob1.StopTimeEnabled = false;
			this.SchedulerJob1.Deactivated += new System.EventHandler(this.SchedulerJob1_Deactivated);
			this.SchedulerJobs.Add(this.SchedulerJob1);
			this.ConnectDataBindings();
		}
		
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		public virtual void ConnectDataBindings()
		{
		}
		
		private void InitializeObjectCreations()
		{
			this.SchedulerJob1 = new Neo.ApplicationFramework.Tools.Scheduler.SchedulerJob();
		}
		
		private void InitializeBeginInits()
		{
		}
		
		private void InitializeEndInits()
		{
		}
		
		private void SchedulerJob1_Action_Activated(object sender, System.EventArgs e)
		{
			Neo.ApplicationFramework.Generated.Globals.Tags.NewTest.SetTag();
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		private void ApplyLanguageInternal()
		{
			Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager resources = new Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager(typeof(Scheduler));
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		void Neo.ApplicationFramework.Interfaces.ISupportMultiLanguage.ApplyLanguage()
		{
			this.ApplyLanguage();
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		protected virtual void ApplyLanguage()
		{
			this.ApplyLanguageInternal();
		}
	}
}