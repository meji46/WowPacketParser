// <auto-generated>
// DO NOT EDIT
// </auto-generated>

using System.CodeDom.Compiler;
using WowPacketParser.Misc;
using WowPacketParser.Store.Objects.UpdateFields;

namespace WowPacketParserModule.V11_0_0_55666.UpdateFields.V11_1_7_61491
{
    [GeneratedCode("UpdateFieldCodeGenerator.Formats.WowPacketParserHandler", "1.0.0.0")]
    public class SocketedGem : ISocketedGem
    {
        public System.Nullable<int> ItemID { get; set; }
        public System.Nullable<ushort>[] BonusListIDs { get; } = new System.Nullable<ushort>[16];
        public System.Nullable<byte> Context { get; set; }
    }
}

