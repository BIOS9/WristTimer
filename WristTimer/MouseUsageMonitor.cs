using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WristTimer
{
    class MouseUsageMonitor
    {
        public static readonly TimeSpan HistoryLength = TimeSpan.FromHours(12);
        public static readonly TimeSpan SampleTime = TimeSpan.FromMinutes(1);
        private float[] _sampleDistances;
        private int _sampleIndex = 0;
        private DateTime _lastSample = DateTime.Now;
        private Point _lastPosition = Point.Empty;
        public readonly int MonitorInterval;

        public MouseUsageMonitor(int monitorInterval)
        {
            MonitorInterval = monitorInterval;
            _sampleDistances = new float[(int)SampleTime.TotalMilliseconds / monitorInterval];
            Monitor();
        }

        public float GetUsageSample()
        {
            float sum = 0;
            foreach(float dist in _sampleDistances)
                sum += dist;
            return sum;
        }

        public void Monitor()
        {
            if (_lastPosition.Equals(Point.Empty))
            {
                _lastSample = DateTime.Now;
                _lastPosition = Cursor.Position;
                return;
            }
            Point pos = Cursor.Position;
            TimeSpan time = DateTime.Now - _lastSample;

            _sampleDistances[_sampleIndex++] = distance(_lastPosition, pos) / Math.Max(time.Milliseconds, 1);
            
            _lastPosition = pos;
            _lastSample = DateTime.Now;

            Console.WriteLine(time.TotalMilliseconds);

            if (_sampleIndex >= _sampleDistances.Length)
                _sampleIndex = 0;
        }

        private float distance(Point a, Point b)
        {
            return (float)Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }
    }
}
