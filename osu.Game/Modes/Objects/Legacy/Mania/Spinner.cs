﻿// Copyright (c) 2007-2017 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using osu.Game.Modes.Objects.Types;

namespace osu.Game.Modes.Objects.Legacy.Mania
{
    /// <summary>
    /// Legacy osu!mania Spinner-type, used for parsing Beatmaps.
    /// </summary>
    internal sealed class Spinner : HitObject, IHasEndTime, IHasXPosition
    {
        public double EndTime { get; set; }

        public double Duration => EndTime - StartTime;

        public float X { get; set; }
    }
}