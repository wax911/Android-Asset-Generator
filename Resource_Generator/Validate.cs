using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Resource_Generator
{
    class Validate
    {
        private static string rule;
        private static Regex regex;
        private static readonly string[] rules = { @"^[a-zA-Z]+$", @"^[0-9]+$", @"^[A-Za-z0-9]+$"};

        public bool Validator(string info, RulesEx eRegex)
        {
            #region Rule
            switch (eRegex)
            {
                case RulesEx.letters:
                    rule = rules[0];
                    break;
                case RulesEx.numbers:
                    rule = rules[1];
                    break;
                case RulesEx.numberandletters:
                    rule = rules[2];
                    break;
                default:
                    break;
            }
            #endregion
            regex = new Regex(rule);

            return regex.IsMatch(info);
        }
    }
}
