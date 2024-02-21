using System;
using System.Collections.Generic;
using System.Linq;

namespace SwinAdventureProg
{
    public class IdentifiableObject
    {
        private List<string> _identifiers;


        public IdentifiableObject(string[] idents)
        {
            _identifiers = new List<string>();
            for (int i = 0; i < idents.Length; i++)
            {
                _identifiers.Add(idents[i].ToLower());
            }
            
        }

        public bool AreYou(string id)
        {
            bool found = _identifiers.Contains(id.ToLower());
            return found;
        }

        public string FirstId()
        {
            if (_identifiers.Count() == 0)
            {
                return "";
            }
            else
            {
                return _identifiers.First();
            }
            
        }

        public void AddIdentifier(string id)
        {
            _identifiers.Add(id.ToLower());
        }
    }
    
}
