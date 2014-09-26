namespace HTMLDispatcher
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    
    public class ElementBuilder
    {
        public string ElementName { get; private set; }
        public string Attribute { get; private set; }
        public string Value { get; private set; }
        public string Content { get; private set; }

        public ElementBuilder(string name)
        {
            this.ElementName = name;  
        }

        Dictionary<string, string> attributes = new Dictionary<string, string>();

        public void AddElement(string attribute, string value)
        {
            attributes.Add(attribute, value);
        }

        public string AddContent(string content)
        {
            this.Content = ">" + content;
            return this.Content;
        }

        public static string operator * (ElementBuilder input, int count) 
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                sb.Append(input.ToString());
                sb.Append("\r\n");
            }

            return sb.ToString();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("<{0}", this.ElementName);

            foreach (var pair in attributes)
            {
                sb.AppendFormat(" \"{0}\"=\"{1}\"", pair.Key, pair.Value);
            }

            if (this.Content != null)
            {
                sb.Append(this.Content);
                sb.AppendFormat("</{0}>", this.ElementName);
            }
            else
            {
                sb.AppendFormat("></{0}>", this.ElementName);
            }

            return sb.ToString();
        }
    }
}
