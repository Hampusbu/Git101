using System.Collections;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using System.IO;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Threading;
using Core.Api.Application;
using Core.Api.Service;
using Core.Api.Tools;
using Core.Api.Utilities;
using Core.Utilities.Utilities;
using Core.Engine.Application;
using Neo.ApplicationFramework.Attributes;
using Neo.ApplicationFramework.Common;
using Neo.ApplicationFramework.Common.Runtime;
using Neo.ApplicationFramework.Common.TypeConverters;
using Neo.ApplicationFramework.Common.Utilities;
using Neo.ApplicationFramework.Interfaces;
using Neo.ApplicationFramework.Measurement;
using Neo.ApplicationFramework.Storage.Settings;
using Neo.ApplicationFramework.Tools.Runtime;
using Neo.ApplicationFramework.Tools.Storage;

[assembly: AssemblyVersion("2.42.103.0")]
[assembly: NeoDesignerVersion("2.42.103.0")]

namespace Neo.ApplicationFramework.Generated
{
    public class Globals : GlobalsBase
    {
        private static readonly log4net.ILog m_Log = log4net.LogManager.GetLogger(typeof(Globals));

        static Globals()
        {
            
        }

        public Globals() 
            : base(CreateToolManager())
        {
            m_ProjectSettings.MainScreenTitle = "Template";
            m_ProjectSettings.Topmost = false;
            m_ProjectSettings.StartupLocation = new Point(0, 0);
            m_ProjectSettings.MaximizeOnStartup = true;
            m_ProjectSettings.UseWideScrollbars = false;
            m_ProjectSettings.MainScreenSize = new Size(800,480);
            m_ProjectSettings.BorderStyle = ScreenBorderStyle.ThreeDBorder;
            m_ProjectSettings.InputDelay = 2000;
            m_ProjectSettings.IsOnScreenKeyboardEnabled = true;
            m_ProjectSettings.KeyboardLayoutName = "US";
            m_ProjectSettings.TerminalGroup = TerminalGroup.Default;
            List<IStorageProviderSetting> storageProviderSettingsList = new List<IStorageProviderSetting>() {
                new ProjectStorageProviderSetting("BackupAtStartup", false), new ProjectStorageProviderSetting("MaxSize", 0), 
            };
            m_ProjectSettings.StorageProviderSettings = new LocallyHostedProjectStorageProviderSettings("SQLite Database", storageProviderSettingsList, "");
            m_SystemSettings.AutomaticallyTurnOfBacklight = false;
            m_SystemSettings.BacklightTimeout = 900;    
            m_SystemSettings.KeepBacklightOnIfNotifierWindowIsVisible = false;
            Dictionary<ComPort, PortMode> comPortModes = new Dictionary<ComPort, PortMode>();
            comPortModes.Add(ComPort.COM1, PortMode.Nonconfigurable); comPortModes.Add(ComPort.COM2, PortMode.rs422);                            
            m_SystemSettings.ComPortModes = comPortModes;                            
            m_SystemSettings.KeyBeep = false;
            m_SystemSettings.TimeZoneDisplayName = "";
            m_SystemSettings.TimeZoneId = -1;
            m_SystemSettings.RegionLCID = 1033;
            m_SystemSettings.AdjustForDaylightSaving = true;
            m_SystemSettings.FtpServerEnabled = true;
            m_SystemSettings.FtpServerFriendlyNamesEnabled = false;
            m_SystemSettings.FtpServerAllowAnonymous = false;
            m_SystemSettings.FtpServerSdCardAccess = false;
            m_SystemSettings.FtpServerUsbAccess = false;
            m_SystemSettings.FtpServerDefaultDir = @"";
            m_SystemSettings.NTLMUser = @"user";
            m_SystemSettings.NTLMPassword = @"U94:Jj2dfBwF8L";
            m_SystemSettings.VncServerEnabled = false;
            m_SystemSettings.VncTcpPort = 5900;
            m_SystemSettings.VncHttpTcpPort = 5800;
            m_SystemSettings.VncViewOnlyPassword = @"";
            m_SystemSettings.VncFullAccessPassword = @"";
            m_SystemSettings.VncActiveConnectionNotification = false;
            m_SystemSettings.IsKeyPanel = false;
            m_SystemSettings.IsHeadless = false;
            m_SystemSettings.AlarmButtonShowScreenTarget = @"";
            m_SystemSettings.ScreenRotationAngle = 0;
            m_SystemSettings.BeShellMenuPassword = @"";
            m_SystemSettings.ProjectGuid = new Guid("fb9bcac8-b4b2-4588-a993-ed2b7bb72767");
        }
        
        
        private static IToolManager CreateToolManager()
        {
            string executablePath = typeof(Globals).Module.FullyQualifiedName;            
            // take simulation into account
            var coreApplication = Environment.OSVersion.Platform != PlatformID.WinCE ? (ICoreApplication)new CoreApplication(true, executablePath) : (ICoreApplication)new CoreApplicationCe();
            IToolManager toolManager = new ApplicationEngineCe().CreateToolManager(true, coreApplication, Path.Combine(coreApplication.StartupPath, "Modules.cfgtool"));
            return toolManager;
        }
            

        
       

