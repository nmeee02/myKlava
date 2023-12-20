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
using static System.Net.Mime.MediaTypeNames;

namespace FULLKEYBOARD
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MyButton[] buttons= new MyButton[35];
        private bool Caps = false;
        public MainWindow()
        {
            InitializeComponent();

            buttons[0]= new MyButton("~","`", TextComa);
            buttons[1] = new MyButton("1", "!", Text1);
            buttons[2] = new MyButton("@", "2", Text2);
            buttons[3] = new MyButton("3", "#", Text3);
            buttons[4] = new MyButton("$", "4", text4);
            buttons[5] = new MyButton("5", "%", Text5);
            buttons[6] = new MyButton("^", "6", Text6);
            buttons[7] = new MyButton("7", "&", Text7);
            buttons[8] = new MyButton("*", "8", Text8);
            buttons[9] = new MyButton("9", "(", Text9);
            buttons[10] = new MyButton(")", "0", text0);
            buttons[11] = new MyButton("-", "_", TextMinus);
            buttons[12] = new MyButton("+", "=", TextEquals);
            buttons[13] = new MyButton("A", "a", TextA);
            buttons[14] = new MyButton("s", "S", TextS);
            buttons[15] = new MyButton("D", "d", TextD);
            buttons[16] = new MyButton("f", "F", TextF);
            buttons[17] = new MyButton("G", "g", TextG);
            buttons[18] = new MyButton("h", "H", TextH);
            buttons[19] = new MyButton("J", "j", TextJ);
            buttons[20] = new MyButton("k", "K", TextK);
            buttons[21] = new MyButton("L", "l", TextL);
            buttons[22] = new MyButton(";", ":", Text2dots);
            buttons[23] = new MyButton("\"", "'", TextHiComa);
            buttons[24] = new MyButton("Z", "z", TextZ);
            buttons[25] = new MyButton("x", "X", TextX);
            buttons[26] = new MyButton("C", "c", TextC);
            buttons[27] = new MyButton("v", "V", TextV);
            buttons[28] = new MyButton("B", "b", TextB);
            buttons[29] = new MyButton("n", "N", TextN);
            buttons[30] = new MyButton("M", "m", TextM);
            buttons[31] = new MyButton(",", "<", TextDComa);
            buttons[32] = new MyButton(">", ".", TextDot);
            buttons[33] = new MyButton("/", "?", TextSlash);
            buttons[34] = new MyButton("|", "\\", TextBkSl);


        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            difficultyValue.Text = slider.Value.ToString();
        }


        private void Start_Button_Click(object sender, RoutedEventArgs e)
        {
            Button_Start.IsEnabled = false;
            Button_Stop.IsEnabled = true;
            output.Focusable = true;
            output.Focus();
            string val = difficultyValue.Text;
            int num = int.Parse(val);
            string line = "";
            Random random = new Random();
            for (int i = 0; i < num; i++)
            {
                int value = random.Next(33, 97);
                char ch = Convert.ToChar(value);
                line += ch;
            }
            input.Text = line;

        }

        private void Stop_Button_Click(object sender, RoutedEventArgs e)
        {
            Button_Start.IsEnabled = true;
            Button_Stop.IsEnabled = false;
            output.Focusable = false;
        }
        private void output_KeyDown(object sender, KeyEventArgs e)
        {
            //output.Text = e.Key.ToString();
            if (e.Key == Key.Tab)
            {
                BorderTab.Background = new SolidColorBrush(Colors.White);
            }
            
            else if (e.Key == Key.LeftShift)
            {
                BorderShift1.Background = new SolidColorBrush(Colors.White);

            }
            else if (e.Key == Key.LeftCtrl)
            {
                BorderCtrl1.Background = new SolidColorBrush(Colors.White);

            }
            else if (e.Key == Key.LWin)
            {
                BorderWin1.Background = new SolidColorBrush(Colors.White);

            }
            else if (e.Key == Key.LeftAlt)
            {
                BorderAlt1.Background = new SolidColorBrush(Colors.White);

            }
            else if (e.Key == Key.Space)
            {
                BorderSpace.Background = new SolidColorBrush(Colors.White);
                output.Text += " ";

            }
            else if (e.Key == Key.RightAlt)
            {
                BorderAlt2.Background = new SolidColorBrush(Colors.White);

            }
            else if (e.Key == Key.RWin)
            {
                BorderWin2.Background = new SolidColorBrush(Colors.White);

            }
            else if (e.Key == Key.RightCtrl)
            {
                BorderCtrl2.Background = new SolidColorBrush(Colors.White);

            }
            else if (e.Key == Key.RightShift)
            {
                BorderShift2.Background = new SolidColorBrush(Colors.White);

            }
            else if (e.Key == Key.Enter)
            {
                BorderEnter.Background = new SolidColorBrush(Colors.White);

            }
            else if (e.Key == Key.Back)
            {
                BorderBack.Background = new SolidColorBrush(Colors.White);
                output.Text = output.Text.Substring(0, output.Text.Length - 1);

            }
            else if (e.Key == Key.D1)
            {
                Border1.Background = new SolidColorBrush(Colors.White);
                output.Text += Text1.Text;
            }
            else if (e.Key == Key.D2)
            {
                Border2.Background = new SolidColorBrush(Colors.White);
                output.Text += Text2.Text;
            }
            else if (e.Key == Key.D3)
            {
                Border3.Background = new SolidColorBrush(Colors.White);
                output.Text += Text3.Text;
            }
            else if (e.Key == Key.D4)
            {
                Border4.Background = new SolidColorBrush(Colors.White);
                output.Text += text4.Text;
            }
            else if (e.Key == Key.D5)
            {
                Border5.Background = new SolidColorBrush(Colors.White);
                output.Text += Text5.Text;
            }
            else if (e.Key == Key.D6)
            {
                Border6.Background = new SolidColorBrush(Colors.White);
                output.Text += Text6.Text;
            }
            else if (e.Key == Key.D7)
            {
                Border7.Background = new SolidColorBrush(Colors.White);
                output.Text += Text7.Text;
            }
            else if (e.Key == Key.D8)
            {
                Border8.Background = new SolidColorBrush(Colors.White);
                output.Text += Text8.Text;
            }
            else if (e.Key == Key.D9)
            {
                Border9.Background = new SolidColorBrush(Colors.White);
                output.Text += Text9.Text;
            }
            else if (e.Key == Key.D0)
            {
                Border0.Background = new SolidColorBrush(Colors.White);
                output.Text += text0.Text;
            }
            else if (e.Key == Key.OemMinus)
            {
                BorderMinus.Background = new SolidColorBrush(Colors.White);
                output.Text += TextMinus.Text;
            }
            else if (e.Key == Key.OemTilde)
            {
                BorderComa.Background = new SolidColorBrush(Colors.White);
                output.Text += TextComa.Text;
            }
            else if (e.Key == Key.OemPlus)
            {
                BorderEquals.Background = new SolidColorBrush(Colors.White);
                output.Text += TextEquals.Text;
            }
            else if (e.Key == Key.Q)
            {
                BorderQ.Background = new SolidColorBrush(Colors.White);
                output.Text += TextQ.Text;
            }
            else if (e.Key == Key.W)
            {
                BorderW.Background = new SolidColorBrush(Colors.White);
                output.Text += TextW.Text;
            }
            else if (e.Key == Key.E)
            {
                BorderE.Background = new SolidColorBrush(Colors.White);
                output.Text += TextE.Text;
            }
            else if (e.Key == Key.R)
            {
                BorderR.Background = new SolidColorBrush(Colors.White);
                output.Text += TextR.Text;
            }
            else if (e.Key == Key.T)
            {
                BorderT.Background = new SolidColorBrush(Colors.White);
                output.Text += TextT.Text;
            }
            else if (e.Key == Key.Y)
            {
                BorderY.Background = new SolidColorBrush(Colors.White);
                output.Text += TextY.Text;
            }
            else if (e.Key == Key.U)
            {
                BorderU.Background = new SolidColorBrush(Colors.White);
                output.Text += TextU.Text;
            }
            else if (e.Key == Key.I)
            {
                BorderI.Background = new SolidColorBrush(Colors.White);
                output.Text += TextI.Text;
            }
            else if (e.Key == Key.O)
            {
                BorderO.Background = new SolidColorBrush(Colors.White);
                output.Text += TextO.Text;
            }
            else if (e.Key == Key.P)
            {
                BorderP.Background = new SolidColorBrush(Colors.White);
                output.Text += TextP.Text;
            }
            else if (e.Key == Key.OemOpenBrackets)
            {
                BorderKv1.Background = new SolidColorBrush(Colors.White);
                output.Text += TextKv1.Text;
            }
            else if (e.Key == Key.OemCloseBrackets)
            {
                BorderKv2.Background = new SolidColorBrush(Colors.White);
                output.Text += TextKv2.Text;
            }
            else if (e.Key == Key.Oem5)
            {
                BorderBkSl.Background = new SolidColorBrush(Colors.White);
                output.Text += TextBkSl.Text;
            }
            else if (e.Key == Key.A)
            {
                BorderA.Background = new SolidColorBrush(Colors.White);
                output.Text += TextA.Text;
            }
            else if (e.Key == Key.S)
            {
                BorderS.Background = new SolidColorBrush(Colors.White);
                output.Text += TextS.Text;
            }
            else if (e.Key == Key.D)
            {
                BorderD.Background = new SolidColorBrush(Colors.White);
                output.Text += TextD.Text;
            }
            else if (e.Key == Key.F)
            {
                BorderF.Background = new SolidColorBrush(Colors.White);
                output.Text += TextF.Text;
            }
            else if (e.Key == Key.G)
            {
                BorderG.Background = new SolidColorBrush(Colors.White);
                output.Text += TextG.Text;
            }
            else if (e.Key == Key.H)
            {
                BorderH.Background = new SolidColorBrush(Colors.White);
                output.Text += TextH.Text;
            }
            else if (e.Key == Key.J)
            {
                BorderJ.Background = new SolidColorBrush(Colors.White);
                output.Text += TextJ.Text;
            }
            else if (e.Key == Key.K)
            {
                BorderK.Background = new SolidColorBrush(Colors.White);
                output.Text += TextK.Text;
            }
            else if (e.Key == Key.L)
            {
                BorderL.Background = new SolidColorBrush(Colors.White);
                output.Text += TextL.Text;
            }
            else if (e.Key == Key.OemSemicolon)
            {
                Border2dots.Background = new SolidColorBrush(Colors.White);
                output.Text += Text2dots.Text;
            }
            else if (e.Key == Key.OemQuotes)
            {
                BorderHiComa.Background = new SolidColorBrush(Colors.White);
                output.Text += TextHiComa.Text;
            }
            else if (e.Key == Key.Z)
            {
                BorderZ.Background = new SolidColorBrush(Colors.White);
                output.Text += TextZ.Text;
            }
            else if (e.Key == Key.X)
            {
                BorderX.Background = new SolidColorBrush(Colors.White);
                output.Text += TextX.Text;
            }
            else if (e.Key == Key.C)
            {
                BorderC.Background = new SolidColorBrush(Colors.White);
                output.Text += TextC.Text;
            }
            else if (e.Key == Key.V)
            {
                BorderV.Background = new SolidColorBrush(Colors.White);
                output.Text += TextV.Text;
            }
            else if (e.Key == Key.B)
            {
                BorderB.Background = new SolidColorBrush(Colors.White);
                output.Text += TextB.Text;
            }
            else if (e.Key == Key.N)
            {
                BorderN.Background = new SolidColorBrush(Colors.White);
                output.Text += TextN.Text;
            }
            else if (e.Key == Key.M)
            {
                BorderM.Background = new SolidColorBrush(Colors.White);
                output.Text += TextM.Text;
            }
            else if (e.Key == Key.OemComma)
            {
                BorderDComa.Background = new SolidColorBrush(Colors.White);
                output.Text += TextDComa.Text;
            }
            else if (e.Key == Key.OemPeriod)
            {
                BorderDot.Background = new SolidColorBrush(Colors.White);
                output.Text += TextDot.Text;
            }
            else if (e.Key == Key.OemQuestion)
            {
                BorderSlash.Background = new SolidColorBrush(Colors.White);
                output.Text += TextSlash.Text;
            }



        }
        private void output_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Tab)
            {
                BorderTab.Background =(SolidColorBrush) new BrushConverter().ConvertFromString("#FFB5B5B5");
            }
            else if (e.Key == Key.CapsLock)
            {
                BorderCaps.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFB5B5B5");

            }
            else if (e.Key == Key.LeftShift)
            {
                BorderShift1.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFB5B5B5");

            }
            else if (e.Key == Key.LeftCtrl)
            {
                BorderCtrl1.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFB5B5B5");

            }
            else if (e.Key == Key.LWin)
            {
                BorderWin1.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFB5B5B5");

            }
            else if (e.Key == Key.LeftAlt)
            {
                BorderAlt1.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFB5B5B5");

            }
            else if (e.Key == Key.Space)
            {
                BorderSpace.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFB5B5B5");

            }
            else if (e.Key == Key.RightAlt)
            {
                BorderAlt2.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFB5B5B5");

            }
            else if (e.Key == Key.RWin)
            {
                BorderWin2.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFB5B5B5");

            }
            else if (e.Key == Key.RightCtrl)
            {
                BorderCtrl2.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFB5B5B5");

            }
            else if (e.Key == Key.RightShift)
            {
                BorderShift2.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFB5B5B5");

            }
            else if (e.Key == Key.Enter)
            {
                BorderEnter.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFB5B5B5");

            }
            else if (e.Key == Key.Back)
            {
                BorderBack.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFB5B5B5");

            }
            else if (e.Key == Key.D1)
            {
                Border1.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFF07795");

            }
            else if (e.Key == Key.D2)
            {
                Border2.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFF07795");

            }
            else if (e.Key == Key.D3)
            {
                Border3.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFE6F077");

            }
            else if (e.Key == Key.D4)
            {
                Border4.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF7FF077");

            }
            else if (e.Key == Key.D5)
            {
                Border5.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF77BEF0");

            }
            else if (e.Key == Key.D6)
            {
                Border6.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF77BEF0");

            }
            else if (e.Key == Key.D7)
            {
                Border7.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFDB77F0");

            }
            else if (e.Key == Key.D8)
            {
                Border8.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFDB77F0");

            }
            else if (e.Key == Key.D9)
            {
                Border9.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFF07795");

            }
            else if (e.Key == Key.D0)
            {
                Border0.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFE6F077");

            }
            else if (e.Key == Key.OemMinus)
            {
                BorderMinus.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF7FF077");

            }
            else if (e.Key == Key.OemTilde)
            {
                BorderComa.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFF07795");

            }
            else if (e.Key == Key.OemPlus)
            {
                BorderEquals.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF7FF077");

            }
            else if (e.Key == Key.Q)
            {
                BorderQ.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFF07795");

            }
            else if (e.Key == Key.W)
            {
                BorderW.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFE6F077");

            }
            else if (e.Key == Key.E)
            {
                BorderE.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF7FF077");

            }
            else if (e.Key == Key.R)
            {
                BorderR.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF77BEF0");

            }
            else if (e.Key == Key.T)
            {
                BorderT.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF77BEF0");

            }
            else if (e.Key == Key.Y)
            {
                BorderY.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFDB77F0");

            }
            else if (e.Key == Key.U)
            {
                BorderU.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFDB77F0");

            }
            else if (e.Key == Key.I)
            {
                BorderI.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFF07795");

            }
            else if (e.Key == Key.O)
            {
                BorderO.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFE6F077");

            }
            else if (e.Key == Key.P)
            {
                BorderP.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF7FF077");

            }
            else if (e.Key == Key.OemOpenBrackets)
            {
                BorderKv1.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF7FF077");

            }
            else if (e.Key == Key.OemCloseBrackets)
            {
                BorderKv2.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF7FF077");

            }
            else if (e.Key == Key.Oem5)
            {
                BorderBkSl.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF7FF077");

            }
            else if (e.Key == Key.A)
            {
                BorderA.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFF07795");

            }
            else if (e.Key == Key.S)
            {
                BorderS.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFE6F077");

            }
            else if (e.Key == Key.D)
            {
                BorderD.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF7FF077");

            }
            else if (e.Key == Key.F)
            {
                BorderF.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF77BEF0");

            }
            else if (e.Key == Key.G)
            {
                BorderG.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF77BEF0");

            }
            else if (e.Key == Key.H)
            {
                BorderH.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFDB77F0");

            }
            else if (e.Key == Key.J)
            {
                BorderJ.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFDB77F0");

            }
            else if (e.Key == Key.K)
            {
                BorderK.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFF07795");

            }
            else if (e.Key == Key.L)
            {
                BorderL.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFE6F077");

            }
            else if (e.Key == Key.OemSemicolon)
            {
                Border2dots.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF7FF077");

            }
            else if (e.Key == Key.OemQuotes)
            {
                BorderHiComa.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF7FF077");

            }
            else if (e.Key == Key.Z)
            {
                BorderZ.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFF07795");

            }
            else if (e.Key == Key.X)
            {
                BorderX.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFE6F077");

            }
            else if (e.Key == Key.C)
            {
                BorderC.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF7FF077");

            }
            else if (e.Key == Key.V)
            {
                BorderV.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF77BEF0");

            }
            else if (e.Key == Key.B)
            {
                BorderB.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF77BEF0");

            }
            else if (e.Key == Key.N)
            {
                BorderN.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFDB77F0");

            }
            else if (e.Key == Key.M)
            {
                BorderM.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFDB77F0");

            }
            else if (e.Key == Key.OemComma)
            {
                BorderDComa.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFF07795");

            }
            else if (e.Key == Key.OemPeriod)
            {
                BorderDot.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFE6F077");

            }
            else if (e.Key == Key.OemQuestion)
            {
                BorderSlash.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF7FF077");

            }


        }
    }
}
