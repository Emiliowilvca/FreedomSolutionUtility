using System;
using System.Collections.Generic;
using System.Linq;

namespace Freedom.Utility
{
    public static class RandomExtension
    {

        private readonly static Random rnd = new Random();

        /// <summary>
        /// use external random
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="rdn"></param>
        /// <returns>Entity T </returns>
        public static T PickRandom<T>(this IList<T> source, Random rdn)
        {
            return source[rdn.Next(source.Count)];
        }

        /// <summary>
        /// simple ramdom 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns> retur T</returns>
        public static T PickRandom<T>(this IList<T> source)
        {
            Random random = new Random();
            return source[random.Next(source.Count)];
        }

        /// <summary>
        /// result does not exceed the number of items in the list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static IEnumerable<T> PickRandom<T>(this IList<T> source, int count)
        {
            return source.OrderBy(x => rnd.Next()).Take(count);
        }

        /// <summary>
        /// result can exceed the number of items in the original list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static IEnumerable<T> PickRandomOver<T>(this IList<T> source, int count)
        {

            Random rnd = new Random();

            List<T> collection = new List<T>();

            for (var i = 0; i < count; i++)
            {
                collection.Add(source[rnd.Next(source.Count)]);
            }
            return collection.AsEnumerable();
        }

    }
}