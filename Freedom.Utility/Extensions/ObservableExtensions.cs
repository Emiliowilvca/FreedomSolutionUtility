using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Freedom.Utility
{
    public static class ObservableExtensions
    {
        public static void AddRange<T>(this ObservableCollection<T> observableCollection, IEnumerable<T> rangeList)
        {
            foreach (T item in rangeList)
            {
                observableCollection.Add(item);
            }
        }

        public static int RemoveAll<T>(this ObservableCollection<T> observableCollection, Func<T, bool> condition)
        {
            var toRemove = observableCollection
                           .Where(condition)
                           .ToList();
            return toRemove.Count(observableCollection.Remove);
        }

        public static void RemoveAll<T>(this ObservableCollection<T> observableCollection)
        {
            foreach (T item in observableCollection.ToList())
            {
                observableCollection.Remove(item);
            }
        }

        public static ObservableCollection<T> CloneObservable<T>(this IList<T> listToClone) where T : ICloneable
        {
            return listToClone.Select(item => (T)item.Clone()).ToList() as ObservableCollection<T>;
        }

        public static IList<T> Clone<T>(this IList<T> listToClone) where T : ICloneable
        {
            return listToClone.Select(item => (T)item.Clone()).ToList();
        }
    }
}