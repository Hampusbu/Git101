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
    public partial class HTML_Viewer : Background, Neo.ApplicationFramework.Interfaces.ISupportMultiLanguage {
        
        private Neo.ApplicationFramework.Controls.Controls.ListBox m_HTMLFileList;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text1;
        
        private Neo.ApplicationFramework.Controls.Controls.Button m_PreviewBtn;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_InfoText;
        
        private bool m_Initialized_HTML_Viewer;
        
        public HTML_Viewer() {
            this.InitializeComponent();
            this.PreviewBtn.Click += new System.EventHandler(this.PreviewBtn_Click);
            this.Adapter.Closed += new System.EventHandler(this.HTML_Viewer_Closed);
            this.Adapter.Opened += new System.EventHandler(this.FTP_Reciever_Opened);
            this.ApplyLanguageInitialize();
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.ListBoxCFAdapter HTMLFileList {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ListBoxCFAdapter>(this.m_HTMLFileList);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text1 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text1);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter PreviewBtn {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter>(this.m_PreviewBtn);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter InfoText {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_InfoText);
            }
        }
        
        private void InitializeComponent() {
            Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper symbolintervalmapper1 = new Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper();
            this.m_HTMLFileList = new Neo.ApplicationFramework.Controls.Controls.ListBox();
            this.m_Text = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_Text1 = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_PreviewBtn = new Neo.ApplicationFramework.Controls.Controls.Button();
            this.m_InfoText = new Neo.ApplicationFramework.Controls.Controls.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_HTMLFileList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PreviewBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_InfoText)).BeginInit();
            this.SuspendLayout();
            // 
            // HTML_Viewer
            // 
            this.BorderStyle = Neo.ApplicationFramework.Interfaces.ScreenBorderStyle.ThreeDBorder;
            this.ControlBox = false;
            // 
            // m_HTMLFileList
            // 
            this.m_HTMLFileList.BackColor = System.Drawing.Color.White;
            this.m_HTMLFileList.EnabledDynamicsValue = true;
            this.m_HTMLFileList.FontFamily = "Tahoma";
            this.m_HTMLFileList.FontSizePixels = 15;
            this.m_HTMLFileList.ForeColor = System.Drawing.Color.Black;
            this.m_HTMLFileList.Location = new System.Drawing.Point(28, 106);
            this.m_HTMLFileList.Name = "m_HTMLFileList";
            this.m_HTMLFileList.Size = new System.Drawing.Size(545, 257);
            this.m_HTMLFileList.TabIndex = 2147483647;
            this.m_HTMLFileList.VisibleDynamicsValue = true;
            // 
            // m_Text
            // 
            this.m_Text.BlinkDynamicsValue = false;
            this.m_Text.Bold = true;
            this.m_Text.DelayMouseInputPeriod = 0;
            this.m_Text.EnabledDynamicsValue = true;
            this.m_Text.FontSizePixels = 19;
            this.m_Text.Foreground = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.m_Text.Height = 28;
            this.m_Text.Left = 6;
            this.m_Text.Name = "m_Text";
            this.m_Text.Padding = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(4.75D, 0D, 4.75D, 1D);
            this.m_Text.ScreenOwnerName = "HTML_Viewer";
            this.m_Text.Top = 10;
            this.m_Text.VisibleDynamicsValue = true;
            this.m_Text.Width = 117;
            // 
            // m_Text1
            // 
            this.m_Text1.BlinkDynamicsValue = false;
            this.m_Text1.DelayMouseInputPeriod = 0;
            this.m_Text1.EnabledDynamicsValue = true;
            this.m_Text1.FontSizePixels = 15;
            this.m_Text1.Height = 28;
            this.m_Text1.Left = 21;
            this.m_Text1.Name = "m_Text1";
            this.m_Text1.Padding = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(3.75D, 0D, 3.75D, 1D);
            this.m_Text1.ScreenOwnerName = "HTML_Viewer";
            this.m_Text1.Top = 66;
            this.m_Text1.VisibleDynamicsValue = true;
            this.m_Text1.Width = 176;
            // 
            // m_PreviewBtn
            // 
            this.m_PreviewBtn.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(188)))), ((int)(((byte)(166))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_PreviewBtn.BlinkDynamicsValue = false;
            this.m_PreviewBtn.Bold = true;
            this.m_PreviewBtn.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_PreviewBtn.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(1D, 1D, 1D, 1D);
            this.m_PreviewBtn.DelayMouseInputPeriod = 0;
            this.m_PreviewBtn.EnabledDynamicsValue = true;
            this.m_PreviewBtn.FontSizePixels = 11;
            this.m_PreviewBtn.ForceTransparency = true;
            this.m_PreviewBtn.Foreground = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.m_PreviewBtn.Height = 50;
            this.m_PreviewBtn.IndicatorMargin = null;
            this.m_PreviewBtn.Left = 591;
            this.m_PreviewBtn.Name = "m_PreviewBtn";
            this.m_PreviewBtn.RequiresTransparency = true;
            this.m_PreviewBtn.ScreenOwnerName = "HTML_Viewer";
            this.m_PreviewBtn.SymbolIntervalMapper = symbolintervalmapper1;
            this.m_PreviewBtn.TextHeight = 27;
            this.m_PreviewBtn.TextValue = 0D;
            this.m_PreviewBtn.TextWidth = 110;
            this.m_PreviewBtn.Top = 313;
            this.m_PreviewBtn.Value = 0D;
            this.m_PreviewBtn.VisibleDynamicsValue = true;
            this.m_PreviewBtn.VisualPropertiesHashCode = 2002145609;
            this.m_PreviewBtn.Width = 120;
            this.m_PreviewBtn.WordWrap = true;
            // 
            // m_InfoText
            // 
            this.m_InfoText.AutoSize = false;
            this.m_InfoText.BlinkDynamicsValue = false;
            this.m_InfoText.DelayMouseInputPeriod = 0;
            this.m_InfoText.EnabledDynamicsValue = true;
            this.m_InfoText.FontSizePixels = 15;
            this.m_InfoText.Height = 30;
            this.m_InfoText.Italic = true;
            this.m_InfoText.Left = 248;
            this.m_InfoText.Name = "m_InfoText";
            this.m_InfoText.Padding = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(3.75D, 0D, 3.75D, 1D);
            this.m_InfoText.ScreenOwnerName = "HTML_Viewer";
            this.m_InfoText.TextHorizontalAlignment = "Right";
            this.m_InfoText.Top = 66;
            this.m_InfoText.VisibleDynamicsValue = true;
            this.m_InfoText.Width = 324;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.IsCacheable = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.ModalScreen = true;
            this.Name = "HTML_Viewer";
            this.PopupScreen = false;
            this.ScreenID = null;
            this.ScreenTitle = "";
            this.StyleName = "";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.m_Initialized_HTML_Viewer = true;
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
            if (!m_Initialized_HTML_Viewer) {
                return;
            }
            this.AddControls();
            this.AddDrawingPrimitives();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override void AddControls() {
            this.Controls.Add(this.m_HTMLFileList);
            ((System.ComponentModel.ISupportInitialize)(this.m_HTMLFileList)).EndInit();
            base.AddControls();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override void AddDrawingPrimitives() {
            base.AddDrawingPrimitives();
            this.DrawingPrimitives.Add(this.m_Text);
            this.DrawingPrimitives.Add(this.m_Text1);
            this.DrawingPrimitives.Add(this.m_PreviewBtn);
            this.DrawingPrimitives.Add(this.m_InfoText);
            ((System.ComponentModel.ISupportInitialize)(this.m_Text)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PreviewBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_InfoText)).EndInit();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private void ApplyLanguageInternal() {
            Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager resources = new Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager(typeof(HTML_Viewer));
            this.m_Text.Text = resources.GetText("HTML_Viewer.Text.Text", "HTML VIEWER");
            this.m_Text1.Text = resources.GetText("HTML_Viewer.Text1.Text", "HTML-Files on display:");
            this.m_PreviewBtn.Text = resources.GetText("HTML_Viewer.PreviewBtn.Text", "PREVIEW SELECTED");
            this.m_InfoText.Text = resources.GetText("HTML_Viewer.InfoText.Text", "Text");
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
            if (!m_Initialized_HTML_Viewer) {
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
