﻿using WorldDoomLeague.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WorldDoomLeague.Infrastructure.Persistence.Configurations
{
    public class StatsAccuracyFlagOutDataConfiguration : IEntityTypeConfiguration<StatsAccuracyFlagOutData>
    {
        public void Configure(EntityTypeBuilder<StatsAccuracyFlagOutData> builder)
        {
            builder.HasKey(e => e.IdStatsAccuracyFlagoutData)
                    .HasName("PRIMARY");

            builder.ToTable("statsaccuracyflagoutdata");

            builder.HasIndex(e => e.FkIdPlayerAttacker)
                .HasName("fk_stataccuracy_player_attacker_idx");

            builder.HasIndex(e => e.FkIdPlayerTarget)
                .HasName("fk_stataccuracy_player_target_idx");

            builder.HasIndex(e => e.FkIdRound)
                .HasName("fk_stataccuracy_round_idx");

            builder.HasIndex(e => e.IdStatsAccuracyFlagoutData)
                .HasName("id_stats_accuracy_data_UNIQUE")
                .IsUnique();

            builder.Property(e => e.IdStatsAccuracyFlagoutData)
                .HasColumnName("id_stats_accuracy_flagout_data")
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

            builder.Property(e => e.HitMissRatio)
                .HasColumnName("hit_miss_ratio")
                .HasColumnType("double unsigned");

            builder.Property(e => e.PinpointPercent)
                .HasColumnName("pinpoint_percent")
                .HasColumnType("double unsigned");

            builder.Property(e => e.SpritePercent)
                .HasColumnName("sprite_percent")
                .HasColumnType("double unsigned");

            builder.Property(e => e.WeaponType)
                .HasColumnName("weapon_type")
                .HasColumnType("tinyint(3) unsigned");

            builder.HasOne(d => d.FkIdPlayerAttackerNavigation)
                .WithMany(p => p.StatsAccuracyFlagOutDataFkIdPlayerAttackerNavigation)
                .HasForeignKey(d => d.FkIdPlayerAttacker)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_stataccuracyflagout_player_attacker");

            builder.HasOne(d => d.FkIdPlayerTargetNavigation)
                .WithMany(p => p.StatsAccuracyFlagOutDataFkIdPlayerTargetNavigation)
                .HasForeignKey(d => d.FkIdPlayerTarget)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_stataccuracyflagout_player_target");

            builder.HasOne(d => d.FkIdRoundNavigation)
                .WithMany(p => p.StatsAccuracyFlagOutData)
                .HasForeignKey(d => d.FkIdRound)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_stataccuracyflagout_round");
        }
    }
}