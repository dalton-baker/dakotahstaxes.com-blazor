using Microsoft.AspNetCore.Components;

namespace Dakotahstaxes.Com.Components
{
    public partial class ContactInfoCard
    {
        [Parameter]
        public string Title { get; set; }

        [Parameter]
        public RenderFragment Body { get; set; }

        [Parameter]
        public RenderFragment Action { get; set; } = null;
    }
}
