using System;

namespace Freedom.Utility.Helper
{
    public static class ThrowHelper
    {
        public static void ThrowIfNull(this object obj, string objName)
        {
            if (obj == null)
                throw new Exception(string.Format("{0} is null.", objName));
        }

        /// <summary>
        /// Throw exception if string contain sql attack injection
        /// </summary>
        /// <param name="source"></param>
        /// <exception cref="Exception"></exception>
        public static void ThrowIfSqlInjectionAttack(this string source)
        {
            if (source == null)
                return;

            string[] attackwords =
            {
                "DELETE",
                "INSERT",
                "UPDATE",
                "DROP",
                "TABLE",
                "FROM",
                "WHERE",
                "TRUNCATE",
                "SELECT",
                "CHAR",
                "NVARCHAR",
                "VARCHAR",
                "ALTER",
                "BEGIN",
                "CAST",
                "CREATE",
                "CURSOR",
                "DECLARE",
                "END",
                "EXEC",
                "EXECUTE",
                "FETCH",
                "KILL",
                "SYS",
                "SYSOBJECT",
                "SYSCOLUMN",
                "DATABASE",
                "@@",
                "--",
                "1=1"

            };
            if (attackwords.Any(x => source.ToUpper().Contains(x)))
            {
                throw new Exception(string.Format("Warning!!!, Malicious SQL Cyberattack: {0}", source));
            }
        }
    }
}