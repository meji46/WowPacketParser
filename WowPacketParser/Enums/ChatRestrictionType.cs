﻿namespace WowPacketParser.Enums
{
    public enum ChatRestrictionType : byte
    {
        ChatRestricted = 0,
        ChatThrottled  = 1,
        UserSquelched  = 2,
        YellRestricted = 3
    }
}
