using System.Reflection;

namespace Freedom.Utility
{
    public static class DbExtension
    {
        
        /// <summary>
        /// Conver
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="nameSuggestion"></param>
        /// <param name="excludeColumns"></param>
        /// <returns></returns>
        public static string ToSqlSelect<T>(string nameSuggestion = "", string[] excludeColumns = null) where T : class
        {
            nameSuggestion = string.IsNullOrEmpty(nameSuggestion) ? typeof(T).Name.ToLower() : nameSuggestion;

            if (excludeColumns == null)
            {
                excludeColumns = Array.Empty<string>();
            }
            List<string> columCollection = new();
            foreach (PropertyInfo propertyInfo in typeof(T).GetProperties()
                    .Where(x => !excludeColumns.Contains(x.Name)))
            {
                Type type = propertyInfo.PropertyType;
                if (type.IsSqlDataType())
                {
                    columCollection.Add($"`{nameSuggestion}`.`{propertyInfo.Name}`");
                }
            }
            return string.Join(',', columCollection);
        }

        /// <summary>
        /// Chek if type is string or bool or int or date or etc...
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool IsSqlDataType(this Type type)
        {
            return type == typeof(string) ||
                     type == typeof(bool) ||
                     type == typeof(long) ||
                     type == typeof(int) ||
                     type == typeof(short) ||
                     type == typeof(double) ||
                     type == typeof(float) ||
                     type == typeof(decimal) ||
                     type == typeof(char) ||
                     type == typeof(byte[]) ||
                     type == typeof(byte) ||
                     type == typeof(DateTime) ||
                     type == typeof(DateTimeOffset) ||
                     type == typeof(Guid);
        }

        /// <summary>
        /// Agregate LIKE mysql special char % and prevent Sql Injection
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string ToSqlLike(this string source)
        {
            return string.Concat(source.PreventSqlInjectionAttack().Replace("*", "%"), "%");
        }

        public static string ToDbName(this Type type)
        {
            return type.Name.ToLower();
        }
         

        /// <summary>
        /// Replace and prevent Sql Ineject Attack
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string PreventSqlInjectionAttack(this string source)
        {
            return source.ToUpper()
                         .Replace("--", string.Empty)
                         .Replace("/*", string.Empty)
                         .Replace("*/", string.Empty)
                         .Replace("DELETE", string.Empty)
                         .Replace("INSERT", string.Empty)
                         .Replace("UPDATE", string.Empty)
                         .Replace("DROP", string.Empty)
                         .Replace("TABLE", string.Empty)
                         .Replace("FROM", string.Empty)
                         .Replace("WHERE", string.Empty)
                         .Replace("TRUNCATE", string.Empty)
                         .Replace("SELECT", string.Empty)
                         .Replace("CHAR", string.Empty)
                         .Replace("NVARCHAR", string.Empty)
                         .Replace("VARCHAR", string.Empty)
                         .Replace("ALTER", string.Empty)
                         .Replace("BEGIN", string.Empty)
                         .Replace("CAST", string.Empty)
                         .Replace("CREATE", string.Empty)
                         .Replace("DECLARE", string.Empty)
                         .Replace("CURSOR", string.Empty)
                         .Replace("END", string.Empty)
                         .Replace("EXEC", string.Empty)
                         .Replace("EXECUTE", string.Empty)
                         .Replace("FETCH", string.Empty)
                         .Replace("KILL", string.Empty)
                         .Replace("SYS", string.Empty)
                         .Replace("SYSOBJECT", string.Empty)
                         .Replace("SYSCOLUMN", string.Empty)
                         .Replace("DATABASE", string.Empty)
                         .Replace("  ", " ")
                         .Trim();
        }

        /// <summary>
        /// sql parameter contain Truncate, RemoveSpecialChar, PreventSqlInjectionAttack, Trim, UpperCase
        /// </summary>
        /// <param name="source"></param>
        /// <param name="lenght"></param>
        /// <returns></returns>
        public static string ToSqlParameter(this string source, int lenght = 50)
        {
            if (source == null)
                return string.Empty;

            return source.Truncate(lenght)
                         .RemoveSpecialCharacters()
                         .PreventSqlInjectionAttack()
                         .Trim();
        }         
       
    }
}