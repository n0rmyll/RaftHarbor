# RaftModLoader adapter investigation

No compiled adapter exists yet. Do not add guessed game stubs, proprietary references, or a fake server entry point to the default build.

First validate the installed loader's supported C# language/runtime, mod manifest and packaging format, lifecycle hooks, and unload behavior. Document assembly identities and local reference setup without committing assemblies. Choose the adapter target only after this evidence exists. The tooling's net8.0 target does not imply loader compatibility.

The first adapter should only log load/unload and world lifecycle observations in a disposable world. Server mode must later require an explicit opt-in and fail closed if required APIs are absent. No networking patches should be enabled by default.
