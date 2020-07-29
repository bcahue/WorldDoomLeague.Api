﻿using WorldDoomLeague.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WorldDoomLeague.Infrastructure.Persistence.Configurations
{
    public class StatsKillCarrierDataConfiguration : IEntityTypeConfiguration<StatsKillCarrierData>
    {
        public void Configure(EntityTypeBuilder<StatsKillCarrierData> builder)
        {
            builder.HasKey(e => e.IdStatsKillcarrier)
                    .HasName("PRIMARY");

            builder.ToTable("statskillcarrierdata");

            builder.HasIndex(e => e.FkIdPlayerAttacker)
                .HasName("fk_statsdamage_player_attacker_idx");

            builder.HasIndex(e => e.FkIdPlayerTarget)
                .HasName("fk_statsdamage_player_target_idx");

            builder.HasIndex(e => e.FkIdRound)
                .HasName("fk_statsdamage_round_idx");

            builder.HasIndex(e => e.IdStatsKillcarrier)
                .HasName("id_stats_damage_UNIQUE")
                .IsUnique();

            builder.Property(e => e.IdStatsKillcarrier)
                .HasColumnName("id_stats_killcarrier")
                .HasColumnType("int(10) unsigned");

            builder.Property(e => e.FkIdPlayerAttacker)
                .HasColumnName("fk_id_player_attacker")
                .HasColumnType("int(10) unsigned");

            builder.Property(e => e.FkIdPlayerTarget)
                .HasColumnName("fk_id_player_target")
                .HasColumnType("int(10) unsigned");

            builder.Property(e => e.FkIdRound)
                .HasColumnName("fk_id_round")
                .HasColumnType("int(10) unsigned");

            builder.Property(e => e.TotalKills)
                .HasColumnName("total_kills")
                .HasColumnType("int(10) unsigned");

            builder.Property(e => e.WeaponType)
                .HasColumnName("weapon_type")
                .HasColumnType("tinyint(3) unsigned");

            builder.HasOne(d => d.FkIdPlayerAttackerNavigation)
                .WithMany(p => p.StatsKillCarrierDataFkIdPlayerAttackerNavigation)
                .HasForeignKey(d => d.FkIdPlayerAttacker)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_statskillcarrierplayer_attacker");

            builder.HasOne(d => d.FkIdPlayerTargetNavigation)
                .WithMany(p => p.StatsKillCarrierDataFkIdPlayerTargetNavigation)
                .HasForeignKey(d => d.FkIdPlayerTarget)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_statskillcarrier_player_target");

            builder.HasOne(d => d.FkIdRoundNavigation)
                .WithMany(p => p.StatsKillCarrierData)
                .HasForeignKey(d => d.FkIdRound)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_statskillcarrier_round");
        }
    }
}