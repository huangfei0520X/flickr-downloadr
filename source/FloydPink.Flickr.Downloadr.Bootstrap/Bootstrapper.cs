using System;
using System.IO;
using System.Xml.Linq;
using log4net;
using log4net.Appender;
using log4net.Repository.Hierarchy;
using StructureMap;

namespace FloydPink.Flickr.Downloadr.Bootstrap {
    public static class Bootstrapper {
        private static readonly ILog Log = LogManager.GetLogger(typeof (Bootstrapper));
        private static Container _container;
        private const string LogConfigFileName = "flickrdownloadr.log4net";
        private const string AppenderName = "XmlSchemaFileAppender";
        private static string _logLevel;
        private static string _logFile;

        public static void Initialize() {
            Log.Debug("Initialize");
            _container = new Container(expression => {
                                           expression.AddRegistry<CommonsRegistry>();
                                           expression.AddRegistry<OAuthRegistry>();
                                           expression.AddRegistry<RepositoryRegistry>();
                                           expression.AddRegistry<LogicRegistry>();
                                           expression.AddRegistry<PresentationRegistry>();
                                       });
            ReadLoggingConfiguration();
        }

        public static T GetInstance<T>() {
            Log.Debug("GetInstance<T>");
            return _container.GetInstance<T>();
        }

        public static TPresenter GetPresenter<TView, TPresenter>(TView view) {
            Log.Debug("GetPresenter<TView, TPresenter>");
            return _container.With(view).GetInstance<TPresenter>();
        }

        public static FileInfo GetLogFile() {
            Log.Debug("GetLogFile");
            return GetAppDirectoryFile("flickrdownloadr.log");
        }

        public static FileInfo GetLogConfigFile() {
            Log.Debug("GetLogConfigFile");
            return GetAppDirectoryFile("flickrdownloadr.log4net");
        }

        public static void ReconfigureLogging(string level, string logFolder) {
            Log.Debug("ReconfigureLogging");
            var logLevel = level.ToUpperInvariant();
            var logFile = Path.Combine(logFolder, "flickrdownloadr.log");

            if (logLevel != _logLevel || logFile != _logFile) {
                _logLevel = logLevel;
                _logFile = logFile;

                var log4NetConfig = XDocument.Load(LogConfigFileName);

                var fileElement = log4NetConfig.Root.Element("appender").Element("file");
                fileElement.Attribute("value").SetValue(logFile);

                var levelElement = log4NetConfig.Root.Element("root").Element("level");
                levelElement.Attribute("value").SetValue(logLevel);

                log4NetConfig.Save(LogConfigFileName);

                Log.Debug(string.Format("Reconfigured log4net to the level '{0}' and the file '{1}'", logLevel, logFile));
            }
        }

        private static FileInfo GetAppDirectoryFile(string filename) {
            Log.Debug("GetAppDirectoryFile");
            return new FileInfo(Path.Combine(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory), filename));
        }

        private static void ReadLoggingConfiguration() {
            Log.Debug("ReadLoggingConfiguration");
            var hierarchy = (Hierarchy) LogManager.GetRepository();
            var rootLogger = hierarchy.Root;

            _logLevel = rootLogger.Level.ToString();

            var appender = rootLogger.GetAppender(AppenderName) as FileAppender;
            if (appender != null) {
                _logFile = appender.File;
            }
        }
    }
}
