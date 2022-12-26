using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Freedom.Utility
{
    public class BulkObservableCollection<T> : ObservableCollection<T>
    {
        private bool deferNotification = false;

        public void AddRange(IEnumerable<T> collection)
        {
            deferNotification = true;
            foreach (T itm in collection)
            {
                this.Add(itm);
            }
            deferNotification = false;
            OnCollectionChanged(new System.Collections.Specialized.NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
        }

        public void RemoveRange(IEnumerable<T> collection)
        {
            deferNotification = true;
            foreach (T itm in collection)
            {
                this.Remove(itm);
            }
            deferNotification = false;
            OnCollectionChanged(new System.Collections.Specialized.NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
        }

        protected override void OnCollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (!deferNotification)
            {
                base.OnCollectionChanged(e);
            }
        }
    }
}