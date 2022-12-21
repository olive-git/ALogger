﻿using ALogger.Constantes;
using ALogger.Logger.Middlewares;
using ALogger.Services.Interfaces;
using ALogger.Tools.Implementations;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AppName = System.Reflection.Assembly;

namespace ALogger.Services.Implementation
{

    /// <summary>
    /// Cette classe définit les fonctions pour logger
    /// </summary>
    public class Logger : ILogger
    {

        #region Properties
            private readonly Display _Log;
            private readonly int _log_ranking;
            private string _className = new StackFrame(1).GetMethod().DeclaringType.Name;
            private string _appName = AppName.GetEntryAssembly().GetName().Name;
        #endregion

        #region Constructors
        public Logger(string level = "Err")
        {
            _Log = new Display();

            try
            {
                _log_ranking = LogLevel.log_level_ranking[level];
            }
            catch (KeyNotFoundException ex)
            {
                _log_ranking = LogLevel.log_level_ranking["Err"];
            }
        }
        #endregion

        #region Methods
        public string logDebug(string message, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string memberName = "")
        {
            string log_level = LogLevel.log_level["Debug"];
            int log_level_ranking = LogLevel.log_level_ranking[log_level];
            DateTime date = DateTime.Now;

            if (log_level_ranking <= _log_ranking)
            {
                _Log.display(date, log_level, message, _className, _appName, lineNumber, memberName);
            }

            string log = $"{date} : {log_level} : {message}";
            return log;
        }

        public string logError(string message, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string memberName = "")
        {
            string log_level = LogLevel.log_level["Error"];
            int log_level_ranking = LogLevel.log_level_ranking[log_level];
            DateTime date = DateTime.Now;

            if (log_level_ranking <= _log_ranking)
            {
                _Log.display(date, log_level, message, _className, _appName, lineNumber, memberName);
            }

            string log = $"{date} : {log_level} : {message}";
            return log;
        }

        public string logInformation(string message, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string memberName = "")
        {
            string log_level = LogLevel.log_level["Information"];
            int log_level_ranking = LogLevel.log_level_ranking[log_level];
            DateTime date = DateTime.Now;

            
            if (log_level_ranking <= _log_ranking)
            {
                _Log.display(date, log_level, message, _className, _appName, lineNumber, memberName);
            }

            string log = $"{date} : {log_level} : {message}";
            return log;
        }

        public string logTrace(string message, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string memberName = "")
        {
            string log_level = LogLevel.log_level["Trace"];
            int log_level_ranking = LogLevel.log_level_ranking[log_level];
            DateTime date = DateTime.Now;

            if (log_level_ranking <= _log_ranking)
            {
                _Log.display(date, log_level, message, _className, _appName, lineNumber, memberName);
            }

            string log = $"{date} : {log_level} : {message}";
            return log;
        }

        public string logWarning(string message, [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string memberName = "")
        {
            string log_level = LogLevel.log_level["Warning"];
            int log_level_ranking = LogLevel.log_level_ranking[log_level];
            DateTime date = DateTime.Now;

            if (log_level_ranking <= _log_ranking)
            {
                _Log.display(date, log_level, message, _className, _appName, lineNumber, memberName);
            }

            string log = $"{date} : {log_level} : {message}";
            return log;
        }
        #endregion
    }
}
