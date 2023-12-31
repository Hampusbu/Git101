//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Neo.ApplicationFramework.Generated {
    using Neo.ApplicationFramework.Controls.Controls;
    using Neo.ApplicationFramework.Controls;
    using Neo.ApplicationFramework.Interfaces;
    using Neo.ApplicationFramework.Tools.Security;
    using Neo.ApplicationFramework.Tools.Actions;
    using Neo.ApplicationFramework.Common.MultiLanguage;
    
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public partial class ErrorWindow : Window640x480, Neo.ApplicationFramework.Interfaces.ISupportMultiLanguage {
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text1;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Disc;
        
        private bool m_Initialized_ErrorWindow;
        
        public ErrorWindow() {
            this.InitializeComponent();
            this.Adapter.Closed += new System.EventHandler(this.ErrorWindow_Closed);
            this.Adapter.Opened += new System.EventHandler(this.ErrorWindow_Opened);
            this.ApplyLanguageInitialize();
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text1 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text1);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Disc {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Disc);
            }
        }
        
        private void InitializeComponent() {
            this.m_Text1 = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_Disc = new Neo.ApplicationFramework.Controls.Controls.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Disc)).BeginInit();
            this.SuspendLayout();
            // 
            // ErrorWindow
            // 
            this.BorderStyle = Neo.ApplicationFramework.Interfaces.ScreenBorderStyle.SingleBorder;
            this.ControlBox = false;
            // 
            // m_Text1
            // 
            this.m_Text1.BlinkDynamicsValue = false;
            this.m_Text1.Bold = true;
            this.m_Text1.DelayMouseInputPeriod = 0;
            this.m_Text1.EnabledDynamicsValue = true;
            this.m_Text1.FontSizePixels = 15;
            this.m_Text1.Foreground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m_Text1.Height = 36;
            this.m_Text1.Left = 96;
            this.m_Text1.Name = "m_Text1";
            this.m_Text1.Padding = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(3.75D, 0D, 3.75D, 1D);
            this.m_Text1.ScreenOwnerName = "ErrorWindow";
            this.m_Text1.Top = 13;
            this.m_Text1.VisibleDynamicsValue = true;
            this.m_Text1.Width = 80;
            // 
            // m_Disc
            // 
            this.m_Disc.AutoSize = false;
            this.m_Disc.BlinkDynamicsValue = false;
            this.m_Disc.DelayMouseInputPeriod = 0;
            this.m_Disc.EnabledDynamicsValue = true;
            this.m_Disc.FontSizePixels = 10;
            this.m_Disc.Height = 417;
            this.m_Disc.Left = 82;
            this.m_Disc.Name = "m_Disc";
            this.m_Disc.Padding = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(2.5D, 0D, 2.5D, 1D);
            this.m_Disc.ScreenOwnerName = "ErrorWindow";
            this.m_Disc.Top = 62;
            this.m_Disc.VisibleDynamicsValue = true;
            this.m_Disc.Width = 634;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.IsCacheable = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.ModalScreen = true;
            this.Name = "ErrorWindow";
            this.PopupScreen = false;
            this.ScreenID = null;
            this.ScreenTitle = "";
            this.StyleName = "";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.m_Initialized_ErrorWindow = true;
            this.AddControlsAndPrimitives();
            this.ResumeLayout(false);
        }
        
        protected override Neo.ApplicationFramework.Common.Alias.Entities.AliasInstancesCF CreateInstanceData() {
            System.Collections.Generic.List<Neo.ApplicationFramework.Common.Alias.Entities.AliasInstanceCF> instanceList = new System.Collections.Generic.List<Neo.ApplicationFramework.Common.Alias.Entities.AliasInstanceCF>(1);
            instanceList.Add(this.CreateInstanceData_Default());
            Neo.ApplicationFramework.Common.Alias.Entities.AliasInstancesCF aliasInstances = new Neo.ApplicationFramework.Common.Alias.Entities.AliasInstancesCF();
            aliasInstances.Instances = instanceList.ToArray();
            return aliasInstances;
        }
        
        private Neo.ApplicationFramework.Common.Alias.Entities.AliasInstanceCF CreateInstanceData_Default() {
            Neo.ApplicationFramework.Common.Alias.Entities.AliasInstanceCF aliasinstancecf1 = new Neo.ApplicationFramework.Common.Alias.Entities.AliasInstanceCF();
            aliasinstancecf1.Name = "Default";
            aliasinstancecf1.Values = new Neo.ApplicationFramework.Common.Alias.Entities.AliasValueCF[0];
            return aliasinstancecf1;
        }
        
        protected override void BindAliases() {
        }
        
        protected override void Dispose(bool disposing) {
            base.Dispose(disposing);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override void AddControlsAndPrimitives() {
            if (!m_Initialized_ErrorWindow) {
                return;
            }
            this.AddControls();
            this.AddDrawingPrimitives();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override void AddControls() {
            base.AddControls();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override void AddDrawingPrimitives() {
            base.AddDrawingPrimitives();
            this.DrawingPrimitives.Add(this.m_Text1);
            this.DrawingPrimitives.Add(this.m_Disc);
            ((System.ComponentModel.ISupportInitialize)(this.m_Text1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Disc)).EndInit();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private void ApplyLanguageInternal() {
            Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager resources = new Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager(typeof(ErrorWindow));
            this.m_Text1.Text = resources.GetText("ErrorWindow.Text1.Text", "ERROR");
            this.m_Disc.Text = resources.GetText("ErrorWindow.Disc.Text", "Text");
            this.ApplyResourcesOnForm();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        void Neo.ApplicationFramework.Interfaces.ISupportMultiLanguage.ApplyLanguage() {
            this.ApplyLanguage();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        protected override void ApplyLanguage() {
            if (((Neo.ApplicationFramework.Interfaces.IScreen)(this)).IsCachedDeactivated) {
                return;
            }
            this.ApplyLanguageInternal();
            base.ApplyLanguage();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override void ApplyLanguageInitialize() {
            if (!m_Initialized_ErrorWindow) {
                return;
            }
            base.ApplyLanguageInitialize();
            this.ApplyLanguageInternal();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override void ConnectDataBindings() {
            base.ConnectDataBindings();
        }
    }
}
