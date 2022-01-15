using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_Task_5._1
{
    internal class AppCommands
    {
        public static RoutedCommand SetBold { get; set; }
        public static RoutedCommand SetItalic { get; set; }
        public static RoutedCommand SetUnderline { get; set; }
        public static RoutedCommand Exit { get; set; }
        public static RoutedCommand FontProperties { get; set; }
        public static RoutedCommand About { get; set; }

        static AppCommands()
        {
            InputGestureCollection inputs = new InputGestureCollection();
            inputs.Add(new KeyGesture(Key.B, ModifierKeys.Control, "Ctrl+B"));
            SetBold = new RoutedCommand("SetBold", typeof(AppCommands), inputs); // Команда установки шрифта Bold

            inputs = new InputGestureCollection();
            inputs.Add(new KeyGesture(Key.I, ModifierKeys.Control, "Ctrl+I"));
            SetItalic = new RoutedCommand("SetItalic", typeof(AppCommands), inputs); // Команда установки шрифта Italic

            inputs = new InputGestureCollection();
            inputs.Add(new KeyGesture(Key.U, ModifierKeys.Control, "Ctrl+U"));
            SetUnderline = new RoutedCommand("SetUnderline", typeof(AppCommands), inputs); // Команда установки шрифта Underlined

            inputs = new InputGestureCollection();
            inputs.Add(new KeyGesture(Key.Q, ModifierKeys.Control, "Ctrl+Q"));
            Exit = new RoutedCommand("Exit", typeof(AppCommands), inputs); // Команда выхода из программы

            FontProperties = new RoutedCommand(); // Команда вызова окна "Шрифт"

            About = new RoutedCommand(); // Команда вызова окна "О программе"
        }
    }
}
