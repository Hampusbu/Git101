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
    public partial class DriveDiagnostics2 : Background, Neo.ApplicationFramework.Interfaces.ISupportMultiLanguage {
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text1;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text6;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text4;
        
        private Neo.ApplicationFramework.Controls.Controls.AnalogNumeric m_AnalogNumeric;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text2;
        
        private Neo.ApplicationFramework.Controls.Controls.AnalogNumeric m_AnalogNumeric1;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text3;
        
        private Neo.ApplicationFramework.Controls.Controls.AnalogNumeric m_AnalogNumeric2;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text5;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text7;
        
        private Neo.ApplicationFramework.Controls.Symbol.PictureCF m_Picture2;
        
        private Neo.ApplicationFramework.Controls.Symbol.PictureCF m_Picture;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text8;
        
        private Neo.ApplicationFramework.Controls.Controls.AnalogNumeric m_AnalogNumeric3;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text9;
        
        private Neo.ApplicationFramework.Controls.Controls.Line m_Line;
        
        private Neo.ApplicationFramework.Controls.Controls.Button m_ResetRear;
        
        private bool m_Initialized_DriveDiagnostics2;
        
        public DriveDiagnostics2() {
            this.InitializeComponent();
            this.m_Picture2.MouseDown += new System.EventHandler(this.m_Picture2_Action_MouseDown);
            this.m_ResetRear.Click += new System.EventHandler(this.m_ResetRear_Action_Click);
            this.ApplyLanguageInitialize();
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text1 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text1);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text6 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text6);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text4 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text4);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.AnalogNumericCFAdapter AnalogNumeric {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.AnalogNumericCFAdapter>(this.m_AnalogNumeric);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text2 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text2);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.AnalogNumericCFAdapter AnalogNumeric1 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.AnalogNumericCFAdapter>(this.m_AnalogNumeric1);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text3 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text3);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.AnalogNumericCFAdapter AnalogNumeric2 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.AnalogNumericCFAdapter>(this.m_AnalogNumeric2);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text5 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text5);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text7 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text7);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter Picture2 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter>(this.m_Picture2);
            }
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
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text8 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text8);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.AnalogNumericCFAdapter AnalogNumeric3 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.AnalogNumericCFAdapter>(this.m_AnalogNumeric3);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text9 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text9);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.LineCFAdapter Line {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.LineCFAdapter>(this.m_Line);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter ResetRear {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter>(this.m_ResetRear);
            }
        }
        
        private void InitializeComponent() {
            Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper symbolintervalmapper1 = new Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper();
            this.m_Text1 = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_Text6 = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_Text4 = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_AnalogNumeric = new Neo.ApplicationFramework.Controls.Controls.AnalogNumeric();
            this.m_Text2 = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_AnalogNumeric1 = new Neo.ApplicationFramework.Controls.Controls.AnalogNumeric();
            this.m_Text3 = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_AnalogNumeric2 = new Neo.ApplicationFramework.Controls.Controls.AnalogNumeric();
            this.m_Text5 = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_Text7 = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_Picture2 = new Neo.ApplicationFramework.Controls.Symbol.PictureCF();
            this.m_Picture = new Neo.ApplicationFramework.Controls.Symbol.PictureCF();
            this.m_Text = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_Text8 = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_AnalogNumeric3 = new Neo.ApplicationFramework.Controls.Controls.AnalogNumeric();
            this.m_Text9 = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_Line = new Neo.ApplicationFramework.Controls.Controls.Line();
            this.m_ResetRear = new Neo.ApplicationFramework.Controls.Controls.Button();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_AnalogNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_AnalogNumeric1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_AnalogNumeric2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_AnalogNumeric3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_ResetRear)).BeginInit();
            this.SuspendLayout();
            // 
            // DriveDiagnostics2
            // 
            this.BorderStyle = Neo.ApplicationFramework.Interfaces.ScreenBorderStyle.ThreeDBorder;
            this.ControlBox = false;
            // 
            // m_Text1
            // 
            this.m_Text1.BlinkDynamicsValue = false;
            this.m_Text1.DelayMouseInputPeriod = 0;
            this.m_Text1.EnabledDynamicsValue = true;
            this.m_Text1.FontSizePixels = 20;
            this.m_Text1.Height = 28;
            this.m_Text1.Left = 259;
            this.m_Text1.Name = "m_Text1";
            this.m_Text1.Padding = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(5D, 0D, 5D, 1D);
            this.m_Text1.ScreenOwnerName = "DriveDiagnostics2";
            this.m_Text1.Top = 137;
            this.m_Text1.VisibleDynamicsValue = true;
            this.m_Text1.Width = 87;
            // 
            // m_Text6
            // 
            this.m_Text6.BlinkDynamicsValue = false;
            this.m_Text6.DelayMouseInputPeriod = 0;
            this.m_Text6.EnabledDynamicsValue = true;
            this.m_Text6.FontSizePixels = 20;
            this.m_Text6.Height = 28;
            this.m_Text6.Left = 138;
            this.m_Text6.Name = "m_Text6";
            this.m_Text6.Padding = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(5D, 0D, 5D, 1D);
            this.m_Text6.ScreenOwnerName = "DriveDiagnostics2";
            this.m_Text6.Top = 213;
            this.m_Text6.VisibleDynamicsValue = true;
            this.m_Text6.Width = 187;
            // 
            // m_Text4
            // 
            this.m_Text4.BlinkDynamicsValue = false;
            this.m_Text4.DelayMouseInputPeriod = 0;
            this.m_Text4.EnabledDynamicsValue = true;
            this.m_Text4.FontSizePixels = 20;
            this.m_Text4.Height = 28;
            this.m_Text4.Left = 233;
            this.m_Text4.Name = "m_Text4";
            this.m_Text4.Padding = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(5D, 0D, 5D, 1D);
            this.m_Text4.ScreenOwnerName = "DriveDiagnostics2";
            this.m_Text4.Top = 175;
            this.m_Text4.VisibleDynamicsValue = true;
            this.m_Text4.Width = 109;
            // 
            // m_AnalogNumeric
            // 
            this.m_AnalogNumeric.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_AnalogNumeric.BlinkDynamicsValue = false;
            this.m_AnalogNumeric.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_AnalogNumeric.DelayMouseInputPeriod = 0;
            this.m_AnalogNumeric.EnabledDynamicsValue = true;
            this.m_AnalogNumeric.FontSizePixels = 20;
            this.m_AnalogNumeric.Height = 30;
            this.m_AnalogNumeric.Left = 385;
            this.m_AnalogNumeric.Name = "m_AnalogNumeric";
            this.m_AnalogNumeric.Padding = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(2D, 2D, 2D, 2D);
            this.m_AnalogNumeric.ReadOnly = true;
            this.m_AnalogNumeric.ScreenOwnerName = "DriveDiagnostics2";
            this.m_AnalogNumeric.Top = 137;
            this.m_AnalogNumeric.VisibleDynamicsValue = true;
            this.m_AnalogNumeric.Width = 100;
            // 
            // m_Text2
            // 
            this.m_Text2.BlinkDynamicsValue = false;
            this.m_Text2.DelayMouseInputPeriod = 0;
            this.m_Text2.EnabledDynamicsValue = true;
            this.m_Text2.FontSizePixels = 20;
            this.m_Text2.Height = 28;
            this.m_Text2.Left = 515;
            this.m_Text2.Name = "m_Text2";
            this.m_Text2.Padding = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(5D, 0D, 5D, 1D);
            this.m_Text2.ScreenOwnerName = "DriveDiagnostics2";
            this.m_Text2.Top = 137;
            this.m_Text2.VisibleDynamicsValue = true;
            this.m_Text2.Width = 50;
            // 
            // m_AnalogNumeric1
            // 
            this.m_AnalogNumeric1.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_AnalogNumeric1.BlinkDynamicsValue = false;
            this.m_AnalogNumeric1.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_AnalogNumeric1.DelayMouseInputPeriod = 0;
            this.m_AnalogNumeric1.EnabledDynamicsValue = true;
            this.m_AnalogNumeric1.FontSizePixels = 20;
            this.m_AnalogNumeric1.Height = 30;
            this.m_AnalogNumeric1.Left = 385;
            this.m_AnalogNumeric1.Name = "m_AnalogNumeric1";
            this.m_AnalogNumeric1.Padding = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(2D, 2D, 2D, 2D);
            this.m_AnalogNumeric1.ReadOnly = true;
            this.m_AnalogNumeric1.ScreenOwnerName = "DriveDiagnostics2";
            this.m_AnalogNumeric1.Top = 175;
            this.m_AnalogNumeric1.VisibleDynamicsValue = true;
            this.m_AnalogNumeric1.Width = 100;
            // 
            // m_Text3
            // 
            this.m_Text3.BlinkDynamicsValue = false;
            this.m_Text3.DelayMouseInputPeriod = 0;
            this.m_Text3.EnabledDynamicsValue = true;
            this.m_Text3.FontSizePixels = 20;
            this.m_Text3.Height = 28;
            this.m_Text3.Left = 515;
            this.m_Text3.Name = "m_Text3";
            this.m_Text3.Padding = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(5D, 0D, 5D, 1D);
            this.m_Text3.ScreenOwnerName = "DriveDiagnostics2";
            this.m_Text3.Top = 175;
            this.m_Text3.VisibleDynamicsValue = true;
            this.m_Text3.Width = 50;
            // 
            // m_AnalogNumeric2
            // 
            this.m_AnalogNumeric2.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_AnalogNumeric2.BlinkDynamicsValue = false;
            this.m_AnalogNumeric2.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_AnalogNumeric2.DelayMouseInputPeriod = 0;
            this.m_AnalogNumeric2.EnabledDynamicsValue = true;
            this.m_AnalogNumeric2.FontSizePixels = 20;
            this.m_AnalogNumeric2.Height = 30;
            this.m_AnalogNumeric2.Left = 385;
            this.m_AnalogNumeric2.Name = "m_AnalogNumeric2";
            this.m_AnalogNumeric2.Padding = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(2D, 2D, 2D, 2D);
            this.m_AnalogNumeric2.ReadOnly = true;
            this.m_AnalogNumeric2.ScreenOwnerName = "DriveDiagnostics2";
            this.m_AnalogNumeric2.Top = 213;
            this.m_AnalogNumeric2.VisibleDynamicsValue = true;
            this.m_AnalogNumeric2.Width = 100;
            // 
            // m_Text5
            // 
            this.m_Text5.BlinkDynamicsValue = false;
            this.m_Text5.DelayMouseInputPeriod = 0;
            this.m_Text5.EnabledDynamicsValue = true;
            this.m_Text5.FontSizePixels = 20;
            this.m_Text5.Height = 28;
            this.m_Text5.Left = 515;
            this.m_Text5.Name = "m_Text5";
            this.m_Text5.Padding = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(5D, 0D, 5D, 1D);
            this.m_Text5.ScreenOwnerName = "DriveDiagnostics2";
            this.m_Text5.Top = 213;
            this.m_Text5.VisibleDynamicsValue = true;
            this.m_Text5.Width = 36;
            // 
            // m_Text7
            // 
            this.m_Text7.BlinkDynamicsValue = false;
            this.m_Text7.Bold = true;
            this.m_Text7.DelayMouseInputPeriod = 0;
            this.m_Text7.EnabledDynamicsValue = true;
            this.m_Text7.FontSizePixels = 20;
            this.m_Text7.Height = 28;
            this.m_Text7.Left = 17;
            this.m_Text7.Name = "m_Text7";
            this.m_Text7.Padding = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(5D, 0D, 5D, 1D);
            this.m_Text7.ScreenOwnerName = "DriveDiagnostics2";
            this.m_Text7.Top = 72;
            this.m_Text7.VisibleDynamicsValue = true;
            this.m_Text7.Width = 183;
            // 
            // m_Picture2
            // 
            this.m_Picture2.BlinkDynamicsValue = false;
            this.m_Picture2.DelayMouseInputPeriod = 0;
            this.m_Picture2.EnabledDynamicsValue = true;
            this.m_Picture2.Height = 69;
            this.m_Picture2.Left = -12;
            this.m_Picture2.Name = "m_Picture2";
            this.m_Picture2.ScreenOwnerName = "DriveDiagnostics2";
            this.m_Picture2.Stretch = true;
            this.m_Picture2.SymbolName = "backward";
            this.m_Picture2.Top = 331;
            this.m_Picture2.VisibleDynamicsValue = true;
            this.m_Picture2.Width = 70;
            // 
            // m_Picture
            // 
            this.m_Picture.BlinkDynamicsValue = false;
            this.m_Picture.DelayMouseInputPeriod = 0;
            this.m_Picture.EnabledDynamicsValue = true;
            this.m_Picture.Height = 50;
            this.m_Picture.Left = 17;
            this.m_Picture.Name = "m_Picture";
            this.m_Picture.ScreenOwnerName = "DriveDiagnostics2";
            this.m_Picture.Stretch = true;
            this.m_Picture.SymbolName = "drive";
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
            this.m_Text.Left = 76;
            this.m_Text.Name = "m_Text";
            this.m_Text.Padding = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(7D, 0D, 7D, 1D);
            this.m_Text.ScreenOwnerName = "DriveDiagnostics2";
            this.m_Text.Top = 6;
            this.m_Text.VisibleDynamicsValue = true;
            this.m_Text.Width = 56;
            // 
            // m_Text8
            // 
            this.m_Text8.BlinkDynamicsValue = false;
            this.m_Text8.DelayMouseInputPeriod = 0;
            this.m_Text8.EnabledDynamicsValue = true;
            this.m_Text8.FontSizePixels = 20;
            this.m_Text8.Height = 28;
            this.m_Text8.Left = 84;
            this.m_Text8.Name = "m_Text8";
            this.m_Text8.Padding = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(5D, 0D, 5D, 1D);
            this.m_Text8.ScreenOwnerName = "DriveDiagnostics2";
            this.m_Text8.Top = 307;
            this.m_Text8.VisibleDynamicsValue = true;
            this.m_Text8.Width = 190;
            // 
            // m_AnalogNumeric3
            // 
            this.m_AnalogNumeric3.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_AnalogNumeric3.BlinkDynamicsValue = false;
            this.m_AnalogNumeric3.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_AnalogNumeric3.DelayMouseInputPeriod = 0;
            this.m_AnalogNumeric3.EnabledDynamicsValue = true;
            this.m_AnalogNumeric3.FontSizePixels = 20;
            this.m_AnalogNumeric3.Height = 30;
            this.m_AnalogNumeric3.Left = 323;
            this.m_AnalogNumeric3.Name = "m_AnalogNumeric3";
            this.m_AnalogNumeric3.Padding = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(2D, 2D, 2D, 2D);
            this.m_AnalogNumeric3.ReadOnly = true;
            this.m_AnalogNumeric3.ScreenOwnerName = "DriveDiagnostics2";
            this.m_AnalogNumeric3.Top = 307;
            this.m_AnalogNumeric3.VisibleDynamicsValue = true;
            this.m_AnalogNumeric3.Width = 219;
            // 
            // m_Text9
            // 
            this.m_Text9.BlinkDynamicsValue = false;
            this.m_Text9.DelayMouseInputPeriod = 0;
            this.m_Text9.EnabledDynamicsValue = true;
            this.m_Text9.FontSizePixels = 20;
            this.m_Text9.Height = 28;
            this.m_Text9.Left = 533;
            this.m_Text9.Name = "m_Text9";
            this.m_Text9.Padding = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(5D, 0D, 5D, 1D);
            this.m_Text9.ScreenOwnerName = "DriveDiagnostics2";
            this.m_Text9.Top = 307;
            this.m_Text9.VisibleDynamicsValue = true;
            this.m_Text9.Width = 22;
            // 
            // m_Line
            // 
            this.m_Line.BlinkDynamicsValue = false;
            this.m_Line.DelayMouseInputPeriod = 0;
            this.m_Line.EnabledDynamicsValue = true;
            this.m_Line.Fill = null;
            this.m_Line.Name = "m_Line";
            this.m_Line.ScreenOwnerName = "DriveDiagnostics2";
            this.m_Line.Stroke = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Line.VisibleDynamicsValue = true;
            this.m_Line.X1 = 3;
            this.m_Line.X2 = 802;
            this.m_Line.Y1 = 281;
            this.m_Line.Y2 = 283;
            // 
            // m_ResetRear
            // 
            this.m_ResetRear.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(188)))), ((int)(((byte)(166))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_ResetRear.BlinkDynamicsValue = false;
            this.m_ResetRear.Bold = true;
            this.m_ResetRear.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_ResetRear.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(1D, 1D, 1D, 1D);
            this.m_ResetRear.DelayMouseInputPeriod = 0;
            this.m_ResetRear.EnabledDynamicsValue = true;
            this.m_ResetRear.FontSizePixels = 15;
            this.m_ResetRear.ForceTransparency = true;
            this.m_ResetRear.Foreground = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.m_ResetRear.Height = 50;
            this.m_ResetRear.IndicatorMargin = null;
            this.m_ResetRear.Left = 640;
            this.m_ResetRear.Name = "m_ResetRear";
            this.m_ResetRear.RequiresTransparency = true;
            this.m_ResetRear.ScreenOwnerName = "DriveDiagnostics2";
            this.m_ResetRear.SymbolIntervalMapper = symbolintervalmapper1;
            this.m_ResetRear.TextHeight = 37;
            this.m_ResetRear.TextValue = 0D;
            this.m_ResetRear.TextWidth = 125;
            this.m_ResetRear.Top = 297;
            this.m_ResetRear.Value = 0D;
            this.m_ResetRear.VisibleDynamicsValue = true;
            this.m_ResetRear.VisualPropertiesHashCode = -997771910;
            this.m_ResetRear.Width = 135;
            this.m_ResetRear.WordWrap = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.IsCacheable = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.ModalScreen = true;
            this.Name = "DriveDiagnostics2";
            this.PopupScreen = false;
            this.ScreenID = null;
            this.ScreenTitle = "";
            this.StyleName = "";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.m_Initialized_DriveDiagnostics2 = true;
            this.AddControlsAndPrimitives();
            this.ResumeLayout(false);
            this.SecurityExtender.SetSecurityGroupsRequired(this.m_ResetRear, SecurityGroups.Group_01);
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
            if (!m_Initialized_DriveDiagnostics2) {
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
            this.DrawingPrimitives.Add(this.m_Text6);
            this.DrawingPrimitives.Add(this.m_Text4);
            this.DrawingPrimitives.Add(this.m_AnalogNumeric);
            this.DrawingPrimitives.Add(this.m_Text2);
            this.DrawingPrimitives.Add(this.m_AnalogNumeric1);
            this.DrawingPrimitives.Add(this.m_Text3);
            this.DrawingPrimitives.Add(this.m_AnalogNumeric2);
            this.DrawingPrimitives.Add(this.m_Text5);
            this.DrawingPrimitives.Add(this.m_Text7);
            this.DrawingPrimitives.Add(this.m_Picture2);
            this.DrawingPrimitives.Add(this.m_Picture);
            this.DrawingPrimitives.Add(this.m_Text);
            this.DrawingPrimitives.Add(this.m_Text8);
            this.DrawingPrimitives.Add(this.m_AnalogNumeric3);
            this.DrawingPrimitives.Add(this.m_Text9);
            this.DrawingPrimitives.Add(this.m_Line);
            this.DrawingPrimitives.Add(this.m_ResetRear);
            ((System.ComponentModel.ISupportInitialize)(this.m_Text1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_AnalogNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_AnalogNumeric1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_AnalogNumeric2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_AnalogNumeric3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_ResetRear)).EndInit();
        }
        
        private void m_Picture2_Action_MouseDown(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_Picture2", "MouseDown", "Show Screen", "DriveDiagnostics1", "Default", "");
            Neo.ApplicationFramework.Generated.Globals.DriveDiagnostics1.Show();
        }
        
        private void m_ResetRear_Action_Click(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_ResetRear", "Click", "Set Tag", "Tags.Rear", "");
            Neo.ApplicationFramework.Generated.Globals.Tags.Rear.SetTag();
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_ResetRear", "Click", "Show Screen", "ConfirmationScreen", "Default", "");
            Neo.ApplicationFramework.Generated.Globals.ConfirmationScreen.Show();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private void ApplyLanguageInternal() {
            Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager resources = new Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager(typeof(DriveDiagnostics2));
            this.m_Text1.Text = resources.GetText("DriveDiagnostics2.Text1.Text", "Set speed:");
            this.m_Text6.Text = resources.GetText("DriveDiagnostics2.Text6.Text", "Encoder distance count:");
            this.m_Text4.Text = resources.GetText("DriveDiagnostics2.Text4.Text", "Actual speed:");
            this.m_Text2.Text = resources.GetText("DriveDiagnostics2.Text2.Text", "mm/s");
            this.m_Text3.Text = resources.GetText("DriveDiagnostics2.Text3.Text", "mm/s");
            this.m_Text5.Text = resources.GetText("DriveDiagnostics2.Text5.Text", "mm");
            this.m_Text7.Text = resources.GetText("DriveDiagnostics2.Text7.Text", "LEFT TRACTION DRIVE");
            this.m_Text.Text = resources.GetText("DriveDiagnostics2.Text.Text", "DRIVE");
            this.m_ResetRear.Text = resources.GetText("DriveDiagnostics2.ResetRear.Text", "RESET DISTANCE");
            this.m_Text9.Text = resources.GetText("DriveDiagnostics2.Text9.Text", "m");
            this.m_Text8.Text = resources.GetText("DriveDiagnostics2.Text8.Text", "Total Distance Traveled:");
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
            if (!m_Initialized_DriveDiagnostics2) {
                return;
            }
            base.ApplyLanguageInitialize();
            this.ApplyLanguageInternal();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override void ConnectDataBindings() {
            base.ConnectDataBindings();
            Neo.ApplicationFramework.Common.Data.DynamicBinding dynamicBinding1 = new Neo.ApplicationFramework.Common.Data.DynamicBinding("Value", Neo.ApplicationFramework.Common.Data.DataItemProxyFactory.CreateProxy("Tags.CurrentSetSpeed2"), "Value", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Neo.ApplicationFramework.Common.Dynamics.VariantValueConverterCF.Default);
            this.m_AnalogNumeric.DataBindings.Add(dynamicBinding1);
            this.m_DynamicBindings.Add(dynamicBinding1);
            Neo.ApplicationFramework.Common.Data.DynamicBinding dynamicBinding2 = new Neo.ApplicationFramework.Common.Data.DynamicBinding("Value", Neo.ApplicationFramework.Common.Data.DataItemProxyFactory.CreateProxy("Tags.ActualSpeed2"), "Value", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Neo.ApplicationFramework.Common.Dynamics.VariantValueConverterCF.Default);
            this.m_AnalogNumeric1.DataBindings.Add(dynamicBinding2);
            this.m_DynamicBindings.Add(dynamicBinding2);
            Neo.ApplicationFramework.Common.Data.DynamicBinding dynamicBinding3 = new Neo.ApplicationFramework.Common.Data.DynamicBinding("Value", Neo.ApplicationFramework.Common.Data.DataItemProxyFactory.CreateProxy("Tags.EncoderDistance2"), "Value", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Neo.ApplicationFramework.Common.Dynamics.VariantValueConverterCF.Default);
            this.m_AnalogNumeric2.DataBindings.Add(dynamicBinding3);
            this.m_DynamicBindings.Add(dynamicBinding3);
            Neo.ApplicationFramework.Common.Data.DynamicBinding dynamicBinding4 = new Neo.ApplicationFramework.Common.Data.DynamicBinding("Value", Neo.ApplicationFramework.Common.Data.DataItemProxyFactory.CreateProxy("Tags.RearWheelDistance"), "Value", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Neo.ApplicationFramework.Common.Dynamics.VariantValueConverterCF.Default);
            this.m_AnalogNumeric3.DataBindings.Add(dynamicBinding4);
            this.m_DynamicBindings.Add(dynamicBinding4);
        }
    }
}
