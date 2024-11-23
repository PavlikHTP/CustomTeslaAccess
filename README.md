# CustomTeslaAccess
**CustomTeslaAccess** - is a plugin for **SCP: Secret Laboratory**, that makes Tesla react only to people with a specific card.

## Access that card has
**Access granted** - KeycardJanitor, KeycardScientist, KeycardResearchCoordinator,
KeycardZoneManager, KeycardGuard, KeycardMTFPrivate, KeycardContainmentEngineer,
KeycardMTFOperative, KeycardMTFCaptain, KeycardFacilityManager, KeycardChaosInsurgency, KeycardO5

**Access denided** - KeycardChaosInsurgency, absence card


## Installation
1. Download the latest version of the plugin from [Releases](https://github.com/PavlikHTP/CustomTeslaAccess/releases).
2. Place the plugin file in the `Plugins` folder of your SCP: SL delicated server.
3. Restart the server to activate the plugin. (the command to restart the server - **sr**)

## Configuration
After the first run of the plugin, a configuration file is created. You can modify it as you wish:
```yml
CustomTeslaAccess:
#Is the plugin enabled?
  is_enabled: true
  #Are debug messages displayed?
  debug: true
```
