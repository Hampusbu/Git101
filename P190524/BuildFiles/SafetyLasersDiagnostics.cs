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
    public partial class SafetyLasersDiagnostics : Background, Neo.ApplicationFramework.Interfaces.ISupportMultiLanguage {
        
        private Neo.ApplicationFramework.Controls.TouchComboBox.TouchComboBoxHostCF m_TouchComboBox;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text6;
        
        private Neo.ApplicationFramework.Controls.Symbol.PictureCF m_Picture;
        
        private Neo.ApplicationFramework.Controls.Controls.Button m_Button;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text1;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text2;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text3;
        
        private bool m_Initialized_SafetyLasersDiagnostics;
        
        private Neo.ApplicationFramework.Common.Dynamics.BrushDynamicsConverterCF brushdynamicsconvertercf1;
        
        private Neo.ApplicationFramework.Common.Dynamics.MessageLibraryDynamicsConverterCF messagelibrarydynamicsconvertercf1;
        
        public SafetyLasersDiagnostics() {
            this.InitializeComponent();
            this.m_Button.Click += new System.EventHandler(this.m_Button_Action_Click);
            this.ApplyLanguageInitialize();
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text6 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text6);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter Picture {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter>(this.m_Picture);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter Button {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.ButtonCFAdapter>(this.m_Button);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text1 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text1);
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
        
        protected Neo.ApplicationFramework.Controls.Script.TouchComboBoxCFAdapter TouchComboBox {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TouchComboBoxCFAdapter>(this.m_TouchComboBox);
            }
        }
        
        private void InitializeComponent() {
            this.messagelibrarydynamicsconvertercf1 = new Neo.ApplicationFramework.Common.Dynamics.MessageLibraryDynamicsConverterCF();
            this.brushdynamicsconvertercf1 = new Neo.ApplicationFramework.Common.Dynamics.BrushDynamicsConverterCF();
            Neo.ApplicationFramework.Common.Dynamics.StringIntervalMapperCF stringintervalmappercf1 = new Neo.ApplicationFramework.Common.Dynamics.StringIntervalMapperCF();
            Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF stringintervalcf1 = new Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF();
            Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF stringintervalcf2 = new Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF();
            Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF stringintervalcf3 = new Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF();
            Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF stringintervalcf4 = new Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF();
            Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF stringintervalcf5 = new Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF();
            Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF stringintervalcf6 = new Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF();
            Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF stringintervalcf7 = new Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF();
            Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF stringintervalcf8 = new Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF();
            Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF stringintervalcf9 = new Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF();
            Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF stringintervalcf10 = new Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF();
            Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF stringintervalcf11 = new Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF();
            Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF stringintervalcf12 = new Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF();
            Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF stringintervalcf13 = new Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF();
            Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF stringintervalcf14 = new Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF();
            Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF stringintervalcf15 = new Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF();
            Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF stringintervalcf16 = new Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF();
            Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF stringintervalcf17 = new Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF();
            Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF stringintervalcf18 = new Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF();
            Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF stringintervalcf19 = new Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF();
            Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF stringintervalcf20 = new Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF();
            Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF stringintervalcf21 = new Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF();
            Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF stringintervalcf22 = new Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF();
            Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF stringintervalcf23 = new Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF();
            Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF stringintervalcf24 = new Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF();
            Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF stringintervalcf25 = new Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF();
            Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF stringintervalcf26 = new Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF();
            Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF stringintervalcf27 = new Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF();
            Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF stringintervalcf28 = new Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF();
            Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF stringintervalcf29 = new Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF();
            Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF stringintervalcf30 = new Neo.ApplicationFramework.Common.Dynamics.StringIntervalCF();
            Neo.ApplicationFramework.Common.Dynamics.BrushCFInterval brushcfinterval1 = new Neo.ApplicationFramework.Common.Dynamics.BrushCFInterval();
            Neo.ApplicationFramework.Common.Dynamics.BrushCFInterval brushcfinterval2 = new Neo.ApplicationFramework.Common.Dynamics.BrushCFInterval();
            Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper symbolintervalmapper1 = new Neo.ApplicationFramework.Common.Dynamics.SymbolIntervalMapper();
            Neo.ApplicationFramework.Common.Dynamics.MessageLibraryGroupResolver messagelibrarygroupresolver1 = new Neo.ApplicationFramework.Common.Dynamics.MessageLibraryGroupResolver();
            this.m_TouchComboBox = new Neo.ApplicationFramework.Controls.TouchComboBox.TouchComboBoxHostCF();
            this.m_Text6 = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_Picture = new Neo.ApplicationFramework.Controls.Symbol.PictureCF();
            this.m_Button = new Neo.ApplicationFramework.Controls.Controls.Button();
            this.m_Text1 = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_Text2 = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_Text3 = new Neo.ApplicationFramework.Controls.Controls.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_TouchComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text3)).BeginInit();
            this.SuspendLayout();
            // 
            // SafetyLasersDiagnostics
            // 
            this.BorderStyle = Neo.ApplicationFramework.Interfaces.ScreenBorderStyle.ThreeDBorder;
            this.ControlBox = false;
            // 
            // m_TouchComboBox
            // 
            this.m_TouchComboBox.AlternateBackground = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(161)))), ((int)(((byte)(161))))), System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107))))), Neo.ApplicationFramework.Interfaces.FillDirection.VerticalTopToBottom);
            this.m_TouchComboBox.AlternateForeground = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.m_TouchComboBox.ArrowBoxWidth = 30;
            this.m_TouchComboBox.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236))))), Neo.ApplicationFramework.Interfaces.FillDirection.VerticalTopToBottom);
            this.m_TouchComboBox.BlinkDynamicsValue = false;
            this.m_TouchComboBox.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.m_TouchComboBox.BorderThickness = 1;
            this.m_TouchComboBox.DelayLoad = false;
            this.m_TouchComboBox.EnabledDynamicsValue = true;
            this.m_TouchComboBox.FontName = "Tahoma";
            this.m_TouchComboBox.FontSize = 26D;
            this.m_TouchComboBox.Foreground = System.Drawing.Color.Black;
            stringintervalmappercf1.DefaultValue = null;
            stringintervalcf1.End = 1D;
            stringintervalcf1.Start = 1D;
            stringintervalcf1.Value = "Null";
            stringintervalcf2.End = 2D;
            stringintervalcf2.Start = 2D;
            stringintervalcf2.Value = "Slow Forward";
            stringintervalcf3.End = 3D;
            stringintervalcf3.Start = 3D;
            stringintervalcf3.Value = "Fast Forward";
            stringintervalcf4.End = 4D;
            stringintervalcf4.Start = 4D;
            stringintervalcf4.Value = "Slow Reverse";
            stringintervalcf5.End = 5D;
            stringintervalcf5.Start = 5D;
            stringintervalcf5.Value = "Fast Reverse";
            stringintervalcf6.End = 6D;
            stringintervalcf6.Start = 6D;
            stringintervalcf6.Value = "FWD Right Turn 30°";
            stringintervalcf7.End = 7D;
            stringintervalcf7.Start = 7D;
            stringintervalcf7.Value = "FWD Right Tunr 60°";
            stringintervalcf8.End = 8D;
            stringintervalcf8.Start = 8D;
            stringintervalcf8.Value = "Clockwise Rotation";
            stringintervalcf9.End = 9D;
            stringintervalcf9.Start = 9D;
            stringintervalcf9.Value = "Counter-Clockwise Rotation";
            stringintervalcf10.End = 10D;
            stringintervalcf10.Start = 10D;
            stringintervalcf10.Value = "FWD Left Turn 30°";
            stringintervalcf11.End = 11D;
            stringintervalcf11.Start = 11D;
            stringintervalcf11.Value = "FWD Left Turn 60°";
            stringintervalcf12.End = 12D;
            stringintervalcf12.Start = 12D;
            stringintervalcf12.Value = "REV Left Turn 60°";
            stringintervalcf13.End = 13D;
            stringintervalcf13.Start = 13D;
            stringintervalcf13.Value = "REV Left Turn 30°";
            stringintervalcf14.End = 14D;
            stringintervalcf14.Start = 14D;
            stringintervalcf14.Value = "REV Right Turn 60°";
            stringintervalcf15.End = 15D;
            stringintervalcf15.Start = 15D;
            stringintervalcf15.Value = "REV Right Turn 30°";
            stringintervalcf16.End = 16D;
            stringintervalcf16.Start = 16D;
            stringintervalcf16.Value = "SpecialField1";
            stringintervalcf17.End = 17D;
            stringintervalcf17.Start = 17D;
            stringintervalcf17.Value = "SpecialField2";
            stringintervalcf18.End = 18D;
            stringintervalcf18.Start = 18D;
            stringintervalcf18.Value = "Diff Left Fast";
            stringintervalcf19.End = 19D;
            stringintervalcf19.Start = 19D;
            stringintervalcf19.Value = "Diff Left Slow";
            stringintervalcf20.End = 20D;
            stringintervalcf20.Start = 20D;
            stringintervalcf20.Value = "Diff Right Fast";
            stringintervalcf21.End = 21D;
            stringintervalcf21.Start = 21D;
            stringintervalcf21.Value = "Diff Right Slow";
            stringintervalcf22.End = 22D;
            stringintervalcf22.Start = 22D;
            stringintervalcf22.Value = "FWD Crab Right 30°";
            stringintervalcf23.End = 23D;
            stringintervalcf23.Start = 23D;
            stringintervalcf23.Value = "FWD Crab Left 30°";
            stringintervalcf24.End = 24D;
            stringintervalcf24.Start = 24D;
            stringintervalcf24.Value = "REV Crab Right 30°";
            stringintervalcf25.End = 25D;
            stringintervalcf25.Start = 25D;
            stringintervalcf25.Value = "REV Crab Left 30°";
            stringintervalcf26.End = 26D;
            stringintervalcf26.Start = 26D;
            stringintervalcf26.Value = "FWD Crab Right 60°";
            stringintervalcf27.End = 27D;
            stringintervalcf27.Start = 27D;
            stringintervalcf27.Value = "FWD Crab Left 60°";
            stringintervalcf28.End = 28D;
            stringintervalcf28.Start = 28D;
            stringintervalcf28.Value = "REV Crab Right 60°";
            stringintervalcf29.End = 29D;
            stringintervalcf29.Start = 29D;
            stringintervalcf29.Value = "REV Crab Left 60°";
            stringintervalcf30.End = 30D;
            stringintervalcf30.Start = 30D;
            stringintervalcf30.Value = "SpecialField3";
            stringintervalmappercf1.Intervals.Add(stringintervalcf1);
            stringintervalmappercf1.Intervals.Add(stringintervalcf2);
            stringintervalmappercf1.Intervals.Add(stringintervalcf3);
            stringintervalmappercf1.Intervals.Add(stringintervalcf4);
            stringintervalmappercf1.Intervals.Add(stringintervalcf5);
            stringintervalmappercf1.Intervals.Add(stringintervalcf6);
            stringintervalmappercf1.Intervals.Add(stringintervalcf7);
            stringintervalmappercf1.Intervals.Add(stringintervalcf8);
            stringintervalmappercf1.Intervals.Add(stringintervalcf9);
            stringintervalmappercf1.Intervals.Add(stringintervalcf10);
            stringintervalmappercf1.Intervals.Add(stringintervalcf11);
            stringintervalmappercf1.Intervals.Add(stringintervalcf12);
            stringintervalmappercf1.Intervals.Add(stringintervalcf13);
            stringintervalmappercf1.Intervals.Add(stringintervalcf14);
            stringintervalmappercf1.Intervals.Add(stringintervalcf15);
            stringintervalmappercf1.Intervals.Add(stringintervalcf16);
            stringintervalmappercf1.Intervals.Add(stringintervalcf17);
            stringintervalmappercf1.Intervals.Add(stringintervalcf18);
            stringintervalmappercf1.Intervals.Add(stringintervalcf19);
            stringintervalmappercf1.Intervals.Add(stringintervalcf20);
            stringintervalmappercf1.Intervals.Add(stringintervalcf21);
            stringintervalmappercf1.Intervals.Add(stringintervalcf22);
            stringintervalmappercf1.Intervals.Add(stringintervalcf23);
            stringintervalmappercf1.Intervals.Add(stringintervalcf24);
            stringintervalmappercf1.Intervals.Add(stringintervalcf25);
            stringintervalmappercf1.Intervals.Add(stringintervalcf26);
            stringintervalmappercf1.Intervals.Add(stringintervalcf27);
            stringintervalmappercf1.Intervals.Add(stringintervalcf28);
            stringintervalmappercf1.Intervals.Add(stringintervalcf29);
            stringintervalmappercf1.Intervals.Add(stringintervalcf30);
            this.m_TouchComboBox.IntervalMapper = stringintervalmappercf1;
            this.m_TouchComboBox.IsSeparatorVisible = true;
            this.m_TouchComboBox.ItemHeight = 30;
            this.m_TouchComboBox.Location = new System.Drawing.Point(219, 185);
            this.m_TouchComboBox.Name = "m_TouchComboBox";
            this.m_TouchComboBox.ScrollBarWidth = 20;
            this.m_TouchComboBox.SelectedBackground = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(136)))), ((int)(((byte)(255))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_TouchComboBox.SelectedForeground = System.Drawing.Color.White;
            this.m_TouchComboBox.SelectedItem = null;
            this.m_TouchComboBox.SeparatorColor = System.Drawing.Color.White;
            this.m_TouchComboBox.Size = new System.Drawing.Size(552, 64);
            this.m_TouchComboBox.TabIndex = 2147483647;
            this.m_TouchComboBox.TouchScrollSensitivity = 8;
            this.m_TouchComboBox.VisibleDynamicsValue = true;
            // 
            // m_Text6
            // 
            this.m_Text6.BlinkDynamicsValue = false;
            this.m_Text6.Bold = true;
            this.m_Text6.DelayMouseInputPeriod = 0;
            this.m_Text6.EnabledDynamicsValue = true;
            this.m_Text6.FontSizePixels = 28;
            this.m_Text6.Foreground = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.m_Text6.Height = 36;
            this.m_Text6.Left = 76;
            this.m_Text6.Name = "m_Text6";
            this.m_Text6.Padding = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(7D, 0D, 7D, 1D);
            this.m_Text6.ScreenOwnerName = "SafetyLasersDiagnostics";
            this.m_Text6.Top = 6;
            this.m_Text6.VisibleDynamicsValue = true;
            this.m_Text6.Width = 170;
            // 
            // m_Picture
            // 
            this.m_Picture.BlinkDynamicsValue = false;
            this.m_Picture.DelayMouseInputPeriod = 0;
            this.m_Picture.EnabledDynamicsValue = true;
            this.m_Picture.Height = 54;
            this.m_Picture.Left = 3;
            this.m_Picture.Name = "m_Picture";
            this.m_Picture.ScreenOwnerName = "SafetyLasersDiagnostics";
            this.m_Picture.Stretch = true;
            this.m_Picture.SymbolName = "safteylaser";
            this.m_Picture.Top = -2;
            this.m_Picture.VisibleDynamicsValue = true;
            this.m_Picture.Width = 96;
            // 
            // m_Button
            // 
            this.m_Button.BlinkDynamicsValue = false;
            this.m_Button.BorderBrush = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Button.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(1D, 1D, 1D, 1D);
            brushdynamicsconvertercf1.BrushIntervalMapper.DefaultValue = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200))))), Neo.ApplicationFramework.Interfaces.FillDirection.VerticalTopToBottom);
            brushcfinterval1.Value = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(80)))), ((int)(((byte)(77))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            brushcfinterval2.End = 1D;
            brushcfinterval2.Start = 1D;
            brushcfinterval2.Value = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(177)))), ((int)(((byte)(76))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            brushdynamicsconvertercf1.BrushIntervalMapper.Intervals.Add(brushcfinterval1);
            brushdynamicsconvertercf1.BrushIntervalMapper.Intervals.Add(brushcfinterval2);
            this.m_Button.DelayMouseInputPeriod = 0;
            this.m_Button.EnabledDynamicsValue = true;
            this.m_Button.FontSizePixels = 24;
            this.m_Button.ForceTransparency = true;
            this.m_Button.Height = 83;
            this.m_Button.IndicatorMargin = null;
            this.m_Button.Left = 634;
            this.m_Button.Name = "m_Button";
            this.m_Button.RequiresTransparency = true;
            this.m_Button.ScreenOwnerName = "SafetyLasersDiagnostics";
            this.m_Button.SymbolIntervalMapper = symbolintervalmapper1;
            this.m_Button.TextHeight = 29;
            this.m_Button.TextValue = 0D;
            this.m_Button.TextWidth = 127;
            this.m_Button.Top = 79;
            this.m_Button.Value = 0D;
            this.m_Button.VisibleDynamicsValue = true;
            this.m_Button.VisualPropertiesHashCode = -2007975934;
            this.m_Button.Width = 137;
            // 
            // m_Text1
            // 
            this.m_Text1.BlinkDynamicsValue = false;
            this.m_Text1.Bold = true;
            this.m_Text1.DelayMouseInputPeriod = 0;
            this.m_Text1.EnabledDynamicsValue = true;
            this.m_Text1.FontSizePixels = 24;
            this.m_Text1.Height = 36;
            this.m_Text1.Left = 2;
            this.m_Text1.Name = "m_Text1";
            this.m_Text1.Padding = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(6D, 0D, 6D, 1D);
            this.m_Text1.ScreenOwnerName = "SafetyLasersDiagnostics";
            this.m_Text1.Top = 102;
            this.m_Text1.VisibleDynamicsValue = true;
            this.m_Text1.Width = 148;
            // 
            // m_Text2
            // 
            this.m_Text2.BlinkDynamicsValue = false;
            this.m_Text2.Bold = true;
            this.m_Text2.DelayMouseInputPeriod = 0;
            this.m_Text2.EnabledDynamicsValue = true;
            this.m_Text2.FontSizePixels = 24;
            this.m_Text2.Height = 36;
            this.m_Text2.Left = 24;
            this.m_Text2.Name = "m_Text2";
            this.m_Text2.Padding = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(6D, 0D, 6D, 1D);
            this.m_Text2.ScreenOwnerName = "SafetyLasersDiagnostics";
            this.m_Text2.Top = 200;
            this.m_Text2.VisibleDynamicsValue = true;
            this.m_Text2.Width = 133;
            // 
            // m_Text3
            // 
            this.m_Text3.BlinkDynamicsValue = false;
            messagelibrarydynamicsconvertercf1.MessageLibraryGroupName = "Group1";
            messagelibrarydynamicsconvertercf1.MessageLibraryGroupResolver = messagelibrarygroupresolver1;
            this.m_Text3.DelayMouseInputPeriod = 0;
            this.m_Text3.EnabledDynamicsValue = true;
            this.m_Text3.FontSizePixels = 20;
            this.m_Text3.Height = 6;
            this.m_Text3.Left = 223;
            this.m_Text3.Name = "m_Text3";
            this.m_Text3.Padding = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(5D, 0D, 5D, 1D);
            this.m_Text3.ScreenOwnerName = "SafetyLasersDiagnostics";
            this.m_Text3.Top = 106;
            this.m_Text3.VisibleDynamicsValue = true;
            this.m_Text3.Width = 2;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.IsCacheable = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.ModalScreen = true;
            this.Name = "SafetyLasersDiagnostics";
            this.PopupScreen = false;
            this.ScreenID = null;
            this.ScreenTitle = "";
            this.StyleName = "";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.m_Initialized_SafetyLasersDiagnostics = true;
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
            if (!m_Initialized_SafetyLasersDiagnostics) {
                return;
            }
            this.AddControls();
            this.AddDrawingPrimitives();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override void AddControls() {
            this.Controls.Add(this.m_TouchComboBox);
            ((System.ComponentModel.ISupportInitialize)(this.m_TouchComboBox)).EndInit();
            base.AddControls();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override void AddDrawingPrimitives() {
            base.AddDrawingPrimitives();
            this.DrawingPrimitives.Add(this.m_Text6);
            this.DrawingPrimitives.Add(this.m_Picture);
            this.DrawingPrimitives.Add(this.m_Button);
            this.DrawingPrimitives.Add(this.m_Text1);
            this.DrawingPrimitives.Add(this.m_Text2);
            this.DrawingPrimitives.Add(this.m_Text3);
            ((System.ComponentModel.ISupportInitialize)(this.m_Text6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text3)).EndInit();
        }
        
        private void m_Button_Action_Click(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_Button", "Click", "Toggle Tag", "", "");
            Neo.ApplicationFramework.Generated.Globals.Tags.SafetyLaserForceEnableBankSelect.ToggleTag();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private void ApplyLanguageInternal() {
            Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager resources = new Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager(typeof(SafetyLasersDiagnostics));
            this.m_Text6.Text = resources.GetText("SafetyLasersDiagnostics.Text6.Text", "SAFETY LASERS");
            this.m_Button.Text = resources.GetText("SafetyLasersDiagnostics.Button.Text", "FORCE");
            this.m_Text1.Text = resources.GetText("SafetyLasersDiagnostics.Text1.Text", "Current Bank:");
            this.m_Text2.Text = resources.GetText("SafetyLasersDiagnostics.Text2.Text", "Bank Select:");
            resources.ApplyTexts(this.m_TouchComboBox, "Texts", "SafetyLasersDiagnostics.TouchComboBox.Texts[0]", "Null", "SafetyLasersDiagnostics.TouchComboBox.Texts[1]", "Slow Forward", "SafetyLasersDiagnostics.TouchComboBox.Texts[2]", "Fast Forward", "SafetyLasersDiagnostics.TouchComboBox.Texts[3]", "Slow Reverse", "SafetyLasersDiagnostics.TouchComboBox.Texts[4]", "Fast Reverse", "SafetyLasersDiagnostics.TouchComboBox.Texts[5]", "FWD Right Turn 30°", "SafetyLasersDiagnostics.TouchComboBox.Texts[6]", "FWD Right Tunr 60°", "SafetyLasersDiagnostics.TouchComboBox.Texts[7]", "Clockwise Rotation", "SafetyLasersDiagnostics.TouchComboBox.Texts[8]", "Counter-Clockwise Rotation", "SafetyLasersDiagnostics.TouchComboBox.Texts[9]", "FWD Left Turn 30°", "SafetyLasersDiagnostics.TouchComboBox.Texts[10]", "FWD Left Turn 60°", "SafetyLasersDiagnostics.TouchComboBox.Texts[11]", "REV Left Turn 60°", "SafetyLasersDiagnostics.TouchComboBox.Texts[12]", "REV Left Turn 30°", "SafetyLasersDiagnostics.TouchComboBox.Texts[13]", "REV Right Turn 60°", "SafetyLasersDiagnostics.TouchComboBox.Texts[14]", "REV Right Turn 30°", "SafetyLasersDiagnostics.TouchComboBox.Texts[15]", "SpecialField1", "SafetyLasersDiagnostics.TouchComboBox.Texts[16]", "SpecialField2", "SafetyLasersDiagnostics.TouchComboBox.Texts[17]", "Diff Left Fast", "SafetyLasersDiagnostics.TouchComboBox.Texts[18]", "Diff Left Slow", "SafetyLasersDiagnostics.TouchComboBox.Texts[19]", "Diff Right Fast", "SafetyLasersDiagnostics.TouchComboBox.Texts[20]", "Diff Right Slow", "SafetyLasersDiagnostics.TouchComboBox.Texts[21]", "FWD Crab Right 30°", "SafetyLasersDiagnostics.TouchComboBox.Texts[22]", "FWD Crab Left 30°", "SafetyLasersDiagnostics.TouchComboBox.Texts[23]", "REV Crab Right 30°", "SafetyLasersDiagnostics.TouchComboBox.Texts[24]", "REV Crab Left 30°", "SafetyLasersDiagnostics.TouchComboBox.Texts[25]", "FWD Crab Right 60°", "SafetyLasersDiagnostics.TouchComboBox.Texts[26]", "FWD Crab Left 60°", "SafetyLasersDiagnostics.TouchComboBox.Texts[27]", "REV Crab Right 60°", "SafetyLasersDiagnostics.TouchComboBox.Texts[28]", "REV Crab Left 60°", "SafetyLasersDiagnostics.TouchComboBox.Texts[29]", "SpecialField3");
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
            if (!m_Initialized_SafetyLasersDiagnostics) {
                return;
            }
            base.ApplyLanguageInitialize();
            this.ApplyLanguageInternal();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override void ConnectDataBindings() {
            base.ConnectDataBindings();
            Neo.ApplicationFramework.Common.Data.DynamicBinding dynamicBinding1 = new Neo.ApplicationFramework.Common.Data.DynamicBinding("Value", Neo.ApplicationFramework.Common.Data.DataItemProxyFactory.CreateProxy("Tags.SafetyLaserBankSelect"), "Value", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Neo.ApplicationFramework.Common.Dynamics.VariantValueConverterCF.Default);
            this.m_TouchComboBox.DataBindings.Add(dynamicBinding1);
            this.m_DynamicBindings.Add(dynamicBinding1);
            Neo.ApplicationFramework.Common.Data.DynamicBinding dynamicBinding2 = new Neo.ApplicationFramework.Common.Data.DynamicBinding("Value", Neo.ApplicationFramework.Common.Data.DataItemProxyFactory.CreateProxy("Tags.SafetyLaserForceEnableBankSelect"), "Value", true, System.Windows.Forms.DataSourceUpdateMode.Never, Neo.ApplicationFramework.Common.Dynamics.VariantValueConverterCF.Default);
            this.m_Button.DataBindings.Add(dynamicBinding2);
            this.m_DynamicBindings.Add(dynamicBinding2);
            Neo.ApplicationFramework.Common.Data.DynamicBinding dynamicBinding3 = new Neo.ApplicationFramework.Common.Data.DynamicBinding("Background", Neo.ApplicationFramework.Common.Data.DataItemProxyFactory.CreateProxy("Tags.SafetyLaserForceEnableBankSelect"), "Value", true, System.Windows.Forms.DataSourceUpdateMode.Never, brushdynamicsconvertercf1);
            this.m_Button.DataBindings.Add(dynamicBinding3);
            this.m_DynamicBindings.Add(dynamicBinding3);
            Neo.ApplicationFramework.Common.Data.DynamicBinding dynamicBinding4 = new Neo.ApplicationFramework.Common.Data.DynamicBinding("Text", Neo.ApplicationFramework.Common.Data.DataItemProxyFactory.CreateProxy("Tags.SafetyLaserBankIndicator"), "Value", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, messagelibrarydynamicsconvertercf1);
            this.m_Text3.DataBindings.Add(dynamicBinding4);
            this.m_DynamicBindings.Add(dynamicBinding4);
            Neo.ApplicationFramework.Common.Data.DynamicBinding dynamicBinding5 = new Neo.ApplicationFramework.Common.Data.DynamicBinding("Value", Neo.ApplicationFramework.Common.Data.DataItemProxyFactory.CreateProxy("Tags.SafetyLaserBankIndicator"), "Value", true, System.Windows.Forms.DataSourceUpdateMode.Never, Neo.ApplicationFramework.Common.Dynamics.VariantValueConverterCF.Default);
            this.m_Text3.DataBindings.Add(dynamicBinding5);
            this.m_DynamicBindings.Add(dynamicBinding5);
        }
    }
}
