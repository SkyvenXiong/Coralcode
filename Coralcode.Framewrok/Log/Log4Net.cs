using System;
using System.ComponentModel;
using System.Configuration;
using System.Globalization;
using System.Reflection;
using System.Xml;
using Coralcode.Framework.ConfigManager;
using log4net;
using log4net.Core;
using System.Threading.Tasks;

namespace Coralcode.Framework.Log
{
    [Description("log4net")]
    internal sealed class Log4Net : ILogger
    {
        private readonly ILog _log;

        public Log4Net(ILog log)
        {
            _log = log;
        }

        public void Debug(string message, params object[] args)
        {
            _log.DebugFormat(CultureInfo.InvariantCulture, message, args);
        }

        public async System.Threading.Tasks.Task DebugAsync(string message, params object[] args) {
            await System.Threading.Tasks.Task.Run(()=> {
                Debug(message, args);
            });
        }

        public void Debug(string message, Exception exception, params object[] args)
        {
            var messageToTrace = string.Format(CultureInfo.InvariantCulture, message, args);
            _log.Debug(messageToTrace, exception);
        }

        public async System.Threading.Tasks.Task DebugAsync(string message, Exception exception, params object[] args)
        {
            await System.Threading.Tasks.Task.Run(() =>
            {
                Debug(message, exception, args);
            });
        }

        public void Fatal(string message, params object[] args)
        {
            _log.FatalFormat(CultureInfo.InvariantCulture, message, args);
        }

        public async System.Threading.Tasks.Task FatalAsync(string message, params object[] args)
        {
            await System.Threading.Tasks.Task.Run(() =>
            {
                Fatal(message, args);
            });
        }

        public void Fatal(string message, Exception exception, params object[] args)
        {
            var messageToTrace = string.Format(CultureInfo.InvariantCulture, message, args);
            _log.Fatal(messageToTrace, exception);
        }

        public async System.Threading.Tasks.Task FatalAsync(string message, Exception exception, params object[] args)
        {
            await System.Threading.Tasks.Task.Run(() =>
            {
                Fatal(message, exception, args);
            });
        }

        public void Info(string message, params object[] args)
        {
            _log.InfoFormat(CultureInfo.InvariantCulture, message, args);
        }

        public async System.Threading.Tasks.Task InfoAsync(string message, params object[] args)
        {
            await System.Threading.Tasks.Task.Run(() =>
            {
                Info(message, args);
            });
        }

        public void Info(string message, Exception exception, params object[] args)
        {
            var messageToTrace = string.Format(CultureInfo.InvariantCulture, message, args);
            _log.Info(messageToTrace, exception);
        }

        public async System.Threading.Tasks.Task InfoAsync(string message, Exception exception, params object[] args)
        {
            await System.Threading.Tasks.Task.Run(() =>
            {
                Info(message, exception, args);
            });
        }

        public void Warning(string message, params object[] args)
        {
            _log.WarnFormat(CultureInfo.InvariantCulture, message, args);
        }

        public async System.Threading.Tasks.Task WarningAsync(string message, params object[] args)
        {
            await System.Threading.Tasks.Task.Run(() =>
            {
                Warning(message, args);
            });
        }

        public void Warning(string message, Exception exception, params object[] args)
        {
            var messageToTrace = string.Format(CultureInfo.InvariantCulture, message, args);
            _log.Warn(messageToTrace, exception);
        }

        public async System.Threading.Tasks.Task WarningAsync(string message, Exception exception, params object[] args)
        {
            await System.Threading.Tasks.Task.Run(() =>
            {
                Warning(message, exception, args);
            });
        }

        public void Error(string message, params object[] args)
        {
            _log.ErrorFormat(CultureInfo.InvariantCulture, message, args);
        }

        public async System.Threading.Tasks.Task ErrorAsync(string message, params object[] args)
        {
            await System.Threading.Tasks.Task.Run(() =>
            {
                Error(message, args);
            });
        }

        public void Error(string message, Exception exception, params object[] args)
        {
            var messageToTrace = string.Format(CultureInfo.InvariantCulture, message, args);
            _log.Error(messageToTrace, exception); ;
        }

        public async System.Threading.Tasks.Task ErrorAsync(string message, Exception exception, params object[] args)
        {
            await System.Threading.Tasks.Task.Run(() =>
            {
                Error(message, exception, args) ;
            });
        }
    }
}