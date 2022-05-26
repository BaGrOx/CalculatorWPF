using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator_ver_2._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Add addOperation = new Add();
        Divide divideOpe = new Divide();
        Multi multiOpe = new Multi();
        Minus minusOpe = new Minus();




        string operation;

        private void ResultEmpty()
        {
            Result.Content = string.Empty;
        }
        public MainWindow()
        {
            InitializeComponent();

            ResultEmpty();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            char content = button.Name[^1];
            Result.Content += content.ToString();


        }

        private void ButtonComma_Click(object sender, RoutedEventArgs e)
        {
            Result.Content += ",";

        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            operation = Result.Content.ToString();

            if (operation.Contains('+'))
            {
                Result.Content = addOperation.AddOperation(operation).ToString();
            }
            Result.Content += "+";


        }

        private void ButtonResult_Click(object sender, RoutedEventArgs e)
        {
            operation = Result.Content.ToString();
            if (operation.Contains('+'))
            {
                Result.Content = addOperation.AddOperation(operation).ToString();
            }
            if (operation.Contains('-'))
            {
                Result.Content = minusOpe.MinusOperatiom(operation).ToString();
            }
            if (operation.Contains('/'))
            {
                Result.Content = divideOpe.DivideOperatiom(operation).ToString();
                if (divideOpe.DivideOperatiom(operation).ToString() == "0")
                {

                    Result.Content = "Don't divide by zero";
                }
            }
            if (operation.Contains('*'))
            {
                Result.Content = multiOpe.MultiOperatiom(operation).ToString();
            }
        }

        private void ButtonDivide_Click(object sender, RoutedEventArgs e)
        {
            operation = Result.Content.ToString();
            if (operation.Contains('/'))
            {
                Result.Content = divideOpe.DivideOperatiom(operation).ToString();
            }
            Result.Content += "/";


        }

        private void ButtonMulti_Click(object sender, RoutedEventArgs e)
        {
            operation = Result.Content.ToString();
            if (operation.Contains('*'))
            {
                Result.Content = multiOpe.MultiOperatiom(operation).ToString();
            }
            Result.Content += "*";


        }

        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            operation = Result.Content.ToString();
            if (operation.Contains('-'))
            {
                Result.Content = minusOpe.MinusOperatiom(operation).ToString();
            }
            Result.Content += "-";


        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            ResultEmpty();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.D0:
                    Button0.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case Key.D1:
                    Button1.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case Key.D2:
                    Button2.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case Key.D3:
                    Button3.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case Key.D4:
                    Button4.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case Key.D5:
                    Button5.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case Key.D6:
                    Button6.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case Key.D7:
                    Button7.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case Key.D8:
                    Button8.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case Key.D9:
                    Button9.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case Key.NumPad0:
                    Button0.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case Key.NumPad1:
                    Button1.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case Key.NumPad2:
                    Button2.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case Key.NumPad3:
                    Button3.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case Key.NumPad4:
                    Button4.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case Key.NumPad5:
                    Button5.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case Key.NumPad6:
                    Button6.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case Key.NumPad7:
                    Button7.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case Key.NumPad8:
                    Button8.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case Key.NumPad9:
                    Button9.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case Key.Add:
                    ButtonAdd.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case Key.Subtract:
                    ButtonMinus.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case Key.Multiply:
                    ButtonMulti.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case Key.Divide:
                    ButtonDivide.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case Key.Enter:
                    ButtonResult.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case Key.Back:
                    ButtonBackSpace.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case Key.Escape:
                    ButtonClear.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
            }
        }

        private void ButtonBackSpace_Click(object sender, RoutedEventArgs e)
        {
            operation = Result.Content.ToString();
            if(operation != string.Empty)
            {
                operation = operation.Remove(operation.Length - 1);
                Result.Content = operation;
            }
            
        }
    }
}
