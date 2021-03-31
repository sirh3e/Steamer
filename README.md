# Sirh3e.Steamer

Sirh3e.Steamer is a .NET wrapper library for the Steam Web API. So you can use static types.

See [interfaces](#interfaces) for all available interfaces and methods.

## Status

| Type            | Service       | Status                                                                                                                                                       |
|-----------------|---------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------|
| .NET Core       | Github Action | [![.NET Core](https://github.com/sirh3e/Steamer/actions/workflows/dotnet-core.yml/badge.svg)](https://github.com/sirh3e/Steamer/actions/workflows/dotnet-core.yml)                                                                                 |
| .NET Format     | Github Action | [![.NET Format](https://github.com/sirh3e/Steamer/actions/workflows/dotnet-format.yml/badge.svg)](https://github.com/sirh3e/Steamer/actions/workflows/dotnet-format.yml)                                                                             |
| Maintainability | CODE CLIMATE  | [![Maintainability](https://api.codeclimate.com/v1/badges/3dcc070246ce930ea7c9/maintainability)](https://codeclimate.com/github/sirh3e/Steamer/maintainability) |
| Code Quality    | CodeFactor    | [![CodeFactor](https://www.codefactor.io/repository/github/sirh3e/steamer/badge)](https://www.codefactor.io/repository/github/sirh3e/steamer) |

## Quick start

```csharp
var steamUserName = "sirh3e";
var key = "YOUR API KEY"; //Create a api key: https://steamcommunity.com/dev/apikey keepit secure
var (service, client) = SteamerWebFactory.CreateByKey(key);

//OnErr where the throw new NotImplementedException is handle the error your self :D
var steamId = (await client.SteamUser.ResolveVanityUrl
        .SetVanityUrl(steamUserName)
        .Build()
        .ExecuteAsync(service))
        .Match(response => response.Model.Map(model => model.Response.SteamId).UnwrapOrDefault(), error => throw new NotImplementedException());
```

Else have a look at: [examples](https://github.com/sirh3e/Steamer/tree/development/examples)

## License

[BSD-3-Clause](https://github.com/sirh3e/Steamer/blob/master/LICENSE.txt)

## Nuget

```cmd
dotnet add package Sirh3e.Steamer --version 0.1.0
```

## Interfaces

Currently implemented interfaces and methods:

- [EconService](https://partner.steamgames.com/doc/webapi/IEconService)
  - CancelTradeOffer
  - DeclineTradeOffer
  - TradeHistory  
  - TradeOffer
  - TradeOffers
  - TradeOffersSummary
- [PlayerService](https://partner.steamgames.com/doc/webapi/IPlayerService)
  - Badges
  - CommunityBadgeProgress
  - OwnedGames
  - SteamLevel
- [SteamApps](https://partner.steamgames.com/doc/webapi/ISteamApps)
  - AppList
- [SteamUser](https://partner.steamgames.com/doc/webapi/ISteamUser)
  - FriendList
  - PlayerBans
  - PlayerSummaries
  - ResolveVanityUrl
  - UserGroupList
- [SteamUserStats](https://partner.steamgames.com/doc/webapi/ISteamUserStats)
  - GlobalAchievementPercentagesForApp
  - NumberOfCurrentPlayers
  - PlayerAchievements
  - SchemaForGame
  - UserStatsForGame

Is a method or interface missing please create a [issue](https://github.com/sirh3e/Steamer/issues/new?assignees=&labels=enhancement&template=feature_request.md&title=%5BENHANCEMENT%5D)

## Semantic Versioning

Sirh3e.Steamer project strictly adhere to a [semantic](https://semver.org/) versioning scheme.

## Becoming Active in Sirh3e.Steamer development

New contributors are always welcome and I am happy to provide guidance if necessary.

## Authors

- **Plackpegasus** - *For the name Steamer* - [Plackpegasus](https://github.com/Plackpegasus)
- **SirCremefresh** - *For simplefining the examples* - [SirCremefresh](https://github.com/SirCremefresh)
- **sirh3e** - *Initial work* - [sirh3e](https://github.com/sirh3e)

See also the list of [contributors](https://github.com/sirh3e/Steamer/contributors) who participated in this project.
