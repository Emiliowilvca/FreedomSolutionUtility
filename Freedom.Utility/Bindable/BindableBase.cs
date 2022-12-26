using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Freedom.Utility.Bindable
{
    /// <summary>
    /// Bindable base
    /// </summary>
    public abstract class BindableBase : INotifyPropertyChanged, ICloneable
    {
        /// <summary>
        /// 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="storage"></param>
        /// <param name="value"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(storage, value))
            {
                return false;
            }
            storage = value;
            this.RaisePropertyChanged(propertyName);
            return true;
        }

        protected void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public virtual object Clone()
        {
            return this.MemberwiseClone();
        }

        public void NotifyAllPropertiesChanged()
        {
            Type t = this.GetType();
            PropertyInfo[] properties = t.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo info in properties)
            {
                this.RaisePropertyChanged(info.Name);
            }
        }

        public static T CopyClass<T>(T obj)
        {
            T objcpy = (T)Activator.CreateInstance(typeof(T));
            foreach (PropertyInfo prop in obj.GetType().GetProperties())
            {
                object value = prop.GetValue(obj);
                objcpy.GetType().GetProperty(prop.Name).SetValue(objcpy, value);
            }
            return objcpy;
        }

        /// <summary>
        /// clear Dto entity, solo es eredable
        /// </summary>
        public virtual void ResetEntity()
        {
        }
    }
}