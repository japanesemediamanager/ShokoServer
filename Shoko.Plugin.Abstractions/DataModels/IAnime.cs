using System;
using System.Collections.Generic;

namespace Shoko.Plugin.Abstractions.DataModels
{
    public interface IAnime
    {
        /// <summary>
        /// The AniDB Anime ID
        /// </summary>
        int AnimeID { get; }
        /// <summary>
        /// The number of total episodes in the series, not including specials
        /// </summary>
        int EpisodeCount { get; }
        /// <summary>
        /// The number of specials in the series
        /// </summary>
        int SpecialsCount { get; }
        DateTime? AirDate { get; }
        /// <summary>
        /// The end date of the series. Null means that it's still airing.
        /// </summary>
        DateTime? EndDate { get; }
        /// <summary>
        /// The Type, such as Movie
        /// </summary>
        AnimeType Type { get; }
        /// <summary>
        /// Titles, in all languages and types
        /// </summary>
        IList<AnimeTitle> Titles { get; }
        /// <summary>
        /// Rating out of 10
        /// </summary>
        double Rating { get; }
    }

    public enum AnimeType
    {
        Movie = 0,
        OVA = 1,
        TVSeries = 2,
        TVSpecial = 3,
        Web = 4,
        Other = 5
    }
}