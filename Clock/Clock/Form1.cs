using System;
using System.Drawing;
using System.Windows.Forms;
using ClockClassLibrary;
using log4net;

namespace Clock
{
    public partial class Form1 : Form
    {
        private readonly Graphics graphics;
        private readonly Point center;
        private readonly Timer timer;
        private readonly Rectangle rectangle;
        private readonly double secHand, minHand, hrHand;
        private readonly DigitalClock digitalClock;
        private readonly AnalogClock analogClock;
        private readonly ClockAdapter clockAdapter;
        private static readonly ILog log = LogManager.GetLogger(typeof(Form1));

        public Form1()
        {
            InitializeComponent();

            try
            {
                log.Info("Elements initialization was started.");

                graphics = clockPanel.CreateGraphics();

                rectangle = clockPanel.DisplayRectangle;
                hrHand = rectangle.Height / 4;
                secHand = hrHand * 1.5;
                minHand = hrHand * 1.3;
                center = new Point(clockPanel.Width / 2, clockPanel.Height / 2);
                secondBox.Enabled = false;
                minuteBox.Enabled = false;
                hourBox.Enabled = false;

                digitalClock = new DigitalClock();
                clockAdapter = new ClockAdapter(digitalClock);
                analogClock = new AnalogClock();
                log.Info("The Clocks have been initialized successfuly.");

                Paint += new PaintEventHandler(DrawClock);
                timer = new Timer();
                timer.Interval = 1000;
                timer.Tick += new EventHandler(TimerTick);
                timer.Start();

                log.Info("Elements initialization was finished successfuly.");
            }
            catch (ArgumentNullException ex)
            {
                log.Error(ex.Message);
                log.Error(ex.StackTrace);
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
                log.Error(ex.StackTrace);
            }
        }

        private void TimerTick(object sender, EventArgs e)
        {
            graphics.Clear(Color.FromKnownColor(KnownColor.Control));
            DrawClock(sender, new PaintEventArgs(graphics, rectangle));
        }

        private void DrawClock(object sender, PaintEventArgs e)
        {
            Pen pen = Pens.Black;

            secondBox.Text = digitalClock.Ss.ToString("00");
            minuteBox.Text = digitalClock.Mm.ToString("00");
            hourBox.Text = digitalClock.Hh.ToString("00");

            graphics.DrawEllipse(new Pen(Color.Black), 0, 0, rectangle.Width - 1, rectangle.Height - 1);
            graphics.DrawString("12", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(175, 0));
            graphics.DrawString("3", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(clockPanel.Width - 25, 175));
            graphics.DrawString("6", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(180, clockPanel.Height - 30));
            graphics.DrawString("9", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(5, 175));

            int handX, handY;
            double[] handCoordinates = new double[2];

            handCoordinates = clockAdapter.GetSsHandPosition();
            handX = center.X + (int)(secHand * handCoordinates[0]);
            handY = center.Y - (int)(secHand * handCoordinates[1]);
            analogClock.SsHandPosition = new Point(handX, handY);

            handCoordinates = clockAdapter.GetMmHandPosition();
            handX = center.X + (int)(minHand * handCoordinates[0]);
            handY = center.Y - (int)(minHand * handCoordinates[1]);
            analogClock.MmHandPosition = new Point(handX, handY);

            handCoordinates = clockAdapter.GetHhHandPosition();
            handX = center.X + (int)(hrHand * handCoordinates[0]);
            handY = center.Y - (int)(hrHand * handCoordinates[1]);
            analogClock.HhHandPosition = new Point(handX, handY);

            graphics.DrawLine(pen, center, analogClock.SsHandPosition);
            graphics.DrawLine(pen, center, analogClock.MmHandPosition);
            graphics.DrawLine(pen, center, analogClock.HhHandPosition);
        }
    }
}
