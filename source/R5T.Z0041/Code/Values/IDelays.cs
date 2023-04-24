using System;

using R5T.T0131;
using R5T.T0182;


namespace R5T.Z0041
{
    [ValuesMarker]
    public partial interface IDelays : IValuesMarker
    {
        private static Raw.IDelays RawDelays => Raw.Delays.Instance;


        /// <summary>
        /// A delay for use after sending a command to open a file.
        /// It's useful to allow programs some time after opening a file to allow the program (and operating system) to process all events related to opening the file.
        /// <para>
        /// <inheritdoc cref="Raw.IDelays._100_Milliseconds" path="/summary"/>
        /// </para>
        /// </summary>
        /// <remarks>
        /// It can take some time for a program to open a file.
        /// So opening multiple files too quickly can result in files being opened in the wrong order.
        /// From the program's perspective, all the file open commands arrived at the same time, so it can choose the order in which to display the opened files.
        /// This is a problem, for example, when using Notepad++ to open multiple files (via a command on a captive command line).
        /// You might want your files to be opened in a specific order, and spend much time and energy getting the order just right,
        /// but without a delay between each open command, they won't be.
        /// </remarks>
        public IDelay For_FileOpen => RawDelays._100_Milliseconds;

        /// <summary>
        /// Allows time for the Windows operating system to position a newly opened window.
        /// Allows Windows Explorer windows to correctly position themselves (if too fast, windows will be out of order).
        /// /// <para>
        /// <inheritdoc cref="Raw.IDelays._500_Milliseconds" path="/summary"/>
        /// </para>
        /// </summary>
        public IDelay For_WindowPositioningByOS => RawDelays._500_Milliseconds;
    }
}
