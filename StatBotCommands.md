# __GRLCS StatBot Commands__

# Table of Contents

- [Admin Commands](#admin-commands)
- [General Commands](#general-commands)

---

# Admin Commands

## Table of Contents

- [CreateTournament](#CreateTournament-<Division\>-<Name\>)
- [CreateCodes](#CreateCodes-<Division\>-<Count\>)

#

### CreateTournament <Division\> <Name\>

This creates a tournamentId with Riot from which tournament codes can be generated. The command will create a unique name for each tournament by appending the division.

#### Parameters

| Param    | Description                                                                |
| -------- | -------------------------------------------------------------------------- |
| Division | The one word rank division of the tournament. (i.e. Gold, Diamond, etc...) |
| Name     | The unique name of the tournament (i.e. GRLCS Summer Splash 2020)          |

#### Return

| Response                  | Description                                             |
| ------------------------- | ------------------------------------------------------- |
| Successful (tournamentId) | The tournamentId was created and saved in the database. |
| Unsuccessful              | There was an error setting the tournamentId.            |

---

### CreateCodes <Division\> <Count\>

Generates the given number of tournament codes for the most recently added tournament. 

*Note: To follow Riot's guidelines, codes should be generated as needed, not all at once at the start of a tournament.*

#### Parameters

| Param    | Description                                                                |
| -------- | -------------------------------------------------------------------------- |
| Division | The one word rank division of the tournament. (i.e. Gold, Diamond, etc...) |
| Count    | The number of tournament codes to be generated.                            |

#### Return

A list of codes.

---

# General Commands

## Table of Contents

- [Leaderboard (Overall)](#Leaderboard-<Division\>-<Category\>)
- [Leaderboard (Lane)](#Leaderboard-<Lane\>-<Division\>-<Category\>)
- [Stats](#Stats-<SummonerName\>)
- [Stats (Category)](#Stats-<Category\>-<SummonerName\>)
- [Categories](#Supported-Statistical-Categories)

#

### Leaderboard <Division\> <Category\>

Outputs a list of the top 10 players in the given category and division in decending order.

#### Parameters

| Param    | Description                                                    |
| -------- | -------------------------------------------------------------- |
| Division | The one word rank division. (i.e. Gold, Diamond, etc...)       |
| Category | The statistical [category](#Supported-Statistical-Categories). |

---

### Leaderboard <Lane\> <Division\> <Category\>

Outputs a list of all the players in the given role, division, and category in decending order.

#### Parameters

| Param    | Description                                                    |
| -------- | -------------------------------------------------------------- |
| Lane     | The lane. (i.e. Top, Jungle, Mid etc...)                       |
| Division | The one word rank division. (i.e. Gold, Diamond, etc...)       |
| Category | The statistical [category](#Supported-Statistical-Categories). |

---

### Stats <SummonerName\>

Outputs a list of all statistical categories for the given summoner name.

#### Parameters

| Param        | Description                      |
| ------------ | -------------------------------- |
| SummonerName | The summoner name of the player. |

---

### Stats <Category\> <SummonerName\>

Outputs the value of the given statistical category for the given summoner name.

#### Parameters

| Param        | Description                              |
| ------------ | ---------------------------------------- |
| Category     | The statistical [category](#Categories). |
| SummonerName | The summoner name of the player.         |

---

### Supported Statistical Categories

- KDA 
- Kills 
- Deaths  
- Assists  
- LargestKillingSpree 
- LargestMultiKill 
- CrowdControlScore 
- FirstBloods 
- TotalDamageToChamps 
- PhysicalDamageToChamps 
- MagicDamageToChamps 
- TrueDamageToChamps 
- TotalDamageToChamps 
- TotalDamageDealt 
- PhysicalDamageDealt 
- MagicDamageDealt 
- TrueDamageDealt 
- LargestCriticalStrike 
- TurretDamage 
- ObjectiveDamage 
- DamageHeal 
- DamageTaken 
- PhysicalDamageTaken 
- MagicDamageTaken 
- TrueDamageTaken 
- TotalDamageTaken 
- SelfMitigatedDamage 
- VisionScore 
- WardsKilled 
- WardsPlaced 
- ControlWardsBought 
- GoldEarned 
- GoldSpent 
- MinionsKilled 
- NeutralMinionsKilled 
- NeutralMinionsKilledTeamJungle 
- NeutralMinionsKilledEnemyJungle 
- DoubleKills 
- Triplekills 
- QuadraKills 
- PentaKills 
- FirstTowerKills 
- FirstInhibitorKills 
- FirstBloodAssists 
- InhibitorKills 
- TurretKills 
- KillingSprees 
- TotalUnitsHealed 
- LongestTimeSpentLiving 