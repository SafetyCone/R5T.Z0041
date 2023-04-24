using System;

using R5T.T0131;
using R5T.T0182;


namespace R5T.Z0041.Conventional
{
    [ValuesMarker]
    public partial interface IDelays : IValuesMarker
    {
        private static Raw.IDelays RawDelays => Raw.Delays.Instance;


        /// <summary>
        /// A half-second delay.
        /// <para>
        /// <inheritdoc cref="Raw.IDelays._100_Milliseconds" path="/summary"/>
        /// </para>
        /// </summary>
        public IDelay HalfSecond => RawDelays._500_Milliseconds;
    }
}
