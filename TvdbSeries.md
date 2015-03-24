# Introduction #
TvdbSeries is the main class for accessing the retrieved information. The class consists of the following sections:

## Information regarding the series [more](http://thetvdb.com/wiki/index.php/API:Base_Series_Record) ##
  * Name
  * Overview
  * Network
  * Writers, Directors,...
  * ...

## Banners [more](http://thetvdb.com/wiki/index.php/Category:Banners) ##
  * Series banners
  * Season banners / wide season banners
  * Poster banners

## Episode information [more](http://thetvdb.com/wiki/index.php/API:Base_Episode_Record) ##
  * Name
  * Overview
  * First Aired
  * Episode Banner
  * ...

## Actor Informations [more](http://thetvdb.com/wiki/index.php/API:actors.xml) ##
  * Name
  * Role
  * Image

# All fields and methods #
For a detailed description of all fields and methods of this class, see the [documentation](http://tvdblib.googlecode.com/files/Documentation.chm)

# Example Usage #
The following sample initialises an Tvdb object, gets a detailed TvdbSeries and writes the information to the console:

```
      TvdbHandler tvdbHandler = new TvdbHandler(null, File.ReadAllText("api_key.txt"));//no caching -> same as "new TvdbHandler(insert_my_apikey);"
      //retrieve series "House" with all available information (without using zipped downloading)
      TvdbSeries s = tvdbHandler.GetSeries(73255, TvdbLanguage.DefaultLanguage, true, true, true, false);
      if (s != null)
      {
        WriteToConsole("Series Description:");
        WriteToConsole("================");
        WriteToConsole("Series id: " + s.Id);
        WriteToConsole("Name: " + s.SeriesName);
        WriteToConsole("Overview: " + s.Overview);
        WriteToConsole("Day of Week: " + s.AirsDayOfWeek);
        WriteToConsole("Airs Time: " + s.AirsTime.ToShortTimeString());
        WriteToConsole("Banner Path: " + s.BannerPath);
        WriteToConsole("Content Rating: " + s.ContentRating);
        WriteToConsole("Fanart Path: " + s.FanartPath);
        WriteToConsole("First Aired: " + s.FirstAired.ToShortDateString());
        WriteToConsole("Genres: " + s.GenreString);
        WriteToConsole("Imdb: " + s.ImdbId);
        WriteToConsole("Rating: " + s.Rating);
        WriteToConsole("Runtime: " + s.Runtime);
        WriteToConsole("Status: " + s.Status);
        WriteToConsole("tv.com id: " + s.TvDotComId);
        WriteToConsole("Zap2itId id: " + s.Zap2itId);
        WriteToConsole("");

        WriteToConsole("Episodes for " + s.SeriesName + ":");
        WriteToConsole("=================");
        foreach (TvdbEpisode e in s.Episodes)
        {
          WriteToConsole("Season " + e.SeasonNumber + " Episode " + e.EpisodeNumber + ": " + e.EpisodeName);
        }
        WriteToConsole("");

        WriteToConsole("Actors:");
        WriteToConsole("======");
        foreach (TvdbActor a in s.TvdbActors)
        {
          WriteToConsole(a.Name + " as " + a.Role + " (" + a.ActorImage.BannerPath + ")");
        }
      }
      else
      {
        WriteToConsole("Couldn't find series");
      }
```