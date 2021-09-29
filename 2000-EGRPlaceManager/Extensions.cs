using System.IO;

namespace MRK {
    public static class Extensions {
        public static bool EOF(this BinaryReader binaryReader) {
            return binaryReader.BaseStream.Position == binaryReader.BaseStream.Length;
        }
    }
}
