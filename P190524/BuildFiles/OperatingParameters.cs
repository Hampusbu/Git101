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
    public partial class OperatingParameters : Background, Neo.ApplicationFramework.Interfaces.ISupportMultiLanguage {
        
        private Neo.ApplicationFramework.Controls.Symbol.PictureCF m_Picture;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text;
        
        private Neo.ApplicationFramework.Controls.Symbol.PictureCF m_Picture2;
        
        private Neo.ApplicationFramework.Controls.Symbol.PictureCF m_Picture4;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text2;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text3;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text4;
        
        private Neo.ApplicationFramework.Controls.Symbol.PictureCF m_Picture5;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text5;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text1;
        
        private Neo.ApplicationFramework.Controls.Symbol.PictureCF m_Picture1;
        
        private Neo.ApplicationFramework.Controls.Symbol.PictureCF m_Picture6;
        
        private Neo.ApplicationFramework.Controls.Symbol.PictureCF m_Picture3;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text6;
        
        private bool m_Initialized_OperatingParameters;
        
        public OperatingParameters() {
            this.InitializeComponent();
            this.m_Picture2.MouseDown += new System.EventHandler(this.m_Picture2_Action_MouseDown);
            this.m_Picture4.MouseDown += new System.EventHandler(this.m_Picture4_Action_MouseDown);
            this.m_Picture5.MouseDown += new System.EventHandler(this.m_Picture5_Action_MouseDown);
            this.m_Picture1.MouseDown += new System.EventHandler(this.m_Picture1_Action_MouseDown);
            this.m_Picture6.MouseDown += new System.EventHandler(this.m_Picture6_Action_MouseDown);
            this.m_Picture3.MouseDown += new System.EventHandler(this.m_Picture3_Action_MouseDown);
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
        
        protected Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter Picture4 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter>(this.m_Picture4);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text2 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text2);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text3 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text3);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text4 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text4);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter Picture5 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter>(this.m_Picture5);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text5 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text5);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text1 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text1);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter Picture1 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter>(this.m_Picture1);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter Picture6 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter>(this.m_Picture6);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter Picture3 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter>(this.m_Picture3);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text6 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text6);
            }
        }
        
        private void InitializeComponent() {
            this.m_Picture = new Neo.ApplicationFramework.Controls.Symbol.PictureCF();
            this.m_Text = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_Picture2 = new Neo.ApplicationFramework.Controls.Symbol.PictureCF();
            this.m_Picture4 = new Neo.ApplicationFramework.Controls.Symbol.PictureCF();
            this.m_Text2 = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_Text3 = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_Text4 = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_Picture5 = new Neo.ApplicationFramework.Controls.Symbol.PictureCF();
            this.m_Text5 = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_Text1 = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_Picture1 = new Neo.ApplicationFramework.Controls.Symbol.PictureCF();
            this.m_Picture6 = new Neo.ApplicationFramework.Controls.Symbol.PictureCF();
            this.m_Picture3 = new Neo.ApplicationFramework.Controls.Symbol.PictureCF();
            this.m_Text6 = new Neo.ApplicationFramework.Controls.Controls.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text6)).BeginInit();
            this.SuspendLayout();
            // 
            // OperatingParameters
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
            this.m_Picture.ScreenOwnerName = "OperatingParameters";
            this.m_Picture.Stretch = true;
            this.m_Picture.SymbolName = "buildicon";
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
            this.m_Text.FontSizePixels = 24;
            this.m_Text.Foreground = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.m_Text.Height = 28;
            this.m_Text.Left = 75;
            this.m_Text.Name = "m_Text";
            this.m_Text.Padding = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(6D, 0D, 6D, 1D);
            this.m_Text.ScreenOwnerName = "OperatingParameters";
            this.m_Text.Top = 6;
            this.m_Text.VisibleDynamicsValue = true;
            this.m_Text.Width = 205;
            // 
            // m_Picture2
            // 
            this.m_Picture2.BlinkDynamicsValue = false;
            this.m_Picture2.DelayMouseInputPeriod = 0;
            this.m_Picture2.EnabledDynamicsValue = true;
            this.m_Picture2.Height = 69;
            this.m_Picture2.Left = 168;
            this.m_Picture2.Name = "m_Picture2";
            this.m_Picture2.ScreenOwnerName = "OperatingParameters";
            this.m_Picture2.Stretch = true;
            this.m_Picture2.SymbolName = "drive";
            this.m_Picture2.Top = 75;
            this.m_Picture2.VisibleDynamicsValue = true;
            this.m_Picture2.Width = 70;
            // 
            // m_Picture4
            // 
            this.m_Picture4.BlinkDynamicsValue = false;
            this.m_Picture4.DelayMouseInputPeriod = 0;
            this.m_Picture4.EnabledDynamicsValue = true;
            this.m_Picture4.Height = 69;
            this.m_Picture4.Left = 430;
            this.m_Picture4.Name = "m_Picture4";
            this.m_Picture4.ScreenOwnerName = "OperatingParameters";
            this.m_Picture4.Stretch = true;
            this.m_Picture4.SymbolName = "onoff";
            this.m_Picture4.Top = 75;
            this.m_Picture4.VisibleDynamicsValue = true;
            this.m_Picture4.Width = 70;
            // 
            // m_Text2
            // 
            this.m_Text2.AutoSize = false;
            this.m_Text2.BlinkDynamicsValue = false;
            this.m_Text2.Bold = true;
            this.m_Text2.DelayMouseInputPeriod = 0;
            this.m_Text2.EnabledDynamicsValue = true;
            this.m_Text2.FontSizePixels = 15;
            this.m_Text2.Foreground = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(188)))), ((int)(((byte)(166)))));
            this.m_Text2.Height = 35;
            this.m_Text2.Left = 145;
            this.m_Text2.Name = "m_Text2";
            this.m_Text2.Padding = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(3.75D, 0D, 3.75D, 1D);
            this.m_Text2.ScreenOwnerName = "OperatingParameters";
            this.m_Text2.TextHorizontalAlignment = "Center";
            this.m_Text2.Top = 144;
            this.m_Text2.VisibleDynamicsValue = true;
            this.m_Text2.Width = 120;
            // 
            // m_Text3
            // 
            this.m_Text3.AutoSize = false;
            this.m_Text3.BlinkDynamicsValue = false;
            this.m_Text3.Bold = true;
            this.m_Text3.DelayMouseInputPeriod = 0;
            this.m_Text3.EnabledDynamicsValue = true;
            this.m_Text3.FontSizePixels = 15;
            this.m_Text3.Foreground = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(188)))), ((int)(((byte)(166)))));
            this.m_Text3.Height = 35;
            this.m_Text3.Left = 275;
            this.m_Text3.Name = "m_Text3";
            this.m_Text3.Padding = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(3.75D, 0D, 3.75D, 1D);
            this.m_Text3.ScreenOwnerName = "OperatingParameters";
            this.m_Text3.TextHorizontalAlignment = "Center";
            this.m_Text3.Top = 144;
            this.m_Text3.VisibleDynamicsValue = true;
            this.m_Text3.Width = 120;
            // 
            // m_Text4
            // 
            this.m_Text4.AutoSize = false;
            this.m_Text4.BlinkDynamicsValue = false;
            this.m_Text4.Bold = true;
            this.m_Text4.DelayMouseInputPeriod = 0;
            this.m_Text4.EnabledDynamicsValue = true;
            this.m_Text4.FontSizePixels = 15;
            this.m_Text4.Foreground = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(188)))), ((int)(((byte)(166)))));
            this.m_Text4.Height = 35;
            this.m_Text4.Left = 405;
            this.m_Text4.Name = "m_Text4";
            this.m_Text4.Padding = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(3.75D, 0D, 3.75D, 1D);
            this.m_Text4.ScreenOwnerName = "OperatingParameters";
            this.m_Text4.TextHorizontalAlignment = "Center";
            this.m_Text4.Top = 144;
            this.m_Text4.VisibleDynamicsValue = true;
            this.m_Text4.Width = 120;
            // 
            // m_Picture5
            // 
            this.m_Picture5.BlinkDynamicsValue = false;
            this.m_Picture5.DelayMouseInputPeriod = 0;
            this.m_Picture5.EnabledDynamicsValue = true;
            this.m_Picture5.Height = 69;
            this.m_Picture5.Left = 533;
            this.m_Picture5.Name = "m_Picture5";
            this.m_Picture5.ScreenOwnerName = "OperatingParameters";
            this.m_Picture5.Stretch = true;
            this.m_Picture5.SymbolName = "lift_gapac";
            this.m_Picture5.Top = 75;
            this.m_Picture5.VisibleDynamicsValue = true;
            this.m_Picture5.Width = 70;
            // 
            // m_Text5
            // 
            this.m_Text5.AutoSize = false;
            this.m_Text5.BlinkDynamicsValue = false;
            this.m_Text5.Bold = true;
            this.m_Text5.DelayMouseInputPeriod = 0;
            this.m_Text5.EnabledDynamicsValue = true;
            this.m_Text5.FontSizePixels = 15;
            this.m_Text5.Foreground = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(188)))), ((int)(((byte)(166)))));
            this.m_Text5.Height = 35;
            this.m_Text5.Left = 508;
            this.m_Text5.Name = "m_Text5";
            this.m_Text5.Padding = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(3.75D, 0D, 3.75D, 1D);
            this.m_Text5.ScreenOwnerName = "OperatingParameters";
            this.m_Text5.TextHorizontalAlignment = "Center";
            this.m_Text5.Top = 144;
            this.m_Text5.VisibleDynamicsValue = true;
            this.m_Text5.Width = 120;
            // 
            // m_Text1
            // 
            this.m_Text1.AutoSize = false;
            this.m_Text1.BlinkDynamicsValue = false;
            this.m_Text1.Bold = true;
            this.m_Text1.DelayMouseInputPeriod = 0;
            this.m_Text1.EnabledDynamicsValue = true;
            this.m_Text1.FontSizePixels = 15;
            this.m_Text1.Foreground = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(188)))), ((int)(((byte)(166)))));
            this.m_Text1.Height = 35;
            this.m_Text1.Left = 17;
            this.m_Text1.Name = "m_Text1";
            this.m_Text1.Padding = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(3.75D, 0D, 3.75D, 1D);
            this.m_Text1.ScreenOwnerName = "OperatingParameters";
            this.m_Text1.TextHorizontalAlignment = "Center";
            this.m_Text1.Top = 144;
            this.m_Text1.VisibleDynamicsValue = true;
            this.m_Text1.Width = 120;
            // 
            // m_Picture1
            // 
            this.m_Picture1.BlinkDynamicsValue = false;
            this.m_Picture1.DelayMouseInputPeriod = 0;
            this.m_Picture1.EnabledDynamicsValue = true;
            this.m_Picture1.Height = 76;
            this.m_Picture1.Left = 41;
            this.m_Picture1.Name = "m_Picture1";
            this.m_Picture1.ScreenOwnerName = "OperatingParameters";
            this.m_Picture1.Stretch = true;
            this.m_Picture1.SymbolName = "rfid_pic";
            this.m_Picture1.Top = 71;
            this.m_Picture1.VisibleDynamicsValue = true;
            this.m_Picture1.Width = 76;
            // 
            // m_Picture6
            // 
            this.m_Picture6.BlinkDynamicsValue = false;
            this.m_Picture6.DelayMouseInputPeriod = 0;
            this.m_Picture6.EnabledDynamicsValue = true;
            this.m_Picture6.Height = 69;
            this.m_Picture6.Left = 293;
            this.m_Picture6.Name = "m_Picture6";
            this.m_Picture6.ScreenOwnerName = "OperatingParameters";
            this.m_Picture6.Stretch = true;
            this.m_Picture6.SymbolName = "drive";
            this.m_Picture6.Top = 75;
            this.m_Picture6.VisibleDynamicsValue = true;
            this.m_Picture6.Width = 70;
            // 
            // m_Picture3
            // 
            this.m_Picture3.BlinkDynamicsValue = false;
            this.m_Picture3.DelayMouseInputPeriod = 0;
            this.m_Picture3.EnabledDynamicsValue = true;
            this.m_Picture3.Height = 88;
            this.m_Picture3.Left = 651;
            this.m_Picture3.Name = "m_Picture3";
            this.m_Picture3.ScreenOwnerName = "OperatingParameters";
            this.m_Picture3.Stretch = true;
            this.m_Picture3.SymbolName = "charge_icon";
            this.m_Picture3.Top = 65;
            this.m_Picture3.VisibleDynamicsValue = true;
            this.m_Picture3.Width = 90;
            // 
            // m_Text6
            // 
            this.m_Text6.AutoSize = false;
            this.m_Text6.BlinkDynamicsValue = false;
            this.m_Text6.Bold = true;
            this.m_Text6.DelayMouseInputPeriod = 0;
            this.m_Text6.EnabledDynamicsValue = true;
            this.m_Text6.FontSizePixels = 15;
            this.m_Text6.Foreground = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(188)))), ((int)(((byte)(166)))));
            this.m_Text6.Height = 35;
            this.m_Text6.Left = 616;
            this.m_Text6.Name = "m_Text6";
            this.m_Text6.Padding = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(3.75D, 0D, 3.75D, 1D);
            this.m_Text6.ScreenOwnerName = "OperatingParameters";
            this.m_Text6.TextHorizontalAlignment = "Center";
            this.m_Text6.Top = 144;
            this.m_Text6.VisibleDynamicsValue = true;
            this.m_Text6.Width = 162;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.IsCacheable = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.ModalScreen = true;
            this.Name = "OperatingParameters";
            this.PopupScreen = false;
            this.ScreenID = ((ushort)(2));
            this.ScreenTitle = "";
            this.StyleName = "";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.m_Initialized_OperatingParameters = true;
            this.AddControlsAndPrimitives();
            this.ResumeLayout(false);
            this.SecurityGroups = SecurityGroups.Group_01;
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
            if (!m_Initialized_OperatingParameters) {
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
            this.DrawingPrimitives.Add(this.m_Picture4);
            this.DrawingPrimitives.Add(this.m_Text2);
            this.DrawingPrimitives.Add(this.m_Text3);
            this.DrawingPrimitives.Add(this.m_Text4);
            this.DrawingPrimitives.Add(this.m_Picture5);
            this.DrawingPrimitives.Add(this.m_Text5);
            this.DrawingPrimitives.Add(this.m_Text1);
            this.DrawingPrimitives.Add(this.m_Picture1);
            this.DrawingPrimitives.Add(this.m_Picture6);
            this.DrawingPrimitives.Add(this.m_Picture3);
            this.DrawingPrimitives.Add(this.m_Text6);
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text6)).EndInit();
        }
        
        private void m_Picture2_Action_MouseDown(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_Picture2", "MouseDown", "Show Screen", "DriveParameters1", "Default", "");
            Neo.ApplicationFramework.Generated.Globals.DriveParameters1.Show();
        }
        
        private void m_Picture4_Action_MouseDown(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_Picture4", "MouseDown", "Show Screen", "PariaMode", "Default", "");
            Neo.ApplicationFramework.Generated.Globals.PariaMode.Show();
        }
        
        private void m_Picture5_Action_MouseDown(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_Picture5", "MouseDown", "Show Screen", "LiftParameters", "Default", "");
            Neo.ApplicationFramework.Generated.Globals.LiftParameters.Show();
        }
        
        private void m_Picture1_Action_MouseDown(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_Picture1", "MouseDown", "Show Screen", "RFID", "Default", "");
            Neo.ApplicationFramework.Generated.Globals.RFID.Show();
        }
        
        private void m_Picture6_Action_MouseDown(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_Picture6", "MouseDown", "Show Screen", "DriveParameters2", "Default", "");
            Neo.ApplicationFramework.Generated.Globals.DriveParameters2.Show();
        }
        
        private void m_Picture3_Action_MouseDown(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_Picture3", "MouseDown", "Show Screen", "Charging", "Default", "");
            Neo.ApplicationFramework.Generated.Globals.Charging.Show();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private void ApplyLanguageInternal() {
            Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager resources = new Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager(typeof(OperatingParameters));
            this.m_Text.Text = resources.GetText("OperatingParameters.Text.Text", "OPERATING PARAMETERS");
            this.m_Text2.Text = resources.GetText("OperatingParameters.Text2.Text", "RIGHT DRIVE");
            this.m_Text3.Text = resources.GetText("OperatingParameters.Text3.Text", "LEFT DRIVE");
            this.m_Text4.Text = resources.GetText("OperatingParameters.Text4.Text", "PARIA");
            this.m_Text5.Text = resources.GetText("OperatingParameters.Text5.Text", "LIFT");
            this.m_Text1.Text = resources.GetText("OperatingParameters.Text1.Text", "RFID");
            this.m_Text6.Text = resources.GetText("OperatingParameters.Text6.Text", "CHARGE CONTROL");
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
            if (!m_Initialized_OperatingParameters) {
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
