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
    public partial class PariaMode : Background, Neo.ApplicationFramework.Interfaces.ISupportMultiLanguage {
        
        private Neo.ApplicationFramework.Controls.Symbol.PictureCF m_Picture;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text1;
        
        private Neo.ApplicationFramework.Controls.Symbol.SymbolCF m_MultiPicture1;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text10;
        
        private Neo.ApplicationFramework.Controls.Symbol.SymbolCF m_MultiPicture;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text2;
        
        private bool m_Initialized_PariaMode;
        
        public PariaMode() {
            this.InitializeComponent();
            this.m_MultiPicture1.MouseDown += new System.EventHandler(this.m_MultiPicture1_Action_MouseDown);
            this.m_Text10.MouseDown += new System.EventHandler(this.m_Text10_Action_MouseDown);
            this.m_MultiPicture.MouseDown += new System.EventHandler(this.m_MultiPicture_Action_MouseDown);
            this.m_Text2.MouseDown += new System.EventHandler(this.m_Text2_Action_MouseDown);
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
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text1 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text1);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter MultiPicture1 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter>(this.m_MultiPicture1);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text10 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text10);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter MultiPicture {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter>(this.m_MultiPicture);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text2 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text2);
            }
        }
        
        private void InitializeComponent() {
            Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper symbolintervalmapper1 = new Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper();
            Neo.ApplicationFramework.Common.Dynamics.SymbolInterval symbolinterval1 = new Neo.ApplicationFramework.Common.Dynamics.SymbolInterval();
            Neo.ApplicationFramework.Common.MultiSymbolItem multisymbolitem1 = new Neo.ApplicationFramework.Common.MultiSymbolItem();
            Neo.ApplicationFramework.Common.Dynamics.SymbolInterval symbolinterval2 = new Neo.ApplicationFramework.Common.Dynamics.SymbolInterval();
            Neo.ApplicationFramework.Common.MultiSymbolItem multisymbolitem2 = new Neo.ApplicationFramework.Common.MultiSymbolItem();
            Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper symbolintervalmapper2 = new Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper();
            Neo.ApplicationFramework.Common.Dynamics.SymbolInterval symbolinterval3 = new Neo.ApplicationFramework.Common.Dynamics.SymbolInterval();
            Neo.ApplicationFramework.Common.MultiSymbolItem multisymbolitem3 = new Neo.ApplicationFramework.Common.MultiSymbolItem();
            Neo.ApplicationFramework.Common.Dynamics.SymbolInterval symbolinterval4 = new Neo.ApplicationFramework.Common.Dynamics.SymbolInterval();
            Neo.ApplicationFramework.Common.MultiSymbolItem multisymbolitem4 = new Neo.ApplicationFramework.Common.MultiSymbolItem();
            this.m_Picture = new Neo.ApplicationFramework.Controls.Symbol.PictureCF();
            this.m_Text = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_Text1 = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_MultiPicture1 = new Neo.ApplicationFramework.Controls.Symbol.SymbolCF();
            this.m_Text10 = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_MultiPicture = new Neo.ApplicationFramework.Controls.Symbol.SymbolCF();
            this.m_Text2 = new Neo.ApplicationFramework.Controls.Controls.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_MultiPicture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_MultiPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text2)).BeginInit();
            this.SuspendLayout();
            // 
            // PariaMode
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
            this.m_Picture.ScreenOwnerName = "PariaMode";
            this.m_Picture.Stretch = true;
            this.m_Picture.SymbolName = "onoff";
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
            this.m_Text.ScreenOwnerName = "PariaMode";
            this.m_Text.Top = 6;
            this.m_Text.VisibleDynamicsValue = true;
            this.m_Text.Width = 105;
            // 
            // m_Text1
            // 
            this.m_Text1.BlinkDynamicsValue = false;
            this.m_Text1.DelayMouseInputPeriod = 0;
            this.m_Text1.EnabledDynamicsValue = true;
            this.m_Text1.FontSizePixels = 20;
            this.m_Text1.Height = 28;
            this.m_Text1.Left = 256;
            this.m_Text1.Name = "m_Text1";
            this.m_Text1.Padding = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(5D, 0D, 5D, 1D);
            this.m_Text1.ScreenOwnerName = "PariaMode";
            this.m_Text1.Top = 204;
            this.m_Text1.VisibleDynamicsValue = true;
            this.m_Text1.Width = 98;
            // 
            // m_MultiPicture1
            // 
            this.m_MultiPicture1.BlinkDynamicsValue = false;
            this.m_MultiPicture1.DelayMouseInputPeriod = 0;
            this.m_MultiPicture1.EnabledDynamicsValue = true;
            this.m_MultiPicture1.Height = 39;
            this.m_MultiPicture1.Left = 398;
            this.m_MultiPicture1.Name = "m_MultiPicture1";
            this.m_MultiPicture1.ScreenOwnerName = "PariaMode";
            this.m_MultiPicture1.Stretch = true;
            multisymbolitem1.SymbolName = "radiooff (1)";
            multisymbolitem1.Transparent = false;
            symbolinterval1.Value = multisymbolitem1;
            symbolinterval2.End = 1D;
            symbolinterval2.Start = 1D;
            multisymbolitem2.SymbolName = "radioon (1)";
            multisymbolitem2.Transparent = false;
            symbolinterval2.Value = multisymbolitem2;
            symbolintervalmapper1.Intervals.Add(symbolinterval1);
            symbolintervalmapper1.Intervals.Add(symbolinterval2);
            this.m_MultiPicture1.SymbolIntervalMapper = symbolintervalmapper1;
            this.m_MultiPicture1.SymbolName = "radiooff (1)";
            this.m_MultiPicture1.Top = 199;
            this.m_MultiPicture1.Value = 0D;
            this.m_MultiPicture1.VisibleDynamicsValue = true;
            this.m_MultiPicture1.Width = 40;
            // 
            // m_Text10
            // 
            this.m_Text10.BlinkDynamicsValue = false;
            this.m_Text10.DelayMouseInputPeriod = 0;
            this.m_Text10.EnabledDynamicsValue = true;
            this.m_Text10.FontSizePixels = 20;
            this.m_Text10.Height = 28;
            this.m_Text10.Left = 450;
            this.m_Text10.Name = "m_Text10";
            this.m_Text10.Padding = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(5D, 0D, 5D, 1D);
            this.m_Text10.ScreenOwnerName = "PariaMode";
            this.m_Text10.Top = 204;
            this.m_Text10.VisibleDynamicsValue = true;
            this.m_Text10.Width = 29;
            // 
            // m_MultiPicture
            // 
            this.m_MultiPicture.BlinkDynamicsValue = false;
            this.m_MultiPicture.DelayMouseInputPeriod = 0;
            this.m_MultiPicture.EnabledDynamicsValue = true;
            this.m_MultiPicture.Height = 39;
            this.m_MultiPicture.Left = 398;
            this.m_MultiPicture.Name = "m_MultiPicture";
            this.m_MultiPicture.ScreenOwnerName = "PariaMode";
            this.m_MultiPicture.Stretch = true;
            multisymbolitem3.SymbolName = "radioon (1)";
            multisymbolitem3.Transparent = false;
            symbolinterval3.Value = multisymbolitem3;
            symbolinterval4.End = 1D;
            symbolinterval4.Start = 1D;
            multisymbolitem4.SymbolName = "radiooff (1)";
            multisymbolitem4.Transparent = false;
            symbolinterval4.Value = multisymbolitem4;
            symbolintervalmapper2.Intervals.Add(symbolinterval3);
            symbolintervalmapper2.Intervals.Add(symbolinterval4);
            this.m_MultiPicture.SymbolIntervalMapper = symbolintervalmapper2;
            this.m_MultiPicture.SymbolName = "radioon (1)";
            this.m_MultiPicture.Top = 255;
            this.m_MultiPicture.Value = 0D;
            this.m_MultiPicture.VisibleDynamicsValue = true;
            this.m_MultiPicture.Width = 40;
            // 
            // m_Text2
            // 
            this.m_Text2.BlinkDynamicsValue = false;
            this.m_Text2.DelayMouseInputPeriod = 0;
            this.m_Text2.EnabledDynamicsValue = true;
            this.m_Text2.FontSizePixels = 20;
            this.m_Text2.Height = 28;
            this.m_Text2.Left = 450;
            this.m_Text2.Name = "m_Text2";
            this.m_Text2.Padding = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(5D, 0D, 5D, 1D);
            this.m_Text2.ScreenOwnerName = "PariaMode";
            this.m_Text2.Top = 259;
            this.m_Text2.VisibleDynamicsValue = true;
            this.m_Text2.Width = 31;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.IsCacheable = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.ModalScreen = true;
            this.Name = "PariaMode";
            this.PopupScreen = false;
            this.ScreenID = null;
            this.ScreenTitle = "";
            this.StyleName = "";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.m_Initialized_PariaMode = true;
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
            if (!m_Initialized_PariaMode) {
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
            this.DrawingPrimitives.Add(this.m_Text1);
            this.DrawingPrimitives.Add(this.m_MultiPicture1);
            this.DrawingPrimitives.Add(this.m_Text10);
            this.DrawingPrimitives.Add(this.m_MultiPicture);
            this.DrawingPrimitives.Add(this.m_Text2);
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_MultiPicture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_MultiPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text2)).EndInit();
        }
        
        private void m_MultiPicture1_Action_MouseDown(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_MultiPicture1", "MouseDown", "Set Tag", "Tags.PariaMode", "");
            Neo.ApplicationFramework.Generated.Globals.Tags.PariaMode.SetTag();
        }
        
        private void m_Text10_Action_MouseDown(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_Text10", "MouseDown", "Set Tag", "Tags.PariaMode", "");
            Neo.ApplicationFramework.Generated.Globals.Tags.PariaMode.SetTag();
        }
        
        private void m_MultiPicture_Action_MouseDown(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_MultiPicture", "MouseDown", "Reset Tag", "Tags.PariaMode", "");
            Neo.ApplicationFramework.Generated.Globals.Tags.PariaMode.ResetTag();
        }
        
        private void m_Text2_Action_MouseDown(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_Text2", "MouseDown", "Reset Tag", "Tags.PariaMode", "");
            Neo.ApplicationFramework.Generated.Globals.Tags.PariaMode.ResetTag();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private void ApplyLanguageInternal() {
            Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager resources = new Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager(typeof(PariaMode));
            this.m_Text.Text = resources.GetText("PariaMode.Text.Text", "PARIA MODE");
            this.m_Text1.Text = resources.GetText("PariaMode.Text1.Text", "Paria mode:");
            this.m_Text10.Text = resources.GetText("PariaMode.Text10.Text", "On");
            this.m_Text2.Text = resources.GetText("PariaMode.Text2.Text", "Off");
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
            if (!m_Initialized_PariaMode) {
                return;
            }
            base.ApplyLanguageInitialize();
            this.ApplyLanguageInternal();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override void ConnectDataBindings() {
            base.ConnectDataBindings();
            Neo.ApplicationFramework.Common.Data.DynamicBinding dynamicBinding1 = new Neo.ApplicationFramework.Common.Data.DynamicBinding("Value", Neo.ApplicationFramework.Common.Data.DataItemProxyFactory.CreateProxy("Tags.PariaMode"), "Value", true, System.Windows.Forms.DataSourceUpdateMode.Never, Neo.ApplicationFramework.Common.Dynamics.VariantValueConverterCF.Default);
            this.m_MultiPicture1.DataBindings.Add(dynamicBinding1);
            this.m_DynamicBindings.Add(dynamicBinding1);
            Neo.ApplicationFramework.Common.Data.DynamicBinding dynamicBinding2 = new Neo.ApplicationFramework.Common.Data.DynamicBinding("Value", Neo.ApplicationFramework.Common.Data.DataItemProxyFactory.CreateProxy("Tags.PariaMode"), "Value", true, System.Windows.Forms.DataSourceUpdateMode.Never, Neo.ApplicationFramework.Common.Dynamics.VariantValueConverterCF.Default);
            this.m_MultiPicture.DataBindings.Add(dynamicBinding2);
            this.m_DynamicBindings.Add(dynamicBinding2);
        }
    }
}
