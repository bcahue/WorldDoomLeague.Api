﻿using WorldDoomLeague.Domain.Enums;

namespace WorldDoomLeague.Application.GameEvents
{
    public class FlagCaptureEvent
    {
        public string PlayerName { get; set; }
        public int ActivatorX { get; set; }
        public int ActivatorY { get; set; }
        public int ActivatorZ { get; set; }
    }
}