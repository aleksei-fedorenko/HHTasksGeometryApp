namespace GeometryLibrary.Helpers
{
    /// <summary>
    /// Helper containing methods for validating parameters
    /// </summary>
    public static class ValidationHelper
    {
        /// <summary>
        /// Method that throws an exception if value in <paramref name="value"/>
        /// is not normal, either less than or equal to 0
        /// </summary>
        /// <param name="value">Value to check</param>
        /// <param name="valueName">
        /// Name of field whose value is passed to <paramref name="value"/>
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// If value in <paramref name="value"/>
        /// is not normal, either less than or equal to 0
        /// </exception>
        public static void ThrowIfOutOfNormalPositiveRange(this double value, string valueName)
        {
            if (value <= 0 || !double.IsNormal(value))
            {
                throw new ArgumentOutOfRangeException(valueName, "The number must be normal and greater than 0.");
            }
        }
    }
}