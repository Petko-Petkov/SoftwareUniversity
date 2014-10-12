namespace StringDisperser
{
    using System;
    using System.Collections;

    public class StringDisperser : ICloneable, IComparable<StringDisperser>, IEnumerable
    {
        public string Text { get; set; } 

        public StringDisperser(params string[] paramsStrings)
        {
            foreach (var pS in paramsStrings)
            {
                this.Text += pS;
            }
        }

        public override bool Equals(object obj)
        {
            StringDisperser strDisperser = obj as StringDisperser;

            if (strDisperser == null)
            {
                return false;
            }

            if (!this.Text.Equals(strDisperser))
            {
                return false;
            }

            return true;
        }

        public static bool operator ==(StringDisperser firstDisperser, StringDisperser seconDisperser)
        {
            return Equals(firstDisperser, seconDisperser);
        }

        public static bool operator !=(StringDisperser firstDisperser, StringDisperser secondDisperser)
        {
            return !Equals(firstDisperser, secondDisperser);
        }

        public override string ToString()
        {
            return this.Text;
        }

        public override int GetHashCode()
        {
            return this.Text.GetHashCode();
        }

        public object Clone()
        {
            char[] output = new char[this.Text.Length];

            for (int i = 0; i < output.Length; i++)
            {
                output[i] = this.Text[i];
            }

            return new StringDisperser(string.Join("", output));
        }

        public int CompareTo(StringDisperser other)
        {
            return this.Text.CompareTo(other.Text);
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var ch in this.ToString().ToCharArray())
            {
                yield return ch;
            }
        }
    }
}
