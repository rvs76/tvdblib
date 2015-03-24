tvdblib is a library written in c# .net which allows pulling information through the api provided at http://thetvdb.com .

[![](http://img210.imageshack.us/img210/6931/tvdblogosmallho5.png)](http://thetvdb.com)

To demonstrate the features and usage of the library, the program TvBrowser allows you to browse through the shows available on thetvdb and watch all available content.

![![](http://img231.imageshack.us/img231/8535/109200821628amkf3.th.png)](http://img231.imageshack.us/img231/8535/109200821628amkf3.png)![![](http://img224.imageshack.us/img224/9615/109200821655amjq4.th.png)](http://img224.imageshack.us/img224/9615/109200821655amjq4.png)
![![](http://img80.imageshack.us/img80/9210/109200821733amiw9.th.png)](http://img80.imageshack.us/img80/9210/109200821733amiw9.png)
![![](http://img80.imageshack.us/img80/2489/109200821804amtl3.th.png)](http://img80.imageshack.us/img80/2489/109200821804amtl3.png)

**The features covered by the library at the moment are:**
  * series information
  * episode information
  * caching of downloaded data
    * save to xml files
    * save to serialized files
  * updating of cached data
  * banners (including thumbnails)
    * series
    * season
    * episode
    * fanart
    * poster
    * actors
  * add/remove user favorites
  * user ratings
  * actors information
  * zipped downloading

If you find any bugs, do not hesitate to post them within the "Issues" section.

# .::News::. #

## Version 0.8 (2010-07-22) ##
A new version of the tvdblib but since there hasn't been much progress on thetvdb site, this version contains mostly bug fixes and only a few new features.

What' new:
  * Improved updating algorithm
  * Support for series lookup by imdb id
  * Improvements in language handling

One of the main problems at the moment is that the api of thetvdb.com has some serious flaws/bugs, but noone there seems to care to fix or even comment on them. This is why updating of cached content might result in inconsistent data. For more information see:
http://forums.thetvdb.com/viewtopic.php?f=8&t=3994 and
http://forums.thetvdb.com/viewtopic.php?f=8&t=3993


## Version 0.7 (2009-06-18) ##
Because of a few open bugs I decided on releasing a new version, even though no major new features have been added. The most noticable changes are:
  * fixed all known bugs
  * Sorting of episodes (aired, dvd, absolute)
  * Running Updates can be aborted
  * A few new properties (e.g. ContainsSeriesName at TvdbFanartBanner)

## Version 0.6 (2009-02-14) ##
The version 0.6 offers a heavily redone update and caching mechanism and a differentiation between [TvdbDownloader](http://code.google.com/p/tvdblib/wiki/TvdbDownloader) and [TvdbHandler](http://code.google.com/p/tvdblib/wiki/TvdbHandler).

Amongst others, these are the main changes/additions to the library:
  * Redone caching mechanism: Improved performance and much lower memory consumption
  * TvdbDownloader: Only download informations from http://thetvdb.com
  * TvdbHandler: Download and handle (cache, update, etc.) the downloaded data
  * Improved update mechanism
  * All banners (except actors) support thumbnails

You can download the new version from [here](http://tvdblib.googlecode.com/files/tvdblib.0.60.rar)

## Version 0.5 ##

This version adds the new api features to get all rated series for a user, get all rated items from a series and the episode lookup using the air-date.

A few minor bugfixes where made and the TvBrowser app now has the ability to store the user identifier.

## Version 0.4 ##

Version 0.4 implements all features offered by the API. It also fixes a lot of bugs of the previous versions. Language handling is much improved now as well as downloading updates for cached content.