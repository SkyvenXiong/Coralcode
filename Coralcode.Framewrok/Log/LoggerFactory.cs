using System;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml;
using Coralcode.Framework.ConfigManager;
using Coralcode.Framework.Reflection;
using log4net;
using log4net.Repository;

namespace Coralcode.Framework.Log
{
    /// <summary>
    /// Log Factory
    /// </summary>
    public static class LoggerFactory
    {
        public static ILogger Instance { get; }
        private static ILoggerRepository _repository;
        static LoggerFactory()
        {
            _repository = LogManager.CreateRepository("Default");
            log4net.Config.XmlConfigurator.ConfigureAndWatch(_repository, new FileInfo(AppConfig.GetAbsolutePath("log4net")));
            var log = LogManager.GetLogger(_repository.Name, "Default");
            Instance = new Log4Net(log);
        }

        public static ILogger GetLogger(string loggerName)
        {
            var log = LogManager.Exists(_repository.Name, loggerName) ?? LogManager.GetLogger(_repository.Name, loggerName);
            return new Log4Net(log);
        }

    }
}
