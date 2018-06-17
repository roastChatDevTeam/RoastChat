using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoastChat
{
    public class Message : MessageInterface
    {
        private String message;
        private String time;
        private String sender;

        public Message(String message, String sender)
        {
            this.message = message;
            this.sender = sender;
            this.time = TimeHelper.STR_CURRENT_TIME();

        }

        public string getMessage()
        {
            return message;
        }

        public string getTime()
        {
            return time;
        }

        public string getTime(String strTime)
        {
            if (TimeHelper.DAYS_SINCE(strTime) > 0) return time;
            else if (TimeHelper.HOURS_SINCE(strTime) > 0) return time.Substring(0, time.IndexOf(','));
            return "";
        }

        public string getSender()
        {
            return sender;
        }

    }

    class TimeHelper
    {
        private const String hourFormat = "HH:mm";
        private const String dateFormat = "H, dd/MM/yyyy";

        public static String STR_HOUR_CURRENT_TIME()
        {
            return DateTime.Now.ToString(hourFormat);
        }

        public static String STR_DATEE_CURRENT_TIME()
        {
            return DateTime.Now.ToString(dateFormat);
        }

        public static String STR_CURRENT_TIME()
        {
            return DateTime.Now.ToString(hourFormat + dateFormat);
        }

        public static int HOURS_SINCE(String strtime)
        {
            DateTime time = DateTime.ParseExact(strtime, hourFormat + dateFormat, CultureInfo.InvariantCulture);
            return (DateTime.Now.Hour - time.Hour);
        }

        public static int DAYS_SINCE(String strtime)
        {
            DateTime time = DateTime.ParseExact(strtime, hourFormat + dateFormat, CultureInfo.InvariantCulture);
            return (DateTime.Now.Day - time.Day);
        }


    }
}
