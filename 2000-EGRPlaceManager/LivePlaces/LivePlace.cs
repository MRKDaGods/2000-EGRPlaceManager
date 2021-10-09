using System;
using System.IO;

namespace MRK {
    public enum LivePlaceType : ushort {
        None = 0,
        Restaurant,
        Delivery,
        Gym,
        Smoking,
        Religion,
        Cinema,
        Park,
        Mall,
        Museum,
        Library,
        Grocery,
        Apparel,
        Electronics,
        Sport,
        BeautySupply,
        Home,
        CarDealer,
        Convenience,
        Hotel,
        ATM,
        Gas,
        Hospital,
        Pharmacy,
        CarWash,
        Parking,
        CarRental,
        BeautySalons,
        EVC,

        MAX
    }

    public class LivePlace {
        public string Name { get;  set; }
        public string Type { get;  set; }
        public string CID { get;  set; }
        public ulong CIDNum { get;  set; }
        public string Address { get;  set; }
        public double Latitude { get;  set; }
        public double Longitude { get;  set; }
        public string[] Ex { get;  set; }
        public LivePlaceType[] Types { get;  set; }
        public ulong Chain { get; set; } //is place related to a chain?

        public LivePlace(string name, string type, string cid, string addr, string lat, string lng, string[] ex, ulong chain = 0) {
            Name = name;
            Type = type;
            CID = cid;
            CIDNum = ulong.Parse(CID);
            Address = addr;
            Latitude = double.Parse(lat);
            Longitude = double.Parse(lng);
            Ex = ex ?? Array.Empty<string>();
            Types = new LivePlaceType[1] { LivePlaceType.None };
            Chain = chain;
        }

        public LivePlace(string name, string type, string cid, string addr, double lat, double lng, string[] ex, ulong chain = 0) {
            Name = name;
            Type = type;
            CID = cid;
            CIDNum = ulong.Parse(CID);
            Address = addr;
            Latitude = lat;
            Longitude = lng;
            Ex = ex ?? Array.Empty<string>();
            Types = new LivePlaceType[1] { LivePlaceType.None };
            Chain = chain;
        }

        public void SetTypes(LivePlaceType[] types) {
            Types = types;
        }

        public void AddType(LivePlaceType type) {
            for (int i = 0; i < Types.Length; i++)
                if (Types[i] == type)
                    return;

            LivePlaceType[] types = Types;
            Array.Resize(ref types, Types.Length + 1);
            types[types.Length - 1] = type;
            Types = types;
        }

        public static LivePlace Read(BinaryReader r) {
            string name = r.ReadString();
            string type = r.ReadString();
            string _cid = r.ReadString();
            string addr = r.ReadString();
            double lat = r.ReadDouble();
            double lng = r.ReadDouble();

            int exLen = r.ReadInt32();
            string[] ex = new string[exLen];
            for (int i = 0; i < exLen; i++)
                ex[i] = r.ReadString();

            ulong chain = r.EOF() ? 0UL : r.ReadUInt64();

            LivePlace place = new(name, type, _cid, addr, lat, lng, ex, chain);
            if (!r.EOF()) {
                int typeLen = r.ReadInt32();
                LivePlaceType[] types = new LivePlaceType[typeLen];
                for (int i = 0; i < typeLen; i++)
                    types[i] = (LivePlaceType)r.ReadUInt16();

                place.SetTypes(types);
            }

            return place;
        }
        public static void Write(BinaryWriter w, LivePlace p) {
            w.Write(p.Name);
            w.Write(p.Type);
            w.Write(p.CID);
            w.Write(p.Address);
            w.Write(p.Latitude);
            w.Write(p.Longitude);

            w.Write(p.Ex.Length);
            foreach (string ex in p.Ex)
                w.Write(ex);

            w.Write(p.Chain);

            w.Write(p.Types.Length);
            foreach (LivePlaceType type in p.Types)
                w.Write((ushort)type);
        }
    }
}
