using System;


namespace R5T.Z0041
{
    public class Delays : IDelays
    {
        #region Infrastructure

        public static IDelays Instance { get; } = new Delays();


        private Delays()
        {
        }

        #endregion
    }
}


namespace R5T.Z0041.Conventional
{
    public class Delays : IDelays
    {
        #region Infrastructure

        public static IDelays Instance { get; } = new Delays();


        private Delays()
        {
        }

        #endregion
    }
}


namespace R5T.Z0041.Raw
{
    public class Delays : IDelays
    {
        #region Infrastructure

        public static IDelays Instance { get; } = new Delays();


        private Delays()
        {
        }

        #endregion
    }
}
