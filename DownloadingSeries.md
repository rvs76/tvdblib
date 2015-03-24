# Main method #

```
public TvdbSeries GetSeries(
	int _seriesId,
	TvdbLanguage _language,
	bool _loadEpisodes,
	bool _loadActors,
	bool _loadBanners,
        bool _useZip
)


Parameters:
_seriesId (Int32)
id of series
_language (TvdbLanguage)
language that should be retrieved
_loadEpisodes (Boolean)
if true, the full series record will be loaded (series + all episodes), otherwise only the base record will be loaded which contains only series information
_loadActors (Boolean)
if true also loads the extended actor information
_loadBanners (Boolean)
if true also loads the paths to the banners
_useZip (Boolean)
If this series is not already cached and the series has to be downloaded, the zipped version will be downloaded
```



# Usage #
The method GetSeries can be used to get a series object. Depending on the given parameter a more or less detailed version is downloaded. if _useZipped is set to true, all details (episodes, actors and banners) are downloaded at once._



# Other methods #
```
public TvdbSeries GetBasicSeries(
	int _seriesId,
	TvdbLanguage _language,
	bool _loadBanners
)
```
Only downloads the basic series information without episodes or banners.

```
public TvdbSeries GetFullSeries(
	int _seriesId,
	TvdbLanguage _language,
	bool _loadBanners
)
```
Downloads the full series information (with episodes and banners)