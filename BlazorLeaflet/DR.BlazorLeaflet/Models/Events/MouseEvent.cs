using DR.BlazorLeaflet.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DR.BlazorLeaflet.Models.Events
{
    public class MouseEvent : Event
    {
        public LatLng LatLng { get; set; }

        public PointF LayerPoint { get; set; }

        public PointF ContainerPoint { get; set; }

    }
}
