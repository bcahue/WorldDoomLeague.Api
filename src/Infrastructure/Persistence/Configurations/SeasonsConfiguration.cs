﻿using WorldDoomLeague.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WorldDoomLeague.Infrastructure.Persistence.Configurations
{
    public class SeasonsConfiguration : IEntityTypeConfiguration<Season>
    {
        public void Configure(EntityTypeBuilder<Season> builder)
        {
            builder.HasKey(e => e.IdSeason)
                    .HasName("PRIMARY");

            builder.ToTable("seasons");

            builder.HasIndex(e => e.FkIdWadFile)
                .HasDatabaseName("fk_Seasons_WadFile_idx");

            builder.HasIndex(e => e.FkIdEngine)
                .HasDatabaseName("fk_Seasons_Engine_idx");

            builder.HasIndex(e => e.IdSeason)
                .HasDatabaseName("id_season_UNIQUE")
                .IsUnique();

            builder.Property(e => e.IdSeason)
                .HasColumnName("id_season")
                .HasColumnType("int(10) unsigned");

            builder.Property(e => e.FkIdEngine)
                .HasColumnName("fk_id_engine")
                .HasColumnType("int(10) unsigned");

            builder.Property(e => e.DateStart)
                .HasColumnName("date_start")
                .HasColumnType("datetime");

            builder.Property(e => e.FkIdWadFile)
                .HasColumnName("fk_id_wad_file")
                .HasColumnType("int(10) unsigned");

            builder.Property(e => e.FkIdTeamWinner)
                .HasColumnName("fk_id_team_winner")
                .HasColumnType("int(11)");

            builder.Property(e => e.SeasonName)
                .IsRequired()
                .HasColumnName("season_name")
                .HasColumnType("varchar(64)")
                .HasCharSet("utf8mb4")
                .HasCollation("utf8mb4_unicode_ci");

            builder.HasOne(d => d.FkIdFileNavigation)
                .WithMany(p => p.Seasons)
                .HasForeignKey(d => d.FkIdWadFile)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_Seasons_WadFiles");

            builder.HasOne(d => d.FkIdEngineNavigation)
                .WithMany(p => p.Seasons)
                .HasForeignKey(d => d.FkIdEngine)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_Seasons_Engine");
        }
    }
}
