using ExileCore2.Shared.Interfaces;
using ExileCore2.Shared.Nodes;
using System.Drawing;

namespace Wheres_My_Cursor
{
    public class Settings : ISettings
    {
        public ToggleNode Enable { get; set; } = new ToggleNode(true);
        public RangeNode<int> WmcLineType { get; set; } = new RangeNode<int>(1, 0, 2);
        public ColorNode WmcLineColor { get; set; } = new ColorNode(Color.White);
        public RangeNode<int> WmcLineLength { get; set; } = new RangeNode<int>(200, 1, 1000);
        public RangeNode<int> WmcLineSize { get; set; } = new RangeNode<int>(1, 1, 10);
        public ToggleNode WmcPlayerOffsetXNegitive { get; set; } = new ToggleNode(true);
        public RangeNode<int> WmcPlayerOffsetX { get; set; } = new RangeNode<int>(0, 0, 200);
        public ToggleNode WmcPlayerOffsetYNegitive { get; set; } = new ToggleNode(true);
        public RangeNode<int> WmcPlayerOffsetY { get; set; } = new RangeNode<int>(0, 0, 200);
    }
}
