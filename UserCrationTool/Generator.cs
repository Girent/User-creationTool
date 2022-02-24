using System;
using System.Text;

namespace UserCrationTool
{
    internal class Generator
    {
        private readonly Random random = new Random();
        public string generatePass()
        {
            var passwordBuilder = new StringBuilder();

            passwordBuilder.Append(random_String(4, true));

            passwordBuilder.Append(random_Number(1000, 9999));

            passwordBuilder.Append(random_String(2));
            return passwordBuilder.ToString();
        }
    
        private int random_Number(int min, int max)
        {
            return random.Next(min, max);
        }

        private string random_String(int size, bool lowerCase = false)
        {
            var builder = new StringBuilder(size);
 
            char offset = lowerCase ? 'a' : 'A';
            const int lettersOffset = 26; // A...Z or a..z: length=26  

            for (var i = 0; i < size; i++)
            {
                var @char = (char)random.Next(offset, offset + lettersOffset);
                builder.Append(@char);
            }

            return lowerCase ? builder.ToString().ToLower() : builder.ToString();
        }
    }
}
