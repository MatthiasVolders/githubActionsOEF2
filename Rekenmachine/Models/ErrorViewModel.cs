namespace Rekenmachine.Models
{
    public class ErrorViewModel
    {
        public string? RequestIds { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}