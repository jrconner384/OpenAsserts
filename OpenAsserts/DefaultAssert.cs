using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenAsserts
{
    /// <summary>
    /// Asserts concerning <see cref="default"/> values.
    /// </summary>
    public static class DefaultAssert
    {
        #region Are/Not
        /// <summary>
        /// Asserts that each element in <paramref name="actual"/> is equal to the <c>default</c> for its type.
        /// </summary>
        /// <typeparam name="T">The type of the object to assert on.</typeparam>
        /// <param name="actual">The collection of objects to assert are equal to the default value of its type.</param>
        public static void AreDefault<T>(List<T> actual) => actual.ForEach(a => IsDefault(a));

        /// <summary>
        /// Asserts that each element in <paramref name="actual"/> is equal to the <c>default</c> for its type.
        /// </summary>
        /// <typeparam name="T">The type of the object to assert on.</typeparam>
        /// <param name="actual">The collection of objects to assert are equal to the default value of its type.</param>
        /// <param name="message">The message to output to the test runner if the assert fails.</param>
        public static void AreDefault<T>(List<T> actual, string message) => actual.ForEach(a => IsDefault(a, message));

        /// <summary>
        /// Asserts that no elements in <paramref name="actual"/> are equal to the <c>default</c> for its type.
        /// </summary>
        /// <typeparam name="T">The type of the object to assert on.</typeparam>
        /// <param name="actual">The collection of objects to assert are not equal to the default value of its type.</param>
        public static void AreNotDefault<T>(List<T> actual) => actual.ForEach(a => IsNotDefault(a));

        /// <summary>
        /// Asserts that no elements in <paramref name="actual"/> are equal to the <c>default</c> for its type.
        /// </summary>
        /// <typeparam name="T">The type of the object to assert on.</typeparam>
        /// <param name="actual">The collection of objects to assert are not equal to the default value of its type.</param>
        /// <param name="message">The message to output to the test runner if the assert fails.</param>
        public static void AreNotDefault<T>(List<T> actual, string message) => actual.ForEach(a => IsNotDefault(a, message));
        #endregion Are/Not

        #region Is/Not
        /// <summary>
        /// Asserts that <paramref name="actual"/> is equal to the <c>default</c> for its type.
        /// </summary>
        /// <typeparam name="T">The type of the object to assert on.</typeparam>
        /// <param name="actual">The object to assert is equal to the default value of its type.</param>
        public static void IsDefault<T>(T actual) => Assert.AreEqual(default(T), actual);

        /// <summary>
        /// Asserts that <paramref name="actual"/> is equal to the <c>default</c> for its type.
        /// </summary>
        /// <typeparam name="T">The type of the object to assert on.</typeparam>
        /// <param name="actual">The object to assert is equal to the default value of its type.</param>
        /// <param name="message">The message to output to the test runner if the assert fails.</param>
        public static void IsDefault<T>(T actual, string message) => Assert.AreEqual(default(T), actual, message);

        /// <summary>
        /// Asserts that <paramref name="actual"/> is not equal to the <c>default</c> for its type.
        /// </summary>
        /// <typeparam name="T">The type of the object to assert on.</typeparam>
        /// <param name="actual">The object to assert is not equal to the default value of its type.</param>
        public static void IsNotDefault<T>(T actual) => Assert.AreNotEqual(default(T), actual);

        /// <summary>
        /// Asserts that <paramref name="actual"/> is not equal to the <c>default</c> for its type.
        /// </summary>
        /// <typeparam name="T">The type of the object to assert on.</typeparam>
        /// <param name="actual">The object to assert is not equal to the default value of its type.</param>
        /// <param name="message">The message to output to the test runner if the assert fails.</param>
        public static void IsNotDefault<T>(T actual, string message) => Assert.AreNotEqual(default(T), actual, message);
        #endregion Is/Not
    }
}
