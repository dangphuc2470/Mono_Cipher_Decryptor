using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterReplace
{
    internal class Letter
    {
        public char? letter = null;
        public bool isReplaced = false;
        public char? orgLetter = null;
        public Letter(char letter)
        {
            this.letter = letter;
            this.orgLetter = letter;
        }
    }
}
