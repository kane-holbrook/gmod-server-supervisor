using Newtonsoft.Json;

namespace ServerSupervisor
{
    internal static class Program
    {

        public static Sidebar Sidebar;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Load();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Sidebar = new Sidebar();
            Application.Run(Sidebar);
        }

        public static void Save()
        {
            File.WriteAllText("servers.json", JsonConvert.SerializeObject(Server.All));
        }

        public static void Load()
        {
            if (File.Exists("servers.json"))
            {
                Server.All = JsonConvert.DeserializeObject<List<Server>>(File.ReadAllText("servers.json"));
            }
        }
    }
}