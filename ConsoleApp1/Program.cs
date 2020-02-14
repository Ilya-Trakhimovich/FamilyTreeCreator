using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ListView lv = new ListView(new string[] { "Идиот", "Недоросль", "Горе от ума", "На дне" });
            ConsoleKeyInfo cki;
            do
            {
                cki = Console.ReadKey(true);
                switch (cki.Key)
                {
                    case ConsoleKey.UpArrow:
                        lv.SelectedIndex--;
                        break;
                    case ConsoleKey.DownArrow:
                        lv.SelectedIndex++;
                        break;
                    default:
                        break;
                }
            } while (cki.Key != ConsoleKey.Enter);
            Console.Clear();
            Foo(lv.SelectedItem);
            Console.ReadKey();
        }

        static void Foo(object o)
        {
            Console.WriteLine($"Выбрана книга {o}");
        }
    }

    class ListView
    {
        private IList items;

        private int selectedIndex;

        public int SelectedIndex
        {
            get
            {
                return selectedIndex;
            }
            set
            {
                value = Math.Abs(value % items.Count);
                selectedIndex = value;
                Draw();
            }
        }

        public object SelectedItem { get { return items[SelectedIndex]; } }

        public ListView(IList items)
        {
            this.items = items;
            SelectedIndex = 0;
        }

        private void Draw()
        {
            Console.Clear();
            for (int i = 0; i < items.Count; i++)
            {
                if (i == selectedIndex)
                {
                    var tmp = Console.BackgroundColor;
                    Console.BackgroundColor = Console.ForegroundColor;
                    Console.ForegroundColor = tmp;
                    Console.WriteLine(items[i]);
                    Console.ForegroundColor = Console.BackgroundColor;
                    Console.BackgroundColor = tmp;
                }
                else
                {
                    Console.WriteLine(items[i]);
                }
            }
        }
    }
}
