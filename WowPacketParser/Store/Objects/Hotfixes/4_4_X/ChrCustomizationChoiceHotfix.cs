using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [Hotfix]
    [DBTableName("chr_customization_choice")]
    public sealed record ChrCustomizationChoiceHotfix440: IDataModel
    {
        [DBFieldName("Name")]
        public string Name;

        [DBFieldName("ID", true)]
        public uint? ID;

        [DBFieldName("ChrCustomizationOptionID")]
        public int? ChrCustomizationOptionID;

        [DBFieldName("ChrCustomizationReqID")]
        public int? ChrCustomizationReqID;

        [DBFieldName("ChrCustomizationVisReqID")]
        public int? ChrCustomizationVisReqID;

        [DBFieldName("OrderIndex")]
        public ushort? OrderIndex;

        [DBFieldName("UiOrderIndex")]
        public ushort? UiOrderIndex;

        [DBFieldName("Flags")]
        public int? Flags;

        [DBFieldName("AddedInPatch")]
        public int? AddedInPatch;

        [DBFieldName("SoundKitID")]
        public int? SoundKitID;

        [DBFieldName("SwatchColor", 2)]
        public int?[] SwatchColor;

        [DBFieldName("VerifiedBuild")]
        public int? VerifiedBuild = ClientVersion.BuildInt;
    }

    [Hotfix]
    [DBTableName("chr_customization_choice_locale")]
    public sealed record ChrCustomizationChoiceLocaleHotfix440: IDataModel
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
