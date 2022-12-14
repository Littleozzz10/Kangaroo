# Kangaroo

Kangaroo is a basic mod management tool for Halo: The Master Chief Collection on Steam designed with the Windows Forms API, allowing for better control over the mods you install through the Steam Workshop.
True, Steam *does* let you manage Workshop content, but it's pretty barebones and basic. I wanted a more dedicated management tool for MCC modding, so here we are.

Note: This manager is *not* a replacement for the Steam Workshop, nor will it work for MCC modding on the Microsoft Store version of the game.
This program isn't perfect, especially when interacting with Steam itself. Also, as it's built on Windows Forms, the program only natively runs on Windows 7 and higher. No Linux/Steam OS support.

See the Getting Started and FAQ pages in the wiki for information on how to use Kangaroo

## Features
- Dedicated management of Master Chief Collection mods, with the ability to view properties and maps in each installed mod.
- Basic backup features, allowing you to backup your entire folder of Workshop mods
- The deletion and reinstallation of mods from the Workshop.*
- A mod tool launcher, with all 24 programs across the 7 sets of released mod tools represented.**

**When deleting mods, only the .map and .bk2 files (which take up the vast majority of a mod's space) are deleted. This allows Kangaroo to still see the mod.
In addition, because the Steam client does not allow outside programs to install content through Steam, when 'reinstalling' a mod, the Steam console is temporarily
brought up, and the command to reinstall the mod will be copied to your clipboard*

***MCC Mod Tools do not need to be installed in order to use Kangaroo*

## Roadmap
The following features are currently *planned* to be added to Kangaroo:
- Restoring multiple mod backups with one operation
- Easy creation of Linked Directories, to allow users to store Workshop content on a drive seperate from where they installed the MCC
- Multi-threaded backups and deletions, to allow for showing progress during the operations
- Support for Spartan Ops mods, as well as improved support for menu video mods
- Other smaller things not worth mentioning

## Known Issues
- Backing up all mods can take a large amount of time, and without a progress bar indicated, it appears as though Kangaroo freezes.
Workaround: Give it time. During testing, it took about 3 1/2 minutes to copy approximately 30GB of mods.

Find an issue? Report it!

## Disclaimer
While Kangaroo has been thouroughly tested, issues affecting Workshop content may arise. Use at your own risk! (That being said, if somehow Kangaroo breaks
your Workshop content, I am deeply sorry; let me know about the issue and I will work to fix it)
