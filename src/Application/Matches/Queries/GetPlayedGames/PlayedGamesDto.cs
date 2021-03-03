﻿using AutoMapper;
using WorldDoomLeague.Application.Common.Mappings;
using WorldDoomLeague.Domain.Entities;

namespace WorldDoomLeague.Application.Matches.Queries.GetPlayedGames
{
    public class PlayedGamesDto : IMapFrom<Domain.Entities.Games>
    {
        public int Id {get; set;}

        public uint RedTeam { get; set; }

        public string RedTeamName { get; set; }

        public uint BlueTeam { get; set; }

        public string BlueTeamName { get; set; }

        public uint WeekNumber { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.Games, PlayedGamesDto>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => (int)s.IdGame))
                .ForMember(d => d.RedTeam, opt => opt.MapFrom(s => s.FkIdTeamRed))
                .ForMember(d => d.BlueTeam, opt => opt.MapFrom(s => s.FkIdTeamBlue))
                .ForMember(d => d.RedTeamName, opt => opt.MapFrom(s => s.FkIdTeamRedNavigation.TeamName))
                .ForMember(d => d.BlueTeamName, opt => opt.MapFrom(s => s.FkIdTeamBlueNavigation.TeamName))
                .ForMember(d => d.WeekNumber, opt => opt.MapFrom(s => s.FkIdWeekNavigation.WeekNumber));
        }
    }
}
