﻿using System;
using System.Collections.Generic;

namespace WorldDoomLeague.Domain.Entities
{
    public partial class Player
    {
        public Player()
        {
            GamePlayers = new HashSet<GamePlayers>();
            RoundPlayers = new HashSet<RoundPlayers>();
            StatsAccuracyDataFkIdPlayerAttackerNavigation = new HashSet<StatsAccuracyData>();
            StatsAccuracyDataFkIdPlayerTargetNavigation = new HashSet<StatsAccuracyData>();
            StatsAccuracyFlagOutDataFkIdPlayerAttackerNavigation = new HashSet<StatsAccuracyFlagOutData>();
            StatsAccuracyFlagOutDataFkIdPlayerTargetNavigation = new HashSet<StatsAccuracyFlagOutData>();
            StatsDamageCarrierDataFkIdPlayerAttackerNavigation = new HashSet<StatsDamageCarrierData>();
            StatsDamageCarrierDataFkIdPlayerTargetNavigation = new HashSet<StatsDamageCarrierData>();
            StatsDamageDataFkIdPlayerAttackerNavigation = new HashSet<StatsDamageData>();
            StatsDamageDataFkIdPlayerTargetNavigation = new HashSet<StatsDamageData>();
            StatsKillCarrierDataFkIdPlayerAttackerNavigation = new HashSet<StatsKillCarrierData>();
            StatsKillCarrierDataFkIdPlayerTargetNavigation = new HashSet<StatsKillCarrierData>();
            StatsKillDataFkIdPlayerAttackerNavigation = new HashSet<StatsKillData>();
            StatsKillDataFkIdPlayerTargetNavigation = new HashSet<StatsKillData>();
            StatsPickupData = new HashSet<StatsPickupData>();
            StatsRounds = new HashSet<StatsRounds>();
            TeamsFkIdPlayerCaptainNavigation = new HashSet<Teams>();
            TeamsFkIdPlayerFirstpickNavigation = new HashSet<Teams>();
            TeamsFkIdPlayerSecondpickNavigation = new HashSet<Teams>();
            TeamsFkIdPlayerThirdpickNavigation = new HashSet<Teams>();
            PlayerGameRecords = new HashSet<PlayerGameRecord>();
            PlayerRoundRecords = new HashSet<PlayerRoundRecord>();
            Transactions = new HashSet<PlayerTransactions>();
            DraftNominated = new HashSet<PlayerDraft>();
            DraftNominating = new HashSet<PlayerDraft>();
            DraftSoldTo = new HashSet<PlayerDraft>();
        }

        public uint Id { get; set; }
        public string PlayerName { get; set; }
        public string PlayerAlias { get; set; }

        public virtual ICollection<GamePlayers> GamePlayers { get; set; }
        public virtual ICollection<RoundPlayers> RoundPlayers { get; set; }
        public virtual ICollection<StatsAccuracyData> StatsAccuracyDataFkIdPlayerAttackerNavigation { get; set; }
        public virtual ICollection<StatsAccuracyData> StatsAccuracyDataFkIdPlayerTargetNavigation { get; set; }
        public virtual ICollection<StatsAccuracyFlagOutData> StatsAccuracyFlagOutDataFkIdPlayerAttackerNavigation { get; set; }
        public virtual ICollection<StatsAccuracyFlagOutData> StatsAccuracyFlagOutDataFkIdPlayerTargetNavigation { get; set; }
        public virtual ICollection<StatsDamageCarrierData> StatsDamageCarrierDataFkIdPlayerAttackerNavigation { get; set; }
        public virtual ICollection<StatsDamageCarrierData> StatsDamageCarrierDataFkIdPlayerTargetNavigation { get; set; }
        public virtual ICollection<StatsDamageData> StatsDamageDataFkIdPlayerAttackerNavigation { get; set; }
        public virtual ICollection<StatsDamageData> StatsDamageDataFkIdPlayerTargetNavigation { get; set; }
        public virtual ICollection<StatsKillCarrierData> StatsKillCarrierDataFkIdPlayerAttackerNavigation { get; set; }
        public virtual ICollection<StatsKillCarrierData> StatsKillCarrierDataFkIdPlayerTargetNavigation { get; set; }
        public virtual ICollection<StatsKillData> StatsKillDataFkIdPlayerAttackerNavigation { get; set; }
        public virtual ICollection<StatsKillData> StatsKillDataFkIdPlayerTargetNavigation { get; set; }
        public virtual ICollection<StatsPickupData> StatsPickupData { get; set; }
        public virtual ICollection<StatsRounds> StatsRounds { get; set; }
        public virtual ICollection<Teams> TeamsFkIdPlayerCaptainNavigation { get; set; }
        public virtual ICollection<Teams> TeamsFkIdPlayerFirstpickNavigation { get; set; }
        public virtual ICollection<Teams> TeamsFkIdPlayerSecondpickNavigation { get; set; }
        public virtual ICollection<Teams> TeamsFkIdPlayerThirdpickNavigation { get; set; }
        public virtual ICollection<Demos> Demos { get; set; }
        public virtual ICollection<PlayerGameRecord> PlayerGameRecords { get; set; }
        public virtual ICollection<PlayerRoundRecord> PlayerRoundRecords { get; set; }
        public virtual ICollection<PlayerTransactions> Transactions { get; set; }
        public virtual ICollection<PlayerDraft> DraftNominated { get; set; }
        public virtual ICollection<PlayerDraft> DraftNominating { get; set; }
        public virtual ICollection<PlayerDraft> DraftSoldTo { get; set; }
    }
}
