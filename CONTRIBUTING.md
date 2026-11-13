# Contributing

Start with the investigation roadmap. Keep experiments small and record reproducible evidence. Do not claim compatibility or server support without an integration result on a licensed installation.

Submit original code only. Do not commit proprietary assemblies, decompiled game source, game assets, loader binaries, saves, secrets, or account information. Keep local game paths and references outside tracked configuration. Document dependency licenses before adding them.

Build with `dotnet build RaftHarbor.sln --configuration Release`. Run the checklist with `dotnet run --project src/RaftHarbor.Probe -- --plan`. Future changes to game integration need meaningful runtime validation; compiling these tools alone is insufficient.
