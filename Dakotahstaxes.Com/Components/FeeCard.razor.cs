using Microsoft.AspNetCore.Components;

namespace Dakotahstaxes.Com.Components
{
    public partial class FeeCard
    {
        [Parameter]
        public string Title { get; set; }

        [Parameter]
        public string Body { get; set; }

        [Parameter]
        public string Caveat { get; set; } = null;

        [Parameter]
        public string Price { get; set; } = null;

    }
}
