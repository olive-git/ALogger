using ALogger.Constantes;
using ALogger.Tools.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALogger.Tools.Implementations
{
    public class Display : IDisplay
    {
        private string space = "  ";
        string logString;
        string shopId = IDisplay._request.Query["shopId"];

        public void display(DateTime date, string log_level, string message, string className, string appName, int line, string memberName)
        {
            Console.Write($"{date}{space}");
            Console.BackgroundColor = ConsoleColors.color[log_level];
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write($"{log_level}");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            logString = $" App name: {appName}; class name: {className}; method name: {memberName} line {line}; ";
            
            if (shopId != "" && shopId != null)
            {
                logString += $"ShopId : {shopId}; ";
            }

            logString += $": {message}";
            
            Console.WriteLine(logString);
        }
    }
}
