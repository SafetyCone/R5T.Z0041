using System;

using R5T.T0131;
using R5T.T0182;
using R5T.T0182.Extensions;


namespace R5T.Z0041.Raw
{
    [ValuesMarker]
    public partial interface IDelays : IValuesMarker
    {
        /// <summary>
        /// 100 <inheritdoc cref="Y0005.Glossary.ForTime.Milliseconds" path="/display"/>.
        /// </summary>
        public IDelay _100_Milliseconds => 100.ToDelay();
        /// <summary>
        /// 500 <inheritdoc cref="Y0005.Glossary.ForTime.Milliseconds" path="/display"/>.
        /// </summary>
        public IDelay _500_Milliseconds => 500.ToDelay();

        /// <summary>
        /// 10,000 <inheritdoc cref="Y0005.Glossary.ForTime.Milliseconds" path="/display"/>.
        /// </summary>
        public IDelay _10_Seconds => 10000.ToDelay();
    }
}
