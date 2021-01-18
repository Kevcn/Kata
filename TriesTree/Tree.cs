using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;

namespace TriesTree
{
    public class Tree
    {
        private readonly node root;

        public Tree()
        {
            root = new node
            {
                character = '/',
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

            var currentNode = root;
            var chars = word.ToCharArray();

            foreach (var c in chars)
            {
                if (currentNode.childNodes.All(x => x.character != c))
                {
                    currentNode.childNodes.Add(new node{ character = c });
                }

                currentNode = currentNode.childNodes.First(x => x.character == c);
            }

            // final node
            currentNode.isWord = true;
        }

        public bool search(string word)
        {
            var node = getNode(word);

            return node != null && node.isWord;
        }
        
        public bool startsWith(string prefix)
        {
            return getNode(prefix) != null;
        }

        private node getNode(string word)
        {
            var currentNode = root;
            for (int i = 0; i < word.Length; i++)
            {
                var c = word[i];
                if (currentNode.childNodes.All(x => x.character != c))
                    return null;

                currentNode = currentNode.childNodes.First(x => x.character == c);
            }

            return currentNode;
        }
        
    }


    class node
    {
        public node()
        {
            childNodes = new List<node>();
            isWord = false;
        }
        public char character { get; set; }

        public bool isWord { get; set; }

        public List<node> childNodes { get; }
    }
}