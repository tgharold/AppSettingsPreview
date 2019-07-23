using System;

namespace AppSettingsPreview
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: check argument count

            var baseName = GetSettingsFileName();
            var compareToName = GetSettingsFileName(args[0]);

            //TODO: Read in JSON strings from files
            //TODO: sort/deserialize
            //TODO: compare
            //TODO: output
        }

        // https://stackoverflow.com/a/56185448/727286
        // https://github.com/wbish/jsondiffpatch.net

        private static string GetSettingsFileName(string environment = null)
        {
            environment = environment ?? string.Empty;
            if (environment.Length > 0)
                environment = $".{environment}";
            return $"appsettings{environment}.json";
        }
    }
}
