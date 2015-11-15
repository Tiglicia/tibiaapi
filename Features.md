# TibiaAPI Features #
As of TibiaAPI v1.3

## Extras ##
  * ### `ClientChooser` ###
    * `ShowBox` - show a client chooser box; the user can then choose a client and the client object is returned

## Objects ##
  * ### `Battlelist` ###
    * `GetCreatures` - get creatures by name, id, or other properties
    * `ShowInvisible` - show invisible creatures with custom outfit
  * ### `Client` ###
    * `EatFood` - eat the first found food item
    * `GetBattlelist` - get the battlelist for this client
    * `GetClients` - get a list of all clients
    * `GetPlayer` - get the client's player
    * `GetProcess` - get the client's process
    * `GetSlot` - get the item at the specified slot
    * `GetStartTime` - get the time when the client was started
    * `GetVersion` - get the client's version
    * `IsActive` - returns true if the client is the foreground window
    * `LoggedIn` - returns true if the user is logged in
    * `Logout` - logs out the player
    * `MakeRune` - make the specified rune
    * `ReadByte, ReadInt, ReadString` - read vars from memory
    * `Send` - send a packet
    * `SetOT` - set the client to use an Open Tibia server
    * `SetRSA` - set the RSA key of the client
    * `SetServer` - set the server of the client
    * `Status` - returns the current status of the client (logged in, logging in, logged out, etc)
    * `Statusbar` - read from and write to the statusbar
    * `WriteByte, WriteInt, WriteString` - write to the clients memory
  * ### `Console` ###
    * `Say` - send a message to the specified channel
    * `Send` - send a private message
    * `Spell` - send a spell
  * ### `Container` ###
    * `GetAddress` - get the address in memory of the container
    * `GetItems` - get a list of all itmes in the container
    * `Id` - returns the containers id (number)
    * `IsOpen` - returns true if the container is open
    * `Name` - returns the name of the container
    * `OpenParent` - open this containers parent container
    * `Volume` - returns the volume of the container
  * ### `Creature` ###
    * Get/Set the following creature variables: `Addon, Address, BlackSquare, Color_Body, Color_Feet, Color_Head, Color_Legs, Direction, HPBar, Id, IsVisible, IsWalking, Light, LightColor, Location (get only), Name, Outfit, Party, ScreenOffsetHoriz, ScreenOffsetVert, Skull, Type, WalkSpeed, X, Y, Z`
    * `Attack` - attack the creature
    * `InParty` - returns true if the creature is in your party
    * `IsAttacking` - returns true if the creature is attacking you (has a black square)
    * `Look` - look at the creature (shift-click)
  * ### `Inventory` ###
    * `FindItem` - find an item in the inventory based on certain criteria
    * `FindNext` - find the next item after calling `FindItem`
    * `GetContainers` - get a list of all open containers
    * `GetItem` - get the item at the specified location
    * `Stack` - stack the specified item; moves the second item it finds to the first item, unless the second is a stack of 100 in the same container
  * ### `Item` ###
    * `Count` - returns the item count
    * `Found` - whether or not the item was found when searching using `inventory.FindItem`
    * `Id` - returns the item's id
    * `IsInList` - returns true if the item is in a list of items (checking if it is food, etc)
    * `ItemLocationToBytes` - used to convert an items location (slot, container, ground) to bytes for a packet
    * `Loc` - return the items location (slot, container, ground)
    * `Move` - move the item to a new location
    * `Name` - returns the item's name (if set)
    * `Stackable` - whether or not the item is stackable
    * `Use` - use the item, use it on a tile, use it on another item (not working), or use it on another creature; if it is a creature and not a player, the item will be used through the hotkey system, making it far more accurate
    * `UseOnSelf` - use the item on the player
  * ### `Map` ###
    * `GetAbsoluteLocation` - find the absolute location from a sqaure number
    * `GetPlayerSquare` - find the square the player is located on
    * `ReplaceObject` - replace an object on the map with another object
    * `ReplaceTile` - replace the specified tile on the map with a differnt tile
    * `ReplaceTrees` - replace all the trees on the map with a small fir tree
    * `SquareNumberToLocation` - convert a square number to a location
  * ### `Player` ###
    * Get/Set the following player variables: `AccessN, AccessS, Addon, Address, Axe, Axe_Percent, BlackSquare, Cap, Club, Club_Percent, Color_Body, Color_Feet, Color_Head, Color_Legs, Direction, Distance, Distance_Percent, Exp, Fishing, Fishing_Percent, Fist, Fist_Percent, Flags, GoTo_X, GoTo_Y, GoTo_Z, HP, HP_Max, HPBar, Id, IsVisible, IsWalking, Level, Level_Percent, Light, LightColor, Location (get only), MagicLevel, MagicLevel_Percent, Mana, Mana_Max, Name, Outfit, Party, ScreenOffsetHoriz, ScreenOffsetVert, Shielding, Shielding_Percent, Skull, Soul, Stamina, Sword, Sword_Percent, Type, WalkSpeed, X, Y, Z`
    * `ExpLeft` - returns the exp needed for the next level (or any level)
    * `GreenSquare` - get/set the id of the player you are following
    * `HasFlag` - check whether or not the player has a certain flag
    * `RedSquare` - get/set the id of the creature you are attacking
    * `SetOutfit` - set the players outfit
    * `Stop` - stop all actions
    * `Turn` - turn to the specified direction
    * `Walk` - walk in the specified direction
    * `WhiteSquare` - get/set the id of the creature with a white square
  * ### `VipList` ###
    * `GetOnline` - returns a list of all online players
    * `GetPlayer` - get the Vip object of a specified player
    * `GetPlayers` - get a list of all players on the Vip list (also get all players with the specified icon)