using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;

namespace TriesTree
{
    public class Tree
    {
        // 
        
        private node root;

        public Tree()
        {
            root = new node
            {
                isWord = false
            };
        }
        

        public void insert(string word)
        {
            // split words into chars
            // foreach char, search all root node child's char
                // if not there, insert the the node with this char as children
                // else continue;
            
                // set the final node isWord to true


            var chars = word.ToCharArray();

            var length = chars.Length;
            foreach (var c in chars)
            {
                length--;
                if (root.childNodes.All(x => x.character != c))
                {
                    root.childNodes.Add(new node{ character = c, isWord = length == 0}); // set final node isWord to true
                }
            }
            
            
            
        }

        public bool search(string word)
        {
            
        }
        
        public bool startsWith(string prefix)
        {
            
        }
        
    }


    class node
    {
        public char character { get; set; }

        public bool isWord { get; set; }

        public List<node> childNodes { get; set; }
    }
}