using System.Numerics;
using OpenTabletDriver.Plugin;
using OpenTabletDriver.Plugin.Attributes;
using OpenTabletDriver.Plugin.Output;
using OpenTabletDriver.Plugin.Tablet;

namespace CursorShift;

[PluginName("Cursor Shift")]
public class CursorShiftFilter : IPositionedPipelineElement<IDeviceReport>
{
    [Property("X Offset")]
    [ToolTip("Horizontal offset in tablet units. Positive moves right, negative moves left.")]
    public float XOffset { get; set; }

    [Property("Y Offset")]
    [ToolTip("Vertical offset in tablet units. Positive moves down, negative moves up.")]
    public float YOffset { get; set; }

    public event Action<IDeviceReport>? Emit;

    public PipelinePosition Position => PipelinePosition.PostTransform;

    public void Consume(IDeviceReport report)
    {
        if (report is ITabletReport tabletReport)
        {
            tabletReport.Position = new Vector2(
                tabletReport.Position.X + XOffset,
                tabletReport.Position.Y + YOffset
            );
        }

        Emit?.Invoke(report);
    }
}
