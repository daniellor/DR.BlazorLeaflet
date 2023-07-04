using System.Drawing;

namespace DR.BlazorLeaflet.Models.Events
{
    public class ResizeEvent : Event
    {
        public PointF OldSize { get; set; }
        public PointF NewSize { get; set; }
    }
}
