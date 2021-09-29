using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace MRK {
    public class Config {
        readonly Dictionary<string, string> m_Config;
        string m_ConfigPath;

        public Config() {
            m_Config = new Dictionary<string, string>();
        }

        public bool Load() {
            m_ConfigPath = $@"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\Config.2000";

            bool result = false;
            if (File.Exists(m_ConfigPath)) {
                foreach (string line in File.ReadAllLines(m_ConfigPath)) {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    string realLine = line.Trim();
                    if (realLine.StartsWith('#'))
                        continue;

                    int eqIdx = realLine.IndexOf('=');
                    if (eqIdx == -1)
                        continue;

                    if (eqIdx == 0) //line starts with =?
                        continue;

                    string key = realLine.Substring(0, eqIdx);
                    string val = realLine.Substring(eqIdx + 1);
                    m_Config[key] = val;
                }

                result = true;
            }
            return result;
        }

        public void ReloadConfig() {
            m_Config.Clear();
            Load();
        }

        public void Save() {
            StringBuilder builder = new();
            builder.AppendLine("# 2000 EGR PLACEMANAGER Config - MRKDaGods(Mohamed Ammar)");

            foreach (KeyValuePair<string, string> pair in m_Config) {
                builder.AppendLine($"{pair.Key}={pair.Value}");
            }

            File.WriteAllText(m_ConfigPath, builder.ToString());
        }

        public ConfigRecord this[string key] {
            get {
                string val;
                m_Config.TryGetValue(key, out val);
                return new ConfigRecord(val);
            }

            set {
                m_Config[key] = value.String;
            }
        }
    }
}
