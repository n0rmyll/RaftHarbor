# Research ledger

Initial public-document review: 2026-11-13. No game or loader binaries were inspected; no runtime experiment has been performed.

## Primary sources

- [RaftModLoader Mod API](https://api.raftmodding.com/modding-api/mod): documents mod and world lifecycle events. Installed API signatures still require verification.
- [RAPI](https://api.raftmodding.com/modding-api/rapi): documents dedicated-server detection and networking helpers. Detection does not create a server and does not establish availability outside RDS.
- [Mod metadata](https://api.raftmodding.com/modding-tutorials/how-to-create-a-mod-project/the-modinfo.json-file): starting point for manifest investigation.
- [Multiplayer guidance](https://api.raftmodding.com/getting-started/installing-a-mod/mods-in-multiplayer): documents matching client mod setups; vanilla-client compatibility is unproven.
- [RDS documentation](https://rdswiki.raftmodding.com/): reference for externally observable server behavior only; RDS is a separate implementation. Do not copy its code or assume compatible networking.

Public docs are leads, not proof of current binary behavior. Earlier claims about a March 2026 networking update have not been independently verified here.

## Open questions

1. Which Unity/Mono framework and C# features does the installed loader accept?
2. Which callbacks and networking helpers are available without RDS?
3. What ties host world simulation to a local player, rendering, audio, and scene UI?
4. Can a world continue after every remote client leaves, without host input?
5. Which Steam account/session requirements apply to launch, hosting and joining?
6. Can the normal game protocol be retained? Which mods must clients install?
7. Are graphics-free execution and Linux practical? These are unknown.

## Experiment record template

For each experiment record date, exact build/loader/OS versions, hypothesis, source/API signature, local-only setup, disposable world, repeatable steps, expected behavior, observed behavior, sanitized evidence, and pass/fail/unknown. Record failures as well as successes. Never commit credentials, full game dumps, game assemblies, private player identifiers, or original world files. Keep logs in ignored `local/` and summarize observations in original prose.

## Name check

A public web search on 2026-11-13 found no obvious RaftHarbor repository conflict. Direct availability of n0rmyll/RaftHarbor could not be confirmed. Names are scoped to a GitHub owner; this is not trademark clearance or a reservation. Recheck before publication.
