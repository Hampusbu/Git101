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
    public partial class IO_Explorer : Background, Neo.ApplicationFramework.Interfaces.ISupportMultiLanguage {
        
        private Neo.ApplicationFramework.Controls.Symbol.PictureCF m_Picture;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text;
        
        private Neo.ApplicationFramework.Controls.Symbol.PictureCF m_Picture2;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text2;
        
        private Neo.ApplicationFramework.Controls.Controls.Line m_Line;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text4;
        
        private Neo.ApplicationFramework.Controls.Controls.Button m_Button1;
        
        private Neo.ApplicationFramework.Controls.Symbol.PictureCF m_Picture3;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text3;
        
        private Neo.ApplicationFramework.Controls.Symbol.PictureCF m_Picture1;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text1;
        
        private bool m_Initialized_IO_Explorer;
        
        private Neo.ApplicationFramework.Common.Dynamics.BrushDynamicsConverterCF brushdynamicsconvertercf1;
        
        public IO_Explorer() {
            this.InitializeComponent();
            this.m_Picture2.MouseDown += new System.EventHandler(this.m_Picture2_Action_MouseDown);
            this.m_Button1.Click += new System.EventHandler(this.m_Button1_Action_Click);
            this.m_Picture1.MouseDown += new System.EventHandler(this.m_Picture1_Action_MouseDown);
            this.ApplyLanguageInitialize();
        }
        
        protected Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter Picture {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter>(this.m_Picture);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter Picture2 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter>(this.m_Picture2);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text2 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text2);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.LineCFAdapter Line {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.LineCFAdapter>(this.m_Line);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text4 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text4);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter Button1 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter>(this.m_Button1);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter Picture3 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter>(this.m_Picture3);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text3 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text3);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter Picture1 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter>(this.m_Picture1);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text1 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text1);
            }
        }
        
        private void InitializeComponent() {
            this.brushdynamicsconvertercf1 = new Neo.ApplicationFramework.Common.Dynamics.BrushDynamicsConverterCF();
            Neo.ApplicationFramework.Common.Dynamics.BrushCFInterval brushcfinterval1 = new Neo.ApplicationFramework.Common.Dynamics.BrushCFInterval();
            Neo.ApplicationFramework.Common.Dynamics.BrushCFInterval brushcfinterval2 = new Neo.ApplicationFramework.Common.Dynamics.BrushCFInterval();
            Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper symbolintervalmapper1 = new Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper();
            Neo.ApplicationFramework.Common.Dynamics.StringIntervalMapperCF stringintervalmappercf1 = new Neo.ApplicationFramework.Common.Dynamics.StringIntervalMapperCF();
            Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF stringintervalcf1 = new Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF();
            Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF stringintervalcf2 = new Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF();
            this.m_Picture = new Neo.ApplicationFramework.Controls.Symbol.PictureCF();
            this.m_Text = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_Picture2 = new Neo.ApplicationFramework.Controls.Symbol.PictureCF();
            this.m_Text2 = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_Line = new Neo.ApplicationFramework.Controls.Controls.Line();
            this.m_Text4 = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_Button1 = new Neo.ApplicationFramework.Controls.Controls.Button();
            this.m_Picture3 = new Neo.ApplicationFramework.Controls.Symbol.PictureCF();
            this.m_Text3 = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_Picture1 = new Neo.ApplicationFramework.Controls.Symbol.PictureCF();
            this.m_Text1 = new Neo.ApplicationFramework.Controls.Controls.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Button1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text1)).BeginInit();
            this.SuspendLayout();
            // 
            // IO_Explorer
            // 
            this.BorderStyle = Neo.ApplicationFramework.Interfaces.ScreenBorderStyle.ThreeDBorder;
            this.ControlBox = false;
            // 
            // m_Picture
            // 
            this.m_Picture.BlinkDynamicsValue = false;
            this.m_Picture.DelayMouseInputPeriod = 0;
            this.m_Picture.EnabledDynamicsValue = true;
            this.m_Picture.Height = 50;
            this.m_Picture.Left = 17;
            this.m_Picture.Name = "m_Picture";
            this.m_Picture.ScreenOwnerName = "IO_Explorer";
            this.m_Picture.Stretch = true;
            this.m_Picture.SymbolName = "io";
            this.m_Picture.Top = 1;
            this.m_Picture.VisibleDynamicsValue = true;
            this.m_Picture.Width = 50;
            // 
            // m_Text
            // 
            this.m_Text.BlinkDynamicsValue = false;
            this.m_Text.Bold = true;
            this.m_Text.DelayMouseInputPeriod = 0;
            this.m_Text.EnabledDynamicsValue = true;
            this.m_Text.FontSizePixels = 28;
            this.m_Text.Foreground = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.m_Text.Height = 28;
            this.m_Text.Left = 75;
            this.m_Text.Name = "m_Text";
            this.m_Text.Padding = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(7D, 0D, 7D, 1D);
            this.m_Text.ScreenOwnerName = "IO_Explorer";
            this.m_Text.Top = 6;
            this.m_Text.VisibleDynamicsValue = true;
            this.m_Text.Width = 117;
            // 
            // m_Picture2
            // 
            this.m_Picture2.BlinkDynamicsValue = false;
            this.m_Picture2.DelayMouseInputPeriod = 0;
            this.m_Picture2.EnabledDynamicsValue = true;
            this.m_Picture2.Height = 69;
            this.m_Picture2.Left = 159;
            this.m_Picture2.Name = "m_Picture2";
            this.m_Picture2.ScreenOwnerName = "IO_Explorer";
            this.m_Picture2.Stretch = true;
            this.m_Picture2.SymbolName = "output";
            this.m_Picture2.Top = 102;
            this.m_Picture2.VisibleDynamicsValue = true;
            this.m_Picture2.Width = 70;
            // 
            // m_Text2
            // 
            this.m_Text2.AutoSize = false;
            this.m_Text2.BlinkDynamicsValue = false;
            this.m_Text2.Bold = true;
            this.m_Text2.DelayMouseInputPeriod = 0;
            this.m_Text2.EnabledDynamicsValue = true;
            this.m_Text2.FontSizePixels = 20;
            this.m_Text2.Foreground = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(188)))), ((int)(((byte)(166)))));
            this.m_Text2.Height = 35;
            this.m_Text2.Left = 134;
            this.m_Text2.Name = "m_Text2";
            this.m_Text2.Padding = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(5D, 0D, 5D, 1D);
            this.m_Text2.ScreenOwnerName = "IO_Explorer";
            this.m_Text2.TextHorizontalAlignment = "Center";
            this.m_Text2.Top = 163;
            this.m_Text2.VisibleDynamicsValue = true;
            this.m_Text2.Width = 120;
            // 
            // m_Line
            // 
            this.m_Line.BlinkDynamicsValue = false;
            this.m_Line.DelayMouseInputPeriod = 0;
            this.m_Line.EnabledDynamicsValue = true;
            this.m_Line.Fill = null;
            this.m_Line.Name = "m_Line";
            this.m_Line.ScreenOwnerName = "IO_Explorer";
            this.m_Line.Stroke = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Line.StrokeThickness = 2;
            this.m_Line.VisibleDynamicsValue = true;
            this.m_Line.X1 = 277;
            this.m_Line.X2 = 277;
            this.m_Line.Y1 = 364;
            this.m_Line.Y2 = 84;
            // 
            // m_Text4
            // 
            this.m_Text4.AutoSize = false;
            this.m_Text4.BlinkDynamicsValue = false;
            this.m_Text4.DelayMouseInputPeriod = 0;
            this.m_Text4.EnabledDynamicsValue = true;
            this.m_Text4.FontSizePixels = 20;
            this.m_Text4.Height = 135;
            this.m_Text4.Left = 294;
            this.m_Text4.Name = "m_Text4";
            this.m_Text4.Padding = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(5D, 0D, 5D, 1D);
            this.m_Text4.ScreenOwnerName = "IO_Explorer";
            this.m_Text4.Top = 127;
            this.m_Text4.VisibleDynamicsValue = true;
            this.m_Text4.Width = 391;
            this.m_Text4.WordWrap = true;
            // 
            // m_Button1
            // 
            this.m_Button1.BlinkDynamicsValue = false;
            this.m_Button1.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Button1.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(1D, 1D, 1D, 1D);
            brushdynamicsconvertercf1.BrushIntervalMapper.DefaultValue = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200))))), Neo.ApplicationFramework.Interfaces.FillDirection.VerticalTopToBottom);
            brushcfinterval1.Value = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(188)))), ((int)(((byte)(166))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            brushcfinterval2.End = 1D;
            brushcfinterval2.Start = 1D;
            brushcfinterval2.Value = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            brushdynamicsconvertercf1.BrushIntervalMapper.Intervals.Add(brushcfinterval1);
            brushdynamicsconvertercf1.BrushIntervalMapper.Intervals.Add(brushcfinterval2);
            this.m_Button1.DelayMouseInputPeriod = 0;
            this.m_Button1.EnabledDynamicsValue = true;
            this.m_Button1.FontSizePixels = 11;
            this.m_Button1.ForceTransparency = true;
            this.m_Button1.Height = 59;
            this.m_Button1.IndicatorMargin = null;
            this.m_Button1.Left = 656;
            this.m_Button1.Name = "m_Button1";
            this.m_Button1.RequiresTransparency = true;
            this.m_Button1.ScreenOwnerName = "IO_Explorer";
            this.m_Button1.SymbolIntervalMapper = symbolintervalmapper1;
            this.m_Button1.TextHeight = 13;
            stringintervalmappercf1.DefaultValue = "Force mode on";
            stringintervalcf1.End = 1D;
            stringintervalcf1.Start = 1D;
            stringintervalcf1.Value = "Force mode On";
            stringintervalcf2.Value = "Force mode Off";
            stringintervalmappercf1.Intervals.Add(stringintervalcf1);
            stringintervalmappercf1.Intervals.Add(stringintervalcf2);
            this.m_Button1.TextIntervalMapper = stringintervalmappercf1;
            this.m_Button1.TextValue = 0D;
            this.m_Button1.TextWidth = 135;
            this.m_Button1.Top = 0;
            this.m_Button1.Value = 0D;
            this.m_Button1.VisibleDynamicsValue = true;
            this.m_Button1.VisualPropertiesHashCode = -640173548;
            this.m_Button1.Width = 145;
            // 
            // m_Picture3
            // 
            this.m_Picture3.BlinkDynamicsValue = false;
            this.m_Picture3.DelayMouseInputPeriod = 0;
            this.m_Picture3.EnabledDynamicsValue = true;
            this.m_Picture3.Height = 114;
            this.m_Picture3.Left = 689;
            this.m_Picture3.Name = "m_Picture3";
            this.m_Picture3.ScreenOwnerName = "IO_Explorer";
            this.m_Picture3.Stretch = true;
            this.m_Picture3.SymbolName = "arrow (1)";
            this.m_Picture3.Top = 83;
            this.m_Picture3.VisibleDynamicsValue = true;
            this.m_Picture3.Width = 57;
            // 
            // m_Text3
            // 
            this.m_Text3.BlinkDynamicsValue = false;
            this.m_Text3.DelayMouseInputPeriod = 0;
            this.m_Text3.EnabledDynamicsValue = true;
            this.m_Text3.FontSizePixels = 20;
            this.m_Text3.Height = 28;
            this.m_Text3.Italic = true;
            this.m_Text3.Left = 273;
            this.m_Text3.Name = "m_Text3";
            this.m_Text3.Padding = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(5D, 0D, 5D, 1D);
            this.m_Text3.ScreenOwnerName = "IO_Explorer";
            this.m_Text3.Top = 317;
            this.m_Text3.VisibleDynamicsValue = true;
            this.m_Text3.Width = 429;
            // 
            // m_Picture1
            // 
            this.m_Picture1.BlinkDynamicsValue = false;
            this.m_Picture1.DelayMouseInputPeriod = 0;
            this.m_Picture1.EnabledDynamicsValue = true;
            this.m_Picture1.Height = 77;
            this.m_Picture1.Left = 49;
            this.m_Picture1.Name = "m_Picture1";
            this.m_Picture1.ScreenOwnerName = "IO_Explorer";
            this.m_Picture1.Stretch = true;
            this.m_Picture1.SymbolName = "input";
            this.m_Picture1.Top = 98;
            this.m_Picture1.VisibleDynamicsValue = true;
            this.m_Picture1.Width = 77;
            // 
            // m_Text1
            // 
            this.m_Text1.AutoSize = false;
            this.m_Text1.BlinkDynamicsValue = false;
            this.m_Text1.Bold = true;
            this.m_Text1.DelayMouseInputPeriod = 0;
            this.m_Text1.EnabledDynamicsValue = true;
            this.m_Text1.FontSizePixels = 20;
            this.m_Text1.Foreground = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(188)))), ((int)(((byte)(166)))));
            this.m_Text1.Height = 35;
            this.m_Text1.Left = 31;
            this.m_Text1.Name = "m_Text1";
            this.m_Text1.Padding = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(5D, 0D, 5D, 1D);
            this.m_Text1.ScreenOwnerName = "IO_Explorer";
            this.m_Text1.TextHorizontalAlignment = "Center";
            this.m_Text1.Top = 163;
            this.m_Text1.VisibleDynamicsValue = true;
            this.m_Text1.Width = 120;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.IsCacheable = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.ModalScreen = true;
            this.Name = "IO_Explorer";
            this.PopupScreen = false;
            this.ScreenID = null;
            this.ScreenTitle = "";
            this.StyleName = "";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.m_Initialized_IO_Explorer = true;
            this.AddControlsAndPrimitives();
            this.ResumeLayout(false);
            this.SecurityExtender.SetSecurityGroupsRequired(this.m_Line, SecurityGroups.Group_01);
            this.SecurityExtender.SetVisibilityOnAccessDenied(this.m_Line, VisibilityModes.Hidden);
            this.SecurityExtender.SetSecurityGroupsRequired(this.m_Text4, SecurityGroups.Group_01);
            this.SecurityExtender.SetVisibilityOnAccessDenied(this.m_Text4, VisibilityModes.Hidden);
            this.SecurityExtender.SetSecurityGroupsRequired(this.m_Button1, SecurityGroups.Group_01);
            this.SecurityExtender.SetVisibilityOnAccessDenied(this.m_Button1, VisibilityModes.Hidden);
            this.SecurityExtender.SetSecurityGroupsRequired(this.m_Picture3, SecurityGroups.Group_01);
            this.SecurityExtender.SetVisibilityOnAccessDenied(this.m_Picture3, VisibilityModes.Hidden);
            this.SecurityExtender.SetSecurityGroupsRequired(this.m_Text3, SecurityGroups.Group_01);
            this.SecurityExtender.SetVisibilityOnAccessDenied(this.m_Text3, VisibilityModes.Hidden);
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
            if (!m_Initialized_IO_Explorer) {
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
            this.DrawingPrimitives.Add(this.m_Picture);
            this.DrawingPrimitives.Add(this.m_Text);
            this.DrawingPrimitives.Add(this.m_Picture2);
            this.DrawingPrimitives.Add(this.m_Text2);
            this.DrawingPrimitives.Add(this.m_Line);
            this.DrawingPrimitives.Add(this.m_Text4);
            this.DrawingPrimitives.Add(this.m_Button1);
            this.DrawingPrimitives.Add(this.m_Picture3);
            this.DrawingPrimitives.Add(this.m_Text3);
            this.DrawingPrimitives.Add(this.m_Picture1);
            this.DrawingPrimitives.Add(this.m_Text1);
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Button1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text1)).EndInit();
        }
        
        private void m_Picture2_Action_MouseDown(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_Picture2", "MouseDown", "Show Screen", "OutputExplorer1", "Default", "");
            Neo.ApplicationFramework.Generated.Globals.OutputExplorer1.Show();
        }
        
        private void m_Button1_Action_Click(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_Button1", "Click", "Toggle Tag", "Tags.IOForceMode", "");
            Neo.ApplicationFramework.Generated.Globals.Tags.IOForceMode.ToggleTag();
        }
        
        private void m_Picture1_Action_MouseDown(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_Picture1", "MouseDown", "Show Screen", "InputScreen1", "Default", "");
            Neo.ApplicationFramework.Generated.Globals.InputScreen1.Show();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private void ApplyLanguageInternal() {
            Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager resources = new Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager(typeof(IO_Explorer));
            this.m_Text.Text = resources.GetText("IO_Explorer.Text.Text", "I/O EXPLORER");
            this.m_Text2.Text = resources.GetText("IO_Explorer.Text2.Text", "OUTPUTS");
            this.m_Text4.Text = resources.GetText("IO_Explorer.Text4.Text", "When Force mode is turned on the user will be able to force state change on input" +
                    "s and outputs. Note that some state changes on the CVC will be prevented during " +
                    "Force mode.");
            this.m_Button1.Text = resources.GetText("IO_Explorer.Button1.Text", "Force mode on");
            this.m_Text3.Text = resources.GetText("IO_Explorer.Text3.Text", "(Note that Force mode will be turned off on user logout) ");
            this.m_Text1.Text = resources.GetText("IO_Explorer.Text1.Text", "INPUTS");
            resources.ApplyTexts(this.m_Button1, "Texts", "IO_Explorer.Button1.Texts[0]", "Force mode On", "IO_Explorer.Button1.Texts[1]", "Force mode Off");
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
            if (!m_Initialized_IO_Explorer) {
                return;
            }
            base.ApplyLanguageInitialize();
            this.ApplyLanguageInternal();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override void ConnectDataBindings() {
            base.ConnectDataBindings();
            Neo.ApplicationFramework.Common.Data.DynamicBinding dynamicBinding1 = new Neo.ApplicationFramework.Common.Data.DynamicBinding("TextValue", Neo.ApplicationFramework.Common.Data.DataItemProxyFactory.CreateProxy("Tags.IOForceMode"), "Value", true, System.Windows.Forms.DataSourceUpdateMode.Never, Neo.ApplicationFramework.Common.Dynamics.VariantValueConverterCF.Default);
            this.m_Button1.DataBindings.Add(dynamicBinding1);
            this.m_DynamicBindings.Add(dynamicBinding1);
            Neo.ApplicationFramework.Common.Data.DynamicBinding dynamicBinding2 = new Neo.ApplicationFramework.Common.Data.DynamicBinding("Background", Neo.ApplicationFramework.Common.Data.DataItemProxyFactory.CreateProxy("Tags.IOForceMode"), "Value", true, System.Windows.Forms.DataSourceUpdateMode.Never, brushdynamicsconvertercf1);
            this.m_Button1.DataBindings.Add(dynamicBinding2);
            this.m_DynamicBindings.Add(dynamicBinding2);
        }
    }
}
