using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace DevZest
{
    public abstract class AsyncRunnerBase
    {
        private readonly object _sync = new object();
        private bool _keepRunning;
        private bool _isRunning;

        public void Run()
        {
            lock (_sync)
            {
                _keepRunning = true;
                if (_isRunning)
                    return;

                _isRunning = true;
                Start(RunAsync);
            }
        }

        protected virtual void Start(Func<Task> task)
        {
            Task.Run(task);
        }

        protected virtual async Task RunAsync()
        {
            do
            {
                Debug.Assert(_keepRunning);
                Debug.Assert(_isRunning);
                _keepRunning = false;
                try
                {
                    await DoWorkAsync();
                }
                catch
                {
                    Abort();
                    throw;
                }
            }
            while (ContinueRunning);
        }

        private void Abort()
        {
            lock (_sync)
            {
                _keepRunning = false;
                _isRunning = false;
            }
        }

        private bool ContinueRunning
        {
            get
            {
                lock (_sync)
                {
                    if (_keepRunning)
                        return true;

                    _isRunning = false;
                    return false;
                }
            }
        }

        protected abstract Task DoWorkAsync();

    }
}