        /// <summary>
        /// Neo generated code - do not modify
        /// the contents of this method(s) with the code editor.
        /// </summary>        
                    public static IPrinterDevice Printer1
                    {
                        get
                        {
                            IDeviceManagerServiceCF deviceManagerService = ServiceContainerCF.GetService<IDeviceManagerServiceCF>();
                            return deviceManagerService.GetOutputDevice<IPrinterDevice>();
                        }
                    }           
                    public static IScreenAdapter ErrorWindow
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<ErrorWindow>("Screens.ErrorWindow.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter InfoBox
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<InfoBox>("Screens.InfoBox.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter HomeScreenInfo
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<HomeScreenInfo>("Screens.HomeScreenInfo.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter ScreenSettings
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<ScreenSettings>("Screens.ScreenSettings.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter ConfirmationScreen
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<ConfirmationScreen>("Screens.ConfirmationScreen.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter CancelOrderConfirmation
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<CancelOrderConfirmation>("Screens.CancelOrderConfirmation.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter UpdateMessage
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<UpdateMessage>("Screens.UpdateMessage.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter IOHelpScreen
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<IOHelpScreen>("Screens.IOHelpScreen.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter Background
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<Background>("Screens.Background.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter Home
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<Home>("Screens.Home.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter Charging
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<Charging>("Screens.Charging.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter RFIDDiagnostics
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<RFIDDiagnostics>("Screens.RFIDDiagnostics.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter PowerDiagnostics
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<PowerDiagnostics>("Screens.PowerDiagnostics.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter RFID
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<RFID>("Screens.RFID.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter Assisted_Insert
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<Assisted_Insert>("Screens.Assisted_Insert.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter SideShiftParameters
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<SideShiftParameters>("Screens.SideShiftParameters.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter WheelVisuals
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<WheelVisuals>("Screens.WheelVisuals.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter SteeringParameters4
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<SteeringParameters4>("Screens.SteeringParameters4.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter SteeringParameters3
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<SteeringParameters3>("Screens.SteeringParameters3.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter SteeringParameters2
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<SteeringParameters2>("Screens.SteeringParameters2.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter SteerDiagnostics4
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<SteerDiagnostics4>("Screens.SteerDiagnostics4.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter SteerDiagnostics3
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<SteerDiagnostics3>("Screens.SteerDiagnostics3.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter SteerDiagnostics2
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<SteerDiagnostics2>("Screens.SteerDiagnostics2.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter DriveParameters2
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<DriveParameters2>("Screens.DriveParameters2.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter DriveDiagnostics2
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<DriveDiagnostics2>("Screens.DriveDiagnostics2.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter AGVStats
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<AGVStats>("Screens.AGVStats.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter DriveDiagnostics1
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<DriveDiagnostics1>("Screens.DriveDiagnostics1.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter LiftParameters
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<LiftParameters>("Screens.LiftParameters.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter InputScreen3
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<InputScreen3>("Screens.InputScreen3.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter InputScreen2
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<InputScreen2>("Screens.InputScreen2.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter InputScreen1
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<InputScreen1>("Screens.InputScreen1.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter HTML_Viewer
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<HTML_Viewer>("Screens.HTML_Viewer.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter OutputExplorer1
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<OutputExplorer1>("Screens.OutputExplorer1.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter IO_Explorer
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<IO_Explorer>("Screens.IO_Explorer.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter Alarms
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<Alarms>("Screens.Alarms.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter SteerDiagnostics1
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<SteerDiagnostics1>("Screens.SteerDiagnostics1.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter LiftDiagnostics
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<LiftDiagnostics>("Screens.LiftDiagnostics.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter Layout
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<Layout>("Screens.Layout.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter wifi
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<wifi>("Screens.wifi.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter PariaMode
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<PariaMode>("Screens.PariaMode.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter SteeringParameters1
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<SteeringParameters1>("Screens.SteeringParameters1.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter DriveParameters1
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<DriveParameters1>("Screens.DriveParameters1.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter LiDARParameters
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<LiDARParameters>("Screens.LiDARParameters.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter VersionInformation
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<VersionInformation>("Screens.VersionInformation.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter LocalOrder
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<LocalOrder>("Screens.LocalOrder.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter Diagnostics
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<Diagnostics>("Screens.Diagnostics.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter OperatingParameters
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<OperatingParameters>("Screens.OperatingParameters.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter Window640x480
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<Window640x480>("Screens.Window640x480.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter Window640x420
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<Window640x420>("Screens.Window640x420.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter Window500x300
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<Window500x300>("Screens.Window500x300.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter ConnectionLost
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<ConnectionLost>("Screens.ConnectionLost.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter Navbar
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<Navbar>("Screens.Navbar.Default").Adapter;
                        }
                    }           
                    public static MessageBox MessageBox
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<MessageBox>("MessageBox");
                        }
                    }           
                    public static CommandFromPC CommandFromPC
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<CommandFromPC>("CommandFromPC");
                        }
                    }           
                    public static AlarmHandler AlarmHandler
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<AlarmHandler>("AlarmHandler");
                        }
                    }           
                    public static StartUpValues StartUpValues
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<StartUpValues>("StartUpValues");
                        }
                    }           
                    public static UpdateStrings UpdateStrings
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<UpdateStrings>("UpdateStrings");
                        }
                    }           
                    public static ScreenSaverTimer ScreenSaverTimer
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<ScreenSaverTimer>("ScreenSaverTimer");
                        }
                    }           
                    public static WebServerRootComponent WebServerRootComponent
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<WebServerRootComponent>("WebServerRootComponent");
                        }
                    }           
                    public static TextLibrary TextLibrary
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<TextLibrary>("TextLibrary");
                        }
                    }           
                    public static Scheduler Scheduler
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<Scheduler>("Scheduler");
                        }
                    }           
                    public static SntpClientRootComponent SntpClientRootComponent
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<SntpClientRootComponent>("SntpClientRootComponent");
                        }
                    }           
                    public static Security Security
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<Security>("Security");
                        }
                    }           
                    public static ProjectConfiguration ProjectConfiguration
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<ProjectConfiguration>("ProjectConfiguration");
                        }
                    }           
                    public static LicenseRootComponent LicenseRootComponent
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<LicenseRootComponent>("LicenseRootComponent");
                        }
                    }           
                    public static Expressions Expressions
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<Expressions>("Expressions");
                        }
                    }           
                    public static Tags Tags
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<Tags>("Tags");
                        }
                    }           
                    public static MultipleLanguages MultipleLanguages
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<MultipleLanguages>("MultipleLanguages");
                        }
                    }           
                    public static AlarmServer AlarmServer
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<AlarmServer>("AlarmServer");
                        }
                    }           
                    public static IScreenAdapter ScreenSaver
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<ScreenSaver>("Screens.ScreenSaver.Default").Adapter;
                        }
                    }   
        [MTAThread]
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "NeoMainThread";
            
            InitializeBeHwApiLog();
            
            
            
            UserStartupMessage.SendUserStartupMessageToBeijerShell("Loading Files");
            if (!StopWatchCF.Silent)
                StopWatchCF.Send("Starting Project");
            StopWatchCF.SetTimestamp("***** Project Startup Time *****");
            while (ProcessExplorer.WaitForAttachDebugger)
            {
                Thread.Sleep(1000);
            }
            IsCompiledForCE = true;
            IsCompiledForDesktopWindowsPanel = false;

            Instance = new Globals();
        	if (!Instance.CheckIfApplicationCanRun())
				return;

            string executingAssemblyName = Assembly.GetExecutingAssembly().FullName;
            string executablePath = typeof(Globals).Module.FullyQualifiedName;
            Instance.Go(executingAssemblyName, executablePath, args, new string[]{"Tags","MultipleLanguages","TextLibrary","AlarmServer","Expressions","LicenseRootComponent","ProjectConfiguration","Security","SntpClientRootComponent","Scheduler","WebServerRootComponent","Controller1","ScreenSaverTimer","UpdateStrings","StartUpValues","AlarmHandler","CommandFromPC","MessageBox","ProjectImages"}, new string[]{}, () => ScreenSaver);
        }

    }
}