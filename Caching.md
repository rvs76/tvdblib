# Caching #

Since it wouldn't make any sense to retrieve the same information on some series from tvdb everytime we need it, everything (nearly everything) that is downloaded is also stored locally.

To ensure that the caching can adopt to most needs, the whole caching logic is done in a so called CacheProvider (Interface: ICacheProvider).

The two options provided within the library are
  * XmlCacheProvder: Saves information to locally stored xml files
  * BinaryCacheProvider: Saves information to serialized files


# ICacheProvider #
To implement an own cache provider, a class has to implement the ICacheProvider Interface:
```
    /// <summary>
    /// Is the cache provider initialised
    /// </summary>
    bool Initialised { get; }

    /// <summary>
    /// Initialises the cache, should do the following things
    /// - initialise connections used for this cache provider (db connections, network shares,...)
    /// - create folder structure / db tables / ...  if they are not created already
    /// - if this is the first time the cache has been initialised (built), mark last_updated with the
    ///   current date
    /// </summary>
    /// <returns></returns>
    TvdbData InitCache();

    /// <summary>
    /// Closes the cache (e.g. close open connection, etc.)
    /// </summary>
    /// <returns>true if successful, false otherwise</returns>
    bool CloseCache();

    /// <summary>
    /// Completely refreshes the cache (all stored information is lost)
    /// </summary>
    /// <returns>true if the cache was cleared successfully, 
    ///          false otherwise (e.g. no write rights,...)</returns>
    bool ClearCache();

    /// <summary>
    /// Remove a specific series from cache
    /// </summary>
    /// <param name="_seriesId">the id of the series</param>
    /// <returns>true if the series was removed from the cache successfully, 
    ///          false otherwise (e.g. series not cached)</returns>
    bool RemoveFromCache(int _seriesId);

    /// <summary>
    /// Loads all cached series from cache -> can take a while
    /// </summary>
    /// <returns>The loaded TvdbData object</returns>
    TvdbData LoadUserDataFromCache();

    /// <summary>
    /// Loads the available languages from cache
    /// </summary>
    /// <returns>A list of TvdbLanguage objects from cache or null</returns>
    List<TvdbLanguage> LoadLanguageListFromCache();

    /// <summary>
    /// Load the available mirrors from cache
    /// </summary>
    /// <returns>A list of TvdbMirror objects from cache or null</returns>
    List<TvdbMirror> LoadMirrorListFromCache();

    /// <summary>
    /// Loads all series from cache
    /// </summary>
    /// <returns>A list of TvdbSeries objects from cache or null</returns>
    List<TvdbSeries> LoadAllSeriesFromCache();

    /// <summary>
    /// Load the give series from cache
    /// </summary>
    /// <param name="_seriesId">Id of the series to load</param>
    /// <returns>The TvdbSeries object from cache or null</returns>
    TvdbSeries LoadSeriesFromCache(int _seriesId);

    /// <summary>
    /// Load user info from cache
    /// </summary>
    /// <param name="_userId">Id of the user</param>
    /// <returns>TvdbUser object or null if the user couldn't be loaded</returns>
    TvdbUser LoadUserInfoFromCache(String _userId);

    /// <summary>
    /// Saves cache settings
    /// </summary>
    /// <param name="_content">settings</param>
    void SaveToCache(TvdbData _content);

    /// <summary>
    /// Save the language to cache
    /// </summary>
    /// <param name="_languageList">List of languages that are available on http://thetvdb.com</param>
    void SaveToCache(List<TvdbLanguage> _languageList);

    /// <summary>
    /// Save the mirror info to cache
    /// </summary>
    /// <param name="_mirrorInfo">List of mirrors of http://thetvdb.com</param>
    void SaveToCache(List<TvdbMirror> _mirrorInfo);

    /// <summary>
    /// Saves the series to cache
    /// </summary>
    /// <param name="_series">TvdbSeries object</param>
    void SaveToCache(TvdbSeries _series);

    /// <summary>
    /// Saves the user data to cache
    /// </summary>
    /// <param name="_user">TvdbUser object</param>
    void SaveToCache(TvdbUser _user);

    /// <summary>
    /// Save the given image to cache
    /// </summary>
    /// <param name="_image">banner to save</param>
    /// <param name="_seriesId">id of series</param>
    /// <param name="_fileName">filename (will be the same name used by LoadImageFromCache)</param>
    void SaveToCache(Image _image, int _seriesId, String _fileName);

    /// <summary>
    /// Loads the specified image from the cache
    /// </summary>
    /// <param name="_seriesId">series id</param>
    /// <param name="_fileName">filename of the image (same one as used by SaveToCache)</param>
    /// <returns>The loaded image or null if the image wasn't found</returns>
    Image LoadImageFromCache(int _seriesId, String _fileName);

    /// <summary>
    /// Receives a list of all series that have been cached
    /// </summary>
    /// <returns>A list of series that have been already stored with this cache provider</returns>
    List<int> GetCachedSeries();

    /// <summary>
    /// Check if the series is cached in the given configuration
    /// </summary>
    /// <param name="_seriesId">Id of the series</param>
    /// <param name="_lang">Language of the series</param>
    /// <param name="_episodesLoaded">are episodes loaded</param>
    /// <param name="_bannersLoaded">are banners loaded</param>
    /// <param name="_actorsLoaded">are actors loaded</param>
    /// <returns>true if the series is cached, false otherwise</returns>
    bool IsCached(int _seriesId, TvdbLanguage _lang, bool _episodesLoaded, bool _bannersLoaded, bool _actorsLoaded);

    /// <summary>
    /// Removes the specified image from cache (if it has been cached)
    /// </summary>
    /// <param name="_seriesId">id of series</param>
    /// <param name="_fileName">name of image</param>
    /// <returns>true if image was removed successfully, false otherwise (e.g. image didn't exist)</returns>
    bool RemoveImageFromCache(int _seriesId, string _fileName);

```