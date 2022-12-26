namespace Freedom.Utility.CloneObject
{
    public static class CloneModel
    {
        public static T CloneJson<T>(this T theObject) where T : class
        {
            string jsonData = System.Text.Json.JsonSerializer.Serialize(theObject);
            return System.Text.Json.JsonSerializer.Deserialize<T>(jsonData);
        }
    }
}