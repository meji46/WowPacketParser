using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [Hotfix]
    [DBTableName("gameobjects")]
    public sealed record GameobjectsHotfix340: IDataModel
    {
        [DBFieldName("Name")]
        public string Name;

        [DBFieldName("PosX")]
        public float? PosX;

        [DBFieldName("PosY")]
        public float? PosY;

        [DBFieldName("PosZ")]
        public float? PosZ;

        [DBFieldName("Rot", 4)]
        public float?[] Rot;

        [DBFieldName("ID", true)]
        public uint? ID;

        [DBFieldName("OwnerID")]
        public ushort? OwnerID;

        [DBFieldName("DisplayID")]
        public uint? DisplayID;

        [DBFieldName("Scale")]
        public float? Scale;

        [DBFieldName("TypeID")]
        public byte? TypeID;

        [DBFieldName("PhaseUseFlags")]
        public byte? PhaseUseFlags;

        [DBFieldName("PhaseID")]
        public ushort? PhaseID;

        [DBFieldName("PhaseGroupID")]
        public ushort? PhaseGroupID;

        [DBFieldName("PropValue", 8)]
        public int?[] PropValue;

        [DBFieldName("VerifiedBuild")]
        public int? VerifiedBuild = ClientVersion.BuildInt;
    }

    [Hotfix]
    [DBTableName("gameobjects_locale")]
    public sealed record GameobjectsLocaleHotfix340: IDataModel
    {
        [DBFieldName("ID", true)]
        public uint? ID;

        [DBFieldName("locale", true)]
        public string Locale = ClientLocale.PacketLocaleString;

        [DBFieldName("Name_lang")]
        public string NameLang;

        [DBFieldName("VerifiedBuild")]
        public int? VerifiedBuild = ClientVersion.BuildInt;
    }
    [Hotfix]
    [DBTableName("gameobjects")]
    public sealed record GameobjectsHotfix344: IDataModel
    {
        [DBFieldName("Name")]
        public string Name;

        [DBFieldName("PosX")]
        public float? PosX;

        [DBFieldName("PosY")]
        public float? PosY;

        [DBFieldName("PosZ")]
        public float? PosZ;

        [DBFieldName("Rot", 4)]
        public float?[] Rot;

        [DBFieldName("ID", true)]
        public uint? ID;

        [DBFieldName("OwnerID")]
        public ushort? OwnerID;

        [DBFieldName("DisplayID")]
        public uint? DisplayID;

        [DBFieldName("Scale")]
        public float? Scale;

        [DBFieldName("TypeID")]
        public byte? TypeID;

        [DBFieldName("PhaseUseFlags")]
        public int? PhaseUseFlags;

        [DBFieldName("PhaseID")]
        public ushort? PhaseID;

        [DBFieldName("PhaseGroupID")]
        public ushort? PhaseGroupID;

        [DBFieldName("Field110054210011")]
        public ushort? Field110054210011;

        [DBFieldName("PropValue", 8)]
        public int?[] PropValue;

        [DBFieldName("VerifiedBuild")]
        public int? VerifiedBuild = ClientVersion.BuildInt;
    }

    [Hotfix]
    [DBTableName("gameobjects_locale")]
    public sealed record GameobjectsLocaleHotfix344: IDataModel
    {
        [DBFieldName("ID", true)]
        public uint? ID;

        [DBFieldName("locale", true)]
        public string Locale = ClientLocale.PacketLocaleString;

        [DBFieldName("Name_lang")]
        public string NameLang;

        [DBFieldName("VerifiedBuild")]
        public int? VerifiedBuild = ClientVersion.BuildInt;
    }
}
