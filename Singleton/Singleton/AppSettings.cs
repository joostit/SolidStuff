using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class AppSettings
    {

        public decimal SpeedFactor { get; set; }

        public string ConnectionString { get; set; } = "";

        public string AccountName { get; set; } = "";

        #region Singleton stuff

        private static AppSettings? _instance;

        private static object plaspas = new object();

        public static AppSettings Instance
        {
            get
            {
                lock (plaspas)
                {
                    if (_instance == null)
                    {
                        _instance = new AppSettings();
                    }
                }

                return _instance;
            }
        }


        private AppSettings()
        {

        }

        #endregion

    }
}
