VersionPreprocessorSymbols
==========================

An MSBuild file dedicated to giving a project targetable preprocessor constants for various .NET Framework versions.

Usage:

1. Drop `VersionPreprocessorSymbols.prop` into the desired project directory.
2a. If you wish to edit the project file in Visual Studio, you must unload the project and then right click it and click "Edit &lt;project&gt;.csproj"
2b. Otherwise, simply edit the file outside of Visual Studio.
3. Edit project file to include `<Import Project="VersionPreprocessorSymbols.prop" />`. This should go before the closing `</Project>`.
4. Target framework versions by using the preprocessor constants, i.e. `#if NETFX_40`. Examples included in this repository.