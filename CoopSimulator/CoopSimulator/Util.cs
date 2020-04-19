using System;
using System.Collections.Generic;
using System.Text;

namespace CoopSimulator
{
    public class Util
    {
        public static Data.ConfigurationDto.Configuration Configuration()
        {
            Data.ConfigurationDto.Configuration configuration = null;

            try
            {
                string json = Helper.FileHelper.
                    ReadFile(System.AppDomain.CurrentDomain.BaseDirectory + "Configuration.json");

                if (!string.IsNullOrWhiteSpace(json))
                {
                    configuration =
                        Newtonsoft.Json.JsonConvert
                            .DeserializeObject<Data.ConfigurationDto.Configuration>(json);
                }
            }
            catch (Exception e)
            {
              
            }
            return configuration;
        }
    }
}
