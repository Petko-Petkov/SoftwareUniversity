namespace AsynchronousTimer
{
    using System;
    using System.Threading;

    public class AsyncTimer
    {

        //private EventHandler ticker;

        private Action<string> someAction;
        private int ticks;
        private int interval;

        public AsyncTimer(Action<string> methodPassed, int ticks, int interval)
        {
            this.someAction = methodPassed;
            this.Ticks = ticks;
            this.Interval = interval;
        }

        #region Properties

        public int Ticks
        {
            get
            {
                return this.ticks;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Value must be a positive integer");
                }

                this.ticks = value;
            }
        }

        public int Interval
        {
            get
            {
                return this.interval;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Interval must be greater than zero");
                }

                this.interval = value;
            }
        }

        #endregion

        #region Methods

        public void Begin()
        {
            Thread.Sleep(this.Interval);

            while (this.Ticks > 0)
            {
                Thread.Sleep(this.Interval);

                someAction(this.Ticks + " ticks left ...");

                this.Ticks--;
            }
        }

        #endregion
    }
}
