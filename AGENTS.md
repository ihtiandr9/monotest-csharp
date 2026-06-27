# monotest-csharp

Three independent Mono C# projects sharing a git repo. No `.csproj`/`.sln` — all compiled with `mcs` via per-project `Makefile`s.

## Projects

| Directory | Type | Binary | Build |
|-----------|------|--------|-------|
| `props/` | Console (inheritance demo) | `myobjtest.exe` | `make` in `props/` |
| `eqsq/` | Console (quadratic solver) | `hello.exe` | `make` in `eqsq/` |
| `mono-gui/` | WinForms GUI | `Program.exe` | `make` in `mono-gui/` |

Each has `make`, `make run`, `make clean`.

## Quirks

- `eqsq/`: takes up to 3 int args (`make run` passes `1 2 3`); links `-r:System.Numerics.dll` for `Complex`
- `mono-gui/`: requires X11 display server; references `System.Windows.Forms.dll` and `System.Drawing.dll`
- `props/`: global namespace, parameterless constructors, `implicit operator double` on base. Existing per-project guide at `props/AGENTS.md`
- No tests, no CI, no NuGet packages

## Conventions

- No project files — edit source, then `make`
- Global or single-namespace per project; no cross-project references
- Gitignore covers `*.exe`, `obj/`, `bin/`; committed binaries in `eqsq/` and `mono-gui/` are stale artifacts
