using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using System.Text.Json;
using System.Web;

namespace Freedom.Utility
{
    public static class StringHelper
    {
        public const string PatterRemoveCharInInsert = @"#@`\»«!~%^&[]{}+=|:'<>,*;";

        public const string PatterRemovedCharInSelect = @"#@`\»«!~^&[]{}+=|:'<>,;";

        public static string Truncate(this string source, int startIndex = 0, int lenght = 50)
        {
            return source.Substring(startIndex, Math.Min(source.Length - startIndex, lenght));
        }

        public static string Truncate(this string source, int lenght)
        {
            int startIndex = 0;
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
        ///
        /// </summary>
        /// <param name="source"></param>
        /// <param name="totalWidth"></param>
        /// <param name="filled"></param>
        /// <returns></returns>
        public static string CenterInString(this string source, int totalWidth, char filled = ' ')
        {
            string str = source.Truncate(totalWidth).Trim();
            int spacesToAdd = totalWidth - str.Length;
            int leftSpaces = spacesToAdd / 2;
            int rightSpaces = spacesToAdd - leftSpaces;
            return new string(filled, leftSpaces) + str + new string(filled, rightSpaces);
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
        /// Remove chars on string,does not contain predefined elements
        /// </summary>
        /// <param name="str">all string</param>
        /// <param name="charsToRemove">chars list to remove in string, does not contain predefined elements </param>
        /// <returns></returns>
        public static string RemoveFilter(this string str, List<char> charsToRemove)
        {
            charsToRemove.ForEach(c => str = str.Replace(c.ToString(), string.Empty));
            return str;
        }

        /// <summary>
        /// remove Special Chars
        /// </summary>
        /// <param name="str"></param>
        /// <param name="charsToRemove"></param>
        /// <returns></returns>
        public static string RemoveFilter(this string str, char[] charsToRemove)
        {
            charsToRemove.ToList().ForEach(c => str = str.Replace(c.ToString(), string.Empty));
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
        /// <para>convert a string that been encoded for transmission in a url into a decoding string.</para>
        /// <para>convertir una cadena que ha sido codificada para su transmisión en una URL en una cadena de decodificación string.</para>
        ///
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ToUrlDecode(this string str)
        {
            return HttpUtility.UrlDecode(str);
        }

        /// <summary>
        /// <para> Trims the whitespace from both ends of the string. Whitespace is defined by
        /// char.IsWhiteSpace. </para>
        /// <para> Creates a copy of this string in upper case. The culture is set by culture.</para>
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ToTrimUppercase(this string str)
        {
            return str.Trim().ToUpper();
        }

        /// <summary>
        ///La codificación de URL reemplaza los caracteres ASCII no seguros con un "%" seguido de dos dígitos hexadecimales.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ToUrlEncodeClient(this string str)
        {
            Dictionary<string, string> map = new()
            {
                { "%", "%25" },
                { " ", "%20" },
                { "!", "%21" },
                { "\"", "%22" },
                { "#", "%23" },
                { "$", "%24" },
                { "&", "%26" },
                { "'", "%27" },
                { "(", "%28" },
                { ")", "%29" },
                { "*", "%2A" },
                { "+", "%2B" },
                { ",", "%2C" },
                { "-", "%2D" },
                { ".", "%2E" },
                { "/", "%2F" },
                { ":", "%3A" },
                { ";", "%3B" },
                { "<", "%3C" },
                { "=", "%3D" },
                { ">", "%3E" },
                { "?", "%3F" },
                { "@", "%40" },
                { "[", "%5B" },
                { "]", "%5D" },
                { "^", "%5E" },
                { "_", "%5F" },
                { "`", "%60" },
                { "{", "%7B" },
                { "|", "%7C" },
                { "}", "%7D" },
                { "~", "%7E" }
            };

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

        /// <summary>
        /// Remove Special chars , already contains elements
        /// </summary>
        /// <param name="source">source</param>
        /// <param name="specialCharacters">predefined elements</param>
        /// <returns></returns>
        public static string RemoveSpecialCharacters(this string source, string specialCharacters = PatterRemoveCharInInsert)
        {
            if (string.IsNullOrEmpty(specialCharacters))
                return "";
            return string.Join("", source.ToCharArray().Where(x => !specialCharacters.Contains(x)).Select(x => x));
        }

        /// <summary>
        /// Convert json string to collection
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="detailJson"></param>
        /// <returns></returns>
        public static IEnumerable<TEntity> JsonToCollection<TEntity>(this string detailJson) where TEntity : class
        {
            if (string.IsNullOrEmpty(detailJson))
            {
                return Enumerable.Empty<TEntity>();
            }
            return JsonSerializer.Deserialize<IEnumerable<TEntity>>(detailJson, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        /// <summary>
        /// Convert json string to Entity
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="detailJson"></param>
        /// <returns></returns>
        public static TEntity JsonToEntity<TEntity>(this string detailJson) where TEntity : class
        {
            if (string.IsNullOrEmpty(detailJson))
                return null;
            return JsonSerializer.Deserialize<IEnumerable<TEntity>>(detailJson,
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true })
                .FirstOrDefault();
        }
    }
}