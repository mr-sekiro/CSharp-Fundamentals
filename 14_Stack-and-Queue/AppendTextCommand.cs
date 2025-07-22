using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Stack_and_Queue
{
    internal class AppendTextCommand
    {
        private StringBuilder originalText = new StringBuilder();
        private Stack<string> inputs = new Stack<string>();
        private Stack<string> poppedInputs = new Stack<string>();

        public string CurrentText => originalText.ToString();

        public void Execute(string input)
        {
            originalText.Append(input);
            inputs.Push(input);
            poppedInputs.Clear();
        }

        public bool CanUndo => inputs.Count > 0;
        public bool CanRedo => poppedInputs.Count > 0;

        public void Undo()
        {
            if (!CanUndo) return;

            string text = inputs.Pop();
            originalText.Remove(originalText.Length - text.Length, text.Length);
            poppedInputs.Push(text);
        }

        public void Redo()
        {
            if (!CanRedo) return;

            string text = poppedInputs.Pop();
            originalText.Append(text);
            inputs.Push(text);
        }
    }

}
