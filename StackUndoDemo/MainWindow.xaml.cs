using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

namespace StackUndoDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Stack<UndoAction> undoOperations = new Stack<UndoAction>();
        Random rndm = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Generate random color for the buttons
        /// </summary>
        /// <returns></returns>
        private Brush GetRandomBrush()
        {
            byte[] rgb = new byte[3];
            rndm.NextBytes(rgb);

            return new SolidColorBrush(Color.FromRgb(rgb[0], rgb[1], rgb[2]));
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            // push the state of the button onto the stack
            undoOperations.Push(new UndoAction(Btn1));
            Btn1.Background = GetRandomBrush();
            UpdateList();
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            undoOperations.Push(new UndoAction(Btn2));
            Btn2.Background = GetRandomBrush();
            UpdateList();
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            undoOperations.Push(new UndoAction(Btn3));
            Btn3.Background = GetRandomBrush();
            UpdateList();
        }

        /// <summary>
        /// Undo Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // verify the Stack isn't empty. if not, pop off item
            if (undoOperations.Count > 0)
            {
                undoOperations.Pop().Execute();
                UpdateList();
            }
        }

        private void UpdateList()
        {
            ListBoxStack.Items.Clear();

            foreach (var item in undoOperations)
            {
                ListBoxStack.Items.Add(item.ToString());
            }
        }

        private void ListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}
