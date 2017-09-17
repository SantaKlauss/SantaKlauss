using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpertAvto
{
    class Program
    {
        static Thread thread;
        static Expert expert = new Expert();

        private static LowLevelMouseProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        [DllImport("User32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetClientRect(IntPtr hWnd, out RECT lpRect);

        static public void draw()
        {
            Console.Clear();
            drawRect();
            Console.SetCursorPosition(20, 0);
            Console.WriteLine("Экспертная система для диагностики авто");

            /*
            Console.SetCursorPosition(10, 23);
            Console.WriteLine("╡Меню╞");

            Console.SetCursorPosition(25, 23);
            Console.WriteLine("╡Редактор╞");*/
            
            Console.SetCursorPosition(45, 23);
            Console.WriteLine("╡Выход╞");
        }

        static public void readyInput()
        {
            Console.SetCursorPosition(0, 24);
            Console.Write(">>");            
        }

        static public void writeAnswers()
        {
            Console.SetCursorPosition(4, 4);
            Console.WriteLine("0. Нет");
            Console.SetCursorPosition(4, 5);
            Console.WriteLine("1. Да");
            Console.SetCursorPosition(4, 6);
            Console.WriteLine("2. Не знаю");
            Console.SetCursorPosition(4, 7);
            Console.WriteLine("3. Скорее да");
            Console.SetCursorPosition(4, 8);
            Console.WriteLine("4. Скорее нет");            
        }

        static void edit()
        {
            string c;

            while (true)
            {
                draw();
                Console.SetCursorPosition(2, 3);
                Console.WriteLine("Список ответов (выберете для редактирования):");
                expert.answersList();

                int a = -1;
                
                do
                {
                    readyInput();
                    if (!int.TryParse(Console.ReadLine(), out a))
                        a = -1;
                } while (a == -1);

                draw();

                if (a == 0)
                {
                    //создать новый 
                    expert.newResponse();
                    /*
                    Console.SetCursorPosition(3, 4);
                    Console.WriteLine("Введите правильный ответ:");

                    string buf;
                    buf = Console.ReadLine();
                    expert.newResponse(buf);
                    expert.newQuestion(buf);
                    expert.save();*/
                }
                else
                {
                    //редактировать
                    expert.editResponse(a);
                }

                
            }
        }

        static void diagnos()
        {
            //string c;

            while (true)
            {
                draw();
                Console.SetCursorPosition(2, 3);

                int a = -1;
                int q = expert.getQuestion();
                writeAnswers();

                do
                {
                    readyInput();
                    if (!int.TryParse(Console.ReadLine(), out a))
                        a = -1;
                } while (a == -1);


                expert.setQuestion(q, a);
                int r = expert.getResponse(0);
                if (r != 0)
                {
                    draw();
                    SResponse response = expert.getfResponse(r);

                    Console.SetCursorPosition(3, 4);
                    Console.WriteLine(response.response);
                    Console.SetCursorPosition(3, 5);
                    Console.WriteLine(response.description);

                    //Thread thread = new Thread(ImageWindow);
                    //Запускаем поток
                    //thread.Start();
                    Application.Run(new ImageForm(response.image));

                    /*
                    do
                    {
                        readyInput();
                        if (!int.TryParse(Console.ReadLine(), out a))
                            a = -1;
                    } while (a == -1);

                    readyInput();
                    c = Console.ReadLine();

                    if (c == "n")
                    {

                        Console.SetCursorPosition(3, 4);
                        Console.WriteLine("Введите правильный ответ:");

                        string buf;
                        buf = Console.ReadLine();
                        expert.newResponse(buf);
                        expert.newQuestion(buf);
                        expert.save();


                    }*/
                    break;
                }
                //game.g
            }
        }
        
        static void ThreadFunction()
        {
            
            string c;

            while (true)
            {
                draw();
                Console.SetCursorPosition(3, 3);
                Console.WriteLine("1.Начать диагностику");
                Console.SetCursorPosition(3, 4);
                Console.WriteLine("2.Редактор");
                Console.SetCursorPosition(3, 5);
                Console.WriteLine("3.Выход\n");
                readyInput();
                c = Console.ReadLine();
                if (c == "3")
                {
                    Application.ExitThread();
                    Application.Exit();
                    break;
                }
                
		        expert.newgame();
		        if (c=="1")
		        {
                    diagnos();
		        }
                else if (c == "2")
                {
                    edit();
                }
            }
        }

        //[STAThread]
        static void Main(string[] args)
        {
            Console.Title = "ExpertAvto";
            

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Clear();

            

            _hookID = SetHook(_proc);            


            thread = new Thread(ThreadFunction);
            //Запускаем поток
            thread.Start();

            
            

            //ImageForm iform = new ImageForm();
            //iform.Show();

            Application.Run();
            
            
            UnhookWindowsHookEx(_hookID);            
        }

        public static void drawRect()
        {
            Console.Write('╔');
            for (int i = 0; i < 78; i++)
                Console.Write('═');
            Console.Write('╗');

            for (int i = 0; i < 22; i++)
            {
                Console.SetCursorPosition(0, i + 1);
                Console.Write('║');

                Console.SetCursorPosition(79, i + 1);
                Console.Write('║');
            }

            Console.SetCursorPosition(0, 23);
            Console.Write('╚');
            for (int i = 0; i < 78; i++)
                Console.Write('═');
            Console.Write('╝');
        }

        private static IntPtr SetHook(LowLevelMouseProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_MOUSE_LL, proc,
                    GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private delegate IntPtr LowLevelMouseProc(int nCode, IntPtr wParam, IntPtr lParam);

        private static IntPtr HookCallback(
            int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && MouseMessages.WM_LBUTTONDOWN == (MouseMessages)wParam)
            {
                MSLLHOOKSTRUCT hookStruct = (MSLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(MSLLHOOKSTRUCT));

                var hWnd = FindWindow(null, Console.Title);
                var wndRect = new RECT();
                GetWindowRect(hWnd, out wndRect);

                int left = wndRect.Left;
                int top = wndRect.Top;

                Console.SetCursorPosition(5, 22);
                int x = hookStruct.pt.x - left - 8;
                int y = hookStruct.pt.y-top - 30;

                if (x >= 366 && x <= 412 && y >= 278 && y <= 289)
                {
                    UnhookWindowsHookEx(_hookID);  
                    Environment.Exit(0);                        
                }

                /*
                if (x >= 207 && x <= 277 && y >= 278 && y <= 289)
                {
                    Thread thread1 = new Thread(edit);
                    //Запускаем поток
                    thread1.Start();
                }

                if (x >= 85 && x <= 125 && y >= 278 && y <= 289)
                {
                    Thread thread1 = new Thread(diagnos);
                    //Запускаем поток
                    thread1.Start();
                }*/
               // Console.WriteLine("Pos click:"+x + ", " + y + "                      ");
                readyInput();
            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        private const int WH_MOUSE_LL = 14;

        private enum MouseMessages
        {
            WM_LBUTTONDOWN = 0x0201,
            WM_LBUTTONUP = 0x0202,
            WM_MOUSEMOVE = 0x0200,
            WM_MOUSEWHEEL = 0x020A,
            WM_RBUTTONDOWN = 0x0204,
            WM_RBUTTONUP = 0x0205
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct POINT
        {
            public int x;
            public int y;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct MSLLHOOKSTRUCT
        {
            public POINT pt;
            public uint mouseData;
            public uint flags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,
            LowLevelMouseProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
            IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
    }
}
