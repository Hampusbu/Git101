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
    public partial class UpdateMessage : Window500x300, Neo.ApplicationFramework.Interfaces.ISupportMultiLanguage {
        
        private Neo.ApplicationFramework.Controls.Controls.RectangleCF m_Rectangle;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text;
        
        private Neo.ApplicationFramework.Controls.Controls.Button m_Button;
        
        private Neo.ApplicationFramework.Controls.Controls.Button m_Button1;
        
        private Neo.ApplicationFramework.Controls.Symbol.PictureCF m_Picture;
        
        private Neo.ApplicationFramework.Controls.Symbol.PictureCF m_Picture1;
        
        private bool m_Initialized_UpdateMessage;
        
        public UpdateMessage() {
            this.InitializeComponent();
            this.m_Button.Click += new System.EventHandler(this.m_Button_Action_Click);
            this.m_Button1.Click += new System.EventHandler(this.m_Button1_Action_Click);
            this.m_Picture1.MouseDown += new System.EventHandler(this.m_Picture1_Action_MouseDown);
            this.ApplyLanguageInitialize();
        }
        
        protected Neo.ApplicationFramework.Controls.Script.ShapeCFAdapter Rectangle {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ShapeCFAdapter>(this.m_Rectangle);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter Button {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter>(this.m_Button);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter Button1 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter>(this.m_Button1);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter Picture {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter>(this.m_Picture);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter Picture1 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter>(this.m_Picture1);
            }
        }
        
        private void InitializeComponent() {
            Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper symbolintervalmapper1 = new Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper();
            Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper symbolintervalmapper2 = new Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper();
            this.m_Rectangle = new Neo.ApplicationFramework.Controls.Controls.RectangleCF();
            this.m_Text = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_Button = new Neo.ApplicationFramework.Controls.Controls.Button();
            this.m_Button1 = new Neo.ApplicationFramework.Controls.Controls.Button();
            this.m_Picture = new Neo.ApplicationFramework.Controls.Symbol.PictureCF();
            this.m_Picture1 = new Neo.ApplicationFramework.Controls.Symbol.PictureCF();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Button1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture1)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateMessage
            // 
            this.BorderStyle = Neo.ApplicationFramework.Interfaces.ScreenBorderStyle.ThreeDBorder;
            this.ControlBox = false;
            // 
            // m_Rectangle
            // 
            this.m_Rectangle.BitmapEffect = new Neo.ApplicationFramework.Common.Graphics.Logic.BitmapEffectCF();
            this.m_Rectangle.BlinkDynamicsValue = false;
            this.m_Rectangle.DelayMouseInputPeriod = 0;
            this.m_Rectangle.EnabledDynamicsValue = true;
            this.m_Rectangle.Fill = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.Empty, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), Neo.ApplicationFramework.Interfaces.FillDirection.DiagonalTopLeftToBottomRight);
            this.m_Rectangle.Height = 516;
            this.m_Rectangle.Left = -3;
            this.m_Rectangle.Name = "m_Rectangle";
            this.m_Rectangle.ScreenOwnerName = "UpdateMessage";
            this.m_Rectangle.Stroke = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF();
            this.m_Rectangle.Top = -19;
            this.m_Rectangle.VisibleDynamicsValue = true;
            this.m_Rectangle.Width = 815;
            // 
            // m_Text
            // 
            this.m_Text.BlinkDynamicsValue = false;
            this.m_Text.DelayMouseInputPeriod = 0;
            this.m_Text.EnabledDynamicsValue = true;
            this.m_Text.FontSizePixels = 20;
            this.m_Text.Height = 36;
            this.m_Text.Left = 268;
            this.m_Text.Name = "m_Text";
            this.m_Text.Padding = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(5D, 0D, 5D, 1D);
            this.m_Text.ScreenOwnerName = "UpdateMessage";
            this.m_Text.Top = 225;
            this.m_Text.VisibleDynamicsValue = true;
            this.m_Text.Width = 290;
            // 
            // m_Button
            // 
            this.m_Button.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(188)))), ((int)(((byte)(166))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Button.BlinkDynamicsValue = false;
            this.m_Button.Bold = true;
            this.m_Button.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Button.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(1D, 1D, 1D, 1D);
            this.m_Button.DelayMouseInputPeriod = 0;
            this.m_Button.EnabledDynamicsValue = true;
            this.m_Button.FontSizePixels = 15;
            this.m_Button.ForceTransparency = true;
            this.m_Button.Foreground = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.m_Button.Height = 50;
            this.m_Button.IndicatorMargin = null;
            this.m_Button.Left = 500;
            this.m_Button.Name = "m_Button";
            this.m_Button.RequiresTransparency = true;
            this.m_Button.ScreenOwnerName = "UpdateMessage";
            this.m_Button.SymbolIntervalMapper = symbolintervalmapper1;
            this.m_Button.TextHeight = 36;
            this.m_Button.TextValue = 0D;
            this.m_Button.TextWidth = 125;
            this.m_Button.Top = 327;
            this.m_Button.Value = 0D;
            this.m_Button.VisibleDynamicsValue = true;
            this.m_Button.VisualPropertiesHashCode = -997771910;
            this.m_Button.Width = 135;
            this.m_Button.WordWrap = true;
            // 
            // m_Button1
            // 
            this.m_Button1.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(188)))), ((int)(((byte)(166))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Button1.BlinkDynamicsValue = false;
            this.m_Button1.Bold = true;
            this.m_Button1.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Button1.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(1D, 1D, 1D, 1D);
            this.m_Button1.DelayMouseInputPeriod = 0;
            this.m_Button1.EnabledDynamicsValue = true;
            this.m_Button1.FontSizePixels = 15;
            this.m_Button1.ForceTransparency = true;
            this.m_Button1.Foreground = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.m_Button1.Height = 50;
            this.m_Button1.IndicatorMargin = null;
            this.m_Button1.Left = 160;
            this.m_Button1.Name = "m_Button1";
            this.m_Button1.RequiresTransparency = true;
            this.m_Button1.ScreenOwnerName = "UpdateMessage";
            this.m_Button1.SymbolIntervalMapper = symbolintervalmapper2;
            this.m_Button1.TextHeight = 18;
            this.m_Button1.TextValue = 0D;
            this.m_Button1.TextWidth = 125;
            this.m_Button1.Top = 327;
            this.m_Button1.Value = 0D;
            this.m_Button1.VisibleDynamicsValue = true;
            this.m_Button1.VisualPropertiesHashCode = -997771910;
            this.m_Button1.Width = 135;
            this.m_Button1.WordWrap = true;
            // 
            // m_Picture
            // 
            this.m_Picture.BlinkDynamicsValue = false;
            this.m_Picture.DelayMouseInputPeriod = 0;
            this.m_Picture.EnabledDynamicsValue = true;
            this.m_Picture.Height = 53;
            this.m_Picture.Left = 160;
            this.m_Picture.Name = "m_Picture";
            this.m_Picture.ScreenOwnerName = "UpdateMessage";
            this.m_Picture.Stretch = true;
            this.m_Picture.SymbolName = "vehicleinfo_gapac";
            this.m_Picture.Top = 93;
            this.m_Picture.VisibleDynamicsValue = true;
            this.m_Picture.Width = 53;
            // 
            // m_Picture1
            // 
            this.m_Picture1.BlinkDynamicsValue = false;
            this.m_Picture1.DelayMouseInputPeriod = 0;
            this.m_Picture1.EnabledDynamicsValue = true;
            this.m_Picture1.Height = 69;
            this.m_Picture1.Left = 581;
            this.m_Picture1.Name = "m_Picture1";
            this.m_Picture1.ScreenOwnerName = "UpdateMessage";
            this.m_Picture1.Stretch = true;
            this.m_Picture1.SymbolName = "exit";
            this.m_Picture1.Top = 84;
            this.m_Picture1.VisibleDynamicsValue = true;
            this.m_Picture1.Width = 70;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.IsCacheable = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.ModalScreen = true;
            this.Name = "UpdateMessage";
            this.PopupScreen = false;
            this.ScreenID = null;
            this.ScreenTitle = "";
            this.StyleName = "";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.m_Initialized_UpdateMessage = true;
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
            if (!m_Initialized_UpdateMessage) {
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
            this.DrawingPrimitives.Add(this.m_Rectangle);
            this.DrawingPrimitives.Add(this.m_Text);
            this.DrawingPrimitives.Add(this.m_Button);
            this.DrawingPrimitives.Add(this.m_Button1);
            this.DrawingPrimitives.Add(this.m_Picture);
            this.DrawingPrimitives.Add(this.m_Picture1);
            ((System.ComponentModel.ISupportInitialize)(this.m_Text)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Button1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture1)).EndInit();
        }
        
        private void m_Button_Action_Click(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_Button", "Click", "Show Screen", "VersionInformation", "Default", "");
            Neo.ApplicationFramework.Generated.Globals.VersionInformation.Show();
        }
        
        private void m_Button1_Action_Click(object sender, System.EventArgs e) {
            Core.Api.Service.ServiceContainerCF.GetService<Neo.ApplicationFramework.Interfaces.IScreenManager>().LogActionBackScreen("m_Button1", "Click", "Show Previous Screen", "");
            Core.Api.Service.ServiceContainerCF.GetService<Neo.ApplicationFramework.Interfaces.IScreenManager>().ActionBackScreen();
        }
        
        private void m_Picture1_Action_MouseDown(object sender, System.EventArgs e) {
            Core.Api.Service.ServiceContainerCF.GetService<Neo.ApplicationFramework.Interfaces.IScreenManager>().LogActionBackScreen("m_Picture1", "MouseDown", "Show Previous Screen", "");
            Core.Api.Service.ServiceContainerCF.GetService<Neo.ApplicationFramework.Interfaces.IScreenManager>().ActionBackScreen();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private void ApplyLanguageInternal() {
            Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager resources = new Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager(typeof(UpdateMessage));
            this.m_Text.Text = resources.GetText("UpdateMessage.Text.Text", "Vehicle application updated!");
            this.m_Button.Text = resources.GetText("UpdateMessage.Button.Text", "VERSION INFORMATION");
            this.m_Button1.Text = resources.GetText("UpdateMessage.Button1.Text", "CLOSE");
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
            if (!m_Initialized_UpdateMessage) {
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