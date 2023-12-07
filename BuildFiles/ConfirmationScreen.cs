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
    public partial class ConfirmationScreen : Window500x300, Neo.ApplicationFramework.Interfaces.ISupportMultiLanguage {
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text;
        
        private Neo.ApplicationFramework.Controls.Controls.Button m_OK;
        
        private Neo.ApplicationFramework.Controls.Controls.Button m_Cancel;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_LoadedMsg;
        
        private bool m_Initialized_ConfirmationScreen;
        
        public ConfirmationScreen() {
            this.InitializeComponent();
            this.OK.Click += new System.EventHandler(this.OK_Click);
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            this.Adapter.Opened += new System.EventHandler(this.ConfirmationScreen_Opened);
            this.ApplyLanguageInitialize();
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter OK {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter>(this.m_OK);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter Cancel {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter>(this.m_Cancel);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter LoadedMsg {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_LoadedMsg);
            }
        }
        
        private void InitializeComponent() {
            Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper symbolintervalmapper1 = new Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper();
            Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper symbolintervalmapper2 = new Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper();
            this.m_Text = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_OK = new Neo.ApplicationFramework.Controls.Controls.Button();
            this.m_Cancel = new Neo.ApplicationFramework.Controls.Controls.Button();
            this.m_LoadedMsg = new Neo.ApplicationFramework.Controls.Controls.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_OK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Cancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_LoadedMsg)).BeginInit();
            this.SuspendLayout();
            // 
            // ConfirmationScreen
            // 
            this.BorderStyle = Neo.ApplicationFramework.Interfaces.ScreenBorderStyle.ThreeDBorder;
            this.ControlBox = false;
            // 
            // m_Text
            // 
            this.m_Text.AutoSize = false;
            this.m_Text.BlinkDynamicsValue = false;
            this.m_Text.DelayMouseInputPeriod = 0;
            this.m_Text.EnabledDynamicsValue = true;
            this.m_Text.FontSizePixels = 20;
            this.m_Text.Height = 52;
            this.m_Text.Left = 189;
            this.m_Text.Name = "m_Text";
            this.m_Text.Padding = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(5D, 0D, 5D, 1D);
            this.m_Text.ScreenOwnerName = "ConfirmationScreen";
            this.m_Text.TextHorizontalAlignment = "Center";
            this.m_Text.Top = 173;
            this.m_Text.VisibleDynamicsValue = true;
            this.m_Text.Width = 429;
            this.m_Text.WordWrap = true;
            // 
            // m_OK
            // 
            this.m_OK.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(188)))), ((int)(((byte)(166))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_OK.BlinkDynamicsValue = false;
            this.m_OK.Bold = true;
            this.m_OK.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_OK.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(1D, 1D, 1D, 1D);
            this.m_OK.DelayMouseInputPeriod = 0;
            this.m_OK.EnabledDynamicsValue = true;
            this.m_OK.FontSizePixels = 18;
            this.m_OK.ForceTransparency = true;
            this.m_OK.Foreground = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.m_OK.Height = 50;
            this.m_OK.IndicatorMargin = null;
            this.m_OK.Left = 165;
            this.m_OK.Name = "m_OK";
            this.m_OK.RequiresTransparency = true;
            this.m_OK.ScreenOwnerName = "ConfirmationScreen";
            this.m_OK.SymbolIntervalMapper = symbolintervalmapper1;
            this.m_OK.TextHeight = 22;
            this.m_OK.TextValue = 0D;
            this.m_OK.TextWidth = 176;
            this.m_OK.Top = 309;
            this.m_OK.Value = 0D;
            this.m_OK.VisibleDynamicsValue = true;
            this.m_OK.VisualPropertiesHashCode = -1346216348;
            this.m_OK.Width = 186;
            this.m_OK.WordWrap = true;
            // 
            // m_Cancel
            // 
            this.m_Cancel.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(188)))), ((int)(((byte)(166))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Cancel.BlinkDynamicsValue = false;
            this.m_Cancel.Bold = true;
            this.m_Cancel.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Cancel.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(1D, 1D, 1D, 1D);
            this.m_Cancel.DelayMouseInputPeriod = 0;
            this.m_Cancel.EnabledDynamicsValue = true;
            this.m_Cancel.FontSizePixels = 18;
            this.m_Cancel.ForceTransparency = true;
            this.m_Cancel.Foreground = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.m_Cancel.Height = 50;
            this.m_Cancel.IndicatorMargin = null;
            this.m_Cancel.Left = 453;
            this.m_Cancel.Name = "m_Cancel";
            this.m_Cancel.RequiresTransparency = true;
            this.m_Cancel.ScreenOwnerName = "ConfirmationScreen";
            this.m_Cancel.SymbolIntervalMapper = symbolintervalmapper2;
            this.m_Cancel.TextHeight = 22;
            this.m_Cancel.TextValue = 0D;
            this.m_Cancel.TextWidth = 176;
            this.m_Cancel.Top = 309;
            this.m_Cancel.Value = 0D;
            this.m_Cancel.VisibleDynamicsValue = true;
            this.m_Cancel.VisualPropertiesHashCode = -1346216348;
            this.m_Cancel.Width = 186;
            this.m_Cancel.WordWrap = true;
            // 
            // m_LoadedMsg
            // 
            this.m_LoadedMsg.BlinkDynamicsValue = false;
            this.m_LoadedMsg.DelayMouseInputPeriod = 0;
            this.m_LoadedMsg.EnabledDynamicsValue = true;
            this.m_LoadedMsg.FontSizePixels = 20;
            this.m_LoadedMsg.Height = 36;
            this.m_LoadedMsg.Left = 207;
            this.m_LoadedMsg.Name = "m_LoadedMsg";
            this.m_LoadedMsg.Padding = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(5D, 0D, 5D, 1D);
            this.m_LoadedMsg.ScreenOwnerName = "ConfirmationScreen";
            this.m_LoadedMsg.Top = 249;
            this.m_LoadedMsg.VisibleDynamicsValue = true;
            this.m_LoadedMsg.Width = 429;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.IsCacheable = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.ModalScreen = true;
            this.Name = "ConfirmationScreen";
            this.PopupScreen = false;
            this.ScreenID = null;
            this.ScreenTitle = "";
            this.StyleName = "";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.m_Initialized_ConfirmationScreen = true;
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
            if (!m_Initialized_ConfirmationScreen) {
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
            this.DrawingPrimitives.Add(this.m_Text);
            this.DrawingPrimitives.Add(this.m_OK);
            this.DrawingPrimitives.Add(this.m_Cancel);
            this.DrawingPrimitives.Add(this.m_LoadedMsg);
            ((System.ComponentModel.ISupportInitialize)(this.m_Text)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_OK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Cancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_LoadedMsg)).EndInit();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private void ApplyLanguageInternal() {
            Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager resources = new Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager(typeof(ConfirmationScreen));
            this.m_Text.Text = resources.GetText("ConfirmationScreen.Text.Text", "This action cannot be undone do you wish to continue?");
            this.m_OK.Text = resources.GetText("ConfirmationScreen.OK.Text", "OK");
            this.m_Cancel.Text = resources.GetText("ConfirmationScreen.Cancel.Text", "CANCEL");
            this.m_LoadedMsg.Text = resources.GetText("ConfirmationScreen.LoadedMsg.Text", "Make sure AGV is loaded prior to STD calc ");
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
            if (!m_Initialized_ConfirmationScreen) {
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