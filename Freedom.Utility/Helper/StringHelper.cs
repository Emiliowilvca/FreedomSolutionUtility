using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Web;

namespace Freedom.Utility
{
    public static class StringHelper
    {
        public static string Truncate(this string source, int startIndex = 0, int lenght = 50)
        {
            return source.Substring(startIndex, Math.Min(source.Length - startIndex, lenght));
        }

        public static string RepeatStr(this string str, int count)
        {
            return Enumerable.Repeat(str, count)
                             .Aggregate(
                                new StringBuilder(),
                                (sb, s) => sb.Append(s))
                             .ToString();
        }

        /// <summary>
        /// Transforma la cultura de una letra a su representación equivalente en la tabla 0-127 ascii, como la letra 'é' se sustituye por una 'e'
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string RemoveDiacritics(this string str)
        {
            return new string(str.Normalize(NormalizationForm.FormD)
               .Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
               .ToArray());
        }

        /// <summary>
        /// alineada a la derecha y rellenada a la izquierda con caractesres paddingChar
        /// </summary>
        /// <param name="source"></param>
        /// <param name="length"></param>
        /// <param name="pading"></param>
        /// <returns></returns>
        public static string ChunkLeft(this string source, int length, char pading = ' ')
        {
            if (string.IsNullOrEmpty(source))
            {
                source = "";
            }
            var newstring = source.PadLeft(length, pading);
            return newstring?.Substring(newstring.Length - length, length) ?? "";
        }

        /// <summary>
        /// alineada a la izquierda y rellenada a la derecha con caracteres paddingChar
        /// </summary>
        /// <param name="source"></param>
        /// <param name="length"></param>
        /// <param name="pading"></param>
        /// <returns></returns>
        public static string ChunkRight(this string source, int length, char pading = ' ')
        {
            if (string.IsNullOrEmpty(source))
            {
                source = "";
            }
            var newstring = source.PadRight(length, pading);
            return newstring?.Substring(0, length) ?? "";
        }

        /// <summary>
        /// dividir la cadena en líneas con la longitud máxima, sin romper palabras
        /// </summary>
        /// <param name="text"></param>
        /// <param name="maxLineLength"></param>
        /// <returns></returns>
        public static List<string> WordWrap(this string text, int maxLineLength)
        {
            var list = new List<string>();

            int currentIndex;
            var lastWrap = 0;
            var whitespace = new[] { ' ', '\r', '\n', '\t' };
            do
            {
                currentIndex = lastWrap + maxLineLength > text.Length ? text.Length : (text.LastIndexOfAny(new[] { ' ', ',', '.', '?', '!', ':', ';', '-', '\n', '\r', '\t' }, Math.Min(text.Length - 1, lastWrap + maxLineLength)) + 1);
                if (currentIndex <= lastWrap)
                    currentIndex = Math.Min(lastWrap + maxLineLength, text.Length);
                list.Add(text.Substring(lastWrap, currentIndex - lastWrap).Trim(whitespace));
                lastWrap = currentIndex;
            } while (currentIndex < text.Length);

            return list;
        }


        public static string CharToZplBarcode(string description)
        {
            Dictionary<string, string> specialChars = new Dictionary<string, string>();
            specialChars.Add("ñ", "_A4");
            specialChars.Add("Ñ", "_A5");
            specialChars.ToList().ForEach(x => description = description.Replace(x.Key, x.Value));
            return description;
        }



        public static string GetSubString(this string currentText, int length = 50)
        {
            return currentText.Length > length ? currentText.Substring(0, length) : currentText;
        }

        public static string GetSubString(this string currentText, int startindex = 0, int length = 50)
        {
            return currentText.Length > length ? currentText.Substring(startindex, length) : currentText;
        }

        public static string NullIfEmpty(this string s)
        {
            return string.IsNullOrEmpty(s) ? null : s;
        }

        public static string NullIfWhiteSpace(this string s)
        {
            return string.IsNullOrWhiteSpace(s) ? null : s;
        }

        /// <summary>
        /// convert obj to querystring
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string BuildQueryString<T>(this T obj)
        {
            NameValueCollection queryString = HttpUtility.ParseQueryString(string.Empty);

            foreach (PropertyDescriptor property in TypeDescriptor.GetProperties(typeof(T)).Cast<PropertyDescriptor>())
            {
                string value = (property.GetValue(obj) ?? "").ToString();
                queryString.Add(property.Name, value);
            }
            return queryString.ToString();
        }

        /// <summary>
        /// Remove chars on string
        /// </summary>
        /// <param name="str">all string</param>
        /// <param name="charsToRemove">chars list to remove in string </param>
        /// <returns></returns>
        public static string RemoveFilter(this string str, List<char> charsToRemove)
        {
            charsToRemove.ForEach(c => str = str.Replace(c.ToString(), String.Empty));
            return str;
        }

        /// <summary>
        /// remove all white spaces in the string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string RemoveWhiteSpace(this string str)
        {
            return new string(str.Where(c => !Char.IsWhiteSpace(c)).ToArray());
        }

        /// <summary>
        /// Converts a string in a URL decoded
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ToUrlDecode(this string str)
        {
            return HttpUtility.UrlDecode(str);
        }

        /// <summary>
        ///La codificación de URL reemplaza los caracteres ASCII no seguros con un "%" seguido de dos dígitos hexadecimales.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ToUrlEncodeClient(this string str)
        {
            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("%", "%25");
            map.Add(" ", "%20");
            map.Add("!", "%21");
            map.Add("\"", "%22");
            map.Add("#", "%23");
            map.Add("$", "%24");
            map.Add("&", "%26");
            map.Add("'", " %27");
            map.Add("(", "%28");
            map.Add(")", "%29");
            map.Add("*", "%2A");
            map.Add("+", "%2B");
            map.Add(",", "%2C");
            map.Add("-", "%2D");
            map.Add(".", "%2E");
            map.Add("/", "%2F");
            map.Add(":", "%3A");
            map.Add(";", "%3B");
            map.Add("<", "%3C");
            map.Add("=", "%3D");
            map.Add(">", "%3E");
            map.Add("?", "%3F");
            map.Add("@", "%40");
            map.Add("[", "%5B");
            map.Add("]", "%5D");
            map.Add("^", "%5E");
            map.Add("_", "%5F");
            map.Add("`", "%60");
            map.Add("{", "%7B");
            map.Add("|", "%7C");
            map.Add("}", "%7D");
            map.Add("~", "%7E");

            StringBuilder sb = new StringBuilder();
            foreach (var item in str.ToArray())
            {
                string st = item.ToString();
                if (map.ContainsKey(item.ToString()))
                {
                    var valuepar = map.TryGetValue(item.ToString(), out st);
                }
                sb.Append(st);
            }
            return sb.ToString();
        }
    }
}