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
    public partial class Background : Navbar, Neo.ApplicationFramework.Interfaces.ISupportMultiLanguage {
        
        private Neo.ApplicationFramework.Controls.Controls.RectangleCF m_Rectangle;
        
        private Neo.ApplicationFramework.Controls.Symbol.PictureCF m_Picture1;
        
        private Neo.ApplicationFramework.Controls.Symbol.SymbolCF m_MultiPicture;
        
        private Neo.ApplicationFramework.Controls.Controls.RectangleCF m_Rectangle1;
        
        private Neo.ApplicationFramework.Controls.Symbol.PictureCF m_Picture;
        
        private Neo.ApplicationFramework.Controls.Symbol.PictureCF m_Picture6;
        
        private Neo.ApplicationFramework.Controls.Symbol.PictureCF m_Picture2;
        
        private bool m_Initialized_Background;
        
        public Background() {
            this.InitializeComponent();
            this.m_Picture1.MouseDown += new System.EventHandler(this.m_Picture1_Action_MouseDown);
            this.m_MultiPicture.MouseDown += new System.EventHandler(this.m_MultiPicture_Action_MouseDown);
            this.m_Picture6.MouseDown += new System.EventHandler(this.m_Picture6_Action_MouseDown);
            this.m_Picture2.MouseDown += new System.EventHandler(this.m_Picture2_Action_MouseDown);
            this.ApplyLanguageInitialize();
        }
        
        protected Neo.ApplicationFramework.Controls.Script.ShapeCFAdapter Rectangle {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ShapeCFAdapter>(this.m_Rectangle);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter Picture1 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter>(this.m_Picture1);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter MultiPicture {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter>(this.m_MultiPicture);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.ShapeCFAdapter Rectangle1 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ShapeCFAdapter>(this.m_Rectangle1);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter Picture {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter>(this.m_Picture);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter Picture6 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter>(this.m_Picture6);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter Picture2 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter>(this.m_Picture2);
            }
        }
        
        private void InitializeComponent() {
            Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper symbolintervalmapper1 = new Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper();
            Neo.ApplicationFramework.Common.Dynamics.SymbolInterval symbolinterval1 = new Neo.ApplicationFramework.Common.Dynamics.SymbolInterval();
            Neo.ApplicationFramework.Common.MultiSymbolItem multisymbolitem1 = new Neo.ApplicationFramework.Common.MultiSymbolItem();
            Neo.ApplicationFramework.Common.Dynamics.SymbolInterval symbolinterval2 = new Neo.ApplicationFramework.Common.Dynamics.SymbolInterval();
            Neo.ApplicationFramework.Common.MultiSymbolItem multisymbolitem2 = new Neo.ApplicationFramework.Common.MultiSymbolItem();
            this.m_Rectangle = new Neo.ApplicationFramework.Controls.Controls.RectangleCF();
            this.m_Picture1 = new Neo.ApplicationFramework.Controls.Symbol.PictureCF();
            this.m_MultiPicture = new Neo.ApplicationFramework.Controls.Symbol.SymbolCF();
            this.m_Rectangle1 = new Neo.ApplicationFramework.Controls.Controls.RectangleCF();
            this.m_Picture = new Neo.ApplicationFramework.Controls.Symbol.PictureCF();
            this.m_Picture6 = new Neo.ApplicationFramework.Controls.Symbol.PictureCF();
            this.m_Picture2 = new Neo.ApplicationFramework.Controls.Symbol.PictureCF();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_MultiPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture2)).BeginInit();
            this.SuspendLayout();
            // 
            // Background
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
            this.m_Rectangle.Fill = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(58))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Rectangle.Height = 62;
            this.m_Rectangle.Left = -1;
            this.m_Rectangle.Name = "m_Rectangle";
            this.m_Rectangle.ScreenOwnerName = "Background";
            this.m_Rectangle.Stroke = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF();
            this.m_Rectangle.Top = -2;
            this.m_Rectangle.VisibleDynamicsValue = true;
            this.m_Rectangle.Width = 802;
            // 
            // m_Picture1
            // 
            this.m_Picture1.BlinkDynamicsValue = false;
            this.m_Picture1.DelayMouseInputPeriod = 0;
            this.m_Picture1.EnabledDynamicsValue = true;
            this.m_Picture1.Height = 50;
            this.m_Picture1.Left = 480;
            this.m_Picture1.Name = "m_Picture1";
            this.m_Picture1.ScreenOwnerName = "Background";
            this.m_Picture1.Stretch = true;
            this.m_Picture1.SymbolName = "settings";
            this.m_Picture1.Top = 4;
            this.m_Picture1.VisibleDynamicsValue = true;
            this.m_Picture1.Width = 50;
            // 
            // m_MultiPicture
            // 
            this.m_MultiPicture.BlinkDynamicsValue = false;
            this.m_MultiPicture.DelayMouseInputPeriod = 0;
            this.m_MultiPicture.EnabledDynamicsValue = true;
            this.m_MultiPicture.Height = 60;
            this.m_MultiPicture.Left = 587;
            this.m_MultiPicture.Name = "m_MultiPicture";
            this.m_MultiPicture.ScreenOwnerName = "Background";
            this.m_MultiPicture.Stretch = true;
            multisymbolitem1.SymbolName = "people";
            multisymbolitem1.Transparent = false;
            symbolinterval1.Value = multisymbolitem1;
            symbolinterval2.End = 1D;
            symbolinterval2.Start = 1D;
            multisymbolitem2.SymbolName = "people_highlighted";
            multisymbolitem2.Transparent = false;
            symbolinterval2.Value = multisymbolitem2;
            symbolintervalmapper1.Intervals.Add(symbolinterval1);
            symbolintervalmapper1.Intervals.Add(symbolinterval2);
            this.m_MultiPicture.SymbolIntervalMapper = symbolintervalmapper1;
            this.m_MultiPicture.SymbolName = "people";
            this.m_MultiPicture.Top = 0;
            this.m_MultiPicture.Value = 0D;
            this.m_MultiPicture.VisibleDynamicsValue = true;
            this.m_MultiPicture.Width = 60;
            // 
            // m_Rectangle1
            // 
            this.m_Rectangle1.BitmapEffect = new Neo.ApplicationFramework.Common.Graphics.Logic.BitmapEffectCF();
            this.m_Rectangle1.BlinkDynamicsValue = false;
            this.m_Rectangle1.DelayMouseInputPeriod = 0;
            this.m_Rectangle1.EnabledDynamicsValue = true;
            this.m_Rectangle1.Fill = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(58))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Rectangle1.Height = 62;
            this.m_Rectangle1.Left = 585;
            this.m_Rectangle1.Name = "m_Rectangle1";
            this.m_Rectangle1.ScreenOwnerName = "Background";
            this.m_Rectangle1.Stroke = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF();
            this.m_Rectangle1.Top = -2;
            this.m_Rectangle1.VisibleDynamicsValue = true;
            this.m_Rectangle1.Width = 128;
            // 
            // m_Picture
            // 
            this.m_Picture.BlinkDynamicsValue = false;
            this.m_Picture.DelayMouseInputPeriod = 0;
            this.m_Picture.EnabledDynamicsValue = true;
            this.m_Picture.Height = 60;
            this.m_Picture.Left = 655;
            this.m_Picture.Name = "m_Picture";
            this.m_Picture.ScreenOwnerName = "Background";
            this.m_Picture.Stretch = true;
            this.m_Picture.SymbolName = "logo_dark";
            this.m_Picture.Top = 0;
            this.m_Picture.VisibleDynamicsValue = true;
            this.m_Picture.Width = 145;
            // 
            // m_Picture6
            // 
            this.m_Picture6.BlinkDynamicsValue = false;
            this.m_Picture6.DelayMouseInputPeriod = 0;
            this.m_Picture6.EnabledDynamicsValue = true;
            this.m_Picture6.Height = 62;
            this.m_Picture6.Left = 585;
            this.m_Picture6.Name = "m_Picture6";
            this.m_Picture6.ScreenOwnerName = "Background";
            this.m_Picture6.Stretch = true;
            this.m_Picture6.SymbolName = "people_logout";
            this.m_Picture6.Top = -2;
            this.m_Picture6.VisibleDynamicsValue = true;
            this.m_Picture6.Width = 62;
            // 
            // m_Picture2
            // 
            this.m_Picture2.BlinkDynamicsValue = false;
            this.m_Picture2.DelayMouseInputPeriod = 0;
            this.m_Picture2.EnabledDynamicsValue = true;
            this.m_Picture2.Height = 72;
            this.m_Picture2.Left = 525;
            this.m_Picture2.Name = "m_Picture2";
            this.m_Picture2.ScreenOwnerName = "Background";
            this.m_Picture2.Stretch = true;
            this.m_Picture2.SymbolName = "backward";
            this.m_Picture2.Top = -6;
            this.m_Picture2.VisibleDynamicsValue = true;
            this.m_Picture2.Width = 73;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.IsCacheable = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.ModalScreen = true;
            this.Name = "Background";
            this.PopupScreen = false;
            this.ScreenID = null;
            this.ScreenTitle = "";
            this.StyleName = "";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.m_Initialized_Background = true;
            this.AddControlsAndPrimitives();
            this.ResumeLayout(false);
            this.SecurityExtender.SetSecurityGroupsRequired(this.m_Picture1, SecurityGroups.Group_01);
            this.SecurityExtender.SetVisibilityOnAccessDenied(this.m_Picture1, VisibilityModes.Hidden);
            this.SecurityExtender.SetSecurityGroupsRequired(this.m_Rectangle1, SecurityGroups.Group_01 | SecurityGroups.Group_03);
            this.SecurityExtender.SetVisibilityOnAccessDenied(this.m_Rectangle1, VisibilityModes.Hidden);
            this.SecurityExtender.SetSecurityGroupsRequired(this.m_Picture6, SecurityGroups.Group_01 | SecurityGroups.Group_03);
            this.SecurityExtender.SetVisibilityOnAccessDenied(this.m_Picture6, VisibilityModes.Hidden);
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
            if (!m_Initialized_Background) {
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
            this.DrawingPrimitives.Add(this.m_Picture1);
            this.DrawingPrimitives.Add(this.m_MultiPicture);
            this.DrawingPrimitives.Add(this.m_Rectangle1);
            this.DrawingPrimitives.Add(this.m_Picture);
            this.DrawingPrimitives.Add(this.m_Picture6);
            this.DrawingPrimitives.Add(this.m_Picture2);
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_MultiPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture2)).EndInit();
        }
        
        private void m_Picture1_Action_MouseDown(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_Picture1", "MouseDown", "Show Screen", "ScreenSettings", "Default", "");
            Neo.ApplicationFramework.Generated.Globals.ScreenSettings.Show();
        }
        
        private void m_MultiPicture_Action_MouseDown(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_MultiPicture", "MouseDown", "Login", "Security", "");
            Neo.ApplicationFramework.Generated.Globals.Security.Login();
        }
        
        private void m_Picture6_Action_MouseDown(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_Picture6", "MouseDown", "Logout", "Security", "");
            Neo.ApplicationFramework.Generated.Globals.Security.Logout();
        }
        
        private void m_Picture2_Action_MouseDown(object sender, System.EventArgs e) {
            Core.Api.Service.ServiceContainerCF.GetService<Neo.ApplicationFramework.Interfaces.IScreenManager>().LogActionBackScreen("m_Picture2", "MouseDown", "Show Previous Screen", "");
            Core.Api.Service.ServiceContainerCF.GetService<Neo.ApplicationFramework.Interfaces.IScreenManager>().ActionBackScreen();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private void ApplyLanguageInternal() {
            Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager resources = new Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager(typeof(Background));
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
            if (!m_Initialized_Background) {
                return;
            }
            base.ApplyLanguageInitialize();
            this.ApplyLanguageInternal();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override void ConnectDataBindings() {
            base.ConnectDataBindings();
            Neo.ApplicationFramework.Common.Data.DynamicBinding dynamicBinding1 = new Neo.ApplicationFramework.Common.Data.DynamicBinding("Value", Neo.ApplicationFramework.Common.Data.DataItemProxyFactory.CreateProxy("Tags.HighlightLogin"), "Value", true, System.Windows.Forms.DataSourceUpdateMode.Never, Neo.ApplicationFramework.Common.Dynamics.VariantValueConverterCF.Default);
            this.m_MultiPicture.DataBindings.Add(dynamicBinding1);
            this.m_DynamicBindings.Add(dynamicBinding1);
        }
    }
}
