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

    }
}