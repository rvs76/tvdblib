# Basic Code Usage #
If you want to use the library to gain information from tvdb you first need your own api key from http://thetvdb.com/?tab=apiregister . If you also want to access your favorite list and rate series and episodes you also need your "account identifier", which is listed on the "account" tab on http://thetvdb.com.

After adding the dll to your project you set up a tvdb instance (in this case using an xml cache provider) like this:

```
TvdbHandler tvdbHandler = new TvdbHandler(new XmlCacheProvider("C:\\test"), "YOUR_API_KEY");
```

You can then use the InitCache() method to initialise the cache provider. This should be done before loading any other information.

```
tvdbHandler.InitCache();
```

You can get a list of available languages by accessing the "Languages" field:

```
List<TvdbLanguage> m_languages = tvdbHandler.Languages;
```

Now you can easily retrieve information on a series by calling

```
TvdbSeries s = tvdbHandler.GetSeries(73255, TvdbLanguage.DefaultLanguage, true, true, true);
```

This will retrieve all available data from the series 73255 (which is House M.D.) in the default language (which is english) and also load episode, banner and actor information. After using the information you should call

```
tvdbHandler.CloseCache();
```

to close the selected cache provider.


# Advanced Scenarios #

This was a short introduction on how to use the library, some other things you can do with it:
  * Get user specific data:
Every user of http://thetvdb.com has his own favorites list, preferred language and can rate series, episodes and banner (banners are not supported via their api yet). If you want to access this information, you need to first set the libraries "TvdbUser". The following code sample shows how to set the user, retrieve the list of favorites, add and remove favorites and rate a series.

```
TvdbUser user = new TvdbUser("some name for user", "your_user_identifier");
tvdbHandler.UserInfo = user;

//get list of all favorites and print them to console
List<int> favList = tvdbHandler.GetUserFavouritesList();
foreach(int id in favList)
{
   Console.WriteLine("Favorite: " + id);
}

//add house m.d. to favorite list
tvdbHandler.AddSeriesToFavorites(73255);

//rate house m.d. with 10 points (highest rating)
tvdbHandler.RateSeries(73255, 10);

//remove house m.d. from favorite list
tvdbHandler.RemoveSeriesFromFavorites(73255);
```