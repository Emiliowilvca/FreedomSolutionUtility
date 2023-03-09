namespace Freedom.Utility.Helper
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
                if (type == typeof(byte) ||
                    type == typeof(short) ||
                    type == typeof(int) ||
                    type == typeof(long) ||
                    type == typeof(float) ||
                    type == typeof(double))
                {
                    pi.SetValue(entity, 0, null);
                }
                if (type == typeof(decimal))
                {
                    pi.SetValue(entity, 0m, null);
                }
                if (type == typeof(string))
                {
                    pi.SetValue(entity, string.Empty, null);
                }
                if (type == typeof(bool))
                {
                    pi.SetValue(entity, false, null);
                }
                if (type == typeof(DateTime) || type == typeof(DateTimeOffset))
                {
                    pi.SetValue(entity, DateTime.UtcNow, null);
                }
                if (type == typeof(Guid))
                {
                    pi.SetValue(entity, Guid.Empty, null);
                }
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
                    pi.SetValue(entity, value.PreventSqlInjectionAttack(), null);
                }
            }
            return entity as T;
        }
    }
}