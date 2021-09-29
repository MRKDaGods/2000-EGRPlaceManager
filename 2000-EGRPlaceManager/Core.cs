using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace MRK {
    public class Core {
        string LivePlacesDirectory => @"\Places";
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
    }
}
