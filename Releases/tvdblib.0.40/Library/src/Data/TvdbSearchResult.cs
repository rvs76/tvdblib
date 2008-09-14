﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TvdbConnector.Data.Banner;

namespace TvdbConnector.Data
{
  /// <summary>
  /// Class representing the result of a tvdb name query -> for further information
  /// visit http://thetvdb.com/wiki/index.php/API:GetSeries
  /// </summary>
  public class TvdbSearchResult
  {
    /// <summary>
    /// TvdbSearchResult constructor
    /// </summary>
    public TvdbSearchResult()
    {

    }

    /// <summary>
    /// TvdbSearchResult constructor
    /// </summary>
    /// <param name="_id"></param>
    public TvdbSearchResult(int _id)
    {
      m_id = _id;
    }

    #region private properties
    private int m_id;
    private String m_seriesName;
    private DateTime m_firstAired;
    private TvdbLanguage m_language;
    private String m_overview;
    private TvdbSeriesBanner m_banner;
    private String m_imdbId;
    #endregion

    #region tvdb properties
    /// <summary>
    /// Id of the returned series
    /// </summary>
    public int Id
    {
      get { return m_id; }
      set { m_id = value; }
    }

    /// <summary>
    /// Name of the returned series
    /// </summary>
    public String SeriesName
    {
      get { return m_seriesName; }
      set { m_seriesName = value; }
    }

    /// <summary>
    /// When was the returned series aired first
    /// </summary>
    public DateTime FirstAired
    {
      get { return m_firstAired; }
      set { m_firstAired = value; }
    }

    /// <summary>
    /// Language of the returned series
    /// </summary>
    public TvdbLanguage Language
    {
      get { return m_language; }
      set { m_language = value; }
    }

    /// <summary>
    /// Overview of the returned series
    /// </summary>
    public String Overview
    {
      get { return m_overview; }
      set { m_overview = value; }
    }

    /// <summary>
    /// Banner of the returned series
    /// </summary>
    public TvdbSeriesBanner Banner
    {
      get { return m_banner; }
      set { m_banner = value; }
    }

    /// <summary>
    /// Imdb id of the returned series
    /// </summary>
    public String ImdbId
    {
      get { return m_imdbId;}
      set { m_imdbId = value; }
    }
    #endregion
  }
}
