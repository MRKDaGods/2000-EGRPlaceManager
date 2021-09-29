using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace MRK {
    public partial class Main : Form {
        string m_WorkingDir;
        readonly Config m_Config;
        readonly PlacesLiveView m_PlacesLiveView;
        readonly Thread m_UIThread;
        readonly Timer m_RunnableTimer;

        public string WorkingDirectory => m_WorkingDir;
        public bool ConsoleShowCallerNames { get; private set; }
        public Runnable UIRunnable { get; private set; }

        public static Main Instance { get; private set; }

        public Main() {
            Instance = this;
            m_UIThread = Thread.CurrentThread;
            UIRunnable = new Runnable(m_UIThread);

            InitializeComponent();

            //button event handlers
            chooseWorkingAreaButton.Click += OnWorkingAreaButtonClicked;
            refreshToolstrip.Click += OnRefreshTooltipClick;

            //textbox event handlers
            workingDirectoryTextbox.TextChanged += OnWorkingDirectoryTextboxTextChanged;

            //toggle event handlers
            consoleCallerPathToggle.CheckedChanged += OnConsoleCheckStateChanged;
            //update ConsoleShowCallerNames!!
            OnConsoleCheckStateChanged(null, null);

            m_RunnableTimer = new Timer {
                Interval = 34,
                Enabled = true
            };
            m_RunnableTimer.Tick += OnRunnableTimerTick;

            //view
            m_PlacesLiveView = new PlacesLiveView(placesLiveTabPage);

            //load our config
            m_Config = new Config();
            if (!m_Config.Load()) {
                m_Config.Save();
            }

            workingDirectoryTextbox.Text = m_Config["WORKING_DIRECTORY"].String;
            Select();
        }

        void OnRunnableTimerTick(object? sender, EventArgs e) {
            UIRunnable.Update();
        }

        void OnConsoleCheckStateChanged(object? sender, EventArgs e) {
            //avoid cross thread
            ConsoleShowCallerNames = consoleCallerPathToggle.Checked;
        }

        void OnWorkingAreaButtonClicked(object? sender, EventArgs e) {
            FolderBrowserDialog dialog = new();
            if (dialog.ShowDialog() == DialogResult.OK) {
                m_WorkingDir = dialog.SelectedPath;
                workingDirectoryTextbox.Text = m_WorkingDir;
            }
        }

        void OnWorkingDirectoryTextboxTextChanged(object? sender, EventArgs e) {
            m_WorkingDir = workingDirectoryTextbox.Text;
            m_Config["WORKING_DIRECTORY"] = new ConfigRecord(m_WorkingDir);
        }

        protected override void OnClosing(CancelEventArgs e) {
            m_Config.Save();

            base.OnClosing(e);
        }

        void OnRefreshTooltipClick(object? sender, EventArgs e) {
            m_PlacesLiveView.ReloadData();
        }

        public void AppendToConsole(string line) {
            if (Thread.CurrentThread != m_UIThread) {
                consoleTextbox.Invoke(() => {
                    consoleTextbox.AppendText(line);
                });
            }
            else {
                consoleTextbox.AppendText(line);
            }
        }
    }
}
