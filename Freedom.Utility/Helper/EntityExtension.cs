namespace Freedom.Utility
{
    public static class EntityExtension
    {
        /// <summary>
        /// Remove spaces and convert to UpperCase in all string properties values
        /// </summary>
        /// <typeparam name="T">Entity type</typeparam>
        /// <param name="entity">Model</param>
        /// <returns></returns>
        public static T ToTrimUpperCase<T>(this T entity) where T : class
        {
            var propertyInfo = entity.GetType().GetProperties();

            foreach (var pi in propertyInfo)
            {
                if (pi.PropertyType == typeof(string))
                {
                    string value = (string)pi.GetValue(entity, null);
                    pi.SetValue(entity, value.Trim().ToUpper(), null);
                }
            }
            return entity;
        }

        /// <summary>
        /// prevents sql attack to the minimum
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static T PreventSqlInjectionMinimal<T>(this T entity) where T : class
        {
            var propertyInfo = entity.GetType().GetProperties();

            foreach (var pi in propertyInfo)
            {
                if (pi.PropertyType == typeof(string))
                {
                    string value = (string)pi.GetValue(entity, null);
                    pi.SetValue(entity, value.PreventSqlInjectionAttackMinimal(), null);
                }
            }
            return entity;
        }

        /// <summary>
        /// Remove spaces and convert to UpperCase in all string properties values
        /// </summary>
        /// <typeparam name="T">Entity Type</typeparam>
        /// <param name="entity">Model</param>
        /// <param name="excludeProperties">Exclude properties by Name</param>
        /// <returns></returns>
        public static T ToTrimUpperCase<T>(this T entity, string[] excludeProperties) where T : class
        {
            string[] exclude = excludeProperties ?? Array.Empty<string>();

            var propertyInfo = entity.GetType().GetProperties().Where(x => !exclude.Contains(x.Name));

            foreach (var pi in propertyInfo)
            {
                if (pi.PropertyType == typeof(string))
                {
                    string value = (string)pi.GetValue(entity, null);
                    pi.SetValue(entity, value.Trim().ToUpper(), null);
                }
            }
            return entity;
        }

        public static T ResetEntity<T>(this T entity) where T : class
        {
            var propertyInfo = entity.GetType().GetProperties();
            foreach (var pi in propertyInfo)
            {
                Type type = pi.PropertyType;
                if (type == typeof(byte)) { pi.SetValue(entity, (byte)0); }
                if (type == typeof(short)) { pi.SetValue(entity, (short)0); }
                if (type == typeof(int)) { pi.SetValue(entity, 0); }
                if (type == typeof(long)) { pi.SetValue(entity, (long)0); }
                if (type == typeof(float)) { pi.SetValue(entity, 0.0f); }
                if (type == typeof(double)) { pi.SetValue(entity, 0.0d); }
                if (type == typeof(decimal)) { pi.SetValue(entity, 0.0m); }
                if (type == typeof(string)) { pi.SetValue(entity, string.Empty); }
                if (type == typeof(bool)) { pi.SetValue(entity, false); }
                if (type == typeof(DateTime)) { pi.SetValue(entity, DateTime.UtcNow); }
                if (type == typeof(DateTimeOffset)) { pi.SetValue(entity, DateTime.UtcNow); }
                if (type == typeof(Guid)) { pi.SetValue(entity, Guid.Empty); }
            }
            return entity;
        }

        /// <summary>
        /// prevent Sql Ineject Attack in Model (each all string in model and replace special char and sqlInjection commands)
        /// </summary>
        /// <typeparam name="T">Entity or Model to database </typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static T PreventSqlInjection<T>(this T entity) where T : class
        {
            if (entity == null)
                return default(T);

            var propertyInfo = entity.GetType().GetProperties();

            foreach (var pi in propertyInfo)
            {
                if (pi.PropertyType == typeof(string))
                {
                    string value = (string)pi.GetValue(entity, null);
                    pi.SetValue(entity, value.PreventSqlInjectionAttack(), null);
                }
            }
            return entity as T;
        }

        /// <summary>
        /// prevent Sql Ineject Attack in Model (each all string in model and replace special char and sqlInjection commands)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <param name="excludeProperties"></param>
        /// <returns></returns>
        public static T PreventSqlInjection<T>(this T entity, string[] excludeProperties) where T : class
        {
            if (entity == null)
                return default(T);
            string[] exclude = excludeProperties ?? Array.Empty<string>();
            var propertyInfo = entity.GetType().GetProperties().Where(x => !exclude.Contains(x.Name));

            foreach (var pi in propertyInfo)
            {
                if (pi.PropertyType == typeof(string))
                {
                    string value = (string)pi.GetValue(entity, null);
                    pi.SetValue(entity, value.RemoveSpecialCharacters().PreventSqlInjectionAttack(), null);
                }
            }
            return entity as T;
        }

        /// <summary>
        /// property selector from entity and check if null
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="source"></param>
        /// <param name="propertySelector"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static string MapStringOrDefault<TSource>(this TSource source, Func<TSource, string> propertySelector, string defaultValue = "")
        {
            return source != null ? propertySelector(source) : defaultValue;
        }

        /// <summary>
        /// use in automapper
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TDestination"></typeparam>
        /// <param name="source"></param>
        /// <param name="propertySelector"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static TDestination MapEntityOrDefault<TSource, TDestination>(this TSource source, Func<TSource, TDestination> propertySelector,
                                                                                   TDestination defaultValue)
        {
            return source != null ? propertySelector(source) : defaultValue;
        }

        /// <summary>
        /// use in Automapper
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TDestination"></typeparam>
        /// <param name="source"></param>
        /// <param name="propertySelector"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>

        public static TDestination MapCollectionOrDefault<TSource, TDestination>(this IEnumerable<TSource> source, Func<TSource, TDestination> propertySelector,
                                                                               TDestination defaultValue)
        {
            if (source == null || !source.Any())
                return defaultValue;

            return source != null ? propertySelector(source.FirstOrDefault()) : defaultValue;
        }
    }
}