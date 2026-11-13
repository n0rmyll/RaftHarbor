# RaftHarbor

A free, open-source project investigating a dedicated-server mod for Raft.

**Status: repository scaffold only. No working mod, server, launcher, or headless support exists yet.** The included .NET tool prints the investigation checklist; it does not start Raft.

## Ownership and distribution

You must provide a legitimately owned Raft installation. RaftHarbor supplies only original project code: no game executables, assets, assemblies, saves, Steam credentials, or third-party mod binaries. Owning the game does not establish redistribution or commercial hosting rights. We have not verified unattended Steam authentication, anonymous SteamCMD installation, or headless operation. Do not bypass ownership checks or collect Steam passwords.

This project is independent of Redbeet Interactive, Axolot Games, RaftModLoader, and RDS. It does not copy RDS code or promise RDS compatibility. Our original code is MIT licensed; third-party software retains its own terms. Future managed hosting is outside this repository's initial scope.

## Development

Install a supported .NET 8 SDK (8.0.100 or newer compatible SDK).

```sh
dotnet build RaftHarbor.sln --configuration Release
dotnet run --project src/RaftHarbor.Probe -- --plan
```

Neither command needs game files. The core library currently contains only research milestones. .NET 8 is for development tooling, **not a selected Unity mod runtime**. The adapter framework, assembly references, loader packaging, and API compatibility will be selected after inspection of a user-owned installation.

## Layout

- `src/RaftHarbor.Core`: game-independent research checklist.
- `src/RaftHarbor.Probe`: local checklist command, not a game probe or server.
- `research/adapter`: adapter investigation boundary; no invented loader entry point.
- `docs/ROADMAP.md`: milestones and acceptance criteria.
- `docs/RESEARCH.md`: sources, hypotheses, and evidence protocol.

Keep game installations outside the repository. Keep local experiments, logs, saves, and private configuration in the ignored directories described in `.gitignore`. Ignore rules are a backstop: review every staged file before sharing. No GitHub remote or publication is configured by this scaffold.

Next: inspect the loader and networking lifecycle on a Windows machine with a legitimate Raft installation, then attempt a minimal server-mode proof of concept. See the roadmap before implementing hosting infrastructure.
