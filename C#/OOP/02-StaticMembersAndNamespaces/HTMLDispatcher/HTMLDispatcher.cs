namespace HTMLDispatcher
{
    public static class HTMLDispatcher
    {
        public static ElementBuilder CreateImage(string imageSource, string alternative, string imageTitle)
        {
            ElementBuilder image = new ElementBuilder("img");

            image.AddElement("src", imageSource);
            image.AddElement("alt", alternative);
            image.AddElement("title", imageTitle);

            return image;
        }

        public static ElementBuilder CreateURL (string url, string title, string text)
        {
            ElementBuilder uri = new ElementBuilder("a");

            uri.AddElement("href", url);
            uri.AddElement("title", title);
            uri.AddElement("text", text);

            return uri;
        }

        public static ElementBuilder CreateInput (string inputType, string name, string value)
        {
            ElementBuilder input = new ElementBuilder("input");

            input.AddElement("type", inputType);
            input.AddElement("name", name);
            input.AddElement("value", value);

            return input;
        }
    }
}
