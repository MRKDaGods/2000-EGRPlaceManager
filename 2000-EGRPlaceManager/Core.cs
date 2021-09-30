using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using MRK.WTE;

namespace MRK {
    public class Core {
        string LivePlacesDirectory => @"\Places";
        string WTEPlacesDirectory => @"\WTE";
        static Core ms_Instance;

        public static Core Instance {
            get {
                if (ms_Instance == null) {
                    ms_Instance = new Core();
                }

                return ms_Instance;
            }
        }
        public DateTime StartTime { get; private set; }
        public TimeSpan RelativeTime => DateTime.Now - StartTime;

        public Core() {
            StartTime = DateTime.Now;
        }

        bool CheckDirectory(string path) {
            return Directory.Exists(path);
        }

        public async Task<List<LivePlace>> GetLivePlaces() {
            string dir = Main.Instance.WorkingDirectory + LivePlacesDirectory;
            if (!CheckDirectory(dir)) {
                return null;
            }

            List<LivePlace> livePlaces = new();

            //{CID}/egr0
            foreach (string directory in Directory.EnumerateDirectories(dir)) {
                byte[] data = await File.ReadAllBytesAsync($"{directory}\\egr0");

                using MemoryStream stream = new(data);
                using BinaryReader reader = new(stream);

                livePlaces.Add(LivePlace.Read(reader));

                reader.Close();
            }

            return livePlaces;
        }

        public async Task<Context> GetWTEContext() {
            string dir = Main.Instance.WorkingDirectory + WTEPlacesDirectory;
            if (!CheckDirectory(dir)) {
                return null;
            }

            List<string> databases = Directory.EnumerateFiles(dir)
                .Where(filename => Path.GetExtension(filename) == ".2000")
                .ToList();

            switch (databases.Count) {
                case 0:
                    //error
                    Logger.LogError("No WTE database found");
                    break;

                case 1:
                    break;

                default:
                    Logger.LogError("More than one WTE database found");
                    return null;
            }

            byte[] data = await File.ReadAllBytesAsync(databases[0]);

            using MemoryStream stream = new(data);
            using BinaryReader reader = new(stream);

            Context ctx = new Context();
            ctx.BinaryRead(reader);

            reader.Close();

            return ctx;
        }
    }
}
