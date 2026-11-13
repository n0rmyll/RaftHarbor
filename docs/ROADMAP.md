# Technical roadmap

All milestones are incomplete. A successful .NET build is not evidence of a working mod.

## 0 — Reproducible baseline

Record the exact Raft build, OS, Unity/runtime, Steam session state, loader version, assembly versions, and test setup. Establish a normal two-client host/join/save/rejoin baseline using owned installations. Use disposable worlds and backups.

Exit: a reproducible baseline report with sanitized logs and actual results.

## 1 — Loader and networking investigation

Validate current RaftModLoader APIs, lifecycle, manifest, packaging, and target framework. Build a logging-only mod. Map host authority, scene transitions, world initialization, local-player dependencies, connection authentication, message routing and serialization, disconnects, and Steam identity/session lifetime. Determine whether new APIs depend on RDS infrastructure or licensing. Document API signatures and observations rather than assuming public documentation matches installed binaries.

Exit: verified lifecycle and network sequence notes, minimal mod load/unload evidence, dependency/license inventory, and an explicit go/no-go decision on the adapter design.

## 2 — Minimal server-mode proof of concept

Use the existing game simulation rather than reimplementing the protocol. Add explicit server-mode opt-in on a licensed Windows test host. Attempt loading a disposable world, sustaining simulation without an actively controlled host player, and accepting one remote client. Initially allow a graphical process; true headless execution is a separate experiment. Never bypass Steam authentication or entitlement.

Exit: versioned steps and logs showing host startup, remote join, host inactivity, all clients leaving, continued simulation for at least 30 minutes, save, clean stop, restart, and successful rejoin with persisted changes. Record CPU/RAM and any dummy-player requirement. If any step fails, report the limitation; do not call it dedicated-server support.

## 3 — Reliability and headless feasibility

Investigate batch/no-graphics startup only after the proof of concept. Validate time progression, physics, AI, autosave integrity, disconnect/reconnect, unexpected termination recovery, shutdown cancellation, and safe patch removal. Determine supported authentication and client-mod requirements. Test Linux separately; no compatibility promise before measurement.

Exit: repeatable integration scenarios, recovery evidence, documented limitations, and a support matrix.

## 4 — Free release readiness

Add operator configuration, redacted diagnostics, installation instructions using user-owned files, and automated checks for original code. Review packaging to exclude game/loader binaries, credentials and saves; review dependency licenses and distribution terms. Establish version compatibility and upgrade/backup procedures. Publish to GitHub only after the user's confirmation. Paid hosting automation is deferred.
