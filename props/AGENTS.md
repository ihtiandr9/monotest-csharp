# pitest

Mono C# console project. Entrypoint: `Program.cs::Main`.

## Commands

```sh
make        # build
make run    # build + run
make clean  # remove binary
```

## Structure

- `MyProperty.cs` — base class with `Value` / `Unit` properties and `ToString()`
- `Speed.cs` / `Accel.cs` — inherit from `MyProperty`, set their own default unit
- `MyObject.cs` — composes `Speed` and `Accel` instances
- `Printer.cs` — struct wrapping `Console.WriteLine`/`Console.Write`; consumed by `MyProperty.Print()` and `MyObject.Print()`
- `Program.cs` — creates a `MyObject`, prints hello + state

## Conventions

- No project file — compile with `mcs` manually
- All classes in global namespace
- Every class has a parameterless constructor for property-initializer usage
