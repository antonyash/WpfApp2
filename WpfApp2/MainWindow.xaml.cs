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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        int i = 0;
        char ch;
        char read(char x,ref int i)
        {
            if (i < textBox1.Text.Length)
            {
                x = textBox1.Text[i];
                
                i++;
            }
            else
            {
                x = ' ';
            }
            return x;
        }

        bool res()
        {
            i = 0;
          
            return form(ref i);
        }

        bool form(ref int i)
        {
            if (i < textBox1.Text.Length)
            {
                ch = textBox1.Text[i];
            }
            else
            {
                ch = ' ';
            }
            if (ch == '(')
            {
                ch=read(ch,ref i);


                if (form(ref i) && ch == ')')
                {
                    ch = read(ch, ref i);
                    return okon(ref i);
                }
                else
                    return false;
            }
            else if (chisl(ref i))

            {
                return okon(ref i);
            }
            else if (rad(ref i))

            {
                return (okon(ref i));
            }
            else return false;
        }

        bool okon(ref int i)
        {
            if (i < textBox1.Text.Length)
            {
                ch = textBox1.Text[i];
            }
            else
            {
                ch = ' ';
            }
            if (znak(ref i))
            {
                return form(ref i);
            }
            else if(ch=='V')
            {
                return rad(ref i);
            }
            else 
            {
                
                    return true;
               
            }
        }

        bool rad(ref int i)
        {
            if (i < textBox1.Text.Length)
            {
                ch = textBox1.Text[i];
            }
            else
            {
                ch = ' ';
            }
            if (ch == 'V')
            {
                ch = read(ch, ref i);
                return (form(ref i));
            }
            else
                return false;
        }

       

        bool chisl(ref int i)
        {
            if (i < textBox1.Text.Length)
            {
                ch = textBox1.Text[i];
            }
            else
            {
                ch = ' ';
            }
            if (cifr(ref i))
                return razr(ref i);
            else return false;
        }

        bool razr(ref int i)
        {
            if (i < textBox1.Text.Length)
            {
                ch = textBox1.Text[i];
            }
            else
            {
                ch =' ';
            }
            
            if (chisl(ref i))
                return true;
            else
            {
               
                
                return true;
            }
        }

        bool znak(ref int i)
        {
            if (i < textBox1.Text.Length)
            {
                ch = textBox1.Text[i];
            }
            else
            {
                ch = ' ';
            }
            if (ch == '+')
            {
                ch=read(ch,ref i);
               
                return true;
            }
            else if (ch == '-')
            {
                ch = read(ch, ref i);
                
                return true;
            }
            else if (ch == '*')
            {
                ch = read(ch, ref i);
                
                return true;
            }
            else if (ch == '/')
            {
                ch = read(ch, ref i);
                
                return true;
            }
            else
                return false;
        }

        bool cifr(ref int i)
        {
            if (i < textBox1.Text.Length)
            {
                ch = textBox1.Text[i];
            }
            else
            {
                ch = ' ';
            }
            if (ch == '0')
            {
                ch = read(ch, ref i);
               
                return true;
            }
            else if (ch == '1')
            {
                ch = read(ch, ref i);
               
                return true;
            }
            else if (ch == '2')
            {
                ch = read(ch, ref i);
                
                return true;
            }
            else if (ch == '3')
            {
                ch = read(ch,ref i);
               
                return true;
            }
            else if (ch == '4')
            {
                ch = read(ch, ref i);
               
                return true;
            }
            else if (ch == '5')
            {
                ch = read(ch,ref i);
                
                return true;
            }
            else if (ch == '6')
            {
                ch = read(ch,ref i);
                
                return true;
            }
            else if (ch == '7')
            {
                ch = read(ch, ref i);
                
                return true;
            }
            else if (ch == '8')
            {
                ch = read(ch,ref  i);
               
                return true;
            }
            else if (ch == '9')
            {
                ch = read(ch, ref i);
                
                return true;
            }
            else
                return false;
        }

       


        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (res())
                try
                {
                    label.Content = "Все верно";
                }
                catch
                {

                }
            else try
                {
                    label.Content = "Ошибка!";
                }
                catch
                {

                }
            
            }
    }
}
