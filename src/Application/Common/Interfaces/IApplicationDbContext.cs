﻿using WorldDoomLeague.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace WorldDoomLeague.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<TodoList> TodoLists { get; set; }
        DbSet<TodoItem> TodoItems { get; set; }
        DbSet<Demos> Demos { get; set; }
        DbSet<Games> Games { get; set; }
        DbSet<Maps> Maps { get; set; }
        DbSet<Player> Player { get; set; }
        DbSet<RoundPlayers> RoundPlayers { get; set; }
        DbSet<Domain.Entities.Rounds> Rounds { get; set; }
        DbSet<Season> Season { get; set; }
        DbSet<GameFiles> Files { get; set; }
        DbSet<GamePlayers> GamePlayers { get; set; }
        DbSet<GameTeamStats> GameTeamStats { get; set; }
        DbSet<RoundFlagTouchCaptures> RoundFlagTouchCaptures { get; set; }
        DbSet<StatsAccuracyData> StatsAccuracyData { get; set; }
        DbSet<StatsAccuracyFlagOutData> StatsAccuracyFlagOutData { get; set; }
        DbSet<StatsDamageCarrierData> StatsDamageCarrierData { get; set; }
        DbSet<StatsDamageData> StatsDamageData { get; set; }
        DbSet<StatsKillCarrierData> StatsKillCarrierData { get; set; }
        DbSet<StatsKillData> StatsKillData { get; set; }
        DbSet<StatsOverall> StatsOverall { get; set; }
        DbSet<StatsOverallSeason> StatsOverallSeason { get; set; }
        DbSet<StatsPickupData> StatsPickupData { get; set; }
        DbSet<StatsRounds> StatsRounds { get; set; }
        DbSet<Domain.Entities.Teams> Teams { get; set; }
        DbSet<Weeks> Weeks { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}