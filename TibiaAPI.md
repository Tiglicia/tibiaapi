# Introduction #

TibiaAPI is an open source application programming interface to ease the creation of programs interacting with the client of the massive multiplayer online roleplaying game Tibia.


# Details #
So really, why use it, why not make your own?
  * It is **compatible** with all of the .Net languages.
  * **Open source**
  * It is compiled and distributed as a DLL. Why is this important?
    * Unified core for many programs. All programs will run on the same underlying architecture, which, through open contribution will contain the fastest and best methods and algorithms.
    * **Easy to update.** Because all memory addresses and offsets are stored in the DLL, once it is updated any program based on it is updated as well. So, even a program that has ceased development can be updated without the original author by dropping in the newest version of the DLL.