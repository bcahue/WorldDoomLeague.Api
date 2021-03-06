﻿using System;
using System.Collections.Generic;

namespace WorldDoomLeague.Domain.Entities
{
    public partial class GameTeamStats
    {
        public uint IdGameteamstats { get; set; }
        public uint FkIdSeason { get; set; }
        public uint FkIdWeek { get; set; }
        public uint FkIdGame { get; set; }
        public uint FkIdTeam { get; set; }
        public uint FkIdOpponentTeam { get; set; }
        public uint Win { get; set; }
        public uint Tie { get; set; }
        public uint Loss { get; set; }
        public uint Points { get; set; }
        public uint CapturesFor { get; set; }
        public uint CapturesAgainst { get; set; }
        public string TeamColor { get; set; }
        public uint NumberRoundsPlayed { get; set; }
        public uint NumberTicsPlayed { get; set; }
        public uint TotalKills { get; set; }
        public uint TotalCarrierKills { get; set; }
        public uint TotalDeaths { get; set; }
        public uint TotalEnvironmentDeaths { get; set; }
        public uint TotalDamage { get; set; }
        public uint TotalCarrierDamage { get; set; }
        public uint TotalDamageWithFlag { get; set; }
        public uint TotalTouches { get; set; }
        public uint TotalPickupTouches { get; set; }
        public uint TotalAssists { get; set; }
        public uint TotalCaptures { get; set; }
        public uint TotalPickupCaptures { get; set; }
        public uint TotalFlagReturns { get; set; }
        public uint TotalPowerPickups { get; set; }
        public uint LongestSpree { get; set; }
        public uint HighestMultiKill { get; set; }
        public virtual Games FkIdGameNavigation { get; set; }
        public virtual Season FkIdSeasonNavigation { get; set; }
        public virtual Teams FkIdTeamNavigation { get; set; }
        public virtual Teams FkIdOpponentTeamNavigation { get; set; }
        public virtual Weeks FkIdWeekNavigation { get; set; }
    }
}
