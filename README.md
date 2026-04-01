# Cursor Shift

A simple OpenTabletDriver plugin that shifts cursor position by configurable X and Y offset values.

## Installation

### Manual
1. Download the latest release from [Releases](https://github.com/d-kja/otd-cursor-shift/releases)
2. Extract `CursorShift.dll` and `metadata.json` to `~/.config/OpenTabletDriver/Plugins/CursorShift/`
3. Restart OpenTabletDriver

### Building from source
```bash
dotnet build
cp bin/Debug/net8.0/CursorShift.dll ~/.config/OpenTabletDriver/Plugins/CursorShift/
cp metadata.json ~/.config/OpenTabletDriver/Plugins/CursorShift/
```

## Usage

1. Open OpenTabletDriver
2. Go to the Filters tab
3. Enable "Cursor Shift"
4. Configure X and Y offset values
5. Save and apply

## Configuration

| Property | Description |
|----------|-------------|
| X Offset | Horizontal offset. Positive moves right, negative moves left. |
| Y Offset | Vertical offset. Positive moves down, negative moves up. |

## Requirements

- OpenTabletDriver 0.6.6.0+
- .NET 8.0

## License

[MIT](LICENSE)
