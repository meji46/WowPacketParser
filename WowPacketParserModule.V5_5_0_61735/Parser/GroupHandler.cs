﻿
using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.Parsing;

namespace WowPacketParserModule.V5_5_0_61735.Parsers
{
    public static class GroupHandler
    {
        [Parser(Opcode.SMSG_CHANGE_PLAYER_DIFFICULTY_RESULT)]
        public static void HandleChangePlayerDifficultyResult(Packet packet)
        {
            var result = packet.ReadBitsE<DifficultyChangeResult>("Result", 4);

            switch (result)
            {
                case DifficultyChangeResult.Cooldown:
                    packet.ReadBit("InCombat");
                    packet.ReadInt64("Cooldown");
                    break;
                case DifficultyChangeResult.LoadingScreenEnable:
                    packet.ReadBit("Unused");
                    packet.ReadInt64("NextDifficultyChangeTime");
                    break;
                case DifficultyChangeResult.MapDifficultyConditionNotSatisfied:
                    packet.ReadInt32E<MapDifficulty>("MapDifficultyID");
                    break;
                case DifficultyChangeResult.PlayerAlreadyLockedToDifferentInstance:
                    packet.ReadPackedGuid128("PlayerGUID");
                    break;
                case DifficultyChangeResult.Success:
                    packet.ReadInt32<MapId>("MapID");
                    packet.ReadInt32<DifficultyId>("DifficultyID");
                    break;
                default:
                    break;
            }
        }
    }
}
