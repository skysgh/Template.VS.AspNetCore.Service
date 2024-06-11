namespace App.Host.Models
{
    /// <summary>
    /// The view model for the Error View
    /// </summary>
    public class ErrorViewModel
    {
        /// <summary>
        /// Gets or sets the optional request identifier.
        /// </summary>
        /// <value>
        /// The request identifier.
        /// </value>
        public string? RequestId { get; set; }

        /// <summary>
        /// Gets a value indicating whether to show the
        /// <see cref="RequestId"/>.
        /// </summary>
        /// <value>
        ///   <c>true</c> if [show request identifier]; otherwise, <c>false</c>.
        /// </value>
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
