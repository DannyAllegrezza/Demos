using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace StackUndoDemo
{
    class UndoAction
    {
        private Button Button { get; set; }
        private Brush Brush { get; set; }

        public UndoAction(Button button)
        {
            Button = button;
            Brush = button.Background.CloneCurrentValue();
        }

        public void Execute()
        {
            Button.Background = Brush;
        }

        public override string ToString()
        {
            return $"{Button.Content} : {Brush.ToString()}";
        }
    }
}
