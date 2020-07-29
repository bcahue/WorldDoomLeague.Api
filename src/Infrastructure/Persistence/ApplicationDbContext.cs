﻿using WorldDoomLeague.Application.Common.Interfaces;
using WorldDoomLeague.Domain.Common;
using WorldDoomLeague.Domain.Entities;
using WorldDoomLeague.Infrastructure.Identity;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Options;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace WorldDoomLeague.Infrastructure.Persistence
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>, IApplicationDbContext
    {
        private readonly ICurrentUserService _currentUserService;
        private readonly IDateTime _dateTime;

        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions,
            ICurrentUserService currentUserService,
            IDateTime dateTime) : base(options, operationalStoreOptions)
        {
            _currentUserService = currentUserService;
            _dateTime = dateTime;
        }

        public DbSet<TodoList> TodoLists { get; set; }
        public DbSet<TodoItem> TodoItems { get; set; }
        public virtual DbSet<Demos> Demos { get; set; }
        public virtual DbSet<Games> Games { get; set; }
        public virtual DbSet<Maps> Maps { get; set; }
        public virtual DbSet<Player> Player { get; set; }
        public virtual DbSet<RoundPlayers> RoundPlayers { get; set; }
        public virtual DbSet<Rounds> Rounds { get; set; }
        public virtual DbSet<Season> Season { get; set; }
        public virtual DbSet<GameFiles> Files { get; set; }
        public virtual DbSet<GamePlayers> GamePlayers { get; set; }
        public virtual DbSet<GameTeamStats> GameTeamStats { get; set; }
        public virtual DbSet<RoundFlagTouchCaptures> RoundFlagTouchCaptures { get; set; }
        public virtual DbSet<StatsAccuracyData> StatsAccuracyData { get; set; }
        public virtual DbSet<StatsAccuracyFlagOutData> StatsAccuracyFlagOutData { get; set; }
        public virtual DbSet<StatsDamageCarrierData> StatsDamageCarrierData { get; set; }
        public virtual DbSet<StatsDamageData> StatsDamageData { get; set; }
        public virtual DbSet<StatsKillCarrierData> StatsKillCarrierData { get; set; }
        public virtual DbSet<StatsKillData> StatsKillData { get; set; }
        public virtual DbSet<StatsOverall> StatsOverall { get; set; }
        public virtual DbSet<StatsOverallSeason> StatsOverallSeason { get; set; }
        public virtual DbSet<StatsPickupData> StatsPickupData { get; set; }
        public virtual DbSet<StatsRounds> StatsRounds { get; set; }
        public virtual DbSet<Teams> Teams { get; set; }
        public virtual DbSet<Weeks> Weeks { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = _currentUserService.UserId;
                        entry.Entity.Created = _dateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedBy = _currentUserService.UserId;
                        entry.Entity.LastModified = _dateTime.Now;
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}