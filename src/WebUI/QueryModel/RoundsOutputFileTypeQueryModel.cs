﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using WorldDoomLeague.Domain.Enums;

namespace WorldDoomLeague.WebUI.QueryModel
{
    public class RoundsOutputFileTypeQueryModel
    {
        [DefaultValue("csv")]
        [FromQuery(Name = "output")]
        public RoundsOutputFileType Output { get; set; }
    }
}
