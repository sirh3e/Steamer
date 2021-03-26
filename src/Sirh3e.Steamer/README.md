# Sirh3e.Steamer

Sirh3e.Steamer is a .NET wrapper library for the Steam Web API. So you can use static types.

See [interfaces](#interfaces) for all available interfaces and methods.

## Status

| Type            | Service       | Status                                                                                                                                                       |
|-----------------|---------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------|
| .NET Core       | Github Action | [![.NET Core](https://github.com/sirh3e/Steamer/actions/workflows/dotnet-core.yml/badge.svg)](https://github.com/sirh3e/Steamer/actions/workflows/dotnet-core.yml)                                                                                 |
| .NET Format     | Github Action | [![.NET Format](https://github.com/sirh3e/Steamer/actions/workflows/dotnet-format.yml/badge.svg)](https://github.com/sirh3e/Steamer/actions/workflows/dotnet-format.yml)                                                                             |

## License

[BSD-3-Clause](https://github.com/sirh3e/Steamer/blob/master/LICENSE.txt)

## Nuget

```cmd
dotnet add package Sirh3e.Steamer --version 1.0.0-preview-0001
```

## Interfaces

Currently implemented interfaces and methods:
Interfaces:
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

Is a method or interface missing please create a [issue](https://github.com/sirh3e/Steamer/issues/new)
## Semantic Versioning

Sirh3e.Steamer project strictly adhere to a [semantic](https://semver.org/) versioning scheme.

## Becoming Active in Sirh3e.Steamer development

New contributors are always welcome and I am happy to provide guidance if necessary.
## Authors

* **Plackpegasus** - *For the name Steamer* - [Plackpegasus](https://github.com/Plackpegasus)
* **sirh3e** - *Initial work* - [sirh3e](https://github.com/sirh3e)

See also the list of [contributors](https://github.com/sirh3e/Steamer/contributors) who participated in this project.