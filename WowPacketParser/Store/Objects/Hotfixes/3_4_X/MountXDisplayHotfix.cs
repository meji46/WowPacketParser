using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [Hotfix]
    [DBTableName("mount_x_display")]
    public sealed record MountXDisplayHotfix340: IDataModel
    {
        [DBFieldName("ID", true)]
        public uint? ID;

        [DBFieldName("CreatureDisplayInfoID")]
        public int? CreatureDisplayInfoID;

        [DBFieldName("PlayerConditionID")]
        public uint? PlayerConditionID;

        [DBFieldName("MountID")]
        public int? MountID;

        [DBFieldName("VerifiedBuild")]
        public int? VerifiedBuild = ClientVersion.BuildInt;
    }
    [Hotfix]
    [DBTableName("mount_x_display")]
    public sealed record MountXDisplayHotfix344: IDataModel
    {
        [DBFieldName("ID", true)]
        public uint? ID;

        [DBFieldName("CreatureDisplayInfoID")]
        public int? CreatureDisplayInfoID;

        [DBFieldName("PlayerConditionID")]
        public uint? PlayerConditionID;

        [DBFieldName("Field110054210002")]
        public ushort? Field110054210002;

        [DBFieldName("MountID")]
        public int? MountID;

        [DBFieldName("VerifiedBuild")]
        public int? VerifiedBuild = ClientVersion.BuildInt;
    }
}
